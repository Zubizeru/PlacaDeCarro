namespace PlacaDeCarro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (!ValidaPlaca(txtPlaca.Text))
                MessageBox.Show("Placa Inválida");
            else
            {
                MessageBox.Show("Placa Registrada");
            }
        }

        private bool ValidaPlaca(string placa)
        {
            // Essa placa tem que ser validada : LLL-9999
            if (!placa.Contains("-") || !(placa.Length == 8))
                return false;

            int posicaodotraco = placa.IndexOf("-");

            if (posicaodotraco == 3)
            {
                string inicioDaPlaca = placa.Substring(0, posicaodotraco);
                string restanteDaPlaca = placa.Substring(posicaodotraco + 1);

                if (inicioDaPlaca.Length == 3 && !inicioDaPlaca.All(char.IsDigit) && inicioDaPlaca.All(char.IsUpper) && restanteDaPlaca.Length == 4 && restanteDaPlaca.All(char.IsDigit))
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
