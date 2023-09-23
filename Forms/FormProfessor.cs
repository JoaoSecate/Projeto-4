using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto4
{
    public partial class FormProfessor : MaterialForm
    {
        // Variável para verificar se estamos fazendo uma alteração de registro
        bool isAlteracao = false;

        // String de conexão com o banco de dados MySQL
        string cs = @"server=127.0.0.1;" + "uid=root;" + "pwd=;" + "database=academico";

        // Construtor da classe
        public FormProfessor()
        {
            InitializeComponent();
        }

        // Método para validar o formulário antes de salvar
        private bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Matricula é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAreaFormacao.Text))
            {
                MessageBox.Show("Área de formação é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAreaFormacao.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Endereco é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Bairro é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Cidade é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cboTitulacao.Text))
            {
                MessageBox.Show("Titulação é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTitulacao.Focus();
                return false;
            }

            if (!DateTime.TryParse(txtDataNascimento.Text, out DateTime _))
            {
                MessageBox.Show("Data de nascimento é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataNascimento.Focus();
                return false;
            }

            return true;
        }

        // Método para limpar os campos do formulário
        private void limpaCampos()
        {
            isAlteracao = false;

            foreach (var control in tabPage1.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        // Método para salvar um registro no banco de dados
        private void Salvar()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "";
            if (!isAlteracao)
            {
                // Se não for uma alteração, inserir um novo registro
                sql = "INSERT INTO professor" + "(matricula, dt_nascimento, nome, titulacao, area_formacao, endereco, bairro, cidade, estado) VALUES (@matricula, @dt_nascimento, @nome, @titulacao, @area_formacao, @endereco, @bairro, @cidade, @estado)";

            }
            else
            {
                // Se for uma alteração, atualizar o registro existente
                sql = "UPDATE professor SET " + "matricula = @matricula," + "dt_nascimento = @dt_nascimento," + "nome = @nome," + "endereco = @endereco," + "bairro = @bairro," + "cidade = @cidade," + "estado = @estado," + "titulacao = @titulacao," + "area_formacao = @area_formacao" + " WHERE id = @id";

            }

            var cmd = new MySqlCommand(sql, con);
            DateTime.TryParse(txtDataNascimento.Text, out var dtNascimento);
            cmd.Parameters.AddWithValue("@matricula", txtMatricula.Text);
            cmd.Parameters.AddWithValue("@dt_nascimento", dtNascimento);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
            cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
            cmd.Parameters.AddWithValue("@estado", cboEstado.Text);
            cmd.Parameters.AddWithValue("@titulacao", cboTitulacao.Text);
            cmd.Parameters.AddWithValue("@area_formacao", txtAreaFormacao.Text);

            if (isAlteracao)
                cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            limpaCampos();
        }

        // Método para carregar dados na grade (dataGridView1)
        private void CarregaGrid()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM professor";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        // Método para deletar um registro do banco de dados
        private void Deletar(int id)
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "DELETE FROM PROFESSOR WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        // Método para editar um registro selecionado na grade
        private void Editar()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridView1.SelectedRows[0];
                txtId.Text = linha.Cells["id"].Value.ToString();
                txtMatricula.Text = linha.Cells["matricula"].Value.ToString();
                txtDataNascimento.Text = linha.Cells["dt_nascimento"].Value.ToString();
                txtNome.Text = linha.Cells["nome"].Value.ToString();
                txtEndereco.Text = linha.Cells["endereco"].Value.ToString();
                txtBairro.Text = linha.Cells["bairro"].Value.ToString();
                cboEstado.Text = linha.Cells["estado"].Value.ToString();
                txtCidade.Text = linha.Cells["cidade"].Value.ToString();
                cboTitulacao.Text = linha.Cells["titulacao"].Value.ToString();
                txtAreaFormacao.Text = linha.Cells["area_formacao"].Value.ToString();
                materialTabControl1.SelectedIndex = 0;
                txtMatricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum professor!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Manipulador de evento para o botão Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            txtMatricula.Focus();
        }

        // Manipulador de evento para o botão Salvar
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Salvar();
                materialTabControl1.SelectedIndex = 1;
            }
        }

        // Manipulador de evento para o clique nas células da grade
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        // Manipulador de evento para a guia (tabPage2) quando é exibida
        private void tabPage2_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        // Manipulador de evento para o botão Excluir
        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente deletar?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum professor!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Manipulador de evento para o botão Editar
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Editar();
        }

        // Manipulador de evento para o botão Novo
        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            limpaCampos();
            materialTabControl1.SelectedIndex = 0;
            txtMatricula.Focus();
        }

        // Manipulador de evento para a guia (tabPage2) quando é exibida
        private void tabPage2_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
