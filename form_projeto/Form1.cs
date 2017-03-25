using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace form_projeto
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            metroLabel1.Text = DateTime.Now.ToShortDateString();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            // instanciando o objeto para relatorios que irá conectar com o bd
            classe_relatorio objRelatorio = new classe_relatorio();

            // ajuste para os campos relacionados a aba geral com refeições

            // tratamento do campo café da manhã
            if (radio_cafe_1.Checked)
            {
                objRelatorio.cafe_relatorio = "Tudo";
            }
            else if (radio_cafe_2.Checked)
            {
                objRelatorio.cafe_relatorio = "Metade";
            }
            else if (radio_cafe_3.Checked)
            {
                objRelatorio.cafe_relatorio = "Nada";
            }

            // tratamento do campo colação
            if (radio_colacao_1.Checked)
            {
                objRelatorio.colacao_relatorio = "Tudo";
            }
            else if (radio_colacao_2.Checked)
            {
                objRelatorio.colacao_relatorio = "Metade";
            }
            else if (radio_colacao_3.Checked)
            {
                objRelatorio.colacao_relatorio = "Nada";
            }

            // tratamento do campo almoco
            if (radio_almoco_1.Checked)
            {
                objRelatorio.almoco_relatorio = "Tudo";
            }
            else if (radio_almoco_2.Checked)
            {
                objRelatorio.almoco_relatorio = "Metade";
            }
            else if (radio_almoco_3.Checked)
            {
                objRelatorio.almoco_relatorio = "Nada";
            }

            // tratamento do campo lanche
            if (radio_lanche_1.Checked)
            {
                objRelatorio.lanche_relatorio = "Tudo";
            }
            else if (radio_lanche_2.Checked)
            {
                objRelatorio.lanche_relatorio = "Metade";
            }
            else if (radio_lanche_3.Checked)
            {
                objRelatorio.lanche_relatorio = "Nada";
            }

            // tratamento do campo jantar
            if (radio_jantar_1.Checked)
            {
                objRelatorio.jantar_relatorio = "Tudo";
            }
            else if (radio_jantar_2.Checked)
            {
                objRelatorio.jantar_relatorio = "Metade";
            }
            else if (radio_jantar_3.Checked)
            {
                objRelatorio.jantar_relatorio = "Nada";
            }

            // tratamento do campo ceia
            if (radio_ceia_1.Checked)
            {
                objRelatorio.ceia_relatorio = "Tudo";
            }
            else if (radio_ceia_2.Checked)
            {
                objRelatorio.ceia_relatorio = "Metade";
            }
            else if (radio_ceia_3.Checked)
            {
                objRelatorio.ceia_relatorio = "Nada";
            }

            // Campos relacionados a necessidades fisiologicas

            // tratamento do campo Liquido
            if (radio_liquido_1.Checked)
            {
                objRelatorio.liquido_relatorio = "Tudo";
            }
            else if (radio_liquido_2.Checked)
            {
                objRelatorio.liquido_relatorio = "Metade";
            }
            else if (radio_liquido_3.Checked)
            {
                objRelatorio.liquido_relatorio = "Nada";
            }

            // tratamento do campo Urina
            if (radio_urina_1.Checked)
            {
                objRelatorio.urina_relatorio = "Tudo";
            }
            else if (radio_urina_2.Checked)
            {
                objRelatorio.urina_relatorio = "Metade";
            }
            else if (radio_urina_3.Checked)
            {
                objRelatorio.urina_relatorio = "Nada";
            }

            // tratamento do campo Evacuacao
            if (radio_evacuacao_1.Checked)
            {
                objRelatorio.evacuacao_relatorio = "Tudo";
            }
            else if (radio_evacuacao_2.Checked)
            {
                objRelatorio.evacuacao_relatorio = "Metade";
            }
            else if (radio_evacuacao_3.Checked)
            {
                objRelatorio.evacuacao_relatorio = "Nada";
            }

            // tratamento do campo Banho
            if (radio_banho_1.Checked)
            {
                objRelatorio.banho_relatorio = "Tudo";
            }
            else if (radio_banho_2.Checked)
            {
                objRelatorio.banho_relatorio = "Metade";
            }
            else if (radio_banho_3.Checked)
            {
                objRelatorio.banho_relatorio = "Nada";
            }

            // tratamento do campo Sono
            if (radio_sono_1.Checked)
            {
                objRelatorio.sono_relatorio = "Tudo";
            }
            else if (radio_sono_2.Checked)
            {
                objRelatorio.sono_relatorio = "Metade";
            }
            else if (radio_sono_3.Checked)
            {
                objRelatorio.sono_relatorio = "Nada";
            }

            // Inserindo o campo de intensidade da dor
            objRelatorio.dor_intensidade_relatorio = metroLabel5.Text;
            // Insere o campo de observações na var do objRelatorio
            objRelatorio.obs_relatorio = observacoes.Text;

            // Insere campos do questionario no objRelatorio

            if (q1_1.Checked)
            {
                objRelatorio.q1_relatorio = "Sim";
            }
            else
            {
                objRelatorio.q1_relatorio = "Não";
            }

            if (q2_1.Checked)
            {
                objRelatorio.q2_relatorio = "Sim";
            }
            else
            {
                objRelatorio.q2_relatorio = "Não";
            }

            if (q3_1.Checked)
            {
                objRelatorio.q3_relatorio = "Sim";
            }
            else
            {
                objRelatorio.q3_relatorio = "Não";
            }

            if (q4_1.Checked)
            {
                objRelatorio.q4_relatorio = "Sim";
            }
            else
            {
                objRelatorio.q4_relatorio = "Não";
            }

            if (q5_1.Checked)
            {
                objRelatorio.q5_relatorio = "Sim";
            }
            else
            {
                objRelatorio.q5_relatorio = "Não";
            }

            if (q6_1.Checked)
            {
                objRelatorio.q6_relatorio = "Sim";
            }
            else
            {
                objRelatorio.q6_relatorio = "Não";
            }

            if (q7_1.Checked)
            {
                objRelatorio.q7_relatorio = "Sim";
            }
            else
            {
                objRelatorio.q7_relatorio = "Não";
            }

            if (q8_1.Checked)
            {
                objRelatorio.q8_relatorio = "Sim";
            }
            else
            {
                objRelatorio.q8_relatorio = "Não";
            }

            if (q9_1.Checked)
            {
                objRelatorio.q9_relatorio = "Sim";
            }
            else
            {
                objRelatorio.q9_relatorio = "Não";
            }

            if (q10_1.Checked)
            {
                objRelatorio.q10_relatorio = "Sim";
            }
            else
            {
                objRelatorio.q10_relatorio = "Não";
            }

            if (q11_1.Checked)
            {
                objRelatorio.q11_relatorio = "Sim";
            }
            else
            {
                objRelatorio.q11_relatorio = "Não";
            }

            metroLabel3.Text = objRelatorio.gravaRelatorio().ToString();

        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            metroLabel5.Text = (System.Math.Round(metroTrackBar1.Value / 1.0)).ToString();
        }
    }
}
