using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projeto_tabelas
{
    public partial class ConsFunc : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        public ConsFunc()
        {
            InitializeComponent();

        }

        private void formatarGrid()
        {
            grid.Columns[0].HeaderText = "PR";
            grid.Columns[1].HeaderText = "NOME";
            grid.Columns[2].HeaderText = "SEXO";
            grid.Columns[3].HeaderText = "NASCIMENTO";
            grid.Columns[4].HeaderText = "TELEFONE";
            grid.Columns[5].HeaderText = "EMAIL";
        }



        private void consultar(object sender, EventArgs e)
        {
            listarGrid();
        }

        private void listarGrid()
        {
            conn = new MySqlConnection("server=localhost;uid=root; pwd='';database=prada;useAffectedRows=true");
            conn.Open();
            String sql = "Select pr, nome, genero, data_nasc, telefone, email from cadastro";
            cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            conn.Close();
            formatarGrid();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            String nome = textBox1.Text;
            conn = new MySqlConnection("server=localhost;uid=root; pwd='';database=prada;useAffectedRows=true");
            conn.Open();
            String sql = "Select pr, nome, genero, data_nasc, telefone, email from cadastro where nome like @nome";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", textBox1.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            conn.Close();
            formatarGrid();
        }

        // ======= MenuStrip =======
        // Configurar abertura de outras telas e fechar a atual
        // Abrir tela principal
        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new inicio()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void turno1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new tabela1()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void turno2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new tabela2()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void turno3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new tabela3()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new cadastro()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new login()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }



        private void produçãoDaManhãToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new ConsT1()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void produçãoDaTardeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new ConsT2()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void produçãoDaNoiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new ConsT3()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new ConsFunc()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }
        //fim do strip

        private void ajustarTamanho(object sender, EventArgs e)
        {
            int larguraTela = this.Size.Width;
            int alturaTela = this.Size.Height;
            int larguraConFunc = groupBox1.Size.Width;
            int alturaConFunc = groupBox1.Size.Height;

            Point p = new Point();
            p.X = (larguraTela - larguraConFunc) / 2;
            p.Y = (alturaTela - alturaConFunc) / 2;
            groupBox1.Location = p;
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            String nome = textBox1.Text;
            conn = new MySqlConnection("server=localhost;uid=root; pwd='';database=prada;useAffectedRows=true");
            conn.Open();
            String sql = "Select pr, nome, genero, data_nasc, telefone, email from cadastro where nome like @nome";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", textBox1.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            conn.Close();
            formatarGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            grid.DataSource = null;
        }


    }
}
