namespace practica_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpar1 = new System.Windows.Forms.TextBox();
            this.txtpar2 = new System.Windows.Forms.TextBox();
            this.txtpar3 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtprom = new System.Windows.Forms.TextBox();
            this.txtcondicion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALIFICACIONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "PARCIAL 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "PARCIAL 2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "PARCIAL 3";
            // 
            // txtpar1
            // 
            this.txtpar1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpar1.Location = new System.Drawing.Point(182, 148);
            this.txtpar1.Name = "txtpar1";
            this.txtpar1.Size = new System.Drawing.Size(157, 35);
            this.txtpar1.TabIndex = 5;
            // 
            // txtpar2
            // 
            this.txtpar2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpar2.Location = new System.Drawing.Point(182, 195);
            this.txtpar2.Name = "txtpar2";
            this.txtpar2.Size = new System.Drawing.Size(157, 35);
            this.txtpar2.TabIndex = 6;
            // 
            // txtpar3
            // 
            this.txtpar3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpar3.Location = new System.Drawing.Point(182, 244);
            this.txtpar3.Name = "txtpar3";
            this.txtpar3.Size = new System.Drawing.Size(157, 35);
            this.txtpar3.TabIndex = 7;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.IndianRed;
            this.btncalcular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(101, 330);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(154, 87);
            this.btncalcular.TabIndex = 8;
            this.btncalcular.Text = "Calcular promedio";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.IndianRed;
            this.btnnuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(328, 330);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(154, 87);
            this.btnnuevo.TabIndex = 9;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "PROMEDIO FINAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "CONDICION";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtprom
            // 
            this.txtprom.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprom.Location = new System.Drawing.Point(248, 460);
            this.txtprom.Name = "txtprom";
            this.txtprom.Size = new System.Drawing.Size(234, 35);
            this.txtprom.TabIndex = 12;
            this.txtprom.TextChanged += new System.EventHandler(this.txtprom_TextChanged);
            // 
            // txtcondicion
            // 
            this.txtcondicion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcondicion.Location = new System.Drawing.Point(248, 509);
            this.txtcondicion.Name = "txtcondicion";
            this.txtcondicion.Size = new System.Drawing.Size(234, 35);
            this.txtcondicion.TabIndex = 13;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(182, 104);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(381, 35);
            this.txtnombre.TabIndex = 14;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(422, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(672, 592);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcondicion);
            this.Controls.Add(this.txtprom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtpar3);
            this.Controls.Add(this.txtpar2);
            this.Controls.Add(this.txtpar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpar1;
        private System.Windows.Forms.TextBox txtpar2;
        private System.Windows.Forms.TextBox txtpar3;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtprom;
        private System.Windows.Forms.TextBox txtcondicion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

