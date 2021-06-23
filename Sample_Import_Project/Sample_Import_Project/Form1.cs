using System;
using System.Data;
using System.Windows.Forms;

namespace Sample_Import_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
                        // The OpenFileDialog allows us to pop-up a new window where the user can select a file from their computer
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set some properties on the Open File dialog before we display it to the user
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv| All Files (*.*)|*.*";
            openFileDialog.Title = "Select File for Import";

            // Display the Open File dialog to the user
            // The function ShowDialog() stops all code excution until the dialog is closed by the user
            // We store the result of the Open File Dialog to a variable so we can act on it
            DialogResult openFileDialogResult = openFileDialog.ShowDialog();

            // Check that the result of the Open File Dialog is OK.  expected results are OK or Cancel
            if (openFileDialogResult == DialogResult.OK)
            {
                // If OK, we retrieve the File the user selected in the Open File Dialog, and put that into the Import File Path Textbox on the main Form
                ImportFilePathTextbox.Text = openFileDialog.FileName;
            }
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            // Pull out the Import File Path from the textbox into a local variable
            string ImportFilePath = ImportFilePathTextbox.Text;

            // Perform some validation on the Import File Path Provided
            // Validate Import File Path is not empty
            if (ImportFilePath.Trim().Length == 0)
            {
                MessageBox.Show("The Import file Path is empty!");
                return;
            }

            // Validate the Import file Path is a valid path on the local machine
            if (System.IO.File.Exists(ImportFilePath) == false)
            {
                MessageBox.Show("The Import file at the provided path does not exist!");
                return;
            }

            // Validate that the Import File Path is a CSV file
            if (System.IO.Path.GetExtension(ImportFilePath) != ".csv")
            {
                MessageBox.Show("The Import file is not a valid type.  Valid types are: CSV");
                return;
            }


            // Validation complete
            // Begin Import of the file using our own library ADSFramework.Excel
            DataTable ImportFileDataTable = ADSFramework.Excel.CsvConverter.ToDatatable(ImportFilePath);

            // Do some validation on the Import File DataTable
            // Validate DataTable has 1+ columns
            if (ImportFileDataTable.Columns.Count == 0)
            {
                MessageBox.Show("The Import File does not contain any columns!");
                return;
            }

            // Validate DataTable has 1+ Rows
            if (ImportFileDataTable.Rows.Count == 0)
            {
                MessageBox.Show("The Import File does not contain any Rows!");
                return;
            }

            // Completed Import File DataTable validation
            // Now to finally display the Import File data to the user
            // The DataTable object has no way to show itself on the Form to the user
            // We use the DataGridView Control to display the DataTable by setting the DataSource
            // (Controls are objects which are shown in the Form such as TextBox, Label, Button, DataGridView, etc.  All controls inherit from System.Windows.Forms.Control)
            ImportFileDataGridView.DataSource = ImportFileDataTable;
            MessageBox.Show("File has been Imported Successfully!");
        }

        private void ClearScreenButton_Click(object sender, EventArgs e)
        {
            // Clearing the screen is a simple as overwriting properties with empty string/null
            ImportFilePathTextbox.Text = "";
            ImportFileDataGridView.DataSource = null;
            MessageBox.Show("Import Screen has been Cleared!");


            //FirstLast testFirstLast = new FirstLast("Nathan", "Sawyer");
        }
    }


    public class FirstLast
    {
        string FirstName;
        string LastName;

        public FirstLast()
        {

        }

        public FirstLast(string First, string Last)
        {
            FirstName = First;
            LastName = Last;
        }
    }
}
