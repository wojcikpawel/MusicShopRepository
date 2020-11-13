using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace MusicShopLibrary
{
    public class Test
    {
        public void CreateExcelDoc(string fileName)
        {
            //Resource - tworzenie pliku excela
            using (SpreadsheetDocument document = SpreadsheetDocument.Create(fileName, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet();

                Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());

                Sheet sheet = new Sheet() { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Arkusz 1 Pawełka" };
                sheets.Append(sheet);

                workbookPart.Workbook.Save();

                WritingToExcel(worksheetPart);

            }
        }
        
        private static void WritingToExcel(WorksheetPart worksheetPart)
        {
            //zapis do pliku excel
            SheetData sheetData = worksheetPart.Worksheet.AppendChild(new SheetData());

            //wiersze i kolumny
            Row row = new Row();
            // Cell cell = new Cell() { CellValue = new CellValue("napis test"), DataType = CellValues.String };
            row.Append(new Cell() { CellValue = new CellValue("napis test"), DataType = CellValues.String },
                       new Cell() { CellValue = new CellValue("napis test"), DataType = CellValues.String },
                       new Cell() { CellValue = new CellValue("napis test"), DataType = CellValues.String });



            sheetData.AppendChild(row);

            for (int i = 0; i < 20; i++)
            {
                //wiersze i kolumny
                row = new Row();
                // Cell cell = new Cell() { CellValue = new CellValue("napis test"), DataType = CellValues.String };
                row.Append(new Cell() { CellValue = new CellValue("napis test"+ i ), DataType = CellValues.String },
                           new Cell() { CellValue = new CellValue("napis test"+ i), DataType = CellValues.String },
                           new Cell() { CellValue = new CellValue("napis test"+ i), DataType = CellValues.String },
                           new Cell() { CellValue = new CellValue("napis test" + i), DataType = CellValues.String },
                           new Cell() { CellValue = new CellValue("napis test" + i), DataType = CellValues.String },
                           new Cell() { CellValue = new CellValue("napis test" + i), DataType = CellValues.String },
                           new Cell() { CellValue = new CellValue("napis test"), DataType = CellValues.String },
                           new Cell() { CellValue = new CellValue("napis test" + i), DataType = CellValues.String },
                           new Cell() { CellValue = new CellValue("napis test"), DataType = CellValues.String });

                sheetData.AppendChild(row);
            }

            worksheetPart.Worksheet.Save();
        }

       
    }
}
