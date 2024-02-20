
namespace WinFormsExportListviewToFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void InitializeListView()
        {
            // Assuming your ListView is in Details view and you have defined columns in the designer
            listViewData.View = View.Details;
            listViewData.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listViewData.Columns.Add("Name", -2, HorizontalAlignment.Left);
            listViewData.Columns.Add("Age", -2, HorizontalAlignment.Left);

            // Adding sample data
            listViewData.Items.Add(new ListViewItem(new[] { "1", "Alissa Melton", "30" }));
            listViewData.Items.Add(new ListViewItem(new[] { "2", "Everton Jones", "25" }));
            listViewData.Items.Add(new ListViewItem(new[] { "3", "Jordi Brown", "45" }));
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Save an Export File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (ListViewItem item in listViewData.Items)
                    {
                        // Using LINQ to select and format item subitems into a comma-separated string
                        var line = item.SubItems.Cast<ListViewItem.ListViewSubItem>()
                                                .Select(subItem => subItem.Text)
                                                .Aggregate((current, next) => current + ", " + next);
                        writer.WriteLine(line);
                    }
                }
                MessageBox.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
