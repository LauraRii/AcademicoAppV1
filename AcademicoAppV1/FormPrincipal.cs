using ReaLTaiizor.Forms;

namespace AcademicoAppV1
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void alunosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAluno formAluno = new FormAluno();
            // Definindo formPrincipal como pai do FormAluno
            formAluno.MdiParent = this;
            // Apresenta formulário aluno
            formAluno.Show();
        }
    }
}
