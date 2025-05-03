namespace atm
{
    partial class menu
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
            labelWelcome = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            anulo = new Button();
            terheqja = new Button();
            bilanci = new Button();
            transfer = new Button();
            deponim = new Button();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Location = new Point(30, 30);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(0, 20);
            labelWelcome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(145, 229);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(384, 229);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 6;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(570, 229);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(145, 277);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 8;
            // 
            // anulo
            // 
            anulo.Font = new Font("Segoe UI", 12F);
            anulo.Location = new Point(384, 280);
            anulo.Name = "anulo";
            anulo.Size = new Size(171, 62);
            anulo.TabIndex = 9;
            anulo.Text = "Anulo";
            anulo.UseVisualStyleBackColor = true;
            // 
            // terheqja
            // 
            terheqja.Font = new Font("Segoe UI", 12F);
            terheqja.Location = new Point(164, 210);
            terheqja.Name = "terheqja";
            terheqja.Size = new Size(193, 59);
            terheqja.TabIndex = 10;
            terheqja.Text = "Tërheqje e mjeteve";
            terheqja.UseVisualStyleBackColor = true;
            // 
            // bilanci
            // 
            bilanci.Font = new Font("Segoe UI", 12F);
            bilanci.Location = new Point(384, 210);
            bilanci.Name = "bilanci";
            bilanci.Size = new Size(171, 59);
            bilanci.TabIndex = 11;
            bilanci.Text = "Shiko bilancin";
            bilanci.UseVisualStyleBackColor = true;
            // 
            // transfer
            // 
            transfer.Font = new Font("Segoe UI", 12F);
            transfer.Location = new Point(589, 210);
            transfer.Name = "transfer";
            transfer.Size = new Size(187, 59);
            transfer.TabIndex = 12;
            transfer.Text = "Transfer i mjeteve";
            transfer.UseVisualStyleBackColor = true;
            // 
            // deponim
            // 
            deponim.Font = new Font("Segoe UI", 12F);
            deponim.Location = new Point(164, 280);
            deponim.Name = "deponim";
            deponim.Size = new Size(193, 62);
            deponim.TabIndex = 13;
            deponim.Text = "Deponim i mjeteve";
            deponim.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 543);
            Controls.Add(deponim);
            Controls.Add(transfer);
            Controls.Add(bilanci);
            Controls.Add(terheqja);
            Controls.Add(anulo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "menu";
            Text = "Tërheqje e mjeteve";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button anulo;
        private Button terheqja;
        private Button bilanci;
        private Button transfer;
        private Button deponim;
    }
}