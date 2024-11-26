namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] info = { "Dima", "Belov", "20", "DATA scientist" };
            int counter = 0;
            string fullInfo = string.Join(" ", info);
            int length = fullInfo.Length;

            //DialogResult result = MessageBox.Show("info", info[0], MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            for (int i = 0; i < info.Length; i++)
            {
                if (counter < info.Length)
                {
                    MessageBox.Show(info[counter], "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label1.Text = info[counter];
                    counter++;
                    button1.Visible = false;
                }
                else { break; }
            }
            string MsgBoxCount = counter.ToString();
            MessageBox.Show(MsgBoxCount, "количество Messagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string CountOfSymbols = length.ToString();
            MessageBox.Show(CountOfSymbols, "количество символов", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}