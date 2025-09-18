using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace AcademicoAppV1
{
    public partial class FormAluno : MaterialForm
    {
        string alunosFileName = "alunos.txt";
        bool isEditMode = false;

        public FormAluno()
        {
            InitializeComponent();
        }

        private void LimpaCampos()
        {
            isEditMode = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit textBox)
                    textBox.Clear();
                if (control is MaterialMaskedTextBox maskedTextBox)
                    maskedTextBox.Clear();
            }
        }

        private void materialButtonNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            // Mudando para página cadastro
            tabControlCadastro.SelectedIndex = 0;
            // Campo matrícula recebe foco do teclado
            materialTextBoxMatricula.Focus();
        }

        private void materiaButtonCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Informações não salvas serão perdidas!\n Deseja realmente cancelar?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                // Mudando para página consulta
                tabControlCadastro.SelectedIndex = 1;
            }
        }
    }
}
