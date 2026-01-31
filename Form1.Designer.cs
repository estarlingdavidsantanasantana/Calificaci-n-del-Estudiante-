namespace primera_tarea_del_año
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNota1 = new TextBox();
            txtNota4 = new TextBox();
            txtNota3 = new TextBox();
            txtNota2 = new TextBox();
            txtPromedio = new TextBox();
            txtCompletivo = new TextBox();
            txtResultado = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 57);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Nota1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 111);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 1;
            label2.Text = "Nota2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 162);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 2;
            label3.Text = "Nota3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 206);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 3;
            label4.Text = "Nota4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 253);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 4;
            label5.Text = "Promedio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 307);
            label6.Name = "label6";
            label6.Size = new Size(148, 25);
            label6.TabIndex = 5;
            label6.Text = "Nota Completivo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 354);
            label7.Name = "label7";
            label7.Size = new Size(90, 25);
            label7.TabIndex = 6;
            label7.Text = "Resultado";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(357, 57);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(150, 31);
            txtNota1.TabIndex = 7;
            // 
            // txtNota4
            // 
            txtNota4.Location = new Point(357, 203);
            txtNota4.Name = "txtNota4";
            txtNota4.Size = new Size(150, 31);
            txtNota4.TabIndex = 8;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(357, 159);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(150, 31);
            txtNota3.TabIndex = 9;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(357, 111);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(150, 31);
            txtNota2.TabIndex = 10;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(357, 250);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(150, 31);
            txtPromedio.TabIndex = 11;
            // 
            // txtCompletivo
            // 
            txtCompletivo.Location = new Point(357, 301);
            txtCompletivo.Name = "txtCompletivo";
            txtCompletivo.Size = new Size(150, 31);
            txtCompletivo.TabIndex = 12;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(357, 351);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(150, 31);
            txtResultado.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(737, 367);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 14;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(592, 367);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 15;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 413);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtResultado);
            Controls.Add(txtCompletivo);
            Controls.Add(txtPromedio);
            Controls.Add(txtNota2);
            Controls.Add(txtNota3);
            Controls.Add(txtNota4);
            Controls.Add(txtNota1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo de Notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNota1;
        private TextBox txtNota4;
        private TextBox txtNota3;
        private TextBox txtNota2;
        private TextBox txtPromedio;
        private TextBox txtCompletivo;
        private TextBox txtResultado;
        private Button button1;
        private Button button2;
    }
}
