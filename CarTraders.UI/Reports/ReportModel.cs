using System.Windows.Forms;

namespace CarTraders.UI.Reports
{
    public class ReportModel
    {
        public DataGridView Data { get; set; }
        public string Name { get; set; }

        public ReportModel(DataGridView data, string name)
        {
            Data = data;
            Name = name;
        }
    }
}
