namespace CalculadoraMatrices
{
    partial class Transpuesta
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
            this.btnCriarMatriz = new System.Windows.Forms.Button();
            this.btnCriarMatriz2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxMatrizResultante = new System.Windows.Forms.GroupBox();
            this.groupBoxMatriz2 = new System.Windows.Forms.GroupBox();
            this.groupBoxMatriz1 = new System.Windows.Forms.GroupBox();
            this.btnGerarTranspostM1 = new System.Windows.Forms.Button();
            this.btnGerarTranspostM2 = new System.Windows.Forms.Button();
            this.btnGerarTransposta = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnDiminuir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCriarMatriz
            // 
            this.btnCriarMatriz.Location = new System.Drawing.Point(265, 28);
            this.btnCriarMatriz.Name = "btnCriarMatriz";
            this.btnCriarMatriz.Size = new System.Drawing.Size(75, 23);
            this.btnCriarMatriz.TabIndex = 0;
            this.btnCriarMatriz.Text = "Matriz 1";
            this.btnCriarMatriz.UseVisualStyleBackColor = true;
            this.btnCriarMatriz.Click += new System.EventHandler(this.btnCriarMatriz_Click);
            // 
            // btnCriarMatriz2
            // 
            this.btnCriarMatriz2.Location = new System.Drawing.Point(265, 61);
            this.btnCriarMatriz2.Name = "btnCriarMatriz2";
            this.btnCriarMatriz2.Size = new System.Drawing.Size(75, 23);
            this.btnCriarMatriz2.TabIndex = 1;
            this.btnCriarMatriz2.Text = "Matriz 2";
            this.btnCriarMatriz2.UseVisualStyleBackColor = true;
            this.btnCriarMatriz2.Click += new System.EventHandler(this.btnCriarMatriz2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(134, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(134, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxMatrizResultante);
            this.groupBox1.Controls.Add(this.groupBoxMatriz2);
            this.groupBox1.Controls.Add(this.groupBoxMatriz1);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1003, 337);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxMatrizResultante
            // 
            this.groupBoxMatrizResultante.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxMatrizResultante.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBoxMatrizResultante.Location = new System.Drawing.Point(666, 16);
            this.groupBoxMatrizResultante.Name = "groupBoxMatrizResultante";
            this.groupBoxMatrizResultante.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxMatrizResultante.Size = new System.Drawing.Size(313, 318);
            this.groupBoxMatrizResultante.TabIndex = 2;
            this.groupBoxMatrizResultante.TabStop = false;
            this.groupBoxMatrizResultante.Text = "Resultado";
            // 
            // groupBoxMatriz2
            // 
            this.groupBoxMatriz2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxMatriz2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBoxMatriz2.Location = new System.Drawing.Point(328, 16);
            this.groupBoxMatriz2.Name = "groupBoxMatriz2";
            this.groupBoxMatriz2.Size = new System.Drawing.Size(338, 318);
            this.groupBoxMatriz2.TabIndex = 1;
            this.groupBoxMatriz2.TabStop = false;
            this.groupBoxMatriz2.Text = "Matriz2";
            // 
            // groupBoxMatriz1
            // 
            this.groupBoxMatriz1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxMatriz1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBoxMatriz1.Location = new System.Drawing.Point(3, 16);
            this.groupBoxMatriz1.Name = "groupBoxMatriz1";
            this.groupBoxMatriz1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxMatriz1.Size = new System.Drawing.Size(325, 318);
            this.groupBoxMatriz1.TabIndex = 0;
            this.groupBoxMatriz1.TabStop = false;
            this.groupBoxMatriz1.Text = "Matriz1";
            // 
            // btnGerarTranspostM1
            // 
            this.btnGerarTranspostM1.Location = new System.Drawing.Point(134, 448);
            this.btnGerarTranspostM1.Name = "btnGerarTranspostM1";
            this.btnGerarTranspostM1.Size = new System.Drawing.Size(75, 23);
            this.btnGerarTranspostM1.TabIndex = 7;
            this.btnGerarTranspostM1.Text = "Transpuesta";
            this.btnGerarTranspostM1.UseVisualStyleBackColor = true;
            this.btnGerarTranspostM1.Click += new System.EventHandler(this.btnGerarTranspostM1_Click);
            // 
            // btnGerarTranspostM2
            // 
            this.btnGerarTranspostM2.Location = new System.Drawing.Point(490, 448);
            this.btnGerarTranspostM2.Name = "btnGerarTranspostM2";
            this.btnGerarTranspostM2.Size = new System.Drawing.Size(75, 23);
            this.btnGerarTranspostM2.TabIndex = 8;
            this.btnGerarTranspostM2.Text = "Transpuesta";
            this.btnGerarTranspostM2.UseVisualStyleBackColor = true;
            this.btnGerarTranspostM2.Click += new System.EventHandler(this.btnGerarTranspostM2_Click);
            // 
            // btnGerarTransposta
            // 
            this.btnGerarTransposta.Location = new System.Drawing.Point(817, 448);
            this.btnGerarTransposta.Name = "btnGerarTransposta";
            this.btnGerarTransposta.Size = new System.Drawing.Size(75, 23);
            this.btnGerarTransposta.TabIndex = 9;
            this.btnGerarTransposta.Text = "Transpuesta";
            this.btnGerarTransposta.UseVisualStyleBackColor = true;
            this.btnGerarTransposta.Click += new System.EventHandler(this.btnGerarTransposta_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(449, 11);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 10;
            this.btnSomar.Text = "Sumar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnDiminuir
            // 
            this.btnDiminuir.Location = new System.Drawing.Point(449, 45);
            this.btnDiminuir.Name = "btnDiminuir";
            this.btnDiminuir.Size = new System.Drawing.Size(75, 23);
            this.btnDiminuir.TabIndex = 11;
            this.btnDiminuir.Text = "Restar";
            this.btnDiminuir.UseVisualStyleBackColor = true;
            this.btnDiminuir.Click += new System.EventHandler(this.btnDiminuir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(560, 11);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 12;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Columna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fila";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Columna";
            // 
            // Transpuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 496);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDiminuir);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnGerarTransposta);
            this.Controls.Add(this.btnGerarTranspostM2);
            this.Controls.Add(this.btnGerarTranspostM1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCriarMatriz2);
            this.Controls.Add(this.btnCriarMatriz);
            this.Name = "Transpuesta";
            this.Text = "Transpuesta";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarMatriz;
        private System.Windows.Forms.Button btnCriarMatriz2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxMatrizResultante;
        private System.Windows.Forms.GroupBox groupBoxMatriz2;
        private System.Windows.Forms.Button btnGerarTranspostM1;
        private System.Windows.Forms.Button btnGerarTranspostM2;
        private System.Windows.Forms.Button btnGerarTransposta;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnDiminuir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.GroupBox groupBoxMatriz1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}