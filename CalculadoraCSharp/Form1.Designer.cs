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
            this.multiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.sumar = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
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
            this.resultado = new System.Windows.Forms.Button();
            this.boton0 = new System.Windows.Forms.Button();
            this.botonMasMenos = new System.Windows.Forms.Button();
            this.puntoDecimal = new System.Windows.Forms.Button();
            this.displaySecundario = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.multiplicar, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.dividir, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.sumar, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.restar, 4, 4);
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
            this.tableLayoutPanel1.Controls.Add(this.resultado, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.boton0, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.botonMasMenos, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.puntoDecimal, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.displaySecundario, 0, 0);
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
            this.displayPrincipal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.displayPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.displayPrincipal, 5);
            this.displayPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPrincipal.Location = new System.Drawing.Point(3, 24);
            this.displayPrincipal.Name = "displayPrincipal";
            this.displayPrincipal.ReadOnly = true;
            this.displayPrincipal.Size = new System.Drawing.Size(307, 55);
            this.displayPrincipal.TabIndex = 21;
            this.displayPrincipal.Text = "0";
            this.displayPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // multiplicar
            // 
            this.multiplicar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.multiplicar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicar.Location = new System.Drawing.Point(189, 172);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(56, 76);
            this.multiplicar.TabIndex = 11;
            this.multiplicar.Text = "×";
            this.multiplicar.UseVisualStyleBackColor = false;
            // 
            // dividir
            // 
            this.dividir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dividir.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividir.Location = new System.Drawing.Point(251, 172);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(56, 76);
            this.dividir.TabIndex = 12;
            this.dividir.Text = "÷";
            this.dividir.UseVisualStyleBackColor = false;
            // 
            // sumar
            // 
            this.sumar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sumar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumar.Location = new System.Drawing.Point(189, 256);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(56, 76);
            this.sumar.TabIndex = 9;
            this.sumar.Text = "+";
            this.sumar.UseVisualStyleBackColor = false;
            // 
            // restar
            // 
            this.restar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.restar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restar.Location = new System.Drawing.Point(251, 256);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(56, 76);
            this.restar.TabIndex = 10;
            this.restar.Text = "-";
            this.restar.UseVisualStyleBackColor = false;
            // 
            // botonClearEntry
            // 
            this.botonClearEntry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.botonClearEntry.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonClearEntry.Location = new System.Drawing.Point(251, 88);
            this.botonClearEntry.Name = "botonClearEntry";
            this.botonClearEntry.Size = new System.Drawing.Size(56, 76);
            this.botonClearEntry.TabIndex = 16;
            this.botonClearEntry.Text = "CE";
            this.botonClearEntry.UseVisualStyleBackColor = false;
            // 
            // boton7
            // 
            this.boton7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.boton7.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton7.Location = new System.Drawing.Point(3, 88);
            this.boton7.Name = "boton7";
            this.boton7.Size = new System.Drawing.Size(56, 76);
            this.boton7.TabIndex = 1;
            this.boton7.Text = "7";
            this.boton7.UseVisualStyleBackColor = false;
            this.boton7.Click += new System.EventHandler(this.BotonNumerico);
            // 
            // boton8
            // 
            this.boton8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.boton8.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton8.Location = new System.Drawing.Point(65, 88);
            this.boton8.Name = "boton8";
            this.boton8.Size = new System.Drawing.Size(56, 76);
            this.boton8.TabIndex = 0;
            this.boton8.Text = "8";
            this.boton8.UseVisualStyleBackColor = false;
            this.boton8.Click += new System.EventHandler(this.BotonNumerico);
            // 
            // boton9
            // 
            this.boton9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.boton9.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton9.Location = new System.Drawing.Point(127, 88);
            this.boton9.Name = "boton9";
            this.boton9.Size = new System.Drawing.Size(56, 76);
            this.boton9.TabIndex = 2;
            this.boton9.Text = "9";
            this.boton9.UseVisualStyleBackColor = false;
            this.boton9.Click += new System.EventHandler(this.BotonNumerico);
            // 
            // boton4
            // 
            this.boton4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.boton4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton4.Location = new System.Drawing.Point(3, 172);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(56, 76);
            this.boton4.TabIndex = 3;
            this.boton4.Text = "4";
            this.boton4.UseVisualStyleBackColor = false;
            this.boton4.Click += new System.EventHandler(this.BotonNumerico);
            // 
            // boton5
            // 
            this.boton5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.boton5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton5.Location = new System.Drawing.Point(65, 172);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(56, 76);
            this.boton5.TabIndex = 4;
            this.boton5.Text = "5";
            this.boton5.UseVisualStyleBackColor = false;
            this.boton5.Click += new System.EventHandler(this.BotonNumerico);
            // 
            // boton6
            // 
            this.boton6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.boton6.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton6.Location = new System.Drawing.Point(127, 172);
            this.boton6.Name = "boton6";
            this.boton6.Size = new System.Drawing.Size(56, 76);
            this.boton6.TabIndex = 5;
            this.boton6.Text = "6";
            this.boton6.UseVisualStyleBackColor = false;
            this.boton6.Click += new System.EventHandler(this.BotonNumerico);
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.boton1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.Location = new System.Drawing.Point(3, 256);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(56, 76);
            this.boton1.TabIndex = 6;
            this.boton1.Text = "1";
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.BotonNumerico);
            // 
            // boton2
            // 
            this.boton2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.boton2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.Location = new System.Drawing.Point(65, 256);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(56, 76);
            this.boton2.TabIndex = 7;
            this.boton2.Text = "2";
            this.boton2.UseVisualStyleBackColor = false;
            this.boton2.Click += new System.EventHandler(this.BotonNumerico);
            // 
            // boton3
            // 
            this.boton3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.boton3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton3.Location = new System.Drawing.Point(127, 256);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(56, 76);
            this.boton3.TabIndex = 0;
            this.boton3.Text = "3";
            this.boton3.UseVisualStyleBackColor = false;
            this.boton3.Click += new System.EventHandler(this.BotonNumerico);
            // 
            // botonAllClear
            // 
            this.botonAllClear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.botonAllClear.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAllClear.Location = new System.Drawing.Point(189, 88);
            this.botonAllClear.Name = "botonAllClear";
            this.botonAllClear.Size = new System.Drawing.Size(56, 76);
            this.botonAllClear.TabIndex = 15;
            this.botonAllClear.Text = "AC";
            this.botonAllClear.UseVisualStyleBackColor = false;
            // 
            // resultado
            // 
            this.resultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tableLayoutPanel1.SetColumnSpan(this.resultado, 2);
            this.resultado.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(189, 340);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(118, 78);
            this.resultado.TabIndex = 17;
            this.resultado.Text = "=";
            this.resultado.UseVisualStyleBackColor = false;
            // 
            // boton0
            // 
            this.boton0.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.boton0.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton0.Location = new System.Drawing.Point(65, 340);
            this.boton0.Name = "boton0";
            this.boton0.Size = new System.Drawing.Size(56, 78);
            this.boton0.TabIndex = 19;
            this.boton0.Text = "0";
            this.boton0.UseVisualStyleBackColor = false;
            this.boton0.Click += new System.EventHandler(this.BotonNumerico);
            // 
            // botonMasMenos
            // 
            this.botonMasMenos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.botonMasMenos.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMasMenos.Location = new System.Drawing.Point(3, 340);
            this.botonMasMenos.Name = "botonMasMenos";
            this.botonMasMenos.Size = new System.Drawing.Size(56, 78);
            this.botonMasMenos.TabIndex = 18;
            this.botonMasMenos.Text = "±";
            this.botonMasMenos.UseVisualStyleBackColor = false;
            // 
            // puntoDecimal
            // 
            this.puntoDecimal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.puntoDecimal.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntoDecimal.Location = new System.Drawing.Point(127, 340);
            this.puntoDecimal.Name = "puntoDecimal";
            this.puntoDecimal.Size = new System.Drawing.Size(56, 78);
            this.puntoDecimal.TabIndex = 13;
            this.puntoDecimal.Text = ".";
            this.puntoDecimal.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button puntoDecimal;
        private System.Windows.Forms.Button botonAllClear;
        private System.Windows.Forms.Button botonClearEntry;
        private System.Windows.Forms.Button resultado;
        private System.Windows.Forms.Button boton0;
        private System.Windows.Forms.Button botonMasMenos;
        private System.Windows.Forms.TextBox displayPrincipal;
        private System.Windows.Forms.TextBox displaySecundario;
    }
}

