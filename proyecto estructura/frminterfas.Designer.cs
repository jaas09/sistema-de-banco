namespace proyecto_estructura
{
    partial class frm_inicio
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
            this.components = new System.ComponentModel.Container();
            this.menuUsuario = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menudepositos = new FontAwesome.Sharp.IconMenuItem();
            this.solicitudPrestamo = new FontAwesome.Sharp.IconMenuItem();
            this.PRESTAMOS = new FontAwesome.Sharp.IconMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.iNFORMEGENERALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRESTAMOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuUsuario
            // 
            this.menuUsuario.AutoSize = false;
            this.menuUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.menuUsuario.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuUsuario.Location = new System.Drawing.Point(0, 0);
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuUsuario.Size = new System.Drawing.Size(935, 68);
            this.menuUsuario.TabIndex = 0;
            this.menuUsuario.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuarios,
            this.menudepositos,
            this.solicitudPrestamo,
            this.PRESTAMOS,
            this.iNFORMEGENERALToolStripMenuItem,
            this.pRESTAMOSToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 68);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(935, 48);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuusuarios
            // 
            this.menuusuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            this.menuusuarios.IconColor = System.Drawing.Color.Black;
            this.menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuarios.IconSize = 50;
            this.menuusuarios.Name = "menuusuarios";
            this.menuusuarios.Size = new System.Drawing.Size(85, 44);
            this.menuusuarios.Text = "USUARIO";
            this.menuusuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.menuusuarios.Click += new System.EventHandler(this.menuusuarios_Click);
            // 
            // menudepositos
            // 
            this.menudepositos.IconChar = FontAwesome.Sharp.IconChar.User;
            this.menudepositos.IconColor = System.Drawing.Color.Black;
            this.menudepositos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menudepositos.IconSize = 50;
            this.menudepositos.Name = "menudepositos";
            this.menudepositos.Size = new System.Drawing.Size(99, 44);
            this.menudepositos.Text = "DEPOSITOS";
            this.menudepositos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.menudepositos.Click += new System.EventHandler(this.menudepositos_Click);
            // 
            // solicitudPrestamo
            // 
            this.solicitudPrestamo.IconChar = FontAwesome.Sharp.IconChar.User;
            this.solicitudPrestamo.IconColor = System.Drawing.Color.Black;
            this.solicitudPrestamo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.solicitudPrestamo.IconSize = 50;
            this.solicitudPrestamo.Name = "solicitudPrestamo";
            this.solicitudPrestamo.Size = new System.Drawing.Size(80, 44);
            this.solicitudPrestamo.Text = "RETIROS";
            this.solicitudPrestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.solicitudPrestamo.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // PRESTAMOS
            // 
            this.PRESTAMOS.IconChar = FontAwesome.Sharp.IconChar.User;
            this.PRESTAMOS.IconColor = System.Drawing.Color.Black;
            this.PRESTAMOS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PRESTAMOS.IconSize = 50;
            this.PRESTAMOS.Name = "PRESTAMOS";
            this.PRESTAMOS.Size = new System.Drawing.Size(123, 44);
            this.PRESTAMOS.Text = "TRANSACCION";
            this.PRESTAMOS.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.PRESTAMOS.Click += new System.EventHandler(this.PRESTAMOS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "SISTEMA DEL BANCO ";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 116);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(935, 389);
            this.contenedor.TabIndex = 4;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // iNFORMEGENERALToolStripMenuItem
            // 
            this.iNFORMEGENERALToolStripMenuItem.Name = "iNFORMEGENERALToolStripMenuItem";
            this.iNFORMEGENERALToolStripMenuItem.Size = new System.Drawing.Size(153, 44);
            this.iNFORMEGENERALToolStripMenuItem.Text = "INFORME GENERAL";
            this.iNFORMEGENERALToolStripMenuItem.Click += new System.EventHandler(this.iNFORMEGENERALToolStripMenuItem_Click);
            // 
            // pRESTAMOSToolStripMenuItem
            // 
            this.pRESTAMOSToolStripMenuItem.Name = "pRESTAMOSToolStripMenuItem";
            this.pRESTAMOSToolStripMenuItem.Size = new System.Drawing.Size(105, 44);
            this.pRESTAMOSToolStripMenuItem.Text = "PRESTAMOS";
            this.pRESTAMOSToolStripMenuItem.Click += new System.EventHandler(this.pRESTAMOSToolStripMenuItem_Click);
            // 
            // frm_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 505);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuUsuario);
            this.MainMenuStrip = this.menuUsuario;
            this.Name = "frm_inicio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "f";
            this.Load += new System.EventHandler(this.frm_inicio_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuUsuario;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem PRESTAMOS;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private FontAwesome.Sharp.IconMenuItem menudepositos;
        private FontAwesome.Sharp.IconMenuItem solicitudPrestamo;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.ToolStripMenuItem iNFORMEGENERALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRESTAMOSToolStripMenuItem;
    }
}

