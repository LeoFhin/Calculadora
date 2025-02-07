namespace Calculadora
{
    public partial class Calculadora : Form
    {
        private double primeiroNumero = 0;
        private double segundoNumero = 0;
        private string operacao = "";
        public Calculadora()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            richTextBox1.Text += botao.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            richTextBox1.Text += botao.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            richTextBox1.Text += botao.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            richTextBox1.Text += botao.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            richTextBox1.Text += botao.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            richTextBox1.Text += botao.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            richTextBox1.Text += botao.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            richTextBox1.Text += botao.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            richTextBox1.Text += botao.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            richTextBox1.Text += botao.Text;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                primeiroNumero = double.Parse(richTextBox1.Text);
                operacao = botao.Text;
                richTextBox1.Clear();
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                primeiroNumero = double.Parse(richTextBox1.Text);
                operacao = botao.Text;
                richTextBox1.Clear();
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                primeiroNumero = double.Parse(richTextBox1.Text);
                operacao = botao.Text;
                richTextBox1.Clear();
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                primeiroNumero = double.Parse(richTextBox1.Text);
                operacao = botao.Text;
                richTextBox1.Clear();
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Text.Contains(","))
            {
                richTextBox1.Text += ",";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                segundoNumero = double.Parse(richTextBox1.Text);

                double resultado = 0;

                switch (operacao)
                {
                    case "+":
                        resultado = primeiroNumero + segundoNumero;
                        break;
                    case "-":
                        resultado = primeiroNumero - segundoNumero;
                        break;
                    case "*":
                        resultado = primeiroNumero * segundoNumero;
                        break;
                    case "/":
                        if (segundoNumero != 0)
                            resultado = primeiroNumero / segundoNumero;
                        else
                            richTextBox1.Text = "Erro: Divisão por zero";
                        break;
                }

                string calculo = $"{primeiroNumero} {operacao} {segundoNumero} = {resultado}";
                richTextBox1.Text = resultado.ToString();

                Historico.SalvarNoArquivo(calculo);
                
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            primeiroNumero = 0;
            segundoNumero = 0;
            operacao = "";

            
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            Hsitorico_Calculadora formHistorico = new Hsitorico_Calculadora();
            formHistorico.ShowDialog();
        }
    }
} 

// adiconar criptografia

