using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace ProyectAsimov.Clases
{
    class GenerarExcel
    {
        Excel.Application excel;
        Excel._Workbook libro;
        Excel._Worksheet hoja;
        Excel.Range rango;
        M_Eno m;
        string titulo;

        public GenerarExcel(M_Eno m,string titulo)
        {
            this.m = m;
            this.titulo=titulo;
            excel = new Excel.Application();
            libro = (Excel._Workbook)excel.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            hoja = (Excel._Worksheet)libro.Worksheets.Add();
            hoja.Name = "Resultado Del ENO";
            ((Excel.Worksheet)excel.ActiveWorkbook.Sheets["Hoja1"]).Delete();
            generarDocumento(ref hoja);
            libro.SaveAs(Environment.CurrentDirectory + @"\Result.xlxs");
        }
        private void generarDocumento(ref Excel._Worksheet hoja)
        {
            int i, s;
            hoja.Cells[2, 2] = "RESULT";
            for(i = 0; i < m.m.x; i++)
            {
                for(s = 0; s < m.m.y; s++)
                {
                    hoja.Cells[(i * 2)+3, (s * 2)+2] = m.m.mp[i, s];
                }
            }
        }
        private string intToLetter(int x)
        {
            char l;
            l = Convert.ToChar(x + 65);
            return Convert.ToString(l);
        }
    }
}
