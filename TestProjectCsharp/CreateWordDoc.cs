using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace TestProjectCsharp
{
    public class CreateWordDoc
    {
        public void ExportToWord(DataGridView dgv01, DataGridView dgv02, DataGridView dgv03, DataGridView dgv04, DataGridView dgv05, DataGridView dgv06,
                                    DataGridView dgv07, DataGridView dgv08, DataGridView dgv09, string txt)
        {
            object missing = Type.Missing;
            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = new Word.Document();
            wordApp.Visible = true;
            wordApp.WindowState = Word.WdWindowState.wdWindowStateNormal;
            wordDoc = wordApp.Documents.Add(ref missing, ref missing, ref missing, ref missing);

            CreateAndPopulateTable(dgv01, wordDoc);
            CreateAndPopulateTable(dgv02, wordDoc);
            CreateAndPopulateTable(dgv03, wordDoc);
            CreateAndPopulateTable(dgv04, wordDoc);
            CreateAndPopulateTable(dgv05, wordDoc);
            CreateAndPopulateTable(dgv06, wordDoc);
            CreateAndPopulateTable(dgv07, wordDoc);
            CreateAndPopulateTable(dgv08, wordDoc);
            CreateAndPopulateTable(dgv09, wordDoc);
            CreateSpecialInstructions(txt, wordDoc);

            //SaveDocument(wordApp);
        }
        public void SaveDocument(Word.Application wordApp)
        {
            object fileName = "C:\\Users\\jared\\Desktop\\test.pdf";
            object missing = Type.Missing;
            wordApp.ActiveDocument.SaveAs2(ref fileName, ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing,
                                            ref missing);
        }
        public void CreateAndPopulateTable(DataGridView dgv, Word.Document wordDoc)
        {
            object endOfDoc = "\\endofdoc";
            object missing = Type.Missing;
            int rowCount = dgv.Rows.Count;
            int colCount = dgv.Columns.Count;
            Word.Table table;
            Word.Paragraph paragraph;

            if (dgv != null)
            {
                Word.Range range = wordDoc.Bookmarks.get_Item(ref endOfDoc).Range;
                table = wordDoc.Tables.Add(range, 1, colCount, ref missing, ref missing);
                table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.AllowAutoFit = true;

                foreach (DataGridViewCell cell in dgv.Rows[0].Cells)
                {
                    table.Cell(table.Rows.Count + 1, cell.ColumnIndex + 1).Range.Text = dgv.Columns[cell.ColumnIndex].Name;
                    table.Rows[1].Range.Font.Bold = 1;
                    table.Rows[1].Alignment = Word.WdRowAlignment.wdAlignRowCenter;
                    table.Rows[1].Range.Font.Name = "Arial";
                    table.Rows[1].Range.Font.Size = 14;
                }
                table.Rows.Add();
                table.Rows[2].Range.Font.Bold = 0;
                table.Rows[2].Alignment = Word.WdRowAlignment.wdAlignRowLeft;
                table.Rows[2].Range.Font.Name = "Arial";
                table.Rows[2].Range.Font.Size = 12;

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            table.Cell(table.Rows.Count + 1, cell.ColumnIndex + 1).Range.Text = cell.Value.ToString();
                        }
                        else { }
                    }
                    table.Rows.Add();
                }
                table.Rows[rowCount + 2].Delete();
                paragraph = wordDoc.Paragraphs.Add();
            }
            else { }
        }

        public void CreateSpecialInstructions(string txt, Word.Document wordDoc)
        {
            object endOfDoc = "\\endofdoc";
            Word.Range range = wordDoc.Bookmarks.get_Item(ref endOfDoc).Range;

            range.InsertBefore(txt);            
        }
    }
}

