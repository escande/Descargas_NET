using Descargas_NET.Models;
using Descargas_NET.Properties;
using Descargas_NET.Services;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descargas_NET.Helpers
{
    public enum StatusCom
    {
        Disconected, Conected
    }

    public class MSCommNet : IDisposable
    {
        public int Puerto { get; set; }

        public int BaudRate { get; set; }

        public StatusCom StatusCom { get; set; }

        private readonly SerialPort _serialPort;

        private readonly Log _log;


        //Eventos
        public delegate void Comm_ConexionChange(bool e);
        public delegate void Comm_DataReceive(LecturaOdette e);
        public Comm_ConexionChange _comm_ConexionChange;
        public Comm_DataReceive _comm_DataReceive;

        public MSCommNet(int puerto = 1, int baudRate = 9600)
        {
            Puerto = puerto;
            BaudRate = baudRate;

            _log = new Log("MSCOMM");
            //_log = Injector.GetService(x => 
            //{
            //    return new Log("MSCOMM");
            //});
            _serialPort = new SerialPort($"COM{Puerto}", BaudRate, Parity.None, 8, StopBits.One);
            _serialPort.DataReceived += SerialPort_DataReceived;
        }

        public void AbrirPuerto()
        {
            try
            {
                _log.EscribirEnFichero($"Abriendo puerto COM: {Puerto}, BaudRate: {BaudRate}");

                if (!_serialPort.IsOpen)
                {
                    _serialPort.PortName = $"COM{Puerto}";
                    _serialPort.BaudRate = BaudRate;

                    _serialPort.Open();
                    StatusCom = StatusCom.Conected;
                    _comm_ConexionChange?.Invoke(true);
                }
            }
            catch
            {
                _log.EscribirEnFichero($"Error abriendo puerto COM{Puerto}");
                StatusCom = StatusCom.Disconected;
                _comm_ConexionChange?.Invoke(false);
            }
        }

        public void CerrarPuerto()
        {
            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                    StatusCom = StatusCom.Disconected;
                    _comm_ConexionChange?.Invoke(false);
                }
            }
            catch
            {
                _log.EscribirEnFichero($"Error cerrando el puerto COM{Puerto}");
            }
        }

        //public void Dispose()
        //{
        //    if(_serialPort != null)
        //    {
        //        CerrarPuerto();

        //        _serialPort.Dispose();
        //    }
        //}
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_serialPort != null)
                {
                    CerrarPuerto();

                    _serialPort.Dispose();
                }
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            StringBuilder lectura = new("");
            int Aux = 0;
            bool Salir = false;
            DateTime tiempo;
            TimeSpan tDiff;
            if (_serialPort.BytesToRead > 0)
            {
                while (Aux != 10 && !Salir)
                {
                    tiempo = DateTime.Now;
                    if (_serialPort.BytesToRead == 0)
                    {
                        //Lo mismo que un DateDiff en VBNET
                        tDiff = DateTime.Now.Subtract(tiempo);
                        int c = tDiff.Seconds;
                        if (c > 0.2)
                            Salir = true;
                    }
                    else
                    {
                        Aux = _serialPort.ReadByte();
                        lectura.Append(Convert.ToChar(Aux));
                    }
                }

                if (lectura.ToString().Substring(lectura.Length - 1, 1) == Convert.ToString((Char)42))
                {
                    string stDatoLeido = lectura.ToString().Substring(1, lectura.Length - 3);
                    ProcesarLectura(stDatoLeido);
                    _log.EscribirEnFichero("Lectura Escaner - " + stDatoLeido);
                }
                else
                {
                    string stDatoLeido = lectura.ToString().Replace((char)13, (char)32).Replace((char)10, (char)32);//lectura.ToString().Substring(0, lectura.Length - 2);
                    ProcesarLectura(stDatoLeido);
                    _log.EscribirEnFichero("Lectura Escaner - " + stDatoLeido);
                }
            }
        }

        private void ProcesarLectura(string _lectura)
        {
            string[] lectura;
            CodeType cType;
            LecturaOdette lecturaOdette;
            try
            {
                int cQR = _lectura.IndexOf((char)43);//43
                int cPDF = _lectura.IndexOf((char)29);
                bool cPDFcab = _lectura[..3].Contains("[)>");

                //Otra ñapa más para solventar de momento los PDF's raros
                bool cPDFRaro = ComprobarPDFRaro(_lectura);
                if (cQR > 0)
                {
                    cType = CodeType.Code_QR;
                }
                else if (cPDF > 0 || cPDFcab || cPDFRaro)
                {
                    cType = CodeType.PDF417;
                }
                else
                {
                    cType = CodeType.Code1D;
                }


                if (cType == CodeType.Code_QR || cType == CodeType.PDF417)
                {
                    //Si lleva otro separador lo intercambio
                    if (_lectura.IndexOf("#") > 3)
                    {
                        _lectura = _lectura.Replace('#', (char)29);
                    }

                    if (cPDFRaro)
                    {
                        var lecturaRara = _lectura.Split((char)32).ToList();
                        var pn = lecturaRara[0] + lecturaRara[1] + lecturaRara[2];
                        lecturaRara.Add(pn);
                        //_lectura += $" {pn}";
                        var auxLectura = lecturaRara.Where((source, index) => index >= 2).ToArray();
                        lectura = auxLectura;
                    }
                    else
                    {
                        lectura = cType == CodeType.PDF417 ? _lectura.Split((char)29) : _lectura.Split((char)43);
                    }

                    lecturaOdette = UbicarLecturas(lectura);

                    lecturaOdette.Lectura = _lectura;
                    lecturaOdette.CodeType = cType;

                    _comm_DataReceive?.Invoke(lecturaOdette);
                }
                else if (cType == CodeType.Code1D)
                {
                    lecturaOdette = new LecturaOdette
                    {
                        Lectura = _lectura,
                        CodeType = cType
                    };

                    _comm_DataReceive?.Invoke(lecturaOdette);
                }
            }
            catch (Exception ex)
            {
                _log.EscribirEnFichero($"Error Procesando Lectura: {ex.Message}");
            }
        }

        public static bool ComprobarPDFRaro(string lectura)
        {
            var cantidad = lectura.Length;

            var numeroEspacios = lectura.Count(x => x == (char)32);

            if (cantidad >= 25 && numeroEspacios > 5 && lectura[0] == 'P')
            {
                return true;
            }

            return false;
        }

        public static LecturaOdette UbicarLecturas(string[] lectura)
        {
            var lOdette = new LecturaOdette();

            foreach (var z in lectura)
            {
                switch (z[..1])
                {
                    case "A":
                        lOdette.Campo_S = z[1..];
                        break;

                    case "P":
                        lOdette.Campo_P = z[1..];
                        break;

                    case "Q":
                        lOdette.Campo_Q = int.Parse(z[1..]);
                        break;

                    case "N":
                        lOdette.Campo_N = z[1..];
                        break;

                    case "V":
                        lOdette.Campo_V = z[1..];
                        break;

                    case "S":
                    case "M":
                        lOdette.Campo_S = z[1..];
                        break;

                    case "D":
                        lOdette.Campo_D = z[1..];
                        break;

                    case "H":
                        lOdette.Campo_H = z[1..];
                        break;

                    case "U":
                        lOdette.Campo_U = z[1..];
                        break;

                    case "I":
                        lOdette.Campo_I = z[1..];
                        break;

                    case "B":
                        lOdette.Campo_B = z[1..];
                        break;

                    case "3":
                    case "4":
                        if(z[0..1] == "4")
                        {
                            lOdette.Campo_S = z[2..];
                        }
                        else
                        {
                            if(z[0..2] == "30")
                            {
                                lOdette.Campo_3 = z[3..];
                            }
                            else
                            {
                                lOdette.Campo_S = z[2..];
                            }
                        }

                        break;

                    default: break;
                }
            }

            return lOdette;
        }
    }
}
