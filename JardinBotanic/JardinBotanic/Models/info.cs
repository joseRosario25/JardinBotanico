using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JardinBotanic.Models
{
    public class info
    {
        public string edad;
        public string exp;
        public string favFlor;
        public string lugar;
        public string florCasa;
        public string fact;
        public string motiv;


        public static List<info> DatosInfo = new List<info>();


        public string Edad { get => edad; set => edad = value; }
        public string Exp { get => exp; set => exp = value; }
        public string FavFlor { get => favFlor; set => favFlor = value; }
        public string Lugar { get => lugar; set => lugar = value; }
        public string FlorCasa { get => florCasa; set => florCasa = value; }
        public string Fact { get => fact; set => fact = value; }
        public string Motiv { get => motiv; set => motiv = value; }

    }
}