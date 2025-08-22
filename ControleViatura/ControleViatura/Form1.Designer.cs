namespace ControleViatura
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
            name = new Label();
            text = new Label();
            label3 = new Label();
            nameBox1_txt = new TextBox();
            nameBox2_txt = new TextBox();
            nameBox3_txt = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(63, 96);
            name.Name = "name";
            name.Size = new Size(99, 20);
            name.TabIndex = 0;
            name.Text = "Insira o nome";
            name.Click += label1_Click;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Location = new Point(63, 181);
            text.Name = "text";
            text.Size = new Size(161, 20);
            text.TabIndex = 1;
            text.Text = "Insira a marca do carro";
            text.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 278);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 2;
            label3.Text = "Insira a matrícula";
            label3.Click += label3_Click;
            // 
            // nameBox1_txt
            // 
            nameBox1_txt.Location = new Point(63, 133);
            nameBox1_txt.Name = "nameBox1_txt";
            nameBox1_txt.Size = new Size(355, 27);
            nameBox1_txt.TabIndex = 3;
            nameBox1_txt.TextChanged += textBox1_TextChanged;
            // 
            // nameBox2_txt
            // 
            nameBox2_txt.Location = new Point(63, 224);
            nameBox2_txt.Name = "nameBox2_txt";
            nameBox2_txt.Size = new Size(355, 27);
            nameBox2_txt.TabIndex = 4;
            // 
            // nameBox3_txt
            // 
            nameBox3_txt.Location = new Point(63, 319);
            nameBox3_txt.Name = "nameBox3_txt";
            nameBox3_txt.Size = new Size(355, 27);
            nameBox3_txt.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 52);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 6;
            label1.Text = "CADASTRAR CONDUTOR";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 416);
            Controls.Add(label1);
            Controls.Add(nameBox3_txt);
            Controls.Add(nameBox2_txt);
            Controls.Add(nameBox1_txt);
            Controls.Add(label3);
            Controls.Add(text);
            Controls.Add(name);
            Name = "Form1";
            Text = "Form1";
            Load += this.Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label text;
        private Label label3;
        private TextBox nameBox1_txt;
        private TextBox nameBox2_txt;
        private TextBox nameBox3_txt;
        private Label label1;
    }
}
