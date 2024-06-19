namespace proyecto_estructura
{
    partial class NuevoUsuario
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
            this.NOMBRES = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Carnet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbnTipoCuenta = new System.Windows.Forms.ComboBox();
            this.TXT_CONTRASEÑA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_CORREO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.tn_registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(66, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREA UNA CUENTA NUEVA";
            // 
            // NOMBRES
            // 
            this.NOMBRES.AutoSize = true;
            this.NOMBRES.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NOMBRES.Location = new System.Drawing.Point(56, 103);
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.Size = new System.Drawing.Size(143, 16);
            this.NOMBRES.TabIndex = 1;
            this.NOMBRES.Text = "NOMBRE COMPLETO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(331, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "APELLIDOS";
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombre.Location = new System.Drawing.Point(59, 122);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 22);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txt_apellido
            // 
            this.txt_apellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_apellido.Location = new System.Drawing.Point(334, 122);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(224, 22);
            this.txt_apellido.TabIndex = 4;
            // 
            // txt_telefono
            // 
            this.txt_telefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_telefono.Location = new System.Drawing.Point(59, 216);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(155, 22);
            this.txt_telefono.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(56, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "NUMERO TELEFONO";
            // 
            // txt_Carnet
            // 
            this.txt_Carnet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Carnet.Location = new System.Drawing.Point(334, 216);
            this.txt_Carnet.Name = "txt_Carnet";
            this.txt_Carnet.Size = new System.Drawing.Size(155, 22);
            this.txt_Carnet.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(331, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "NUMERO DE CARNET";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(61, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "TIPO DE CUENTA";
            // 
            // cbnTipoCuenta
            // 
            this.cbnTipoCuenta.FormattingEnabled = true;
            this.cbnTipoCuenta.Items.AddRange(new object[] {
            "DEVITO",
            "CREDITO"});
            this.cbnTipoCuenta.Location = new System.Drawing.Point(59, 441);
            this.cbnTipoCuenta.Name = "cbnTipoCuenta";
            this.cbnTipoCuenta.Size = new System.Drawing.Size(121, 24);
            this.cbnTipoCuenta.TabIndex = 10;
//            this.cbnTipoCuenta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TXT_CONTRASEÑA
            // 
            this.TXT_CONTRASEÑA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TXT_CONTRASEÑA.Location = new System.Drawing.Point(59, 329);
            this.TXT_CONTRASEÑA.Name = "TXT_CONTRASEÑA";
            this.TXT_CONTRASEÑA.Size = new System.Drawing.Size(155, 22);
            this.TXT_CONTRASEÑA.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(56, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "MONTO DEPOSITO";
            // 
            // TXT_CORREO
            // 
            this.TXT_CORREO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TXT_CORREO.Location = new System.Drawing.Point(334, 341);
            this.TXT_CORREO.Name = "TXT_CORREO";
            this.TXT_CORREO.Size = new System.Drawing.Size(155, 22);
            this.TXT_CORREO.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(331, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "CORREO ELECTRONICO";
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(334, 530);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(112, 33);
            this.BTN_SALIR.TabIndex = 18;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // tn_registrar
            // 
            this.tn_registrar.Location = new System.Drawing.Point(61, 526);
            this.tn_registrar.Name = "tn_registrar";
            this.tn_registrar.Size = new System.Drawing.Size(138, 41);
            this.tn_registrar.TabIndex = 19;
            this.tn_registrar.Text = "REGISTRAR";
            this.tn_registrar.UseVisualStyleBackColor = true;
            this.tn_registrar.Click += new System.EventHandler(this.tn_registrar_Click);
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(612, 600);
            this.Controls.Add(this.tn_registrar);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.TXT_CORREO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TXT_CONTRASEÑA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbnTipoCuenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Carnet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NOMBRES);
            this.Controls.Add(this.label1);
            this.Name = "NuevoUsuario";
            this.Text = "NuevoUsuario";
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NOMBRES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Carnet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbnTipoCuenta;
        private System.Windows.Forms.TextBox TXT_CONTRASEÑA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_CORREO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Button tn_registrar;
    }
}