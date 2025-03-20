namespace PlacaDeCarro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPlaca.KeyDown += new KeyEventHandler(txtPlaca_KeyDown);
        }

        private void txtPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada foi Enter
            if (e.KeyCode == Keys.Enter)
            {
                btnValidar.PerformClick(); // Aciona o botão "Validar"
                e.SuppressKeyPress = true; // Impede o som de "beep" no Enter
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.ToUpper();

            if (ValidaPlaca(placa))
            {
                if (Database.ExistePlaca(txtPlaca.Text))
                {
                    MessageBox.Show("Placa já existente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show($"{placa}\nPlaca Registrada", "Placa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Database.SalvarPlacaDeCarro(txtPlaca.Text.ToUpper());
                AtualizarListView();
            }
            else
                MessageBox.Show("Placa Inválida", "Placa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidaPlaca(string placa)
        {
            // Validação para o padrão "ABC-1234"
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

        private void AtualizarListView()
        {
            lvPlacas.Items.Clear();

            List<string> placas = Database.ListaPlacas();

            foreach (string placa in placas)
            {
                lvPlacas.Items.Add(new ListViewItem(placa));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarListView();
        }
    }
}
