namespace Interfaz_grafica
{
    partial class sistemaintegral
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
            lbltitulogen = new Label();
            btnclientes = new Button();
            btnproductos = new Button();
            btnventas = new Button();
            btnreportes = new Button();
            btnconfig = new Button();
            btnsalir = new Button();
            SuspendLayout();
            // 
            // lbltitulogen
            // 
            lbltitulogen.AutoSize = true;
            lbltitulogen.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltitulogen.Location = new Point(189, 28);
            lbltitulogen.Name = "lbltitulogen";
            lbltitulogen.Size = new Size(161, 23);
            lbltitulogen.TabIndex = 0;
            lbltitulogen.Text = "SIstema de gestiòn";
            // 
            // btnclientes
            // 
            btnclientes.Location = new Point(60, 61);
            btnclientes.Name = "btnclientes";
            btnclientes.Size = new Size(150, 32);
            btnclientes.TabIndex = 1;
            btnclientes.Text = "Clientes";
            btnclientes.UseVisualStyleBackColor = true;
            // 
            // btnproductos
            // 
            btnproductos.Location = new Point(60, 106);
            btnproductos.Name = "btnproductos";
            btnproductos.Size = new Size(150, 32);
            btnproductos.TabIndex = 2;
            btnproductos.Text = "Productos";
            btnproductos.UseVisualStyleBackColor = true;
            btnproductos.Click += btnproductos_Click;
            // 
            // btnventas
            // 
            btnventas.Location = new Point(60, 147);
            btnventas.Name = "btnventas";
            btnventas.Size = new Size(150, 32);
            btnventas.TabIndex = 3;
            btnventas.Text = "Ventas";
            btnventas.UseVisualStyleBackColor = true;
            // 
            // btnreportes
            // 
            btnreportes.Location = new Point(60, 185);
            btnreportes.Name = "btnreportes";
            btnreportes.Size = new Size(150, 32);
            btnreportes.TabIndex = 4;
            btnreportes.Text = "Reportes";
            btnreportes.UseVisualStyleBackColor = true;
            btnreportes.Click += button4_Click;
            // 
            // btnconfig
            // 
            btnconfig.Location = new Point(60, 225);
            btnconfig.Name = "btnconfig";
            btnconfig.Size = new Size(150, 32);
            btnconfig.TabIndex = 5;
            btnconfig.Text = "Configuraciòn";
            btnconfig.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(60, 293);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(150, 32);
            btnsalir.TabIndex = 6;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += button6_Click;
            // 
            // sistemaintegral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 368);
            Controls.Add(btnsalir);
            Controls.Add(btnconfig);
            Controls.Add(btnreportes);
            Controls.Add(btnventas);
            Controls.Add(btnproductos);
            Controls.Add(btnclientes);
            Controls.Add(lbltitulogen);
            Name = "sistemaintegral";
            Text = "sistemaintegral";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulogen;
        private Button btnclientes;
        private Button btnproductos;
        private Button btnventas;
        private Button btnreportes;
        private Button btnconfig;
        private Button btnsalir;
    }
}