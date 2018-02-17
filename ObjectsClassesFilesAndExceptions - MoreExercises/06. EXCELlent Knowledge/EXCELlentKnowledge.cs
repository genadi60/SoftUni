using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
public class EXCELlentKnowledge
{
    public static void Main()
    {
        Application xlApp = new Application();
        Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\sample_table.xlsx");
        _Worksheet xlWorksheet = xlWorkbook.Sheets[1];
        Range xlRange = xlWorksheet.UsedRange;

        int rowCount = xlRange.Rows.Count;
        int colCount = xlRange.Columns.Count;
        var stringForEmptyCells = "\r\n";
        var sampleTextLine = string.Empty;
        var sampleText = string.Empty;
        for (int i = 1; i <= rowCount; i++)
        {
            for (int j = 1; j <= colCount; j++)
            {
               
                if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                {
                    //Console.Write("{0}",xlRange.Cells[i, j].Value2.ToString() + "|");
                    var sampleTextCell = String.Format("{0}", xlRange.Cells[i, j].Value2.ToString() + "|");
                    sampleTextLine += sampleTextCell;
                    
                }
                else
                {
                   stringForEmptyCells = "\r";
                }   
                
                    
            }
            sampleTextLine += "\r\n";
            sampleText += sampleTextLine;
            sampleTextLine = string.Empty;
            Console.Write(stringForEmptyCells);
        }
        File.WriteAllText("textFromExcel.txt", sampleText);
        //cleanup
        GC.Collect();
        GC.WaitForPendingFinalizers();

        //rule of thumb for releasing com objects:
        //  never use two dots, all COM objects must be referenced and released individually
        //  ex: [somthing].[something].[something] is bad

        //release com objects to fully kill excel process from running in the background
        Marshal.ReleaseComObject(xlRange);
        Marshal.ReleaseComObject(xlWorksheet);

        //close and release
        xlWorkbook.Close();
        Marshal.ReleaseComObject(xlWorkbook);

        //quit and release
        xlApp.Quit();
        Marshal.ReleaseComObject(xlApp);
    }
}