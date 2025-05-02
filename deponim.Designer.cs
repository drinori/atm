namespace atm
{
    partial class deponim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(291, 224);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(388, 66);
            textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, 444);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 96);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(391, 16);
            button3.Name = "button3";
            button3.Size = new Size(178, 68);
            button3.TabIndex = 4;
            button3.Text = "Anulo";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(688, 16);
            button2.Name = "button2";
            button2.Size = new Size(186, 68);
            button2.TabIndex = 3;
            button2.Text = "Vazhdo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(86, 16);
            button1.Name = "button1";
            button1.Size = new Size(178, 68);
            button1.TabIndex = 2;
            button1.Text = "Kthehu";
            button1.UseVisualStyleBackColor = true;
            // 
            // deponim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 540);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "deponim";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}