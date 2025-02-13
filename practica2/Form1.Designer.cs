namespace practica2
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
            txtingreso1 = new TextBox();
            btbconvertir1 = new Button();
            lblresultado1 = new Label();
            lblresultado2 = new Label();
            btnconvertir2 = new Button();
            txtingresar2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 41);
            label1.Name = "label1";
            label1.Size = new Size(234, 28);
            label1.TabIndex = 0;
            label1.Text = "INGRESE CELSIUS";
            // 
            // txtingreso1
            // 
            txtingreso1.BackColor = Color.Aquamarine;
            txtingreso1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtingreso1.Location = new Point(65, 104);
            txtingreso1.Name = "txtingreso1";
            txtingreso1.Size = new Size(150, 35);
            txtingreso1.TabIndex = 1;
            txtingreso1.TextChanged += txtingreso1_TextChanged;
            // 
            // btbconvertir1
            // 
            btbconvertir1.BackColor = Color.Aquamarine;
            btbconvertir1.Location = new Point(330, 66);
            btbconvertir1.Name = "btbconvertir1";
            btbconvertir1.Size = new Size(135, 69);
            btbconvertir1.TabIndex = 2;
            btbconvertir1.Text = "CONVERTIR";
            btbconvertir1.UseVisualStyleBackColor = false;
            btbconvertir1.Click += btbconvertir1_Click;
            // 
            // lblresultado1
            // 
            lblresultado1.AutoSize = true;
            lblresultado1.BackColor = Color.Teal;
            lblresultado1.Location = new Point(518, 88);
            lblresultado1.Name = "lblresultado1";
            lblresultado1.Size = new Size(108, 25);
            lblresultado1.TabIndex = 3;
            lblresultado1.Text = "RESULTADO";
            lblresultado1.Click += lblresultado1_Click;
            // 
            // lblresultado2
            // 
            lblresultado2.AutoSize = true;
            lblresultado2.BackColor = Color.Teal;
            lblresultado2.Location = new Point(518, 280);
            lblresultado2.Name = "lblresultado2";
            lblresultado2.Size = new Size(108, 25);
            lblresultado2.TabIndex = 7;
            lblresultado2.Text = "RESULTADO";
            // 
            // btnconvertir2
            // 
            btnconvertir2.BackColor = Color.Aquamarine;
            btnconvertir2.Location = new Point(330, 258);
            btnconvertir2.Name = "btnconvertir2";
            btnconvertir2.Size = new Size(135, 69);
            btnconvertir2.TabIndex = 6;
            btnconvertir2.Text = "CONVERTIR";
            btnconvertir2.UseVisualStyleBackColor = false;
            btnconvertir2.Click += btnconvertir2_Click;
            // 
            // txtingresar2
            // 
            txtingresar2.BackColor = Color.Aquamarine;
            txtingresar2.Font = new Font("Arial Narrow", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtingresar2.Location = new Point(65, 296);
            txtingresar2.Name = "txtingresar2";
            txtingresar2.Size = new Size(150, 40);
            txtingresar2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 222);
            label3.Name = "label3";
            label3.Size = new Size(267, 28);
            label3.TabIndex = 4;
            label3.Text = "INGRESE FARENHEIT";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(lblresultado2);
            Controls.Add(btnconvertir2);
            Controls.Add(txtingresar2);
            Controls.Add(label3);
            Controls.Add(lblresultado1);
            Controls.Add(btbconvertir1);
            Controls.Add(txtingreso1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtingreso1;
        private Button btbconvertir1;
        private Label lblresultado1;
        private Label lblresultado2;
        private Button btnconvertir2;
        private TextBox txtingresar2;
        private Label label3;
    }
}
