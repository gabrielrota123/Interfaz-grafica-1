namespace Interfaz_grafica
{
    partial class complementaria
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
            btnnuevo = new Button();
            btnguardar = new Button();
            btnborrar = new Button();
            lblnombre = new Label();
            lblcodigo = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lbltitulo = new Label();
            lst1 = new ListView();
            nombre = new ColumnHeader();
            Codigo = new ColumnHeader();
            SuspendLayout();
            // 
            // btnnuevo
            // 
            btnnuevo.Location = new Point(125, 142);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(75, 23);
            btnnuevo.TabIndex = 0;
            btnnuevo.Text = "Nuevo";
            btnnuevo.UseVisualStyleBackColor = true;
            btnnuevo.Click += button1_Click;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(228, 142);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 1;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            // 
            // btnborrar
            // 
            btnborrar.Location = new Point(336, 142);
            btnborrar.Name = "btnborrar";
            btnborrar.Size = new Size(75, 23);
            btnborrar.TabIndex = 2;
            btnborrar.Text = "Borrar";
            btnborrar.UseVisualStyleBackColor = true;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(142, 53);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(51, 15);
            lblnombre.TabIndex = 3;
            lblnombre.Text = "Nombre";
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.Location = new Point(142, 87);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(46, 15);
            lblcodigo.TabIndex = 4;
            lblcodigo.Text = "Còdigo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(228, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Location = new Point(228, 9);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(95, 15);
            lbltitulo.TabIndex = 7;
            lbltitulo.Text = "Gestion de datos";
            // 
            // lst1
            // 
            lst1.Columns.AddRange(new ColumnHeader[] { nombre, Codigo });
            lst1.Location = new Point(125, 186);
            lst1.Name = "lst1";
            lst1.Size = new Size(286, 97);
            lst1.TabIndex = 8;
            lst1.UseCompatibleStateImageBehavior = false;
            lst1.View = View.Details;
            // 
            // nombre
            // 
            nombre.Text = "Nombre";
            nombre.Width = 160;
            // 
            // Codigo
            // 
            Codigo.Text = "Codigo";
            Codigo.TextAlign = HorizontalAlignment.Center;
            Codigo.Width = 120;
            // 
            // complementaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 329);
            Controls.Add(lst1);
            Controls.Add(lbltitulo);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblcodigo);
            Controls.Add(lblnombre);
            Controls.Add(btnborrar);
            Controls.Add(btnguardar);
            Controls.Add(btnnuevo);
            Name = "complementaria";
            Text = "complementaria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnnuevo;
        private Button btnguardar;
        private Button btnborrar;
        private Label lblnombre;
        private Label lblcodigo;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lbltitulo;
        private ListView lst1;
        private ColumnHeader nombre;
        private ColumnHeader Codigo;
    }
}