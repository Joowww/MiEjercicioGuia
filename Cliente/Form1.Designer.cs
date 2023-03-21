namespace Cliente
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
            button1 = new Button();
            nombre = new TextBox();
            label3 = new Label();
            Bonito = new CheckBox();
            Longitud = new CheckBox();
            Altura = new CheckBox();
            button2 = new Button();
            button3 = new Button();
            alturaBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(580, 326);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nombre
            // 
            nombre.Location = new Point(502, 75);
            nombre.Name = "nombre";
            nombre.Size = new Size(235, 27);
            nombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 78);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // Bonito
            // 
            Bonito.AutoSize = true;
            Bonito.Location = new Point(502, 183);
            Bonito.Name = "Bonito";
            Bonito.Size = new Size(224, 24);
            Bonito.TabIndex = 5;
            Bonito.Text = "Dime si mi nombre es bonito";
            Bonito.UseVisualStyleBackColor = true;
            // 
            // Longitud
            // 
            Longitud.AutoSize = true;
            Longitud.Location = new Point(502, 225);
            Longitud.Name = "Longitud";
            Longitud.Size = new Size(241, 24);
            Longitud.TabIndex = 6;
            Longitud.Text = "Dime la longitud de mi nombre";
            Longitud.UseVisualStyleBackColor = true;
            // 
            // Altura
            // 
            Altura.AutoSize = true;
            Altura.Location = new Point(502, 281);
            Altura.Name = "Altura";
            Altura.Size = new Size(137, 24);
            Altura.TabIndex = 7;
            Altura.Text = "Dime si soy alto";
            Altura.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(92, 212);
            button2.Name = "button2";
            button2.Size = new Size(160, 75);
            button2.TabIndex = 8;
            button2.Text = "Desconectar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(92, 75);
            button3.Name = "button3";
            button3.Size = new Size(160, 73);
            button3.TabIndex = 9;
            button3.Text = "Conectar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // alturaBox
            // 
            alturaBox.Location = new Point(502, 121);
            alturaBox.Name = "alturaBox";
            alturaBox.Size = new Size(235, 27);
            alturaBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(389, 128);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 11;
            label1.Text = "Altura";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(alturaBox);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Altura);
            Controls.Add(Longitud);
            Controls.Add(Bonito);
            Controls.Add(label3);
            Controls.Add(nombre);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox nombre;
        private Label label3;
        private CheckBox Bonito;
        private CheckBox Longitud;
        private CheckBox Altura;
        private Button button2;
        private Button button3;
        private TextBox alturaBox;
        private Label label1;
    }
}