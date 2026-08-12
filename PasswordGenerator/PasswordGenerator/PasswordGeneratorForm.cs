namespace PasswordGenerator
{
    public partial class PasswordGeneratorForm : Form
    {
        public PasswordGeneratorForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = PasswordGenerator.Generate(
                    (int)nudLength.Value,
                    chkUppercase.Checked,
                    chkLowercase.Checked,
                    chkNumbers.Checked,
                    chkSymbols.Checked
                );
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
                Clipboard.SetText(txtResult.Text);
        }

      
    }
}
