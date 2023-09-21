using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using ReaLTaiizor.Forms;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace projeto4
{
    public partial class FormRelatorioCurso : MaterialForm
    {
        bool isAlteracao = false;
        string cs = @"server=127.0.0.1;" + "uid=root;" + "pwd=;" + "database=academico";

        public FormRelatorioCurso()
        {
            InitializeComponent();
            CarregaImpressora();
        }

        private void CarregaImpressora()
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cboImpressora.Items.Add(printer);
            }
        }

        private void FormRelatorioCurso_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            MontaRelatorio();

            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"RelatorioCursos.pdf")
            {
                UseShellExecute = true
            };
            p.Start();
            //Start("RelatorioAlunos.pdf");
        }

        private PdfDocument doc = new PdfDocument();
        private void MontaRelatorio()
        {
            //ativar as seguintes´propriedades:
            //ALLOW USER TO ADD ROWS -> False
            //ALLOW USER TO DELETE ROWS -> False
            //SELECTION MODE -> FullRowSelect
            //MULTISELECT -> False
            //READY ONLY -> True
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM curso where 1 = 1";
            var sqlAd = new MySqlDataAdapter();

            if (cboTipo.Text != "")
                sql += " and Tipo = @tipo";

            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            if (cboTipo.Text != "")
                sqlAd.SelectCommand.Parameters.AddWithValue("@tipo", cboTipo.Text);          

            var dt = new DataTable();
            sqlAd.Fill(dt);
            con.Close();

            //Inicio geracao PDF
            //PdfDocument doc = new PdfDocument();
            PdfSection sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            PdfPageBase page = sec.Pages.Add();
            int y = 20;//linha
            PdfBrush brush1 = PdfBrushes.Black;
            PdfTrueTypeFont font1 = new PdfTrueTypeFont(new Font("Arial", 16f, FontStyle.Bold));
            PdfStringFormat format1 = new PdfStringFormat(PdfTextAlignment.Center);

            page.Canvas.DrawString("Relatório de Curos", font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1);

            PdfTable table = new PdfTable();
            table.Style.CellPadding = 2;
            table.Style.BorderPen = new PdfPen(brush1, 0.75f);
            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            table.Style.HeaderSource = PdfHeaderSource.ColumnCaptions;
            //table.Style.HeaderRowCount = 1;
            table.Style.ShowHeader = true;
            table.DataSource = dt;
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.BlueViolet;

            foreach (PdfColumn col in table.Columns)
            {
                col.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            }

            table.Draw(page, new Point(0, y + 30));
            doc.SaveToFile("RelatorioCursos.pdf");
        }


        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            MontaRelatorio();

            doc.LoadFromFile("RelatorioCursos.pdf");
            doc.PrintSettings.PrinterName = cboImpressora.Text;
            doc.Print();
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            MontaRelatorio();

            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"RelatorioCursos.pdf")
            {
                UseShellExecute = true
            };
            p.Start();
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
