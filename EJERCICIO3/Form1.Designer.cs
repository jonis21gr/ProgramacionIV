namespace EJERCICIO3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncal = new System.Windows.Forms.Button();
            this.RBSUMA = new System.Windows.Forms.RadioButton();
            this.RBRESTA = new System.Windows.Forms.RadioButton();
            this.RBMULT = new System.Windows.Forms.RadioButton();
            this.RBDIV = new System.Windows.Forms.RadioButton();
            this.lblres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUM 1";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(128, 80);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 26);
            this.txtnum1.TabIndex = 1;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(128, 133);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 26);
            this.txtnum2.TabIndex = 3;
            this.txtnum2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "NUM 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(80, 214);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(129, 59);
            this.btncal.TabIndex = 4;
            this.btncal.Text = "CALCULAR";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // RBSUMA
            // 
            this.RBSUMA.AutoSize = true;
            this.RBSUMA.Location = new System.Drawing.Point(390, 80);
            this.RBSUMA.Name = "RBSUMA";
            this.RBSUMA.Size = new System.Drawing.Size(81, 24);
            this.RBSUMA.TabIndex = 5;
            this.RBSUMA.TabStop = true;
            this.RBSUMA.Text = "SUMA";
            this.RBSUMA.UseVisualStyleBackColor = true;
            // 
            // RBRESTA
            // 
            this.RBRESTA.AutoSize = true;
            this.RBRESTA.Location = new System.Drawing.Point(390, 111);
            this.RBRESTA.Name = "RBRESTA";
            this.RBRESTA.Size = new System.Drawing.Size(88, 24);
            this.RBRESTA.TabIndex = 6;
            this.RBRESTA.TabStop = true;
            this.RBRESTA.Text = "RESTA";
            this.RBRESTA.UseVisualStyleBackColor = true;
            // 
            // RBMULT
            // 
            this.RBMULT.AutoSize = true;
            this.RBMULT.Location = new System.Drawing.Point(390, 142);
            this.RBMULT.Name = "RBMULT";
            this.RBMULT.Size = new System.Drawing.Size(167, 24);
            this.RBMULT.TabIndex = 7;
            this.RBMULT.TabStop = true;
            this.RBMULT.Text = "MULTIPLICACION";
            this.RBMULT.UseVisualStyleBackColor = true;
            // 
            // RBDIV
            // 
            this.RBDIV.AutoSize = true;
            this.RBDIV.Location = new System.Drawing.Point(390, 173);
            this.RBDIV.Name = "RBDIV";
            this.RBDIV.Size = new System.Drawing.Size(106, 24);
            this.RBDIV.TabIndex = 8;
            this.RBDIV.TabStop = true;
            this.RBDIV.Text = "DIVISION";
            this.RBDIV.UseVisualStyleBackColor = true;
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.Location = new System.Drawing.Point(281, 223);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(62, 32);
            this.lblres.TabIndex = 9;
            this.lblres.Text = "???";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.RBDIV);
            this.Controls.Add(this.RBMULT);
            this.Controls.Add(this.RBRESTA);
            this.Controls.Add(this.RBSUMA);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.RadioButton RBSUMA;
        private System.Windows.Forms.RadioButton RBRESTA;
        private System.Windows.Forms.RadioButton RBMULT;
        private System.Windows.Forms.RadioButton RBDIV;
        private System.Windows.Forms.Label lblres;
    }
}

