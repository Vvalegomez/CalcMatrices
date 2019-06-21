using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMatrices
{
    public partial class CalculadoraMatrices : Form
    {
        public CalculadoraMatrices()
        {
            InitializeComponent();
        }
        //Limpia las matrices
        private void btLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvA.Columns.Clear();
                dgvB.Columns.Clear();
                dgvResultado.Columns.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Primero debe generar una matriz.");
            }
        }
        
        //Carga las matrices.

        private void btCargar_Click(object sender, EventArgs e)
        {
            try
            {
                int y = System.Convert.ToInt32(txtCsrp.Text);
                int x = System.Convert.ToInt32(txtFsrp.Text);
                dgvA.ColumnCount = y;
                dgvB.ColumnCount = y;
                dgvA.RowCount = x;
                dgvB.RowCount = x;
                dgvResultado.ColumnCount = y;
                dgvResultado.RowCount = x;
                dgvA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception)
            {
                MessageBox.Show("Debe poner algun valor.");
            }
        }

        private void btSumar_Click(object sender, EventArgs e)
        {
            sumarMatriz(true);
        }

        private void btRestar_Click(object sender, EventArgs e)
        {
            sumarMatriz(false);

        }

        //Metodo de sumar y restar matrices.
        private void sumarMatriz(bool Sumar)
        {
            try
            {
                int i, j;
                int fila, columna;
                fila = System.Convert.ToInt32(txtCsrp.Text);
                columna = System.Convert.ToInt32(txtFsrp.Text);

                for (i = 0; i < fila; i++)
                {
                    for (j = 0; j < columna; j++)
                    {
                        if (Sumar)
                            dgvResultado.Rows[i].Cells[j].Value = Convert.ToDouble(dgvA.Rows[i].Cells[j].Value) + Convert.ToDouble(dgvB.Rows[i].Cells[j].Value);
                        else dgvResultado.Rows[i].Cells[j].Value = Convert.ToDouble(dgvA.Rows[i].Cells[j].Value) - Convert.ToDouble(dgvB.Rows[i].Cells[j].Value);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede realizar.");
            }

           
        }

        private void btEscalar_Click(object sender, EventArgs e)
        {
            prodEscalar(true);
        }

        //Metodo para multiplicar matriz A con prod. escalar

        private void prodEscalar(bool multi)
        {

            try
            {
                int i, j;
                int fila, columna;
                int p = System.Convert.ToInt32(txtEscalar.Text);

                fila = System.Convert.ToInt32(txtFsrp.Text);
                columna = System.Convert.ToInt32(txtCsrp.Text);

                for (i = 0; i < fila; i++)
                {
                    for (j = 0; j < columna; j++)
                    {
                        dgvResultado.Rows[i].Cells[j].Value = Convert.ToDouble(dgvA.Rows[i].Cells[j].Value) * p;

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingresar numero para producto escalar.");
            }
        }

        private void btGenA_Click(object sender, EventArgs e)
        {
            try
            {
                int y = System.Convert.ToInt16(txtCA.Text);
                int x = System.Convert.ToInt16(txtFA.Text);
                dgvA.ColumnCount = y;
                dgvA.RowCount = x;
                dgvA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception)
            {
                MessageBox.Show("Ingresar número valido para matriz A.");
            }

        }

        private void btGenB_Click(object sender, EventArgs e)
        {
            try
            {
                int y = System.Convert.ToInt16(txtCB.Text);
                int x = System.Convert.ToInt16(txtFB.Text);
                int z = System.Convert.ToInt32(txtCA.Text);
                int p = System.Convert.ToInt32(txtFA.Text);
                if (z == x)
                {
                    dgvB.ColumnCount = y;
                    dgvB.RowCount = x;
                    dgvB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvResultado.ColumnCount = y;
                    dgvResultado.RowCount = p;
                    dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Ingresar numero valido para matriz B.");
            }

        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                int i, j;
            Decimal filaA, columnaB, result;

            filaA = System.Convert.ToDecimal(txtFA.Text);
            columnaB = System.Convert.ToDecimal(txtCB.Text);


            
                for (i = 0; i < filaA; i++)//recorre fila matriz resultado
                {
                    
                    for (j = 0; j < columnaB; j++)//recorre columna de matriz resultado
                    {
                        
                        dgvResultado.Rows[i].Cells[j].Value = 0;
                        for (int p = 0; p < filaA - 1; p++)
                        {

                            
                            dgvResultado.Rows[i].Cells[j].Value = Convert.ToDouble(dgvResultado.Rows[i].Cells[j].Value) + Convert.ToDouble(dgvA.Rows[i].Cells[p].Value) * Convert.ToDouble(dgvB.Rows[p].Cells[j].Value);
                        }
                    }
                }
            }


            catch (Exception )
            {
                MessageBox.Show("No se puede realizar.");
            }




        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btTranspuesta_Click(object sender, EventArgs e)
        {
            Transpuesta abrir = new Transpuesta();
            abrir.Show();
        }
    }
    
}



