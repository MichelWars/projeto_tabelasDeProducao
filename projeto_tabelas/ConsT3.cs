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
    public partial class ConsT3 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        MySqlCommand cmd2 = null;
        public ConsT3()
        {
            InitializeComponent();
        }

        private void formatarGrid()
        {
            grid.Columns[0].HeaderText = "DATA";
            grid.Columns[1].HeaderText = "EQUIPAMENTO";
            grid.Columns[2].HeaderText = "HORARIO";
            grid.Columns[3].HeaderText = "META";
            grid.Columns[4].HeaderText = "ACUMULADO";
            grid.Columns[5].HeaderText = "MINUTOS_PARADA";
            grid.Columns[6].HeaderText = "OBSERVAÇÃO";

            grid2.Columns[0].HeaderText = "DATA";
            grid2.Columns[1].HeaderText = "EQUIPAMENTO";
            grid2.Columns[2].HeaderText = "DISP. PROD.(H)";
            grid2.Columns[3].HeaderText = "VELOC MEDIA PLAN";
            grid2.Columns[4].HeaderText = "PROD REALIZADA";
            grid2.Columns[5].HeaderText = "TOTAL PARADA";
            grid2.Columns[6].HeaderText = "VELOC MED REAL";
            grid2.Columns[7].HeaderText = "PERDA DE QUALIDADE";
            grid2.Columns[8].HeaderText = "%";
            grid2.Columns[9].HeaderText = "%";
            grid2.Columns[10].HeaderText = "%";
            grid2.Columns[11].HeaderText = "OEE";
        }



        private void btnConsTodos_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;uid=root; pwd='';database=prada;useAffectedRows=true");
            conn.Open();
            String sql = "Select data, equipamento,horario, meta_unidades, acumulado_unidades, parada_minutos, observacao from periodo_noite order by equipamento,data";
            String sql2 = "Select * from relatorio_noite";
            cmd = new MySqlCommand(sql, conn);
            cmd2 = new MySqlCommand(sql2, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlDataAdapter da2 = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da2.SelectCommand = cmd2;
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            da.Fill(dt);
            da2.Fill(dt2);
            grid.DataSource = dt;
            grid2.DataSource = dt2;
            conn.Close();
            formatarGrid();
        }

        private void ConsData(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;uid=root; pwd='';database=prada;useAffectedRows=true");
            conn.Open();
            String sql = "Select data, equipamento,horario, meta_unidades, acumulado_unidades, parada_minutos, observacao from periodo_noite where data like @data";
            String sql2 = "Select * from relatorio_noite where data like @data";
            cmd = new MySqlCommand(sql, conn);
            cmd2 = new MySqlCommand(sql2, conn);
            cmd.Parameters.AddWithValue("@data", txtData.Text + "%");
            cmd2.Parameters.AddWithValue("@data", txtData.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlDataAdapter da2 = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da2.SelectCommand = cmd2;
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            da.Fill(dt);
            da2.Fill(dt2);
            grid.DataSource = dt;
            grid2.DataSource = dt2;
            conn.Close();
            formatarGrid();
        }

        private void ConsEq(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;uid=root; pwd='';database=prada;useAffectedRows=true");
            conn.Open();
            String sql = "Select data, equipamento,horario, meta_unidades, acumulado_unidades, parada_minutos, observacao from periodo_noite where equipamento = @equipamento";
            String sql2 = "Select * from relatorio_noite where equipamento = @equipamento";
            cmd = new MySqlCommand(sql, conn);
            cmd2 = new MySqlCommand(sql2, conn);
            cmd.Parameters.AddWithValue("@equipamento", comboEquip.Text);
            cmd2.Parameters.AddWithValue("@equipamento", comboEquip.Text);
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlDataAdapter da2 = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da2.SelectCommand = cmd2;
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            da.Fill(dt);
            da2.Fill(dt2);
            grid.DataSource = dt;
            grid2.DataSource = dt2;
            conn.Close();
            formatarGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            comboEquip.SelectedIndex = -1;
            txtData.Clear();
            grid.DataSource = null;
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

        private void produçãoDaNoiteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new ConsT3()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new ConsFunc()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }
        //fim do strip

        private void ajustarTamanho3(object sender, EventArgs e)
        {
            int larguraTela = this.Size.Width;
            int alturaTela = this.Size.Height;
            int larguraConsT3 = groupConst3.Size.Width;
            int alturaConsT3 = groupConst3.Size.Height;

            Point p = new Point();
            p.X = (larguraTela - larguraConsT3) / 2;
            p.Y = (alturaTela - alturaConsT3) / 2;
            groupConst3.Location = p;
        }
    }
}
