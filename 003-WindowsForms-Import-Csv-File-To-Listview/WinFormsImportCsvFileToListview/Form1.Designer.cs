namespace WinFormsImportCsvFileToListview
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewBooks = new ListView();
            btnLoadBooks = new Button();
            ID = new ColumnHeader();
            Title = new ColumnHeader();
            Author = new ColumnHeader();
            SuspendLayout();
            // 
            // listViewBooks
            // 
            //listViewBooks.Columns.AddRange(new ColumnHeader[] { ID, Title, Author });
            //listViewBooks.Location = new Point(12, 12);
            //listViewBooks.Name = "listViewBooks";
            //listViewBooks.Size = new Size(760, 369);
            //listViewBooks.TabIndex = 0;
            //listViewBooks.UseCompatibleStateImageBehavior = false;
            this.listViewBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            new System.Windows.Forms.ColumnHeader { Text = "ID", Width = 50 },
            new System.Windows.Forms.ColumnHeader { Text = "Title", Width = 200 },
            new System.Windows.Forms.ColumnHeader { Text = "Author", Width = 150 }});
            this.listViewBooks.FullRowSelect = true;
            this.listViewBooks.GridLines = true;
            this.listViewBooks.HideSelection = false;
            this.listViewBooks.Location = new System.Drawing.Point(12, 12);
            this.listViewBooks.Name = "listViewBooks";
            this.listViewBooks.Size = new System.Drawing.Size(410, 237);
            this.listViewBooks.TabIndex = 0;
            this.listViewBooks.UseCompatibleStateImageBehavior = false;
            this.listViewBooks.View = System.Windows.Forms.View.Details;
            // 
            // btnLoadBooks
            // 
            btnLoadBooks.Location = new Point(299, 415);
            btnLoadBooks.Name = "btnLoadBooks";
            btnLoadBooks.Size = new Size(75, 23);
            btnLoadBooks.TabIndex = 1;
            btnLoadBooks.Text = "Import Books";
            btnLoadBooks.UseVisualStyleBackColor = true;
            btnLoadBooks.Click += BtnLoadBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 595);
            Controls.Add(btnLoadBooks);
            Controls.Add(listViewBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewBooks;
        private Button btnLoadBooks;
        private ColumnHeader ID;
        private ColumnHeader Title;
        private ColumnHeader Author;
    }
}
