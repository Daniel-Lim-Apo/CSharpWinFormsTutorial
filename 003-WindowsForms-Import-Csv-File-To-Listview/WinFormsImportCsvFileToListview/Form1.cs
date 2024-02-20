namespace WinFormsImportCsvFileToListview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnLoadBooks.Click += BtnLoadBooks_Click;
        }

        private void BtnLoadBooks_Click(object sender, EventArgs e)
        {
            // Define the path to the CSV file
            string filePath = "D:\\Doc\\VSCode\\CSharpWinFormsTutorial\\003-WindowsForms-Import-Csv-File-To-Listview\\WinFormsImportCsvFileToListview\\books.csv";

            // Read the CSV file and skip the header line
            var bookLines = File.ReadAllLines(filePath).Skip(1);

            // Parse each line into an anonymous type and use LINQ to filter as needed
            var books = bookLines.Select(line =>
            {
                var columns = line.Split(',');
                return new
                {
                    ID = columns[0],
                    Title = columns[1],
                    Author = columns[2]
                };
            }).ToList();

            // Populate the ListView
            listViewBooks.Items.Clear();
            foreach (var book in books)
            {
                var listViewItem = new ListViewItem(new[] { book.ID , book.Title , book.Author });
                listViewBooks.Items.Add(listViewItem);
            }
        }
    }


}
