using System;
using MyExcel = Microsoft.Office.Interop.Excel;
//Framework
namespace Ex6EXCELlentKnowledge
{
    class PrograEXCELlentKnowledgeFWm
    {
        static void Main()
        {
            MyExcel.Application app = new MyExcel.Application();
            MyExcel.Workbook workbook = app.Workbooks.Open(@"\sample_table.xlsx");
            MyExcel.Worksheet sheet = (MyExcel.Worksheet)workbook.Sheets["Sheet1"];
            MyExcel.Range range = sheet.UsedRange;
            long columnsCount = range.Columns.Count;
            long rowsCount = range.Rows.Count;

            for (int i = 1; i <= rowsCount; i++)
            {
                for (int j = 1; j <= columnsCount; j++)
                {
                    if (range.Cells[i, j] == null || ((MyExcel.Range)range.Cells[i, j]).Value2 == null)
                    {
                        goto Break;
                    }
                    Console.Write(((((MyExcel.Range)range.Cells[i, j]).Value2.ToString()) + "|"));
                }
                Console.WriteLine();
            }
            Break:
            workbook.Close();
            app.Quit();
        }
    }
}
