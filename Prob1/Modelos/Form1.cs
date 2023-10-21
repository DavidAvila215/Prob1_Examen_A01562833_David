using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prob1.Algoritmos;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prob1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Paso 0: Condicíon de vacío
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") ||
                textBox3.Text.Equals(""))
            {
                MessageBox.Show("Hay casillas vacias");
                return;
            }

            double a = Convert.ToInt32(textBox1.Text);
            double b = Convert.ToInt32(textBox2.Text);
            double n = Convert.ToInt32(textBox3.Text);
            ///
            if (a < 0 || b < 0  || n <1 )
            {
                MessageBox.Show("Ingresa Valores Positivos");
                return;
            }
            if (b <= a)
            {
                MessageBox.Show("b debe de ser mayor que a");
                return;
            }
            Generar algoritmo = new Generar();
            List<List<double>> MatrizValores = algoritmo.
                Montecarlo_Exponencial(a, b, n);
            visualizar(MatrizValores);
        }
        public void visualizar(List<List<double>> matriz)
        {
            double suma_areas = 0;
            int n = matriz.Count;
            int columnas = matriz[0].Count;
            dataGridView1.Columns.Clear(); // Borra todas las columnas existentes
            for (int i = 0; i < columnas; i++)
            {
                dataGridView1.Columns.Add(i.ToString(), i.ToString());
            }

            dataGridView1.Columns[0].HeaderText = "Valor de X";
            dataGridView1.Columns[1].HeaderText = "Altura";
            dataGridView1.Columns[2].HeaderText = "Area";

            dataGridView1.Rows.Clear();
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < columnas; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matriz[i][j].ToString();
                }
                suma_areas = suma_areas + matriz[i][2];
            }


            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString(); // Mostrar números en las filas
            }

            
            labelIntegral.Text = "Estimación de la integral: " + suma_areas.ToString();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


    }
}
