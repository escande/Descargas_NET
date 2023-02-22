using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Permissions;
using System.ComponentModel;

namespace Descargas_NET.Services
{
    public class Log : ILog
    {
        private readonly string extension = ".log";
        private  string _path ="";
        private readonly string _nombreFichero = "";

        public Log(string NombreFichero)
        {
            _nombreFichero = NombreFichero;
            ComprobarRutaFicheros();
        }//end

        public void EscribirEnFichero(string msg)
        {
            FileStream fs;
            StreamWriter sw;
            int dia = DateTime.Now.Day;
            string miFichero = _path + "\\" + _nombreFichero + dia.ToString() + extension;
            string linea = DateTime.Now.ToString() + " --- " + msg;
            //FileIOPermissionAccess value = FileIOPermissionAccess.AllAccess;
            //var perm = new System.Security.Permissions.FileIOPermission(
            //System.Security.Permissions.FileIOPermissionAccess.Write |
            //System.Security.Permissions.FileIOPermissionAccess.Read,
            //_path);
            try
            {
                //perm.Demand();
                EliminarFicheroAntiguo();
                fs = new FileStream(miFichero, FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs, Encoding.UTF8);

                sw.WriteLine(linea);

                sw.Flush();
                sw.Close();
                sw.Dispose();
                fs.Close();
                fs.Dispose();
            }
            catch { }
        }//end

        private void EliminarFicheroAntiguo()
        {
            try
            {
                int dia = CalcularProximoDia();
                string miFichero = _path + "\\" + _nombreFichero + dia.ToString() + extension;

                if (File.Exists(miFichero))
                    File.Delete(miFichero);
            }
            catch { }
        }//end

        private int CalcularProximoDia()
        {
            DateTime elMañana = DateTime.Now.AddDays(1);
            int elDia = elMañana.Day;

            return elDia;
        }//end

        public void ComprobarRutaFicheros()
        {
            //Se obtiene la ruta del ejecutable
            string cudir = Directory.GetCurrentDirectory();
            //Se crea la ruta para anotar en los ficheros
            _path = cudir + "\\logs";
            try
            {
                //Si no existe el directorio se crea
                if (!Directory.Exists(_path))
                    Directory.CreateDirectory(_path);
            }
            catch { }
        }//end
    }//end class
}//end nameSpace
