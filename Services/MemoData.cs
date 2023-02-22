using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descargas_NET.Services
{
    public class MemoData : IMemoData
    {
        private readonly string extension = ".dat";
        private string _path = "";

        public string NombreFichero { get; set; }

        public MemoData()
        {
            ComprobarRutaFicheros();
        }

        public string LeerEnFichero()
        {
            FileStream fs;
            StreamReader sr;

            string miFichero = _path + "\\" + NombreFichero + extension;

            try
            {
                fs = new FileStream(miFichero, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs, Encoding.UTF8);

                var linea = sr.ReadToEnd();

                sr.Close();
                sr.Dispose();
                fs.Close();
                fs.Dispose();

                return linea;
            }
            catch { return ""; }
        }

        public void EscribirEnFichero(string msg)
        {
            FileStream fs;
            StreamWriter sw;
            
            string miFichero = _path + "\\" + NombreFichero  + extension;
            string linea = msg;
            //FileIOPermissionAccess value = FileIOPermissionAccess.AllAccess;
            //var perm = new System.Security.Permissions.FileIOPermission(
            //System.Security.Permissions.FileIOPermissionAccess.Write |
            //System.Security.Permissions.FileIOPermissionAccess.Read,
            //_path);
            try
            {
                EliminarFichero();

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

        public void EliminarFichero()
        {
            try
            {
                string miFichero = _path + "\\" + NombreFichero + extension;

                if (File.Exists(miFichero))
                    File.Delete(miFichero);
            }
            catch { }
        }//end

        private void ComprobarRutaFicheros()
        {
            //Se obtiene la ruta del ejecutable
            string cudir = Directory.GetCurrentDirectory();
            //Se crea la ruta para anotar en los ficheros
            _path = cudir + "\\DatosGuardados";
            try
            {
                //Si no existe el directorio se crea
                if (!Directory.Exists(_path))
                    Directory.CreateDirectory(_path);
            }
            catch { }
        }//end
    }
}
