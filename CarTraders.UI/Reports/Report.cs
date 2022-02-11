using CarTraders.UI.Reports;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarTraders.UI
{
    public class Report
    {
        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

        public void GenerateExcel(ReportModel model)
        {
            CreateExcelSheet(model.Data, model.Name);
        }

        public void GenerateMultipleExcels(List<ReportModel> models)
        {
            foreach (var model in models)
            {
                CreateExcelSheet(model.Data, model.Name);
            }
        }

        private void CreateExcelSheet(DataGridView dataGridView, string reportName)
        {
            try
            {
                if (dataGridView.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                    app.Visible = false;
                    worksheet = workbook.Sheets["Sheet1"];
                    worksheet = workbook.ActiveSheet;
                    worksheet.Name = reportName;

                    for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            var cellValue = dataGridView.Rows[i].Cells[j].Value ?? "";
                            worksheet.Cells[i + 2, j + 1] = cellValue.ToString();
                        }
                    }
                    workbook.SaveAs($"{path}\\Reports\\Output\\{reportName} {DateTime.Now.ToString("yyyy_MM_dd_mm_ss")}", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    app.Quit();

                    MessageBox.Show($"{reportName} generated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No data available for {reportName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to generate {reportName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }
    }
}
