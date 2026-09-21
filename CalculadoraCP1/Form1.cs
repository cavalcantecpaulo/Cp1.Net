using System.Globalization;

namespace CalculadoraCP1
{
    public partial class Form1 : Form
    {
        private double valorAtual = 0;
        private string operacaoSelecionada = null;
        private bool operadorClicado = false;

        public Form1()
        {
            InitializeComponent();
            MostrarIntroducao();
        }

        private void MostrarIntroducao()
        {
            visor.Text = "Tranquilo!        ";

            var timer = new System.Windows.Forms.Timer { Interval = 1200 };
            timer.Tick += (sender, e) =>
            {
                visor.Text = "0";
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        private void btnDigitoClick(object sender, EventArgs e)
        {
            Button botaoClicado = sender as Button;
            string digito = botaoClicado.Text;

            if (visor.Text == "0" || operadorClicado)
            {
                visor.Text = digito;
                operadorClicado = false;
            }
            else
            {
                visor.Text += digito;
            }
        }

        private void btnVirgulaClick(object sender, EventArgs e)
        {
            if (operadorClicado)
            {
                visor.Text = "0,";
                operadorClicado = false;
                return;
            }

            if (!visor.Text.Contains(","))
            {
                visor.Text += ",";
            }
        }

        private void btnApagarClick(object sender, EventArgs e)
        {
            if (operadorClicado)
                return;

            visor.Text = visor.Text.Length <= 1 ? "0" : visor.Text[..^1];
        }

        private void btnClearClick(object sender, EventArgs e)
        {
            visor.Text = "0";
            valorAtual = 0;
            operacaoSelecionada = null;
            operadorClicado = false;
        }

        private void btnOperacaoClick(object sender, EventArgs e)
        {
            Button botaoClicado = sender as Button;

            // Usuário clicou em outro operador sem digitar um novo número
            // troca a operação pendente, sem recalcular com um valor "vazio".
            if (operadorClicado)
            {
                operacaoSelecionada = botaoClicado.Text;
                visor.Text = operacaoSelecionada;
                return;
            }

            double valorDigitado = ObterValorVisor();

            if (operacaoSelecionada != null)
            {
                double resultado = Calcular(valorAtual, valorDigitado, operacaoSelecionada);
                if (ExibirErroSeInvalido(resultado))
                    return;

                valorAtual = resultado;
            }
            else
            {
                valorAtual = valorDigitado;
            }

            operacaoSelecionada = botaoClicado.Text;
            operadorClicado = true;
            visor.Text = operacaoSelecionada;
        }

        private void btnIgualClick(object sender, EventArgs e)
        {
            if (operacaoSelecionada == null)
                return;

            double resultado = Calcular(valorAtual, ObterValorVisor(), operacaoSelecionada);
            if (ExibirErroSeInvalido(resultado))
                return;

            valorAtual = resultado;
            MostrarResultado(valorAtual);

            operacaoSelecionada = null;
            operadorClicado = true;
        }

        private void btnRaizClick(object sender, EventArgs e)
        {
            double valor = ObterValorVisor();

            if (valor < 0)
            {
                visor.Text = "Erro";
                operadorClicado = true;
                return;
            }

            valorAtual = Math.Sqrt(valor);
            MostrarResultado(valorAtual);
            operadorClicado = true;
        }

        private double Calcular(double a, double b, string operacao)
        {
            return operacao switch
            {
                "+" => a + b,
                "-" => a - b,
                "X" => a * b,
                "/" => a / b,
                "x^y" => Math.Pow(a, b),
                _ => throw new InvalidOperationException("Operação inválida"),
            };
        }

        private double ObterValorVisor()
        {
            double.TryParse(visor.Text.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, out double valor);
            return valor;
        }

        private void MostrarResultado(double valor)
        {
            visor.Text = valor.ToString("G10", CultureInfo.InvariantCulture).Replace(".", ",");
        }

        private bool ExibirErroSeInvalido(double resultado)
        {
            if (double.IsNaN(resultado) || double.IsInfinity(resultado))
            {
                visor.Text = "Erro";
                operacaoSelecionada = null;
                operadorClicado = true;
                return true;
            }

            return false;
        }

        private void menuSobreClick(object sender, EventArgs e)
        {
            using var formSobre = new FormSobre();
            formSobre.ShowDialog(this);
        }
    }
}
