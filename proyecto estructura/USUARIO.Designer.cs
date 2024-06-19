using System;

namespace proyecto_estructura
{
    partial class USUARIO
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_numeroCuenta = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lst_cacrnet = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lst_targeta = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lst_saldo = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lst_correo = new System.Windows.Forms.ListBox();
            this.lst_telefono = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lst_nombre = new System.Windows.Forms.ListBox();
            this.lst_apellido = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENBENIDO AL BANCO BNB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "APELLIDO";
            // 
            // lst_numeroCuenta
            // 
            this.lst_numeroCuenta.FormattingEnabled = true;
            this.lst_numeroCuenta.ItemHeight = 16;
            this.lst_numeroCuenta.Location = new System.Drawing.Point(468, 225);
            this.lst_numeroCuenta.Name = "lst_numeroCuenta";
            this.lst_numeroCuenta.Size = new System.Drawing.Size(244, 20);
            this.lst_numeroCuenta.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "NUMERO DE CUENTA ";
            // 
            // lst_cacrnet
            // 
            this.lst_cacrnet.FormattingEnabled = true;
            this.lst_cacrnet.ItemHeight = 16;
            this.lst_cacrnet.Location = new System.Drawing.Point(468, 136);
            this.lst_cacrnet.Name = "lst_cacrnet";
            this.lst_cacrnet.Size = new System.Drawing.Size(244, 20);
            this.lst_cacrnet.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(462, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "NUMERO DE CARNET";
            // 
            // lst_targeta
            // 
            this.lst_targeta.FormattingEnabled = true;
            this.lst_targeta.ItemHeight = 16;
            this.lst_targeta.Location = new System.Drawing.Point(36, 349);
            this.lst_targeta.Name = "lst_targeta";
            this.lst_targeta.Size = new System.Drawing.Size(244, 20);
            this.lst_targeta.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "TIPO DE TARGETA ";
            // 
            // lst_saldo
            // 
            this.lst_saldo.FormattingEnabled = true;
            this.lst_saldo.ItemHeight = 16;
            this.lst_saldo.Location = new System.Drawing.Point(560, 419);
            this.lst_saldo.Name = "lst_saldo";
            this.lst_saldo.Size = new System.Drawing.Size(115, 36);
            this.lst_saldo.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(378, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "SALDO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "CORREO";
            // 
            // lst_correo
            // 
            this.lst_correo.FormattingEnabled = true;
            this.lst_correo.ItemHeight = 16;
            this.lst_correo.Location = new System.Drawing.Point(36, 438);
            this.lst_correo.Name = "lst_correo";
            this.lst_correo.Size = new System.Drawing.Size(244, 20);
            this.lst_correo.TabIndex = 12;
            // 
            // lst_telefono
            // 
            this.lst_telefono.FormattingEnabled = true;
            this.lst_telefono.ItemHeight = 16;
            this.lst_telefono.Location = new System.Drawing.Point(431, 313);
            this.lst_telefono.Name = "lst_telefono";
            this.lst_telefono.Size = new System.Drawing.Size(244, 20);
            this.lst_telefono.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(425, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(330, 32);
            this.label9.TabIndex = 15;
            this.label9.Text = "NUMERO DE CUENTA ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lst_nombre
            // 
            this.lst_nombre.FormattingEnabled = true;
            this.lst_nombre.ItemHeight = 16;
            this.lst_nombre.Location = new System.Drawing.Point(36, 136);
            this.lst_nombre.Name = "lst_nombre";
            this.lst_nombre.Size = new System.Drawing.Size(244, 20);
            this.lst_nombre.TabIndex = 17;
            // 
            // lst_apellido
            // 
            this.lst_apellido.FormattingEnabled = true;
            this.lst_apellido.ItemHeight = 16;
            this.lst_apellido.Location = new System.Drawing.Point(36, 252);
            this.lst_apellido.Name = "lst_apellido";
            this.lst_apellido.Size = new System.Drawing.Size(244, 20);
            this.lst_apellido.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(674, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "label10";
            // 
            // USUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 618);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lst_apellido);
            this.Controls.Add(this.lst_nombre);
            this.Controls.Add(this.lst_telefono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lst_saldo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lst_correo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lst_targeta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lst_numeroCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lst_cacrnet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "USUARIO";
            this.Text = "USUARIO";
            this.Load += new System.EventHandler(this.USUARIO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lst_telefono_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_numeroCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lst_cacrnet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lst_targeta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lst_saldo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lst_correo;
        private System.Windows.Forms.ListBox lst_telefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lst_nombre;
        private System.Windows.Forms.ListBox lst_apellido;
        private System.Windows.Forms.Label label10;
    }
}