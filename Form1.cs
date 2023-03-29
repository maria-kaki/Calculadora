using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double n1 = 0, n2 = 0, resultado = 0;
        string conta = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Quando a tela abrir
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            // Configurações da caixa de texto
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            txt.Text += "0";
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            txt.Text += "1";
        }
        
        private void bt_2_Click(object sender, EventArgs e)
        {
            txt.Text += "2";
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            txt.Text += "3";
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            txt.Text += "4";
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            txt.Text += "5";
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            txt.Text += "6";
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            txt.Text += "7";
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            txt.Text += "8";
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            txt.Text += "9";
        }

        private void bt_virgula_Click(object sender, EventArgs e)
        {
            if(txt.Text == "")
            {
                txt.Text = "0.";
            }
            else
            {
                txt.Text += ".";
            }
        }

        // Quando o botão de subtração for ativado
        private void bt_subtrai_Click(object sender, EventArgs e)
        {
            if (txt.Text != "")
            {
                // atriui à variável n1 o valor escrito na txt_box convertendo para decimal e salvando a pontuação (caso haja vírgulas)
                n1 = double.Parse(txt.Text, CultureInfo.InvariantCulture);
                txt.Text = "";
                conta = "subtracao";
            }
            else
            {
                MessageBox.Show("Coloque um valor para fazer a conta");
            }
        }

        private void bt_multiplica_Click(object sender, EventArgs e)
        {
            if (txt.Text != "")
            {
                // atriui à variável n1 o valor escrito na txt_box convertendo para decimal e salvando a pontuação (caso haja vírgulas)
                n1 = double.Parse(txt.Text, CultureInfo.InvariantCulture);
                txt.Text = "";
                conta = "multiplicacao";
            }
            else
            {
                MessageBox.Show("Coloque um valor para fazer a conta");
            }
        }

        private void bt_divide_Click(object sender, EventArgs e)
        {
            if (txt.Text != "")
            {
                // atriui à variável n1 o valor escrito na txt_box convertendo para decimal e salvando a pontuação (caso haja vírgulas)
                n1 = double.Parse(txt.Text, CultureInfo.InvariantCulture);
                txt.Text = "";
                conta = "divisao";
            }
            else
            {
                MessageBox.Show("Coloque um valor para fazer a conta");
            }
        }

        private void bt_umporx_Click(object sender, EventArgs e)
        {
            if (txt.Text != "")
            {
                // atriui à variável n1 o valor escrito na txt_box convertendo para decimal e salvando a pontuação (caso haja vírgulas)
                n1 = double.Parse(txt.Text, CultureInfo.InvariantCulture);
                resultado = 1 / n1;
                txt.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Coloque um valor para fazer a conta");
            }
        }

        private void bt_porcento_Click(object sender, EventArgs e)
        {
            if (txt.Text != "")
            {
                // atriui à variável n1 o valor escrito na txt_box convertendo para decimal e salvando a pontuação (caso haja vírgulas)
                n1 = double.Parse(txt.Text, CultureInfo.InvariantCulture);
                resultado = n1 / 100;
                txt.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Coloque um valor para fazer a conta");
            }
        }

        private void bt_potencia_Click(object sender, EventArgs e)
        {
            if (txt.Text != "")
            {
                // atriui à variável n1 o valor escrito na txt_box convertendo para decimal e salvando a pontuação (caso haja vírgulas)
                n1 = double.Parse(txt.Text, CultureInfo.InvariantCulture);
                txt.Text = "";
                conta = "potencia";
            }
            else
            {
                MessageBox.Show("Coloque um valor para fazer a conta");
            }
        }

        private void bt_ce_Click(object sender, EventArgs e)
        {
            txt.Text = "";
        }

        private void bt_c_Click(object sender, EventArgs e)
        {
            txt.Text = "";
            n1 = 0;
            n2 = 0;
        }

        private void bt_menosum_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text.Substring(0,txt.TextLength-1);
        }

        private void bt_raiz_Click(object sender, EventArgs e)
        {
            // atriui à variável n1 o valor escrito na txt_box convertendo para decimal e salvando a pontuação (caso haja vírgulas)
            n1 = double.Parse(txt.Text, CultureInfo.InvariantCulture);
            resultado = Math.Sqrt(n1);
            txt.Text = resultado.ToString();
        }

        private void bt_invertesinal_Click(object sender, EventArgs e)
        {
            // atriui à variável n1 o valor escrito na txt_box convertendo para decimal e salvando a pontuação (caso haja vírgulas)
            n1 = double.Parse(txt.Text, CultureInfo.InvariantCulture);
            resultado = n1 * -1;
            txt.Text=resultado.ToString();
        }

        // Quando o botão de adição for ativado
        private void bt_soma_Click(object sender, EventArgs e)
        {
            if (txt.Text != "")
            {
                // atriui à variável n1 o valor escrito na txt_box convertendo para decimal e salvando a pontuação (caso haja vírgulas)
                n1 = double.Parse(txt.Text, CultureInfo.InvariantCulture);
                txt.Text = "";
                conta = "soma";
            }
            else
            {
                MessageBox.Show("Coloque um valor para fazer a conta");
            }
        }

        // Quando o botão de igual for ativado
        private void bt_resultado_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(txt.Text, CultureInfo.InvariantCulture);

            if (conta == "soma")
            {
                resultado = n1 + n2;
                txt.Text = Convert.ToString(resultado);
            }
            else if (conta == "subtracao")
            {
                resultado = n1 - n2;
                txt.Text = Convert.ToString(resultado);
            }
            else if (conta == "multiplicacao")
            {
                resultado = n1 * n2;
                txt.Text = Convert.ToString(resultado);
            }
            else if (conta == "divisao")
            {
                resultado = n1 / n2;
                txt.Text = Convert.ToString(resultado);
            }
            else if (conta == "potencia")
            {
                resultado = Math.Pow(n1,n2);
                txt.Text = Convert.ToString(resultado);
            }
        }
    }
}