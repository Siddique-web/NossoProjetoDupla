using System.Diagnostics;
using System.Security;

namespace Currency_Convertor
{
    public partial class Form1 : Form
    {
        int conteudoArquivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void conv_btn_Click(object sender, EventArgs e)
        {
            //Metical para dólar
            int i = int.Parse(quantia_txt.Text);
            if (fromcombo1.SelectedItem == "Metical" && tocombo2.SelectedItem == "Dollar")
            {
                //    double conver = i * 0.016;

                display_txt.Text = "Quantia convertida:" + i * (Convert.ToInt32(conteudoArquivo)) + "\t $";
            }
            //Metical para Euro
            if (fromcombo1.SelectedItem == "Metical" && tocombo2.SelectedItem == "Euro")
            {
                double conver = i * 0.013;
                display_txt.Text = "Quantia convertida:" + conver + "\t €";
            }
            //Metical para Reais
            if (fromcombo1.SelectedItem == "Metical" && tocombo2.SelectedItem == "Reais")
            {
                double conver = i * 0.085;
                display_txt.Text = "Quantia convertida:" + conver + "\t R$";
            }
            //Metical para Rupias

            if (fromcombo1.SelectedItem == "Metical" && tocombo2.SelectedItem == "Rupees")
            {
                double conver = i * 1.37;
                display_txt.Text = "Quantia convertida:" + conver + "\t ₹";
            }

            //Segunda fase de conversão
            //Agora teremmos de dólar para metical

            if (fromcombo1.SelectedItem == "Dollar" && tocombo2.SelectedItem == "Metical")
            {
                double conver = i * 63.90;
                display_txt.Text = "Quantia convertida:" + conver + "\t Mzn";
            }

            //Euro para metical
            if (fromcombo1.SelectedItem == "Euro" && tocombo2.SelectedItem == "Metical")
            {
                double conver = i * 74.78;
                display_txt.Text = "Quantia convertida:" + conver + "\t Mzn";
            }
            //Reais para metical
            if (fromcombo1.SelectedItem == "Reais" && tocombo2.SelectedItem == "Metical")
            {
                double conver = i * 11.83;
                display_txt.Text = "Quantia convertida:" + conver + "\t Mzn";
            }
            //Rupias para metical

            if (fromcombo1.SelectedItem == "Rupees" && tocombo2.SelectedItem == "Metical")
            {
                double conver = i * 0.73;
                display_txt.Text = "Quantia convertida:" + conver + "\t Mzn";
            }


            //Segunda Moeda a ser convertida a 100%

            //Dólar para Rupees

            if (fromcombo1.SelectedItem == "Dollar" && tocombo2.SelectedItem == "Rupees")
            {
                double conver = i * 87.65;
                display_txt.Text = "Quantia convertida:" + conver + "\t ₹";
            }

            //Metical para Euro
            if (fromcombo1.SelectedItem == "Dollar" && tocombo2.SelectedItem == "Euro")
            {
                double conver = i * 0.85;
                display_txt.Text = "Quantia convertida:" + conver + "\t €";
            }
            //Metical para Reais
            if (fromcombo1.SelectedItem == "Dollar" && tocombo2.SelectedItem == "Reais")
            {
                double conver = i * 5.40;
                display_txt.Text = "Quantia convertida:" + conver + "\t R$";
            }






            //Segunda fase de conversão
            //Agora teremmos de dólar para metical



            //Euro para metical
            if (fromcombo1.SelectedItem == "Euro" && tocombo2.SelectedItem == "Metical")
            {
                double conver = i * 74.78;
                display_txt.Text = "Quantia convertida:" + conver + "\t Mzn";
            }
            //Reais para metical
            if (fromcombo1.SelectedItem == "Reais" && tocombo2.SelectedItem == "Metical")
            {
                double conver = i * 11.83;
                display_txt.Text = "Quantia convertida:" + conver + "\t Mzn";
            }
            //Rupias para metical

            if (fromcombo1.SelectedItem == "Rupees" && tocombo2.SelectedItem == "Metical")
            {
                double conver = i * 0.73;
                display_txt.Text = "Quantia convertida:" + conver + "\t Mzn";
            }



            //Terceira moeda a ser convertida a 100%

            //  Euro para Rupees

            if (fromcombo1.SelectedItem == "Euro" && tocombo2.SelectedItem == "Rupees")
            {
                double conver = i * 102.20;
                display_txt.Text = "Quantia convertida:" + conver + "\t ₹";
            }

            //Metical para Euro
            if (fromcombo1.SelectedItem == "Euro" && tocombo2.SelectedItem == "Dollar")
            {
                double conver = i * 1.17;
                display_txt.Text = "Quantia convertida:" + conver + "\t $";
            }
            //Metical para Reais
            if (fromcombo1.SelectedItem == "Euro" && tocombo2.SelectedItem == "Reais")
            {
                double conver = i * 6.32;
                display_txt.Text = "Quantia convertida:" + conver + "\t R$";
            }






            //Segunda fase de conversão
            //Agora teremos de Euro para metical

            if (fromcombo1.SelectedItem == "Reais" && tocombo2.SelectedItem == "Euro")
            {
                double conver = i * 0.16;
                display_txt.Text = "Quantia convertida:" + conver + "\t €";
            }

            //Euro para metical
            if (fromcombo1.SelectedItem == "Rupees" && tocombo2.SelectedItem == "Dollar")
            {
                double conver = i * 0.011;
                display_txt.Text = "Quantia convertida:" + conver + "\t $";
            }
            //Reais para metical
            if (fromcombo1.SelectedItem == "Rupees" && tocombo2.SelectedItem == "Reais")
            {
                double conver = i * 0.062;
                display_txt.Text = "Quantia convertida:" + conver + "\t R$";
            }
            //Rupias para Euro

            if (fromcombo1.SelectedItem == "Rupees" && tocombo2.SelectedItem == "Euro")
            {
                double conver = i * 0.0098;
                display_txt.Text = "Quantia convertida:" + conver + "\t €";
            }


            //Quarta moeda a ser convertida a 100%

            // Reais para dollar
            if (fromcombo1.SelectedItem == "Reais" && tocombo2.SelectedItem == "Dollar")
            {
                double conver = i * 0.19;
                display_txt.Text = "Quantia convertida:" + conver + "\t $";
            }
            if (fromcombo1.SelectedItem == "Reais" && tocombo2.SelectedItem == "Rupees")
            {
                double conver = i * 16.18;
                display_txt.Text = "Quantia convertida:" + conver + "\t ₹";
            }

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void taxa_cambio_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            openFileDialog1 = new OpenFileDialog
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };

            carregar_ficheiro = new Button()
            {
                Size = new Size(100, 20),
                Location = new Point(15, 15),
                Text = "Select file"
            };
            carregar_ficheiro.Click += new EventHandler(carregar_ficheiro_Click);
            Controls.Add(carregar_ficheiro);
        }

        private void carregar_ficheiro_Click(object sender, EventArgs e)
        {
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        var filePath = openFileDialog1.FileName;
            //        using (Stream str = openFileDialog1.OpenFile())
            //        {
            //            Process.Start("notepad.exe", filePath);
            //        }
            //    }
            //    catch (SecurityException ex)
            //    {
            //        MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
            //        $"Details:\n\n{ex.StackTrace}");
            //    }
            //}
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                conteudoArquivo = int.Parse( File.ReadAllText(file.FileName));
                //MessageBox.Show(conteudoArquivo);

            }
        }
    }
}
