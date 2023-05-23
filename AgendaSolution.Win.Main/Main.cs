using AgendaSolution.Win.Cadastros;

namespace AgendaSolution.Win.Main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContatoCadastroForm contato = new ContatoCadastroForm();
            contato.Show();

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContatoConsultaForm consultaForm = new ContatoConsultaForm();
            consultaForm.Show();
        }
    }
}