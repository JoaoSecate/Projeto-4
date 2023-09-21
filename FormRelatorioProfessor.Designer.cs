namespace projeto4
{
    partial class FormRelatorioProfessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            groupBox2 = new GroupBox();
            cboAgrupamento = new ReaLTaiizor.Controls.MaterialComboBox();
            groupBox3 = new GroupBox();
            cboImpressora = new ReaLTaiizor.Controls.MaterialComboBox();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboEstado);
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Location = new Point(29, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 94);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // cboEstado
            // 
            cboEstado.AutoResize = false;
            cboEstado.BackColor = Color.FromArgb(255, 255, 255);
            cboEstado.Depth = 0;
            cboEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cboEstado.DropDownHeight = 174;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.DropDownWidth = 121;
            cboEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEstado.FormattingEnabled = true;
            cboEstado.Hint = "Estado";
            cboEstado.IntegralHeight = false;
            cboEstado.ItemHeight = 43;
            cboEstado.Items.AddRange(new object[] { "", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cboEstado.Location = new Point(416, 31);
            cboEstado.MaxDropDownItems = 4;
            cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(119, 49);
            cboEstado.StartIndex = 0;
            cboEstado.TabIndex = 1;
            // 
            // txtCidade
            // 
            txtCidade.AnimateReadOnly = false;
            txtCidade.AutoCompleteMode = AutoCompleteMode.None;
            txtCidade.AutoCompleteSource = AutoCompleteSource.None;
            txtCidade.BackgroundImageLayout = ImageLayout.None;
            txtCidade.CharacterCasing = CharacterCasing.Normal;
            txtCidade.Depth = 0;
            txtCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCidade.HideSelection = true;
            txtCidade.Hint = "Cidade";
            txtCidade.LeadingIcon = null;
            txtCidade.Location = new Point(28, 31);
            txtCidade.MaxLength = 32767;
            txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCidade.Name = "txtCidade";
            txtCidade.PasswordChar = '\0';
            txtCidade.PrefixSuffixText = null;
            txtCidade.ReadOnly = false;
            txtCidade.RightToLeft = RightToLeft.No;
            txtCidade.SelectedText = "";
            txtCidade.SelectionLength = 0;
            txtCidade.SelectionStart = 0;
            txtCidade.ShortcutsEnabled = true;
            txtCidade.Size = new Size(382, 48);
            txtCidade.TabIndex = 0;
            txtCidade.TabStop = false;
            txtCidade.TextAlign = HorizontalAlignment.Left;
            txtCidade.TrailingIcon = null;
            txtCidade.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboAgrupamento);
            groupBox2.Location = new Point(29, 228);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(541, 105);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agrupamentos";
            // 
            // cboAgrupamento
            // 
            cboAgrupamento.AutoResize = false;
            cboAgrupamento.BackColor = Color.FromArgb(255, 255, 255);
            cboAgrupamento.Depth = 0;
            cboAgrupamento.DrawMode = DrawMode.OwnerDrawVariable;
            cboAgrupamento.DropDownHeight = 174;
            cboAgrupamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAgrupamento.DropDownWidth = 121;
            cboAgrupamento.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAgrupamento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAgrupamento.FormattingEnabled = true;
            cboAgrupamento.Hint = "Agrupamento";
            cboAgrupamento.IntegralHeight = false;
            cboAgrupamento.ItemHeight = 43;
            cboAgrupamento.Location = new Point(28, 40);
            cboAgrupamento.MaxDropDownItems = 4;
            cboAgrupamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAgrupamento.Name = "cboAgrupamento";
            cboAgrupamento.Size = new Size(507, 49);
            cboAgrupamento.StartIndex = 0;
            cboAgrupamento.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboImpressora);
            groupBox3.Location = new Point(29, 359);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(541, 102);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Impressora";
            // 
            // cboImpressora
            // 
            cboImpressora.AutoResize = false;
            cboImpressora.BackColor = Color.FromArgb(255, 255, 255);
            cboImpressora.Depth = 0;
            cboImpressora.DrawMode = DrawMode.OwnerDrawVariable;
            cboImpressora.DropDownHeight = 174;
            cboImpressora.DropDownStyle = ComboBoxStyle.DropDownList;
            cboImpressora.DropDownWidth = 121;
            cboImpressora.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboImpressora.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboImpressora.FormattingEnabled = true;
            cboImpressora.Hint = "Impressora";
            cboImpressora.IntegralHeight = false;
            cboImpressora.ItemHeight = 43;
            cboImpressora.Location = new Point(28, 36);
            cboImpressora.MaxDropDownItems = 4;
            cboImpressora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboImpressora.Name = "cboImpressora";
            cboImpressora.Size = new Size(507, 49);
            cboImpressora.StartIndex = 0;
            cboImpressora.TabIndex = 2;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(372, 480);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(103, 36);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "Visualizar";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton2.Location = new Point(483, 480);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(87, 36);
            materialButton2.TabIndex = 4;
            materialButton2.Text = "Imprimir";
            materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // FormRelatorioProfessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 537);
            Controls.Add(materialButton2);
            Controls.Add(materialButton1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormRelatorioProfessor";
            Text = "Relatorio de Professor";
            Load += FormRelatorioProfessor_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
        private ReaLTaiizor.Controls.MaterialComboBox cboAgrupamento;
        private ReaLTaiizor.Controls.MaterialComboBox cboImpressora;
    }
}