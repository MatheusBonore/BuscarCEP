using OfficeOpenXml;
using System.IO;

namespace BuscaCEP.Functions
{
    class Planilha
    {
        //FileInfo PathFile = new FileInfo(@"P:\Planilha.xlsx");
        public static void GravarArquivo(FileInfo PathFile, int Row, int Col, string value)
        {
            ExcelPackage ExcelPkg = new ExcelPackage();
            ExcelWorksheet wsSheet1 = ExcelPkg.Workbook.Worksheets.Add("Sheet1");

            using (ExcelRange Rng = wsSheet1.Cells[Row, Col])
            {
                Rng.Value = value;

                wsSheet1.Protection.IsProtected = false;
                wsSheet1.Protection.AllowSelectLockedCells = false;
                ExcelPkg.SaveAs(PathFile);
            }
        }

        public static void AlterarArquivo() { }

        public static void LerArquivo(FileInfo PathFile) { }
    }
}
