namespace Currency_Convertor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            quantia_txt = new TextBox();
            fromcombo1 = new ComboBox();
            label2 = new Label();
            tocombo2 = new ComboBox();
            label3 = new Label();
            display_txt = new Label();
            conv_btn = new Button();
            taxa_cambio = new TextBox();
            label4 = new Label();
            openFileDialog1 = new OpenFileDialog();
            carregar_ficheiro = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 122);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Inserir quantia";
            label1.Click += label1_Click;
            // 
            // quantia_txt
            // 
            quantia_txt.Location = new Point(162, 122);
            quantia_txt.Name = "quantia_txt";
            quantia_txt.Size = new Size(192, 27);
            quantia_txt.TabIndex = 1;
            quantia_txt.TextChanged += textBox1_TextChanged;
            // 
            // fromcombo1
            // 
            fromcombo1.FormattingEnabled = true;
            fromcombo1.Items.AddRange(new object[] { "Metical", "Dollar", "Euro", "Reais", "Rupees" });
            fromcombo1.Location = new Point(162, 167);
            fromcombo1.Name = "fromcombo1";
            fromcombo1.Size = new Size(192, 28);
            fromcombo1.TabIndex = 2;
            fromcombo1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 170);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 3;
            label2.Text = "Converter de";
            // 
            // tocombo2
            // 
            tocombo2.FormattingEnabled = true;
            tocombo2.Items.AddRange(new object[] { "Dollar", "Euro", "Reais", "Metical", "Rupees" });
            tocombo2.Location = new Point(162, 221);
            tocombo2.Name = "tocombo2";
            tocombo2.Size = new Size(192, 28);
            tocombo2.TabIndex = 4;
            tocombo2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 221);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 5;
            label3.Text = "Converter para";
            // 
            // display_txt
            // 
            display_txt.AutoSize = true;
            display_txt.Location = new Point(53, 306);
            display_txt.Name = "display_txt";
            display_txt.Size = new Size(142, 20);
            display_txt.TabIndex = 6;
            display_txt.Text = "Quantia convertida: ";
            display_txt.Click += label4_Click;
            // 
            // conv_btn
            // 
            conv_btn.Location = new Point(391, 122);
            conv_btn.Name = "conv_btn";
            conv_btn.Size = new Size(94, 29);
            conv_btn.TabIndex = 8;
            conv_btn.Text = "Converter";
            conv_btn.UseVisualStyleBackColor = true;
            conv_btn.Click += conv_btn_Click;
            // 
            // taxa_cambio
            // 
            taxa_cambio.Location = new Point(162, 79);
            taxa_cambio.Name = "taxa_cambio";
            taxa_cambio.Size = new Size(192, 27);
            taxa_cambio.TabIndex = 9;
            taxa_cambio.TextChanged += taxa_cambio_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 79);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 10;
            label4.Text = "Taxa de cambio";
            label4.Click += label4_Click_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk_1;
            // 
            // carregar_ficheiro
            // 
            carregar_ficheiro.Location = new Point(391, 75);
            carregar_ficheiro.Name = "carregar_ficheiro";
            carregar_ficheiro.Size = new Size(115, 29);
            carregar_ficheiro.TabIndex = 11;
            carregar_ficheiro.Text = "Carregar";
            carregar_ficheiro.UseVisualStyleBackColor = true;
            carregar_ficheiro.Click += carregar_ficheiro_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(518, 443);
            Controls.Add(carregar_ficheiro);
            Controls.Add(label4);
            Controls.Add(taxa_cambio);
            Controls.Add(conv_btn);
            Controls.Add(display_txt);
            Controls.Add(label3);
            Controls.Add(tocombo2);
            Controls.Add(label2);
            Controls.Add(fromcombo1);
            Controls.Add(quantia_txt);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox quantia_txt;
        private ComboBox fromcombo1;
        private Label label2;
        private ComboBox tocombo2;
        private Label label3;
        private Label display_txt;
        private Button conv_btn;
        private TextBox taxa_cambio;
        private Label label4;
        private OpenFileDialog openFileDialog1;
        private Button carregar_ficheiro;
    }
}
