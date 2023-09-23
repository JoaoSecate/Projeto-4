using ReaLTaiizor.Forms;

namespace projeto4
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent(); // Inicializa o formul�rio principal.
        }

        private void cadastroDeAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre um formul�rio de cadastro de aluno como janela filha deste formul�rio principal.
            FormAluno formAluno = new FormAluno();
            formAluno.MdiParent = this;
            formAluno.Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Intercepta o evento de fechamento do formul�rio principal e cancela-o caso a raz�o seja a chamada de sa�da da aplica��o.
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void cadastroDeProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre um formul�rio de cadastro de professor como janela filha deste formul�rio principal.
            FormProfessor formProfessor = new FormProfessor();
            formProfessor.MdiParent = this;
            formProfessor.Show();
        }

        private void cadastroCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre um formul�rio de cadastro de curso como janela filha deste formul�rio principal.
            FormCurso formCurso = new FormCurso();
            formCurso.MdiParent = this;
            formCurso.Show();
        }

        private void relat�riosDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre um formul�rio de relat�rio de alunos como janela filha deste formul�rio principal.
            FormRelatorioAluno formEelatorioAluno = new FormRelatorioAluno();
            formEelatorioAluno.MdiParent = this;
            formEelatorioAluno.Show();
        }

        private void relat�riosDeProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre um formul�rio de relat�rio de professores como janela filha deste formul�rio principal.
            FormRelatorioProfessor formRelatorioProfessor = new FormRelatorioProfessor();
            formRelatorioProfessor.MdiParent = this;
            formRelatorioProfessor.Show();
        }

        private void relat�riosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Abre um formul�rio de relat�rio de cursos como janela filha deste formul�rio principal.
            FormRelatorioCurso formRelatorioCurso = new FormRelatorioCurso();
            formRelatorioCurso.MdiParent = this;
            formRelatorioCurso.Show();
        }
    }
}