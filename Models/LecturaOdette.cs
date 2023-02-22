using System;
using System.Collections.Generic;
using System.Text;

namespace Descargas_NET.Models
{
    public enum CodeType
    {
        Code1D, PDF417, Code_QR
    }
    public class LecturaOdette
    {
        public string Lectura { get; set; }
        public CodeType CodeType { get; set; }
        public string Campo_A { get; set; }
        public string Campo_P { get; set; }
        public int Campo_Q { get; set; }
        public string Campo_N { get; set; }
        public string Campo_V { get; set; }
        public string Campo_S { get; set; }
        public string Campo_D { get; set; }
        public string Campo_H { get; set; }
        public string Campo_3 { get; set; }
        public string Campo_U { get; set; }
        public string Campo_I { get; set; }
        public string Campo_B { get; set; }

        //Campo que corresponde al Serie en etiquetas con QR Benteler
        public string Campo_C { get; set; }
    }
}
