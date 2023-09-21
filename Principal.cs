
using ReaLTaiizor.Forms;
namespace projeto4
{
    public partial class Principal : MaterialForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAluno formAluno = new FormAluno();
            formAluno.MdiParent = this;
            formAluno.Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void cadastroDeProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfessor formProfessor = new FormProfessor();
            formProfessor.MdiParent = this;
            formProfessor.Show();
        }

        private void cadastroCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCurso formCurso = new FormCurso();
            formCurso.MdiParent = this;
            formCurso.Show();
        }

        private void relatóriosDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEelatorioAluno formEelatorioAluno = new FormEelatorioAluno();
            formEelatorioAluno.MdiParent = this;
            formEelatorioAluno.Show();
        }

        private void relatóriosDeProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioProfessor formRelatorioProfessor = new FormRelatorioProfessor();
            formRelatorioProfessor.MdiParent = this;
            formRelatorioProfessor.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void relatóriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRelatorioCurso formRelatorioCurso = new FormRelatorioCurso();
            formRelatorioCurso.MdiParent = this;
            formRelatorioCurso.Show();
        }
    }
}