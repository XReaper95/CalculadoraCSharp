namespace CalculadoraCSharp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.displayPrincipal = new System.Windows.Forms.TextBox();
            this.botonMultiplicar = new System.Windows.Forms.Button();
            this.BotonDividir = new System.Windows.Forms.Button();
            this.botonSumar = new System.Windows.Forms.Button();
            this.botonRestar = new System.Windows.Forms.Button();
            this.botonClearEntry = new System.Windows.Forms.Button();
            this.boton7 = new System.Windows.Forms.Button();
            this.boton8 = new System.Windows.Forms.Button();
            this.boton9 = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.boton5 = new System.Windows.Forms.Button();
            this.boton6 = new System.Windows.Forms.Button();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.botonAllClear = new System.Windows.Forms.Button();
            this.boton0 = new System.Windows.Forms.Button();
            this.botonMasMenos = new System.Windows.Forms.Button();
            this.botonPuntoDecimal = new System.Windows.Forms.Button();
            this.displaySecundario = new System.Windows.Forms.TextBox();
            this.botonResultadoOperacion = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.displayPrincipal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.botonMultiplicar, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.BotonDividir, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.botonSumar, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.botonRestar, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.botonClearEntry, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.boton7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.boton8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.boton9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.boton4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.boton5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.boton6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.boton1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.boton2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.boton3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.botonAllClear, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.boton0, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.botonMasMenos, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.botonPuntoDecimal, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.displaySecundario, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.botonResultadoOperacion, 3, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.087615F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.26285F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.91239F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.91239F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.91239F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.91239F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(313, 424);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // displayPrincipal
            // 
            this.displayPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.displayPrincipal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.displayPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.displayPrincipal, 5);
            this.displayPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPrincipal.Location = new System.Drawing.Point(3, 25);
            this.displayPrincipal.Name = "displayPrincipal";
            this.displayPrincipal.ReadOnly = true;
            this.displayPrincipal.Size = new System.Drawing.Size(307, 55);
            this.displayPrincipal.TabIndex = 21;
            this.displayPrincipal.Text = "0";
            this.displayPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // botonMultiplicar
            // 
            this.botonMultiplicar.BackColor = System.Drawing.Color.MistyRose;
            this.botonMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMultiplicar.Location = new System.Drawing.Point(189, 172);
            this.botonMultiplicar.Name = "botonMultiplicar";
            this.botonMultiplicar.Size = new System.Drawing.Size(56, 76);
            this.botonMultiplicar.TabIndex = 11;
            this.botonMultiplicar.Tag = "multiplica";
            this.botonMultiplicar.Text = "×";
            this.botonMultiplicar.UseVisualStyleBackColor = false;
            this.botonMultiplicar.Click += new System.EventHandler(this.BotonOperacion_Click);
            // 
            // BotonDividir
            // 
            this.BotonDividir.BackColor = System.Drawing.Color.MistyRose;
            this.BotonDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonDividir.Location = new System.Drawing.Point(251, 172);
            this.BotonDividir.Name = "BotonDividir";
            this.BotonDividir.Size = new System.Drawing.Size(56, 76);
            this.BotonDividir.TabIndex = 12;
            this.BotonDividir.Tag = "divide";
            this.BotonDividir.Text = "÷";
            this.BotonDividir.UseVisualStyleBackColor = false;
            this.BotonDividir.Click += new System.EventHandler(this.BotonOperacion_Click);
            // 
            // botonSumar
            // 
            this.botonSumar.BackColor = System.Drawing.Color.MistyRose;
            this.botonSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSumar.Location = new System.Drawing.Point(189, 256);
            this.botonSumar.Name = "botonSumar";
            this.botonSumar.Size = new System.Drawing.Size(56, 76);
            this.botonSumar.TabIndex = 9;
            this.botonSumar.Tag = "suma";
            this.botonSumar.Text = "+";
            this.botonSumar.UseVisualStyleBackColor = false;
            this.botonSumar.Click += new System.EventHandler(this.BotonOperacion_Click);
            // 
            // botonRestar
            // 
            this.botonRestar.BackColor = System.Drawing.Color.MistyRose;
            this.botonRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRestar.Location = new System.Drawing.Point(251, 256);
            this.botonRestar.Name = "botonRestar";
            this.botonRestar.Size = new System.Drawing.Size(56, 76);
            this.botonRestar.TabIndex = 10;
            this.botonRestar.Tag = "resta";
            this.botonRestar.Text = "-";
            this.botonRestar.UseVisualStyleBackColor = false;
            this.botonRestar.Click += new System.EventHandler(this.BotonOperacion_Click);
            // 
            // botonClearEntry
            // 
            this.botonClearEntry.BackColor = System.Drawing.Color.MistyRose;
            this.botonClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonClearEntry.Location = new System.Drawing.Point(251, 88);
            this.botonClearEntry.Name = "botonClearEntry";
            this.botonClearEntry.Size = new System.Drawing.Size(56, 76);
            this.botonClearEntry.TabIndex = 16;
            this.botonClearEntry.Text = "CE";
            this.botonClearEntry.UseVisualStyleBackColor = false;
            this.botonClearEntry.Click += new System.EventHandler(this.BotonClearEntry_Click);
            // 
            // boton7
            // 
            this.boton7.BackColor = System.Drawing.Color.MistyRose;
            this.boton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton7.Location = new System.Drawing.Point(3, 88);
            this.boton7.Name = "boton7";
            this.boton7.Size = new System.Drawing.Size(56, 76);
            this.boton7.TabIndex = 1;
            this.boton7.Text = "7";
            this.boton7.UseVisualStyleBackColor = false;
            this.boton7.Click += new System.EventHandler(this.BotonNumerico_Click);
            // 
            // boton8
            // 
            this.boton8.BackColor = System.Drawing.Color.MistyRose;
            this.boton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton8.Location = new System.Drawing.Point(65, 88);
            this.boton8.Name = "boton8";
            this.boton8.Size = new System.Drawing.Size(56, 76);
            this.boton8.TabIndex = 0;
            this.boton8.Text = "8";
            this.boton8.UseVisualStyleBackColor = false;
            this.boton8.Click += new System.EventHandler(this.BotonNumerico_Click);
            // 
            // boton9
            // 
            this.boton9.BackColor = System.Drawing.Color.MistyRose;
            this.boton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton9.Location = new System.Drawing.Point(127, 88);
            this.boton9.Name = "boton9";
            this.boton9.Size = new System.Drawing.Size(56, 76);
            this.boton9.TabIndex = 2;
            this.boton9.Text = "9";
            this.boton9.UseVisualStyleBackColor = false;
            this.boton9.Click += new System.EventHandler(this.BotonNumerico_Click);
            // 
            // boton4
            // 
            this.boton4.BackColor = System.Drawing.Color.MistyRose;
            this.boton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton4.Location = new System.Drawing.Point(3, 172);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(56, 76);
            this.boton4.TabIndex = 3;
            this.boton4.Text = "4";
            this.boton4.UseVisualStyleBackColor = false;
            this.boton4.Click += new System.EventHandler(this.BotonNumerico_Click);
            // 
            // boton5
            // 
            this.boton5.BackColor = System.Drawing.Color.MistyRose;
            this.boton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton5.Location = new System.Drawing.Point(65, 172);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(56, 76);
            this.boton5.TabIndex = 4;
            this.boton5.Text = "5";
            this.boton5.UseVisualStyleBackColor = false;
            this.boton5.Click += new System.EventHandler(this.BotonNumerico_Click);
            // 
            // boton6
            // 
            this.boton6.BackColor = System.Drawing.Color.MistyRose;
            this.boton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton6.Location = new System.Drawing.Point(127, 172);
            this.boton6.Name = "boton6";
            this.boton6.Size = new System.Drawing.Size(56, 76);
            this.boton6.TabIndex = 5;
            this.boton6.Text = "6";
            this.boton6.UseVisualStyleBackColor = false;
            this.boton6.Click += new System.EventHandler(this.BotonNumerico_Click);
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.Color.MistyRose;
            this.boton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.Location = new System.Drawing.Point(3, 256);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(56, 76);
            this.boton1.TabIndex = 6;
            this.boton1.Text = "1";
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.BotonNumerico_Click);
            // 
            // boton2
            // 
            this.boton2.BackColor = System.Drawing.Color.MistyRose;
            this.boton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.Location = new System.Drawing.Point(65, 256);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(56, 76);
            this.boton2.TabIndex = 7;
            this.boton2.Text = "2";
            this.boton2.UseVisualStyleBackColor = false;
            this.boton2.Click += new System.EventHandler(this.BotonNumerico_Click);
            // 
            // boton3
            // 
            this.boton3.BackColor = System.Drawing.Color.MistyRose;
            this.boton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton3.Location = new System.Drawing.Point(127, 256);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(56, 76);
            this.boton3.TabIndex = 0;
            this.boton3.Text = "3";
            this.boton3.UseVisualStyleBackColor = false;
            this.boton3.Click += new System.EventHandler(this.BotonNumerico_Click);
            // 
            // botonAllClear
            // 
            this.botonAllClear.BackColor = System.Drawing.Color.MistyRose;
            this.botonAllClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAllClear.Location = new System.Drawing.Point(189, 88);
            this.botonAllClear.Name = "botonAllClear";
            this.botonAllClear.Size = new System.Drawing.Size(56, 76);
            this.botonAllClear.TabIndex = 15;
            this.botonAllClear.Text = "AC";
            this.botonAllClear.UseVisualStyleBackColor = false;
            this.botonAllClear.Click += new System.EventHandler(this.BotonAllClear_Click);
            // 
            // boton0
            // 
            this.boton0.BackColor = System.Drawing.Color.MistyRose;
            this.boton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton0.Location = new System.Drawing.Point(65, 340);
            this.boton0.Name = "boton0";
            this.boton0.Size = new System.Drawing.Size(56, 78);
            this.boton0.TabIndex = 19;
            this.boton0.Text = "0";
            this.boton0.UseVisualStyleBackColor = false;
            this.boton0.Click += new System.EventHandler(this.BotonNumerico_Click);
            // 
            // botonMasMenos
            // 
            this.botonMasMenos.BackColor = System.Drawing.Color.MistyRose;
            this.botonMasMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMasMenos.Location = new System.Drawing.Point(3, 340);
            this.botonMasMenos.Name = "botonMasMenos";
            this.botonMasMenos.Size = new System.Drawing.Size(56, 78);
            this.botonMasMenos.TabIndex = 18;
            this.botonMasMenos.Text = "±";
            this.botonMasMenos.UseVisualStyleBackColor = false;
            this.botonMasMenos.Click += new System.EventHandler(this.BotonMasMenos_Click);
            // 
            // botonPuntoDecimal
            // 
            this.botonPuntoDecimal.BackColor = System.Drawing.Color.MistyRose;
            this.botonPuntoDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPuntoDecimal.Location = new System.Drawing.Point(127, 340);
            this.botonPuntoDecimal.Name = "botonPuntoDecimal";
            this.botonPuntoDecimal.Size = new System.Drawing.Size(56, 78);
            this.botonPuntoDecimal.TabIndex = 13;
            this.botonPuntoDecimal.Text = ".";
            this.botonPuntoDecimal.UseVisualStyleBackColor = false;
            this.botonPuntoDecimal.Click += new System.EventHandler(this.BotonPuntoDecimal_Click);
            // 
            // displaySecundario
            // 
            this.displaySecundario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.displaySecundario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.displaySecundario, 5);
            this.displaySecundario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaySecundario.Location = new System.Drawing.Point(3, 3);
            this.displaySecundario.Name = "displaySecundario";
            this.displaySecundario.ReadOnly = true;
            this.displaySecundario.Size = new System.Drawing.Size(307, 22);
            this.displaySecundario.TabIndex = 20;
            this.displaySecundario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // botonResultadoOperacion
            // 
            this.botonResultadoOperacion.BackColor = System.Drawing.Color.MistyRose;
            this.tableLayoutPanel1.SetColumnSpan(this.botonResultadoOperacion, 2);
            this.botonResultadoOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonResultadoOperacion.Location = new System.Drawing.Point(189, 340);
            this.botonResultadoOperacion.Name = "botonResultadoOperacion";
            this.botonResultadoOperacion.Size = new System.Drawing.Size(118, 76);
            this.botonResultadoOperacion.TabIndex = 22;
            this.botonResultadoOperacion.Text = "=";
            this.botonResultadoOperacion.UseVisualStyleBackColor = false;
            this.botonResultadoOperacion.Click += new System.EventHandler(this.BotonResultadoOperacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(313, 424);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiCalculadora";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button boton8;
        private System.Windows.Forms.Button boton7;
        private System.Windows.Forms.Button boton9;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button boton5;
        private System.Windows.Forms.Button boton6;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Button botonSumar;
        private System.Windows.Forms.Button botonRestar;
        private System.Windows.Forms.Button botonMultiplicar;
        private System.Windows.Forms.Button BotonDividir;
        private System.Windows.Forms.Button botonPuntoDecimal;
        private System.Windows.Forms.Button botonAllClear;
        private System.Windows.Forms.Button botonClearEntry;
        private System.Windows.Forms.Button boton0;
        private System.Windows.Forms.Button botonMasMenos;
        private System.Windows.Forms.TextBox displayPrincipal;
        private System.Windows.Forms.TextBox displaySecundario;
        private System.Windows.Forms.Button botonResultadoOperacion;
    }
}

