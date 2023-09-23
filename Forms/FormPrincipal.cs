using ReaLTaiizor.Forms;

namespace projeto4
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent(); // Inicializa o formulário principal.
        }

        private void cadastroDeAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre um formulário de cadastro de aluno como janela filha deste formulário principal.
            FormAluno formAluno = new FormAluno();
            formAluno.MdiParent = this;
            formAluno.Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Intercepta o evento de fechamento do formulário principal e cancela-o caso a razão seja a chamada de saída da aplicação.
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void cadastroDeProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre um formulário de cadastro de professor como janela filha deste formulário principal.
            FormProfessor formProfessor = new FormProfessor();
            formProfessor.MdiParent = this;
            formProfessor.Show();
        }

        private void cadastroCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre um formulário de cadastro de curso como janela filha deste formulário principal.
            FormCurso formCurso = new FormCurso();
            formCurso.MdiParent = this;
            formCurso.Show();
        }

        private void relatóriosDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre um formulário de relatório de alunos como janela filha deste formulário principal.
            FormRelatorioAluno formEelatorioAluno = new FormRelatorioAluno();
            formEelatorioAluno.MdiParent = this;
            formEelatorioAluno.Show();
        }

        private void relatóriosDeProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre um formulário de relatório de professores como janela filha deste formulário principal.
            FormRelatorioProfessor formRelatorioProfessor = new FormRelatorioProfessor();
            formRelatorioProfessor.MdiParent = this;
            formRelatorioProfessor.Show();
        }

        private void relatóriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Abre um formulário de relatório de cursos como janela filha deste formulário principal.
            FormRelatorioCurso formRelatorioCurso = new FormRelatorioCurso();
            formRelatorioCurso.MdiParent = this;
            formRelatorioCurso.Show();
        }
    }
}