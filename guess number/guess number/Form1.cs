namespace guess_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Если загадали, нажмите ОК", "Загадайте число", MessageBoxButtons.OK);
            button1.Visible = false;
            int MsgBoxCounter = 0;
            DialogResult result;
            do
            {
                for (int i = 0; i < 2000; i++)
                {
                    result = MessageBox.Show("Ваше число это " + i + "?", "", MessageBoxButtons.YesNo);
                    MsgBoxCounter++;

                    if (result == DialogResult.Yes)
                    {
                        string attempts = MsgBoxCounter.ToString();
                        MessageBox.Show("Число отгадано!", "Победа!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MessageBox.Show(attempts, "Количество попыток", MessageBoxButtons.OK);
                        break;
                    }

                }
                result = MessageBox.Show("Начать игру сначала?", "", MessageBoxButtons.YesNo);
            } while (result == DialogResult.Yes);
            this.Close();
        }
    }
}