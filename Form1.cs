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
            string placa = txtPlaca.Text.ToUpper();

            if (!ValidaPlaca(placa))
                MessageBox.Show("Placa Inválida", "Placa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show($"{placa}\nPlaca Registrada", "Placa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidaPlaca(string placa)
        {

            if (!placa.Contains("-") || !(placa.Length == 8))
                return false;

            int posicaodotraco = placa.IndexOf("-");

            if (posicaodotraco == 3)
            {
                string inicioDaPlaca = placa.Substring(0, posicaodotraco);
                string restanteDaPlaca = placa.Substring(posicaodotraco + 1);

                if (inicioDaPlaca.Length == 3 && inicioDaPlaca.All(char.IsLetter) && restanteDaPlaca.Length == 4 && restanteDaPlaca.All(char.IsDigit))
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
