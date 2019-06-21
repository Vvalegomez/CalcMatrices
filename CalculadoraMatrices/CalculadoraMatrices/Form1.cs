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
    public partial class Transpuesta : Form
    {

        private TextBox[,] Matriz1;
        private TextBox[,] Matriz2;
        private TextBox[,] MatrizResultante;
        private float determinante;

        int linha1, coluna1;
        int linha2, coluna2;

        private void btnCriarMatriz2_Click(object sender, EventArgs e)
        {
            groupBoxMatriz2.Controls.Clear();
            /*if (textBox2.Text == null)
            {
                MessageBox.Show("A linha da matriz 2 é nula.", "Erro");
                return;
            }

            if (textBox4.Text == null)
            {
                MessageBox.Show("A coluna da matriz 2 é nula.", "Erro");
                return;
            }
        linha2 = Convert.ToInt32(textBox2.Text);
        coluna2 = Convert.ToInt32(textBox4.Text);*/
            if (!int.TryParse(textBox2.Text, out linha2))
            {
                MessageBox.Show("Error");
                return;
            }
            if (!int.TryParse(textBox4.Text, out coluna2))
            {
                MessageBox.Show("Error");
                return;
            }
            int TamanhoText = groupBoxMatriz2.Width / coluna2;
            Matriz2 = new TextBox[linha2, coluna2];
            TamanhoText = groupBoxMatriz2.Width / coluna2;
            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    Matriz2[x, y] = new TextBox();
                    Matriz2[x, y].Text = "0";
                    Matriz2[x, y].Top = (x * Matriz2[x, y].Height) + 20;
                    Matriz2[x, y].Left = y * TamanhoText + 6;
                    Matriz2[x, y].Width = TamanhoText;
                    groupBoxMatriz2.Controls.Add(Matriz2[x, y]);
                }
            }
        }

        private void btnGerarTranspostM1_Click(object sender, EventArgs e)
        {
            if (Matriz1 == null)
            {
                MessageBox.Show("Error");
                return;
            }
            float[,] tempResultante = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];

            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz1[x, y].Text, out n);
                    tempResultante[x, y] = n;
                    //tempResultante[x, y] = Convert.ToInt32(Matriz1[x, y].Text);
                }
            }

            float[,] tempMatrizResultante = Program.GerarTransposta(tempResultante);
            int TamanhoText = groupBoxMatriz1.Width / Matriz1.GetLength(1);
            Matriz1 = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            groupBoxMatriz1.Controls.Clear();
            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    Matriz1[x, y] = new TextBox();
                    Matriz1[x, y].Text = tempMatrizResultante[x, y].ToString();
                    Matriz1[x, y].Top = (x * Matriz1[x, y].Height) + 20;
                    Matriz1[x, y].Left = y * TamanhoText + 6;
                    Matriz1[x, y].Width = TamanhoText;
                    groupBoxMatriz1.Controls.Add(Matriz1[x, y]);
                }
            }
        }

        private void btnGerarTranspostM2_Click(object sender, EventArgs e)
        {
            if (Matriz2 == null)
            {
                MessageBox.Show("Error");
                return;
            }
            float[,] tempResultante = new float[Matriz2.GetLength(0), Matriz2.GetLength(1)];

            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz2[x, y].Text, out n);
                    tempResultante[x, y] = n;
                    //tempResultante[x, y] = Convert.ToInt32(Matriz2[x, y].Text);
                }
            }

            float[,] tempMatrizResultante = Program.GerarTransposta(tempResultante);
            int TamanhoText = groupBoxMatriz2.Width / Matriz2.GetLength(1);
            Matriz2 = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            groupBoxMatriz2.Controls.Clear();
            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    Matriz2[x, y] = new TextBox();
                    Matriz2[x, y].Text = tempMatrizResultante[x, y].ToString();
                    Matriz2[x, y].Top = (x * Matriz2[x, y].Height) + 20;
                    Matriz2[x, y].Left = y * TamanhoText + 6;
                    Matriz2[x, y].Width = TamanhoText;
                    groupBoxMatriz2.Controls.Add(Matriz2[x, y]);
                }
            }
        }

        private void btnGerarTransposta_Click(object sender, EventArgs e)
        {
            if (MatrizResultante == null)
            {
                MessageBox.Show("Error");
                return;
            }
            float[,] tempResultante = new float[MatrizResultante.GetLength(0), MatrizResultante.GetLength(1)];

            for (int x = 0; x < MatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizResultante[x, y].Text, out n);
                    tempResultante[x, y] = n;
                    //tempResultante[x, y] = Convert.ToInt32(MatrizResultante[x, y].Text);
                }
            }

            float[,] tempMatrizResultante = Program.GerarTransposta(tempResultante);
            int TamanhoText = groupBoxMatrizResultante.Width / MatrizResultante.GetLength(1);
            MatrizResultante = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            groupBoxMatrizResultante.Controls.Clear();
            for (int x = 0; x < MatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                {
                    MatrizResultante[x, y] = new TextBox();
                    MatrizResultante[x, y].Text = tempMatrizResultante[x, y].ToString();
                    MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                    MatrizResultante[x, y].Left = y * TamanhoText + 6;
                    MatrizResultante[x, y].Width = TamanhoText;
                    groupBoxMatrizResultante.Controls.Add(MatrizResultante[x, y]);
                }
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (Matriz1 == null || Matriz2 == null)
            {
                MessageBox.Show("Error");
                return;
            }
            float[,] tempMatriz1 = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];
            float[,] tempMatriz2 = new float[Matriz2.GetLength(0), Matriz2.GetLength(1)];
            if (tempMatriz1.GetLength(0) != tempMatriz2.GetLength(0) || tempMatriz1.GetLength(1) != tempMatriz2.GetLength(1))
            {
                MessageBox.Show("Error");
                return;
            }

            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz1[x, y].Text, out n);
                    tempMatriz1[x, y] = n;
                    //tempMatriz1[x, y] = Convert.ToInt32(Matriz1[x, y].Text);
                }
            }
            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz2[x, y].Text, out n);
                    tempMatriz2[x, y] = n;
                    //tempMatriz2[x, y] = Convert.ToInt32(Matriz2[x, y].Text);
                }
            }

            float[,] tempMatrizResultante = Program.SomarMatrizes(tempMatriz1, tempMatriz2);
            MatrizResultante = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            int TamanhoText = groupBoxMatrizResultante.Width / MatrizResultante.GetLength(1);
            groupBoxMatrizResultante.Controls.Clear();
            for (int x = 0; x < MatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                {
                    MatrizResultante[x, y] = new TextBox();
                    MatrizResultante[x, y].Text = tempMatrizResultante[x, y].ToString();
                    MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                    MatrizResultante[x, y].Left = y * TamanhoText + 6;
                    MatrizResultante[x, y].Width = TamanhoText;
                    groupBoxMatrizResultante.Controls.Add(MatrizResultante[x, y]);
                }
            }
        }

        private void btnDiminuir_Click(object sender, EventArgs e)
        {
            if (Matriz1 == null || Matriz2 == null)
            {
                MessageBox.Show("Error");
                return;
            }
            float[,] tempMatriz1 = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];
            float[,] tempMatriz2 = new float[Matriz2.GetLength(0), Matriz2.GetLength(1)];
            if (tempMatriz1.GetLength(0) != tempMatriz2.GetLength(0) || tempMatriz1.GetLength(1) != tempMatriz2.GetLength(1))
            {
                MessageBox.Show("Error");
                return;
            }

            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz1[x, y].Text, out n);
                    tempMatriz1[x, y] = n;
                    //tempMatriz1[x, y] = Convert.ToInt32(Matriz1[x, y].Text);
                }
            }
            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz2[x, y].Text, out n);
                    tempMatriz2[x, y] = n;
                    //tempMatriz2[x, y] = Convert.ToInt32(Matriz2[x, y].Text);
                }
            }

            float[,] tempMatrizResultante = Program.SubtrairMatrizes(tempMatriz1, tempMatriz2);
            MatrizResultante = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            int TamanhoText = groupBoxMatrizResultante.Width / MatrizResultante.GetLength(1);
            groupBoxMatrizResultante.Controls.Clear();
            for (int x = 0; x < MatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                {
                    MatrizResultante[x, y] = new TextBox();
                    MatrizResultante[x, y].Text = tempMatrizResultante[x, y].ToString();
                    MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                    MatrizResultante[x, y].Left = y * TamanhoText + 6;
                    MatrizResultante[x, y].Width = TamanhoText;
                    groupBoxMatrizResultante.Controls.Add(MatrizResultante[x, y]);
                }
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (Matriz1 == null || Matriz2 == null)
            {
                MessageBox.Show("Error");
                return;
            }
            float[,] tempMatriz1 = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];
            float[,] tempMatriz2 = new float[Matriz2.GetLength(0), Matriz2.GetLength(1)];
            if (tempMatriz1.GetLength(1) != tempMatriz2.GetLength(0))
            {
                MessageBox.Show("Error");
                return;
            }

            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz1[x, y].Text, out n);
                    tempMatriz1[x, y] = n;
                    //tempMatriz1[x, y] = Convert.ToInt32(Matriz1[x, y].Text);
                }
            }
            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz2[x, y].Text, out n);
                    tempMatriz2[x, y] = n;
                    //tempMatriz2[x, y] = Convert.ToInt32(Matriz2[x, y].Text);
                }
            }

            float[,] tempMatrizResultante = Program.MultiplicarMatrizes(tempMatriz1, tempMatriz2);
            MatrizResultante = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            int TamanhoText = groupBoxMatrizResultante.Width / MatrizResultante.GetLength(1);
            groupBoxMatrizResultante.Controls.Clear();
            for (int x = 0; x < MatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                {
                    MatrizResultante[x, y] = new TextBox();
                    MatrizResultante[x, y].Text = tempMatrizResultante[x, y].ToString();
                    MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                    MatrizResultante[x, y].Left = y * TamanhoText + 6;
                    MatrizResultante[x, y].Width = TamanhoText;
                    groupBoxMatrizResultante.Controls.Add(MatrizResultante[x, y]);
                }
            }
        }

        public Transpuesta()
        {
            InitializeComponent();
        }

        private void btnCriarMatriz_Click(object sender, EventArgs e)
        {
            groupBoxMatriz1.Controls.Clear();

            /*if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("A linha da matriz 1 é nula.", "Erro");
                return;
            }
            if (textBox3.Text == null)
            {
                MessageBox.Show("A coluna da matriz 1 é nula.", "Erro");
                return;
            }
            linha1 = Convert.ToInt32(textBox1.Text);
            coluna1 = Convert.ToInt32(textBox3.Text);*/
            if (!int.TryParse(textBox1.Text, out linha1))
            {
                MessageBox.Show("Error");
                return;
            }
            if (!int.TryParse(textBox3.Text, out coluna1))
            {
                MessageBox.Show("Error");
                return;
            }

            Matriz1 = new TextBox[linha1, coluna1];
            int TamanhoText = groupBoxMatriz1.Width / coluna1;
            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    Matriz1[x, y] = new TextBox();
                    Matriz1[x, y].Text = "0";
                    Matriz1[x, y].Top = (x * Matriz1[x, y].Height) + 20;
                    Matriz1[x, y].Left = y * TamanhoText + 6;
                    Matriz1[x, y].Width = TamanhoText;
                    groupBoxMatriz1.Controls.Add(Matriz1[x, y]);
                }
            }
        }
    }
}
