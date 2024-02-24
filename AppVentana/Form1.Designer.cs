namespace AppVentana
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btSaludar = new Button();
            lbNombre = new Label();
            lbResultado = new Label();
            txNombre = new TextBox();
            lbApellido = new Label();
            txApellido = new TextBox();
            checkIncluirApellido = new CheckBox();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btSaludar
            // 
            btSaludar.Font = new Font("Algerian", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSaludar.Location = new Point(205, 189);
            btSaludar.Name = "btSaludar";
            btSaludar.Size = new Size(200, 38);
            btSaludar.TabIndex = 0;
            btSaludar.Text = "Saludar";
            btSaludar.UseVisualStyleBackColor = true;
            btSaludar.Click += button1_Click;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Algerian", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(45, 22);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(128, 31);
            lbNombre.TabIndex = 1;
            lbNombre.Text = "Nombre:";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Algerian", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbResultado.ForeColor = Color.Navy;
            lbResultado.Location = new Point(205, 255);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(102, 31);
            lbResultado.TabIndex = 2;
            lbResultado.Text = "labe2";
            lbResultado.Visible = false;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(205, 25);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(229, 27);
            txNombre.TabIndex = 3;
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Font = new Font("Algerian", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbApellido.Location = new Point(45, 72);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(156, 31);
            lbApellido.TabIndex = 4;
            lbApellido.Text = "Apellido: ";
            // 
            // txApellido
            // 
            txApellido.Location = new Point(207, 76);
            txApellido.Name = "txApellido";
            txApellido.Size = new Size(227, 27);
            txApellido.TabIndex = 5;
            // 
            // checkIncluirApellido
            // 
            checkIncluirApellido.AutoSize = true;
            checkIncluirApellido.Location = new Point(214, 135);
            checkIncluirApellido.Name = "checkIncluirApellido";
            checkIncluirApellido.Size = new Size(198, 24);
            checkIncluirApellido.TabIndex = 6;
            checkIncluirApellido.Text = "incluir apellido en saludo";
            checkIncluirApellido.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.BackgroundImage = Properties.Resources.clse6_1;
            pictureBox1.Image = Properties.Resources.clse6_1;
            pictureBox1.Location = new Point(461, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(453, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(799, 28);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(123, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Ocultar boton";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 450);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(checkIncluirApellido);
            Controls.Add(txApellido);
            Controls.Add(lbApellido);
            Controls.Add(txNombre);
            Controls.Add(lbResultado);
            Controls.Add(lbNombre);
            Controls.Add(btSaludar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSaludar;
        private Label lbNombre;
        private Label lbResultado;
        private TextBox txNombre;
        private Label lbApellido;
        private TextBox txApellido;
        private CheckBox checkIncluirApellido;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
    }
}
