namespace WindowsFormsInputToListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeListView();
        }

        // Define a class to hold the information
        class Info
        {
            public string Field1 { get; set; }
            public string Field2 { get; set; }
        }

        // Create a list to store the information
        private List<Info> infoList = new List<Info>();



        private void InitializeListView()
        {
            // Set up columns in the ListView
            listView1.View = View.Details;
            listView1.Columns.Add("Field 1", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Field 2", -2, HorizontalAlignment.Left);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Create an Info object from the input fields
            var info = new Info()
            {
                Field1 = textBox1.Text,
                Field2 = textBox2.Text
            };

            // Add the object to the list
            infoList.Add(info);

            // Refresh the ListView
            RefreshListView();
        }

        private void RefreshListView()
        {
            // Clear current items
            listView1.Items.Clear();

            // Add items from the list to the ListView
            foreach (var info in infoList)
            {
                var item = new ListViewItem(new[] { info.Field1, info.Field2 });
                listView1.Items.Add(item);
            }
        }

    }
}
