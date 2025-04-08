namespace Task2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ReplaceForm form2 = new ReplaceForm();
            form2.ReplaceText += ReplaceText;
            form2.Show();
        }

        private void ReplaceText(string searchText, string replaceText)
        {
            textTextBox.Text = textTextBox.Text.Replace(searchText, replaceText, StringComparison.OrdinalIgnoreCase);
        }
    }
}
