namespace proyecto_estructura
{
    partial class frmPrestamo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Carnet = new System.Windows.Forms.TextBox();
            this.Lbl_Titi1 = new System.Windows.Forms.Label();
            this.Txt_Monto = new System.Windows.Forms.TextBox();
            this.Lbl_titi3 = new System.Windows.Forms.Label();
            this.Cbx_Garantia = new System.Windows.Forms.ComboBox();
            this.Btn_Verificar = new System.Windows.Forms.Button();
            this.Lbl_Tit1 = new System.Windows.Forms.Label();
            this.Lbl_tii1 = new System.Windows.Forms.Label();
            this.Btn_Permiso = new System.Windows.Forms.Button();
            this.Txt_TipoTarjeta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 75);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(201, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Prestamos";
            // 
            // Txt_Carnet
            // 
            this.Txt_Carnet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Txt_Carnet.Location = new System.Drawing.Point(49, 158);
            this.Txt_Carnet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Carnet.Name = "Txt_Carnet";
            this.Txt_Carnet.Size = new System.Drawing.Size(132, 22);
            this.Txt_Carnet.TabIndex = 2;
            // 
            // Lbl_Titi1
            // 
            this.Lbl_Titi1.AutoSize = true;
            this.Lbl_Titi1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titi1.Location = new System.Drawing.Point(28, 127);
            this.Lbl_Titi1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Titi1.Name = "Lbl_Titi1";
            this.Lbl_Titi1.Size = new System.Drawing.Size(249, 23);
            this.Lbl_Titi1.TabIndex = 3;
            this.Lbl_Titi1.Text = "Ingrese su numero de carnet";
            // 
            // Txt_Monto
            // 
            this.Txt_Monto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Txt_Monto.Location = new System.Drawing.Point(567, 171);
            this.Txt_Monto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Monto.Name = "Txt_Monto";
            this.Txt_Monto.Size = new System.Drawing.Size(132, 22);
            this.Txt_Monto.TabIndex = 2;
            // 
            // Lbl_titi3
            // 
            this.Lbl_titi3.AutoSize = true;
            this.Lbl_titi3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titi3.Location = new System.Drawing.Point(545, 127);
            this.Lbl_titi3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_titi3.Name = "Lbl_titi3";
            this.Lbl_titi3.Size = new System.Drawing.Size(250, 23);
            this.Lbl_titi3.TabIndex = 3;
            this.Lbl_titi3.Text = "Ingrese la cantidad a prestar";
            // 
            // Cbx_Garantia
            // 
            this.Cbx_Garantia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cbx_Garantia.FormattingEnabled = true;
            this.Cbx_Garantia.Items.AddRange(new object[] {
            "Camisa",
            "Juguete",
            "Terreno",
            "Auto",
            "Casa",
            "Mansion"});
            this.Cbx_Garantia.Location = new System.Drawing.Point(483, 305);
            this.Cbx_Garantia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbx_Garantia.Name = "Cbx_Garantia";
            this.Cbx_Garantia.Size = new System.Drawing.Size(273, 24);
            this.Cbx_Garantia.TabIndex = 4;
            // 
            // Btn_Verificar
            // 
            this.Btn_Verificar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Verificar.Location = new System.Drawing.Point(49, 201);
            this.Btn_Verificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Verificar.Name = "Btn_Verificar";
            this.Btn_Verificar.Size = new System.Drawing.Size(121, 33);
            this.Btn_Verificar.TabIndex = 5;
            this.Btn_Verificar.Text = "Verificar";
            this.Btn_Verificar.UseVisualStyleBackColor = true;
            this.Btn_Verificar.Click += new System.EventHandler(this.Btn_Verificar_Click);
            // 
            // Lbl_Tit1
            // 
            this.Lbl_Tit1.AutoSize = true;
            this.Lbl_Tit1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tit1.Location = new System.Drawing.Point(28, 265);
            this.Lbl_Tit1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Tit1.Name = "Lbl_Tit1";
            this.Lbl_Tit1.Size = new System.Drawing.Size(301, 23);
            this.Lbl_Tit1.TabIndex = 3;
            this.Lbl_Tit1.Text = "Coloque el tipo de tarjeta que tiene";
            // 
            // Lbl_tii1
            // 
            this.Lbl_tii1.AutoSize = true;
            this.Lbl_tii1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tii1.Location = new System.Drawing.Point(563, 265);
            this.Lbl_tii1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_tii1.Name = "Lbl_tii1";
            this.Lbl_tii1.Size = new System.Drawing.Size(178, 23);
            this.Lbl_tii1.TabIndex = 3;
            this.Lbl_tii1.Text = "Ingrese su garantia ";
            // 
            // Btn_Permiso
            // 
            this.Btn_Permiso.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Permiso.Location = new System.Drawing.Point(361, 380);
            this.Btn_Permiso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Permiso.Name = "Btn_Permiso";
            this.Btn_Permiso.Size = new System.Drawing.Size(109, 36);
            this.Btn_Permiso.TabIndex = 6;
            this.Btn_Permiso.Text = "Estado";
            this.Btn_Permiso.UseVisualStyleBackColor = true;
            this.Btn_Permiso.Click += new System.EventHandler(this.Btn_Permiso_Click);
            // 
            // Txt_TipoTarjeta
            // 
            this.Txt_TipoTarjeta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Txt_TipoTarjeta.Location = new System.Drawing.Point(49, 305);
            this.Txt_TipoTarjeta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_TipoTarjeta.Name = "Txt_TipoTarjeta";
            this.Txt_TipoTarjeta.Size = new System.Drawing.Size(132, 22);
            this.Txt_TipoTarjeta.TabIndex = 2;
            // 
            // frmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(897, 512);
            this.Controls.Add(this.Btn_Permiso);
            this.Controls.Add(this.Btn_Verificar);
            this.Controls.Add(this.Cbx_Garantia);
            this.Controls.Add(this.Lbl_tii1);
            this.Controls.Add(this.Lbl_titi3);
            this.Controls.Add(this.Lbl_Tit1);
            this.Controls.Add(this.Lbl_Titi1);
            this.Controls.Add(this.Txt_Monto);
            this.Controls.Add(this.Txt_TipoTarjeta);
            this.Controls.Add(this.Txt_Carnet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrestamo";
            this.Text = "frmPrestamo";
            this.Load += new System.EventHandler(this.frmPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Carnet;
        private System.Windows.Forms.Label Lbl_Titi1;
        private System.Windows.Forms.TextBox Txt_Monto;
        private System.Windows.Forms.Label Lbl_titi3;
        private System.Windows.Forms.ComboBox Cbx_Garantia;
        private System.Windows.Forms.Button Btn_Verificar;
        private System.Windows.Forms.Label Lbl_Tit1;
        private System.Windows.Forms.Label Lbl_tii1;
        private System.Windows.Forms.Button Btn_Permiso;
        private System.Windows.Forms.TextBox Txt_TipoTarjeta;
    }
}