namespace proyecto_estructura
{
    partial class frmInforme_General
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Transferencias = new FontAwesome.Sharp.IconMenuItem();
            this.Deposito = new FontAwesome.Sharp.IconMenuItem();
            this.Retiro = new FontAwesome.Sharp.IconMenuItem();
            this.Prestamo = new FontAwesome.Sharp.IconMenuItem();
            this.Mas_Dinero = new FontAwesome.Sharp.IconMenuItem();
            this.InformeG = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Almacen = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Transferencias,
            this.Deposito,
            this.Retiro,
            this.Prestamo,
            this.Mas_Dinero,
            this.InformeG});
            this.menuStrip1.Location = new System.Drawing.Point(0, 110);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 59);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Transferencias
            // 
            this.Transferencias.AutoSize = false;
            this.Transferencias.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transferencias.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.Transferencias.IconColor = System.Drawing.Color.Black;
            this.Transferencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Transferencias.IconSize = 30;
            this.Transferencias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Transferencias.Name = "Transferencias";
            this.Transferencias.Size = new System.Drawing.Size(132, 55);
            this.Transferencias.Text = "Transferencias";
            this.Transferencias.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // Deposito
            // 
            this.Deposito.AutoSize = false;
            this.Deposito.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposito.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.Deposito.IconColor = System.Drawing.Color.Black;
            this.Deposito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Deposito.IconSize = 30;
            this.Deposito.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Deposito.Name = "Deposito";
            this.Deposito.Size = new System.Drawing.Size(122, 55);
            this.Deposito.Text = "Deposito";
            this.Deposito.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Deposito.Click += new System.EventHandler(this.Deposito_Click);
            // 
            // Retiro
            // 
            this.Retiro.AutoSize = false;
            this.Retiro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retiro.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.Retiro.IconColor = System.Drawing.Color.Black;
            this.Retiro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Retiro.IconSize = 30;
            this.Retiro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Retiro.Name = "Retiro";
            this.Retiro.Size = new System.Drawing.Size(132, 55);
            this.Retiro.Text = "Retiro";
            this.Retiro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // Prestamo
            // 
            this.Prestamo.AutoSize = false;
            this.Prestamo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prestamo.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.Prestamo.IconColor = System.Drawing.Color.Black;
            this.Prestamo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Prestamo.IconSize = 30;
            this.Prestamo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Prestamo.Name = "Prestamo";
            this.Prestamo.Size = new System.Drawing.Size(132, 55);
            this.Prestamo.Text = "Con Prestamo";
            this.Prestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // Mas_Dinero
            // 
            this.Mas_Dinero.AutoSize = false;
            this.Mas_Dinero.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mas_Dinero.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.Mas_Dinero.IconColor = System.Drawing.Color.Black;
            this.Mas_Dinero.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Mas_Dinero.IconSize = 30;
            this.Mas_Dinero.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Mas_Dinero.Name = "Mas_Dinero";
            this.Mas_Dinero.Size = new System.Drawing.Size(132, 55);
            this.Mas_Dinero.Text = "Mas Dinero";
            this.Mas_Dinero.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // InformeG
            // 
            this.InformeG.AutoSize = false;
            this.InformeG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformeG.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.InformeG.IconColor = System.Drawing.Color.Black;
            this.InformeG.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InformeG.IconSize = 30;
            this.InformeG.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.InformeG.Name = "InformeG";
            this.InformeG.Size = new System.Drawing.Size(132, 55);
            this.InformeG.Text = "Informe General";
            this.InformeG.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1067, 110);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(287, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sistema de Informes";
            // 
            // Almacen
            // 
            this.Almacen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Almacen.Location = new System.Drawing.Point(0, 169);
            this.Almacen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Almacen.Name = "Almacen";
            this.Almacen.Size = new System.Drawing.Size(1067, 385);
            this.Almacen.TabIndex = 5;
            this.Almacen.Paint += new System.Windows.Forms.PaintEventHandler(this.Almacen_Paint);
            // 
            // frmInforme_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Almacen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInforme_General";
            this.Text = "Informe_General";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem InformeG;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem Transferencias;
        private FontAwesome.Sharp.IconMenuItem Deposito;
        private FontAwesome.Sharp.IconMenuItem Retiro;
        private FontAwesome.Sharp.IconMenuItem Prestamo;
        private FontAwesome.Sharp.IconMenuItem Mas_Dinero;
        private System.Windows.Forms.Panel Almacen;
    }
}