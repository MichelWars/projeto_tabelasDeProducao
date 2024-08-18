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
    public partial class tabela2 : Form
    {
        public tabela2()
        {
            InitializeComponent();
        }
        private void buttonCalcular_Click_1(object sender, EventArgs e)
        {

            if (textVelocPlan.Text == "")
            {
                // Imprimir mensagem para o usuário preencher o campo de velocidade planejada
                MessageBox.Show("Preencha a velocidade planejada!");
            }
            else
            {
                textMeta1.Text = radioRef1.Checked ? "0" : (55 * Convert.ToDouble(textVelocPlan.Text)).ToString();
                textMeta2.Text = radioRef2.Checked ? textMeta1.Text : (60 * Convert.ToDouble(textVelocPlan.Text) + Convert.ToDouble(textMeta1.Text)).ToString();
                textMeta3.Text = radioRef3.Checked ? textMeta2.Text : (60 * Convert.ToDouble(textVelocPlan.Text) + Convert.ToDouble(textMeta2.Text)).ToString();
                textMeta4.Text = radioRef4.Checked ? textMeta3.Text : (60 * Convert.ToDouble(textVelocPlan.Text) + Convert.ToDouble(textMeta3.Text)).ToString();
                textMeta5.Text = radioRef5.Checked ? textMeta4.Text : (60 * Convert.ToDouble(textVelocPlan.Text) + Convert.ToDouble(textMeta4.Text)).ToString();
                textMeta6.Text = radioRef6.Checked ? textMeta5.Text : (60 * Convert.ToDouble(textVelocPlan.Text) + Convert.ToDouble(textMeta5.Text)).ToString();
                textMeta7.Text = radioRef7.Checked ? textMeta6.Text : (60 * Convert.ToDouble(textVelocPlan.Text) + Convert.ToDouble(textMeta6.Text)).ToString();
                textMeta8.Text = radioRef8.Checked ? textMeta7.Text : (70 * Convert.ToDouble(textVelocPlan.Text) + Convert.ToDouble(textMeta7.Text)).ToString();


                double totalParada = 0;
                totalParada += radioRef1.Checked || textParada1.Text == "" ? 0 : Convert.ToDouble(textParada1.Text);
                totalParada += radioRef2.Checked || textParada2.Text == "" ? 0 : Convert.ToDouble(textParada2.Text);
                totalParada += radioRef3.Checked || textParada3.Text == "" ? 0 : Convert.ToDouble(textParada3.Text);
                totalParada += radioRef4.Checked || textParada4.Text == "" ? 0 : Convert.ToDouble(textParada4.Text);
                totalParada += radioRef5.Checked || textParada5.Text == "" ? 0 : Convert.ToDouble(textParada5.Text);
                totalParada += radioRef6.Checked || textParada6.Text == "" ? 0 : Convert.ToDouble(textParada6.Text);
                totalParada += radioRef7.Checked || textParada7.Text == "" ? 0 : Convert.ToDouble(textParada7.Text);
                totalParada += radioRef8.Checked || textParada8.Text == "" ? 0 : Convert.ToDouble(textParada8.Text);

                textBoxTotalHorasParada.Text = Math.Round(totalParada / 60, 2).ToString();
                totalParada = Convert.ToDouble(textBoxTotalHorasParada.Text);

                try
                {
                    // -- Atribuir a produção realizada --
                    double prodRealizada = 0;
                    prodRealizada = Convert.ToDouble(textAcumulado8.Text);
                    textProd.Text = Convert.ToString(prodRealizada);

                    // -- Atribuir a disp. Prod (Disposição de produção) --
                    double dispProd = 0;
                    dispProd = Convert.ToDouble(textDispProd.Text);

                    // -- Calcular a Velocidade média realizada --
                    double velocidadeReal = 0;
                    velocidadeReal = (prodRealizada / (dispProd - totalParada)) / 60;

                    textVelocReal.Text = Math.Round((velocidadeReal), 2).ToString();

                    // -- Atribuir porcentagem1 --
                    double porcentagem1 = 0;
                    porcentagem1 = (1 - (totalParada / dispProd)) * 100;

                    porcentagem1 = ((porcentagem1 * 100) / 100);
                    textPorcentagem1.Text = Math.Round((porcentagem1), 2).ToString();

                    // -- Atribuir porcentagem2 --
                    double porcentagem2 = 0;
                    double velocidadePlan = 0;

                    velocidadePlan = Convert.ToDouble(textVelocPlan.Text);
                    porcentagem2 = (velocidadeReal / velocidadePlan) * 100;
                    porcentagem2 = ((porcentagem2 * 100) / 100);
                    textPorcentagem2.Text = Math.Round((porcentagem2), 2).ToString();

                    // -- Atribuir porcentagem3 --
                    double porcentagem3 = 0;
                    double perdas = 0;

                    perdas = Convert.ToDouble(textPerdas.Text);
                    porcentagem3 = 100 - ((perdas * 100) / prodRealizada);

                    porcentagem3 = ((porcentagem3 * 100) / 100);
                    textPorcentagem3.Text = Math.Round((porcentagem3), 2).ToString();

                    // -- Calcular OEE --
                    double OEE = 0;

                    OEE = porcentagem1 * porcentagem2 * porcentagem3;

                    OEE = (OEE / 10000);
                    textOee.Text = Math.Round((OEE), 2).ToString();
                }
                catch
                {
                    // -- Imprimir mensagem para o usuário preencher a coluna de "Acumulados" --
                    MessageBox.Show("Preencha todos os campos em BRANCO!!");
                }
            }
        }

        private void habilitar()
        {
                textMeta1.Enabled = true;
                textAcumulado1.Enabled = true;
                textParada1.Enabled = true;

                textMeta2.Enabled = true;
                textAcumulado2.Enabled = true;
                textParada2.Enabled = true;

                textMeta3.Enabled = true;
                textAcumulado3.Enabled = true;
                textParada3.Enabled = true;

                textMeta4.Enabled = true;
                textAcumulado4.Enabled = true;
                textParada4.Enabled = true;

                textMeta5.Enabled = true;
                textAcumulado5.Enabled = true;
                textParada5.Enabled = true;

                textMeta6.Enabled = true;
                textAcumulado6.Enabled = true;
                textParada6.Enabled = true;

                textMeta7.Enabled = true;
                textAcumulado7.Enabled = true;
                textParada7.Enabled = true;

                textMeta8.Enabled = true;
                textAcumulado8.Enabled = true;
                textParada8.Enabled = true;
        }

        // Ajustar o tamanho do GroupBox
        private void ajustarTamanho(object sender, EventArgs e)
        {
            int larguraTela = this.Size.Width;
            int alturaTela = this.Size.Height;
            int larguraLogin = groupBoxTabela.Size.Width;
            int alturaLogin = groupBoxTabela.Size.Height;

            Point p = new Point();
            p.X = (larguraTela - larguraLogin) / 2;
            p.Y = (alturaTela - alturaLogin) / 2;
            groupBoxTabela.Location = p;
        }

        // ====== RadioButton ======
        // Marcar o horário de refeição
        private void radioRef1_CheckedChanged_1(object sender, EventArgs e)
        {
            habilitar();
            textMeta1.Enabled = false;
            textAcumulado1.Enabled = false;
            textParada1.Enabled = false;
            textParada1.Text = "";
        }
        private void radioRef2_CheckedChanged_1(object sender, EventArgs e)
        {
            habilitar();
            textMeta2.Enabled = false;
            textAcumulado2.Enabled = false;
            textParada2.Enabled = false;
            textParada2.Text = "";
        }
        private void radioRef3_CheckedChanged_1(object sender, EventArgs e)
        {
            habilitar();
            textMeta3.Enabled = false;
            textAcumulado3.Enabled = false;
            textParada3.Enabled = false;
            textParada3.Text = "";
        }
        private void radioRef4_CheckedChanged_1(object sender, EventArgs e)
        {
            habilitar();
            textMeta4.Enabled = false;
            textAcumulado4.Enabled = false;
            textParada4.Enabled = false;
            textParada4.Text = "";
        }
        private void radioRef5_CheckedChanged_1(object sender, EventArgs e)
        {
            habilitar();
            textMeta5.Enabled = false;
            textAcumulado5.Enabled = false;
            textParada5.Enabled = false;
            textParada5.Text = "";
        }
        private void radioRef6_CheckedChanged_1(object sender, EventArgs e)
        {
            habilitar();
            textMeta6.Enabled = false;
            textAcumulado6.Enabled = false;
            textParada6.Enabled = false;
            textParada6.Text = "";
        }
        private void radioRef7_CheckedChanged_1(object sender, EventArgs e)
        {
            habilitar();
            textMeta7.Enabled = false;
            textAcumulado7.Enabled = false;
            textParada7.Enabled = false;
            textParada7.Text = "";
        }
        private void radioRef8_CheckedChanged_1(object sender, EventArgs e)
        {
            habilitar();
            textMeta8.Enabled = false;
            textAcumulado8.Enabled = false;
            textParada8.Enabled = false;
            textParada8.Text = "";
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

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new ConsFunc()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }
        //fim do strip



        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textMeta1.Clear();
            textMeta2.Clear();
            textMeta3.Clear();
            textMeta4.Clear();
            textMeta5.Clear();
            textMeta6.Clear();
            textMeta7.Clear();
            textMeta8.Clear();


            radioRef1.Checked = false;
            radioRef2.Checked = false;
            radioRef3.Checked = false;
            radioRef4.Checked = false;
            radioRef5.Checked = false;
            radioRef6.Checked = false;
            radioRef7.Checked = false;
            radioRef8.Checked = false;


            textAcumulado1.Clear();
            textAcumulado2.Clear();
            textAcumulado3.Clear();
            textAcumulado4.Clear();
            textAcumulado5.Clear();
            textAcumulado6.Clear();
            textAcumulado7.Clear();
            textAcumulado8.Clear();


            textParada1.Clear();
            textParada2.Clear();
            textParada3.Clear();
            textParada4.Clear();
            textParada5.Clear();
            textParada6.Clear();
            textParada7.Clear();
            textParada8.Clear();


            textObs1.Clear();
            textObs2.Clear();
            textObs3.Clear();
            textObs4.Clear();
            textObs5.Clear();
            textObs6.Clear();
            textObs7.Clear();
            textObs8.Clear();

            comboEquip.SelectedIndex = -1;
            maskedData.Clear();
            textDispProd.Clear();
            textVelocPlan.Clear();
            textProd.Clear();
            textBoxTotalHorasParada.Clear();
            textVelocReal.Clear();
            textPerdas.Clear();
            textPorcentagem1.Clear();
            textPorcentagem2.Clear();
            textPorcentagem3.Clear();
            textOee.Clear();
        }


        //conexão e botao salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String data = maskedData.Text;
            String equipamento = comboEquip.Text;
            String[] horario = new String[8];
            horario[0] = txt1.Text + " as " + txt2.Text;
            horario[1] = txt3.Text + " as " + txt4.Text;
            horario[2] = txt5.Text + " as " + txt6.Text;
            horario[3] = txt7.Text + " as " + txt8.Text;
            horario[4] = txt9.Text + " as " + txt10.Text;
            horario[5] = txt11.Text + " as " + txt12.Text;
            horario[6] = txt13.Text + " as " + txt14.Text;
            horario[7] = txt15.Text + " as " + txt16.Text;

            String[] meta = new String[9];
            meta[0] = textMeta1.Text;
            meta[1] = textMeta2.Text;
            meta[2] = textMeta3.Text;
            meta[3] = textMeta4.Text;
            meta[4] = textMeta5.Text;
            meta[5] = textMeta6.Text;
            meta[6] = textMeta7.Text;
            meta[7] = textMeta8.Text;

            String[] acumulado = new String[8];
            acumulado[0] = textAcumulado1.Text;
            acumulado[1] = textAcumulado2.Text;
            acumulado[2] = textAcumulado3.Text;
            acumulado[3] = textAcumulado4.Text;
            acumulado[4] = textAcumulado5.Text;
            acumulado[5] = textAcumulado6.Text;
            acumulado[6] = textAcumulado7.Text;
            acumulado[7] = textAcumulado8.Text;
 
            String[] parada = new String[8];
            parada[0] = textParada1.Text;
            parada[1] = textParada2.Text;
            parada[2] = textParada3.Text;
            parada[3] = textParada4.Text;
            parada[4] = textParada5.Text;
            parada[5] = textParada6.Text;
            parada[6] = textParada7.Text;
            parada[7] = textParada8.Text;

            String[] observacao = new String[8];
            observacao[0] = textObs1.Text;
            observacao[1] = textObs2.Text;
            observacao[2] = textObs3.Text;
            observacao[3] = textObs4.Text;
            observacao[4] = textObs5.Text;
            observacao[5] = textObs6.Text;
            observacao[6] = textObs7.Text;
            observacao[7] = textObs8.Text;

            string disp = textDispProd.Text;
            string velm = textVelocPlan.Text;
            string prodr = textProd.Text;
            string ttpar = textBoxTotalHorasParada.Text;
            string velr = textVelocReal.Text;
            string perd = textPerdas.Text;
            string p1 = textPorcentagem1.Text;
            string p2 = textPorcentagem2.Text;
            string p3 = textPorcentagem3.Text;
            string oee = textOee.Text;


            string sql =
          $"INSERT INTO periodo_tarde (data, equipamento, horario, meta_unidades, acumulado_unidades,parada_minutos,observacao) " +
            $"VALUES ('{data}', '{equipamento}', '{horario[0]}', '{meta[0]}', '{acumulado[0]}', '{parada[0]}', '{observacao[0]}');" + //linha1

            $"INSERT INTO periodo_tarde (data, equipamento, horario, meta_unidades, acumulado_unidades,parada_minutos,observacao) " +
            $"VALUES ('{data}', '{equipamento}', '{horario[1]}', '{meta[1]}', '{acumulado[1]}', '{parada[1]}', '{observacao[1]}');" +//linha2

            $"INSERT INTO periodo_tarde (data, equipamento, horario, meta_unidades, acumulado_unidades,parada_minutos,observacao) " +
            $"VALUES ('{data}', '{equipamento}', '{horario[2]}', '{meta[2]}', '{acumulado[2]}', '{parada[2]}', '{observacao[2]}');" +//linha3

            $"INSERT INTO periodo_tarde (data, equipamento, horario, meta_unidades, acumulado_unidades,parada_minutos,observacao) " +
            $"VALUES ('{data}', '{equipamento}', '{horario[3]}', '{meta[3]}', '{acumulado[3]}', '{parada[3]}', '{observacao[3]}');" +//linha4

            $"INSERT INTO periodo_tarde (data, equipamento, horario, meta_unidades, acumulado_unidades,parada_minutos,observacao) " +
            $"VALUES ('{data}', '{equipamento}', '{horario[4]}', '{meta[4]}', '{acumulado[4]}', '{parada[4]}', '{observacao[4]}');" +//linha5

            $"INSERT INTO periodo_tarde (data, equipamento, horario, meta_unidades, acumulado_unidades,parada_minutos,observacao) " +
            $"VALUES ('{data}', '{equipamento}', '{horario[5]}', '{meta[5]}', '{acumulado[5]}', '{parada[5]}', '{observacao[5]}');" +//linha6

            $"INSERT INTO periodo_tarde (data, equipamento, horario, meta_unidades, acumulado_unidades,parada_minutos,observacao) " +
            $"VALUES ('{data}', '{equipamento}', '{horario[6]}', '{meta[6]}', '{acumulado[6]}', '{parada[6]}', '{observacao[6]}');" +//linha7

            $"INSERT INTO periodo_tarde (data, equipamento, horario, meta_unidades, acumulado_unidades,parada_minutos,observacao) " +
            $"VALUES ('{data}', '{equipamento}', '{horario[7]}', '{meta[7]}', '{acumulado[7]}', '{parada[7]}', '{observacao[7]}');" +//linha8

           $"INSERT INTO relatorio_tarde (data, equipamento, dispProd, velocMediaPlan, prodReal, totalParada, velocMediaReal, perdasQuali, percent1, percent2, percent3, oee) " +
            $"VALUES ('{data}', '{equipamento}', '{disp}', '{velm}', '{prodr}', '{ttpar}', '{velr}', '{perd}', '{p1}', '{p2}', '{p3}', '{oee}');"



           ;


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
                    textMeta1.Text = cmd.LastInsertedId.ToString();
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
    }
    
}



