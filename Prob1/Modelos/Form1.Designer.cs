using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Prob1
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

            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            labelTitulo = new Label();


            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(403, 67);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Ejecutar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 75);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 2;
            label1.Text = "a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 127);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 3;
            label2.Text = "b";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(436, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(162, 190);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 193);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 6;
            label3.Text = "n";
            // 

            labelTitulo = new Label();
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(87, 20);
            labelTitulo.Name = "Titulito";
            labelTitulo.Text = "Estimación Integral de función exponencial f(x) = a^(bx)";

            Controls.Add(labelTitulo);



            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(dataGridView1);

            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

            // Etiqueta para mostrar la estimación de la integral
            labelIntegral = new Label();
            labelIntegral.AutoSize = true;
            labelIntegral.Location = new Point(87, 400); 
            labelIntegral.Name = "dist_max";
            Controls.Add(labelIntegral);

            // Etiqueta para mostrar la estimación de la integral
            

        }

        #endregion
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private DataGridView dataGridView1;
        private Label labelIntegral;
        private Label labelTitulo;
    }
}