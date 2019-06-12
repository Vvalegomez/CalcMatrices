namespace CalculadoraMatrices
{
    partial class CalculadoraMatrices
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvA = new System.Windows.Forms.DataGridView();
            this.dgvB = new System.Windows.Forms.DataGridView();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.txtCA = new System.Windows.Forms.TextBox();
            this.txtCB = new System.Windows.Forms.TextBox();
            this.btGenA = new System.Windows.Forms.Button();
            this.btGenB = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFA = new System.Windows.Forms.TextBox();
            this.txtFB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btSumar = new System.Windows.Forms.Button();
            this.btRestar = new System.Windows.Forms.Button();
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btEscalar = new System.Windows.Forms.Button();
            this.txtEscalar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFsrp = new System.Windows.Forms.TextBox();
            this.txtCsrp = new System.Windows.Forms.TextBox();
            this.btCargar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvA
            // 
            this.dgvA.AllowUserToAddRows = false;
            this.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA.Location = new System.Drawing.Point(12, 132);
            this.dgvA.Name = "dgvA";
            this.dgvA.Size = new System.Drawing.Size(240, 150);
            this.dgvA.TabIndex = 0;
            // 
            // dgvB
            // 
            this.dgvB.AllowUserToAddRows = false;
            this.dgvB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvB.Location = new System.Drawing.Point(280, 132);
            this.dgvB.Name = "dgvB";
            this.dgvB.Size = new System.Drawing.Size(240, 150);
            this.dgvB.TabIndex = 1;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(548, 132);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(240, 150);
            this.dgvResultado.TabIndex = 2;
            // 
            // txtCA
            // 
            this.txtCA.Location = new System.Drawing.Point(12, 381);
            this.txtCA.Name = "txtCA";
            this.txtCA.Size = new System.Drawing.Size(100, 20);
            this.txtCA.TabIndex = 3;
            // 
            // txtCB
            // 
            this.txtCB.Location = new System.Drawing.Point(140, 381);
            this.txtCB.Name = "txtCB";
            this.txtCB.Size = new System.Drawing.Size(100, 20);
            this.txtCB.TabIndex = 4;
            // 
            // btGenA
            // 
            this.btGenA.Location = new System.Drawing.Point(12, 407);
            this.btGenA.Name = "btGenA";
            this.btGenA.Size = new System.Drawing.Size(100, 23);
            this.btGenA.TabIndex = 5;
            this.btGenA.Text = "Generar matriz A";
            this.btGenA.UseVisualStyleBackColor = true;
            this.btGenA.Click += new System.EventHandler(this.btGenA_Click);
            // 
            // btGenB
            // 
            this.btGenB.Location = new System.Drawing.Point(140, 407);
            this.btGenB.Name = "btGenB";
            this.btGenB.Size = new System.Drawing.Size(100, 23);
            this.btGenB.TabIndex = 6;
            this.btGenB.Text = "Generar matriz B";
            this.btGenB.UseVisualStyleBackColor = true;
            this.btGenB.Click += new System.EventHandler(this.btGenB_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(545, 108);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fila A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fila B";
            // 
            // txtFA
            // 
            this.txtFA.Location = new System.Drawing.Point(12, 334);
            this.txtFA.Name = "txtFA";
            this.txtFA.Size = new System.Drawing.Size(100, 20);
            this.txtFA.TabIndex = 10;
            // 
            // txtFB
            // 
            this.txtFB.Location = new System.Drawing.Point(140, 334);
            this.txtFB.Name = "txtFB";
            this.txtFB.Size = new System.Drawing.Size(100, 20);
            this.txtFB.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Columna A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Columna B";
            // 
            // btSumar
            // 
            this.btSumar.Location = new System.Drawing.Point(550, 18);
            this.btSumar.Name = "btSumar";
            this.btSumar.Size = new System.Drawing.Size(75, 23);
            this.btSumar.TabIndex = 14;
            this.btSumar.Text = "Sumar";
            this.btSumar.UseVisualStyleBackColor = true;
            this.btSumar.Click += new System.EventHandler(this.btSumar_Click);
            // 
            // btRestar
            // 
            this.btRestar.Location = new System.Drawing.Point(550, 61);
            this.btRestar.Name = "btRestar";
            this.btRestar.Size = new System.Drawing.Size(75, 23);
            this.btRestar.TabIndex = 15;
            this.btRestar.Text = "Restar";
            this.btRestar.UseVisualStyleBackColor = true;
            this.btRestar.Click += new System.EventHandler(this.btRestar_Click);
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.Location = new System.Drawing.Point(280, 407);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(105, 23);
            this.btMultiplicar.TabIndex = 16;
            this.btMultiplicar.Text = "Multiplicar matrices";
            this.btMultiplicar.UseVisualStyleBackColor = true;
            this.btMultiplicar.Click += new System.EventHandler(this.btMultiplicar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(465, 399);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(119, 31);
            this.btLimpiar.TabIndex = 17;
            this.btLimpiar.Text = "Limpiar matrices";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btEscalar
            // 
            this.btEscalar.Location = new System.Drawing.Point(687, 24);
            this.btEscalar.Name = "btEscalar";
            this.btEscalar.Size = new System.Drawing.Size(90, 23);
            this.btEscalar.TabIndex = 18;
            this.btEscalar.Text = "Prod. Escalar";
            this.btEscalar.UseVisualStyleBackColor = true;
            this.btEscalar.Click += new System.EventHandler(this.btEscalar_Click);
            // 
            // txtEscalar
            // 
            this.txtEscalar.Location = new System.Drawing.Point(687, 54);
            this.txtEscalar.Name = "txtEscalar";
            this.txtEscalar.Size = new System.Drawing.Size(90, 20);
            this.txtEscalar.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Filas(A/B) para sumar/restar/prod. escalar.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Columnas (A/B) para sumar/restar/prod. escalar.";
            // 
            // txtFsrp
            // 
            this.txtFsrp.Location = new System.Drawing.Point(18, 30);
            this.txtFsrp.Name = "txtFsrp";
            this.txtFsrp.Size = new System.Drawing.Size(100, 20);
            this.txtFsrp.TabIndex = 22;
            // 
            // txtCsrp
            // 
            this.txtCsrp.Location = new System.Drawing.Point(15, 86);
            this.txtCsrp.Name = "txtCsrp";
            this.txtCsrp.Size = new System.Drawing.Size(100, 20);
            this.txtCsrp.TabIndex = 23;
            // 
            // btCargar
            // 
            this.btCargar.Location = new System.Drawing.Point(238, 30);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(75, 23);
            this.btCargar.TabIndex = 24;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(635, 399);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(111, 31);
            this.btSalir.TabIndex = 25;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // CalculadoraMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btCargar);
            this.Controls.Add(this.txtCsrp);
            this.Controls.Add(this.txtFsrp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEscalar);
            this.Controls.Add(this.btEscalar);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btMultiplicar);
            this.Controls.Add(this.btRestar);
            this.Controls.Add(this.btSumar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFB);
            this.Controls.Add(this.txtFA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btGenB);
            this.Controls.Add(this.btGenA);
            this.Controls.Add(this.txtCB);
            this.Controls.Add(this.txtCA);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.dgvB);
            this.Controls.Add(this.dgvA);
            this.Name = "CalculadoraMatrices";
            this.Text = " Calculadora de matrices.";
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvA;
        private System.Windows.Forms.DataGridView dgvB;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.TextBox txtCA;
        private System.Windows.Forms.TextBox txtCB;
        private System.Windows.Forms.Button btGenA;
        private System.Windows.Forms.Button btGenB;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFA;
        private System.Windows.Forms.TextBox txtFB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSumar;
        private System.Windows.Forms.Button btRestar;
        private System.Windows.Forms.Button btMultiplicar;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btEscalar;
        private System.Windows.Forms.TextBox txtEscalar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFsrp;
        private System.Windows.Forms.TextBox txtCsrp;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Button btSalir;
    }
}

