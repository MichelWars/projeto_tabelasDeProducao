
namespace projeto_tabelas
{
    partial class ConsT2
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnConsTodos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboEquip = new System.Windows.Forms.ComboBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turno1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turno2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turno3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produçãoDaManhãToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produçãoDaTardeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produçãoDaNoiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupConst2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grid2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupConst2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(900, 207);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(165, 37);
            this.btnLimpar.TabIndex = 560;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(395, 209);
            this.txtData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(160, 30);
            this.txtData.TabIndex = 559;
            this.txtData.TextChanged += new System.EventHandler(this.ConsData);
            // 
            // btnConsTodos
            // 
            this.btnConsTodos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnConsTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsTodos.Location = new System.Drawing.Point(716, 159);
            this.btnConsTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsTodos.Name = "btnConsTodos";
            this.btnConsTodos.Size = new System.Drawing.Size(349, 37);
            this.btnConsTodos.TabIndex = 558;
            this.btnConsTodos.Text = "Consultar todas as Produções";
            this.btnConsTodos.UseVisualStyleBackColor = false;
            this.btnConsTodos.Click += new System.EventHandler(this.btnConsTodos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 557;
            this.label2.Text = "Consultar por Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 556;
            this.label1.Text = "Consultar por Equipamento:";
            // 
            // comboEquip
            // 
            this.comboEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEquip.FormattingEnabled = true;
            this.comboEquip.Items.AddRange(new object[] {
            "LM 06",
            "LM 07",
            "LM 20",
            "LM 22",
            "LM 23",
            "LM 39",
            "LM 46",
            "LM 48",
            "LM 53",
            "LM 55",
            "LM 59"});
            this.comboEquip.Location = new System.Drawing.Point(395, 161);
            this.comboEquip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboEquip.Name = "comboEquip";
            this.comboEquip.Size = new System.Drawing.Size(160, 33);
            this.comboEquip.TabIndex = 555;
            this.comboEquip.SelectedIndexChanged += new System.EventHandler(this.ConsEq);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(60, 282);
            this.grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(1005, 295);
            this.grid.TabIndex = 554;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.tabelasToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 36);
            this.menuStrip1.TabIndex = 561;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(79, 32);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(228, 32);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // tabelasToolStripMenuItem
            // 
            this.tabelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turno1ToolStripMenuItem,
            this.turno2ToolStripMenuItem,
            this.turno3ToolStripMenuItem});
            this.tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
            this.tabelasToolStripMenuItem.Size = new System.Drawing.Size(89, 32);
            this.tabelasToolStripMenuItem.Text = "Tabelas";
            // 
            // turno1ToolStripMenuItem
            // 
            this.turno1ToolStripMenuItem.Name = "turno1ToolStripMenuItem";
            this.turno1ToolStripMenuItem.Size = new System.Drawing.Size(174, 32);
            this.turno1ToolStripMenuItem.Text = "1º Turno";
            this.turno1ToolStripMenuItem.Click += new System.EventHandler(this.turno1ToolStripMenuItem_Click);
            // 
            // turno2ToolStripMenuItem
            // 
            this.turno2ToolStripMenuItem.Name = "turno2ToolStripMenuItem";
            this.turno2ToolStripMenuItem.Size = new System.Drawing.Size(174, 32);
            this.turno2ToolStripMenuItem.Text = "2º Turno";
            this.turno2ToolStripMenuItem.Click += new System.EventHandler(this.turno2ToolStripMenuItem_Click);
            // 
            // turno3ToolStripMenuItem
            // 
            this.turno3ToolStripMenuItem.Name = "turno3ToolStripMenuItem";
            this.turno3ToolStripMenuItem.Size = new System.Drawing.Size(174, 32);
            this.turno3ToolStripMenuItem.Text = "3º Turno";
            this.turno3ToolStripMenuItem.Click += new System.EventHandler(this.turno3ToolStripMenuItem_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(69, 32);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(176, 32);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(176, 32);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produçãoDaManhãToolStripMenuItem,
            this.produçãoDaTardeToolStripMenuItem,
            this.produçãoDaNoiteToolStripMenuItem,
            this.funcionariosToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
            this.consultaToolStripMenuItem.Text = "Consultar";
            // 
            // produçãoDaManhãToolStripMenuItem
            // 
            this.produçãoDaManhãToolStripMenuItem.Name = "produçãoDaManhãToolStripMenuItem";
            this.produçãoDaManhãToolStripMenuItem.Size = new System.Drawing.Size(274, 32);
            this.produçãoDaManhãToolStripMenuItem.Text = "Produção da Manhã";
            this.produçãoDaManhãToolStripMenuItem.Click += new System.EventHandler(this.produçãoDaManhãToolStripMenuItem_Click);
            // 
            // produçãoDaTardeToolStripMenuItem
            // 
            this.produçãoDaTardeToolStripMenuItem.Name = "produçãoDaTardeToolStripMenuItem";
            this.produçãoDaTardeToolStripMenuItem.Size = new System.Drawing.Size(274, 32);
            this.produçãoDaTardeToolStripMenuItem.Text = "Produção da Tarde";
            this.produçãoDaTardeToolStripMenuItem.Click += new System.EventHandler(this.produçãoDaTardeToolStripMenuItem_Click);
            // 
            // produçãoDaNoiteToolStripMenuItem
            // 
            this.produçãoDaNoiteToolStripMenuItem.Name = "produçãoDaNoiteToolStripMenuItem";
            this.produçãoDaNoiteToolStripMenuItem.Size = new System.Drawing.Size(274, 32);
            this.produçãoDaNoiteToolStripMenuItem.Text = "Produção da Noite";
            this.produçãoDaNoiteToolStripMenuItem.Click += new System.EventHandler(this.produçãoDaNoiteToolStripMenuItem_Click);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(274, 32);
            this.funcionariosToolStripMenuItem.Text = "Funcionários";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // groupConst2
            // 
            this.groupConst2.Controls.Add(this.label3);
            this.groupConst2.Controls.Add(this.grid2);
            this.groupConst2.Controls.Add(this.label1);
            this.groupConst2.Controls.Add(this.grid);
            this.groupConst2.Controls.Add(this.btnLimpar);
            this.groupConst2.Controls.Add(this.comboEquip);
            this.groupConst2.Controls.Add(this.txtData);
            this.groupConst2.Controls.Add(this.label2);
            this.groupConst2.Controls.Add(this.btnConsTodos);
            this.groupConst2.Location = new System.Drawing.Point(77, 106);
            this.groupConst2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupConst2.Name = "groupConst2";
            this.groupConst2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupConst2.Size = new System.Drawing.Size(1787, 820);
            this.groupConst2.TabIndex = 563;
            this.groupConst2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(524, 42);
            this.label3.TabIndex = 566;
            this.label3.Text = "Consultar - Produção 2º Turno";
            // 
            // grid2
            // 
            this.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid2.Location = new System.Drawing.Point(60, 613);
            this.grid2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid2.Name = "grid2";
            this.grid2.RowHeadersWidth = 51;
            this.grid2.RowTemplate.Height = 24;
            this.grid2.Size = new System.Drawing.Size(1672, 105);
            this.grid2.TabIndex = 565;
            // 
            // ConsT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::projeto_tabelas.Properties.Resources.bobina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 988);
            this.Controls.Add(this.groupConst2);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConsT2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar produção turno tarde";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.ajustarTamanho2);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupConst2.ResumeLayout(false);
            this.groupConst2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnConsTodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEquip;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turno1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turno2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turno3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produçãoDaManhãToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produçãoDaTardeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produçãoDaNoiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupConst2;
        private System.Windows.Forms.DataGridView grid2;
        private System.Windows.Forms.Label label3;
    }
}