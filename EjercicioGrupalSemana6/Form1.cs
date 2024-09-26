using System;
using System.Windows.Forms;

namespace EjercicioGrupalSemana6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Rango", "Rango");
            dataGridView1.Columns.Add("NumerosPrimos", "Números Primos");
            dataGridView1.Columns.Add("TiempoDeEjecucion", "Tiempo de Ejecución (ms)");
        }

        private void buttonEjecutar_Click(object sender, EventArgs e)
        {
            NumerosPrimos primos = new NumerosPrimos();

            // Limpiar el DataGridView antes de agregar nuevos resultados
            dataGridView1.Rows.Clear();

            // Calcular y agregar resultados para cada rango
            var resultado1 = primos.CalculosPrimos(1, 99);
            dataGridView1.Rows.Add("1 - 99", string.Join(", ", (int[])resultado1[0]), resultado1[2]);

            var resultado2 = primos.CalculosPrimos(100, 999);
            dataGridView1.Rows.Add("100 - 999", string.Join(", ", (int[])resultado2[0]), resultado2[2]);

            var resultado3 = primos.CalculosPrimos(1000, 9999);
            dataGridView1.Rows.Add("1000 - 9999", string.Join(", ", (int[])resultado3[0]), resultado3[2]);

            var resultado4 = primos.CalculosPrimos(10000, 99999);
            dataGridView1.Rows.Add("10000 - 99999", string.Join(", ", (int[])resultado4[0]), resultado4[2]);

            var resultado5 = primos.CalculosPrimos(100000, 999999);
            dataGridView1.Rows.Add("100000 - 999999", string.Join(", ", (int[])resultado5[0]), resultado5[2]);

            var resultado6 = primos.CalculosPrimos(1000000, 1999999);
            dataGridView1.Rows.Add("1000000 - 1999999", string.Join(", ", (int[])resultado6[0]), resultado6[2]);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}

