using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using SpreadsheetLight;

namespace JardinBotanic.Models
{
    public class TXT
    {
        string Lugarguardar = Environment.UserName.ToString();

        public void Guardar()
        {
            string pathfile = "C:\\Users\\" + Lugarguardar + "\\Downloads\\Informacion.xlsx";
            SLDocument osLDocument = new SLDocument();
            System.Data.DataTable dt = new System.Data.DataTable();

            dt.Columns.Add("Edad", typeof(string));
            dt.Columns.Add("Exp", typeof(string));
            dt.Columns.Add("Lugar", typeof(string));
            dt.Columns.Add("FavFlor", typeof(string));
            dt.Columns.Add("FlorCasa", typeof(string));
            dt.Columns.Add("Fact", typeof(string));
            dt.Columns.Add("Motiv", typeof(string));

            foreach (info k in info.DatosInfo)
            {

                dt.Rows.Add(k.Edad, k.Exp, k.Lugar, k.FavFlor, k.FlorCasa, k.Fact, k.Motiv);

            }

            osLDocument.ImportDataTable(1, 1, dt, true);
            osLDocument.SaveAs(pathfile);

        }
        public void TEXTO()
        {
            foreach (info k in info.DatosInfo)
            {
                StreamWriter DATOS = File.AppendText("C:\\Users\\" + Lugarguardar + "\\Downloads\\Informacion.txt");

                DATOS.Write(k.Edad);
                DATOS.Write(",");
                DATOS.Write(k.Exp);
                DATOS.Write(",");
                DATOS.Write(k.Lugar);
                DATOS.Write(",");
                DATOS.Write(k.FavFlor);
                DATOS.Write(",");
                DATOS.Write(k.FlorCasa);
                DATOS.Write(",");
                DATOS.Write(k.Fact);
                DATOS.Write(",");
                DATOS.Write(k.Motiv);

                DATOS.WriteLine("");
                DATOS.Close();
            }

        }
    }
}