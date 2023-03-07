using Descargas_NET.Forms;
using Descargas_NET.Helpers;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;


namespace Descargas_NET
{
    public static class GlobalSettings
    {
        public static string BASE_SERVER_URL = "http://192.168.153.126/apibentval/";//"https://localhost:44372/";//

        public static string VirtualHost = "apibentval/";

        public static int PuertoCom = 1;

        public static int Baudrate = 9600;

        public static frm_Descarga formDescarga;

        public static frm_ListDescargas formListDescargas;

        public static frm_Login formLogin;

        public static FrmPrincDescargas formPrincDescargas;

        public static frm_PrincReposiciones formPrincReposiciones;

        public static FrmReposiciones formReposiciones;

        public static MSCommNet MSCommNet;

        public static string UsuarioApp = "EL PROBADOR .NET";

        public static string Confirmacion = "CONFIRMACION";

        public static int VersionSoftware = 5;
    }
}
