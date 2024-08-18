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

namespace projeto_tabelas
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var th = new Thread(() => Application.Run(new login()));
            th.SetApartmentState(ApartmentState.STA); 
            th.Start();

            this.Close();

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new cadastro()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void btnConsFunc_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new ConsFunc()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void btnProdT1_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new tabela1()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void btnProdT2_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new tabela2()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void btnProdT3_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new tabela3()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void btnConsT1_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new ConsT1()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void btnConsT2_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new ConsT2()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        private void btnConsT3_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new ConsT3()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }

        // ===== Form 1 =====
        // Método para centralizar a tela quando expandir
        private void ajustarTamanho(object sender, EventArgs e)
        {
            int larguraTela = this.Size.Width;
            int alturaTela = this.Size.Height;
            int larguraInicio = groupBox1.Size.Width;
            int alturaInicio = groupBox1.Size.Height;

            Point p = new Point();
            p.X = (larguraTela - larguraInicio) / 2;
            p.Y = (alturaTela - alturaInicio) / 2;
            groupBox1.Location = p;
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

    }
}
