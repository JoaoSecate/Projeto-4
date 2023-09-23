﻿using MySql.Data.MySqlClient;
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
    public partial class FormCurso : MaterialForm
    {
        // Variável para controlar se estamos realizando uma alteração
        bool isAlteracao = false;
        // String de conexão ao banco de dados MySQL
        string cs = @"server=127.0.0.1;" + "uid=root;" + "pwd=;" + "database=academico";

        public FormCurso()
        {
            InitializeComponent();
        }

        // Função para validar o formulário
        private bool ValidarFormulario()
        {
            // Verifica se o campo Nome está preenchido
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome do curso é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            // Verifica se o campo Ano de Criação está preenchido
            if (string.IsNullOrEmpty(txtAnoCriado.Text))
            {
                MessageBox.Show("Ano de criação é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnoCriado.Focus();
                return false;
            }
            // Verifica se o campo Tipo de Curso está preenchido
            if (string.IsNullOrEmpty(cboTipo.Text))
            {
                MessageBox.Show("Tipo do curso é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTipo.Focus();
                return false;
            }

            return true;
        }

        // Função para limpar os campos do formulário
        private void limpaCampos()
        {
            isAlteracao = false;

            // Limpa todos os campos do formulário
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

        // Função para salvar os dados no banco de dados
        private void Salvar()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "";
            if (!isAlteracao)
            {
                // Se não for uma alteração, insere um novo registro na tabela CURSO
                sql = "INSERT INTO CURSO" + "(nome, tipo, ano_criado) VALUES (@nome, @tipo, @ano_criado)";
            }
            else
            {
                // Se for uma alteração, atualiza um registro existente na tabela CURSO
                sql = "UPDATE CURSO SET " + "nome = @nome," + "tipo = @tipo," + "ano_criado = @ano_criado" + " WHERE id = @id";
            }

            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@tipo", cboTipo.Text);
            cmd.Parameters.AddWithValue("@ano_criado", txtAnoCriado.Text);

            if (isAlteracao)
                cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            limpaCampos();
        }

        // Função para carregar os dados na grade
        private void CarregaGrid()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM CURSO";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        // Função para deletar um registro da tabela CURSO
        private void Deletar(int id)
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "DELETE FROM CURSO WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        // Função para editar um registro existente
        private void Editar()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridView1.SelectedRows[0];
                txtId.Text = linha.Cells["id"].Value.ToString();
                txtNome.Text = linha.Cells["nome"].Value.ToString();
                txtAnoCriado.Text = linha.Cells["ano_criado"].Value.ToString();
                cboTipo.Text = linha.Cells["tipo"].Value.ToString();
                materialTabControl1.SelectedIndex = 0;
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum curso!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Evento de clique no botão "Cancelar"
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            txtNome.Focus();
        }

        // Evento de clique no botão "Salvar"
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            {
                if (ValidarFormulario())
                {
                    Salvar();
                    materialTabControl1.SelectedIndex = 1;
                }
            }
        }

        // Evento de clique na aba "Listagem"
        private void tabPage2_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        // Evento de clique no botão "Editar"
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Editar();
        }

        // Evento de clique no botão "Excluir"
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
                MessageBox.Show("Selecione algum curso!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Evento de clique no botão "Novo"
        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            limpaCampos();
            materialTabControl1.SelectedIndex = 0;
            txtNome.Focus();
        }

        // Evento de entrada na aba "Listagem"
        private void tabPage2_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}