using System.Diagnostics;

namespace CalculadoraCP1
{
    public partial class FormSobre : Form
    {
        public FormSobre()
        {
            InitializeComponent();
        }

        private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(linkGitHub.Text) { UseShellExecute = true });
            }
            catch
            {
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblIntegrantes_Click(object sender, EventArgs e)
        {

        }

        private void txtResumo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
