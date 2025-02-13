namespace practica_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblingre = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnarea = new System.Windows.Forms.Button();
            this.btnperi = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblresult2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblingre
            // 
            this.lblingre.AutoSize = true;
            this.lblingre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingre.Location = new System.Drawing.Point(15, 188);
            this.lblingre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblingre.Name = "lblingre";
            this.lblingre.Size = new System.Drawing.Size(416, 28);
            this.lblingre.TabIndex = 0;
            this.lblingre.Text = "INGRESA EL RADIO DEL CIRCULO";
            this.lblingre.Click += new System.EventHandler(this.lblingre_Click);
            // 
            // txtresult
            // 
            this.txtresult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtresult.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtresult.Location = new System.Drawing.Point(55, 241);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(321, 40);
            this.txtresult.TabIndex = 1;
            this.txtresult.TextChanged += new System.EventHandler(this.txtresult_TextChanged);
            // 
            // btnarea
            // 
            this.btnarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnarea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnarea.Location = new System.Drawing.Point(469, 76);
            this.btnarea.Name = "btnarea";
            this.btnarea.Size = new System.Drawing.Size(175, 110);
            this.btnarea.TabIndex = 2;
            this.btnarea.Text = "CALCULAR AREA";
            this.btnarea.UseVisualStyleBackColor = false;
            this.btnarea.Click += new System.EventHandler(this.btnarea_Click);
            // 
            // btnperi
            // 
            this.btnperi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnperi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnperi.Location = new System.Drawing.Point(469, 386);
            this.btnperi.Name = "btnperi";
            this.btnperi.Size = new System.Drawing.Size(175, 110);
            this.btnperi.TabIndex = 3;
            this.btnperi.Text = "CALCULAR PERIMETRO";
            this.btnperi.UseVisualStyleBackColor = false;
            this.btnperi.Click += new System.EventHandler(this.btnperi_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblresult.Location = new System.Drawing.Point(822, 114);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(191, 32);
            this.lblresult.TabIndex = 4;
            this.lblresult.Text = "RESULTADO";
            this.lblresult.Click += new System.EventHandler(this.lblresult_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblresult2
            // 
            this.lblresult2.AutoSize = true;
            this.lblresult2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblresult2.Location = new System.Drawing.Point(822, 424);
            this.lblresult2.Name = "lblresult2";
            this.lblresult2.Size = new System.Drawing.Size(191, 32);
            this.lblresult2.TabIndex = 5;
            this.lblresult2.Text = "RESULTADO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1303, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblresult2);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnperi);
            this.Controls.Add(this.btnarea);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.lblingre);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblingre;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnarea;
        private System.Windows.Forms.Button btnperi;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblresult2;
    }
}

