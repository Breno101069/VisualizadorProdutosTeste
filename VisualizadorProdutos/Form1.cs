namespace VisualizadorProdutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nomeFotosDosProdutos = Directory.GetFiles(@"C:\Users\Breno\Desktop\Produtos");

            foreach (string img in nomeFotosDosProdutos)
            {
                string [] separador = img.Split('\\');
                //var A = separador.Last().Substring(0, separador.Last().IndexOf('.'));  método diferente para simplificar
                string [] nomeSelecionado = separador[5].Split('.');

                if (comboBox2.Text == nomeSelecionado[0])
                {
                    // dentro desse if estou pegando o que esta sendo selecionado no comboBox2 e colocando a imagem
                    // dentro da pictureBox de acordo com o que foi selecionado
                    pictureBox1.ImageLocation = @"C:\Users\Breno\Desktop\Produtos\" + comboBox2.Text + ".png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "REBITE")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("TAA141XAD1");
                comboBox2.Items.Add("45CD030100");
            }
            else if (comboBox1.Text == "PARAFUSO")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("40CH033100");
            }
        }
    }
}