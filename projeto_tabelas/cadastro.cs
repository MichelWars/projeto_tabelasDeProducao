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
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        // ======= Centralizar a tela =======
        // Ajustar o tamanho do GroupBox
        private void ajustarTamanho(object sender, EventArgs e)
        {
            int larguraTela = this.Size.Width;
            int alturaTela = this.Size.Height;
            int larguraLogin = groupCadastro.Size.Width;
            int alturaLogin = groupCadastro.Size.Height;

            Point p = new Point();
            p.X = (larguraTela - larguraLogin) / 2;
            p.Y = (alturaTela - alturaLogin) / 2;
            groupCadastro.Location = p;
        }

        // BD
        private void button2_Click(object sender, EventArgs e)
        {
            string pr = txtPr.Text;
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string telefone = maskedTel.Text;
            string dataNasc = dateNasc.Text;
            string senha = txtSenha.Text;
            char genero;

            if (radioButtonFem.Checked)
            {
                genero = 'f';
            }
            else if (radioButtonMasc.Checked)
            {
                genero = 'm';
            }
            else
            {
                genero = 'o';
            }

            string sql = $"INSERT INTO cadastro (pr,nome, email, telefone, data_nasc, senha, genero) VALUES ('{pr}','{nome}', '{email}', '{telefone}', '{dataNasc}', '{senha}', '{genero}')";

            MySqlConnection con = null;
            MySqlCommand cmd = null;


            try
            {
                con = new MySqlConnection("server='localhost';uid='root';pwd='';database='prada';useAffectedRows=true");
                cmd = new MySqlCommand(sql, con);
                con.Open();
                int qtdInseridas = cmd.ExecuteNonQuery();
                if (qtdInseridas > 0)
                {
                    txtPr.Text = cmd.LastInsertedId.ToString();
                    MessageBox.Show("Salvo com sucesso!");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível cadastrar!");
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    con.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }
        // ======= MenuStrip =======
        // Configurar abertura de outras telas e fechar a atual
        // Abrir tela principal
        private void menuPrincipalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new inicio()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void turno1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new tabela1()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void turno2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new tabela2()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void turno3ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new tabela3()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void cadastroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new cadastro()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new login()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }



        private void produçãoDaManhãToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new ConsT1()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void produçãoDaTardeToolStripMenuItem_Click_1(object sender, EventArgs e)
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
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtPr.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            maskedTel.Clear();
            dateNasc.ResetText();
            radioButtonFem.Checked = false;
            radioButtonMasc.Checked = false;
            radioButtonOutro.Checked = false;


        }
    }
}
