namespace EstadosWindowsForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.cboNorte = new System.Windows.Forms.ComboBox();
            this.cboNordeste = new System.Windows.Forms.ComboBox();
            this.cboCentro = new System.Windows.Forms.ComboBox();
            this.cboSudeste = new System.Windows.Forms.ComboBox();
            this.cboSul = new System.Windows.Forms.ComboBox();
            this.btnEstados = new System.Windows.Forms.Button();
            this.btnNorte = new System.Windows.Forms.Button();
            this.btnNordeste = new System.Windows.Forms.Button();
            this.btnCentro = new System.Windows.Forms.Button();
            this.btnSudeste = new System.Windows.Forms.Button();
            this.btnSul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todos os estados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Região Norte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Região Nordeste:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Região Centro-Oeste:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Região Sudeste:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(144, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Região Sul:";
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Items.AddRange(new object[] {
            "AC",
            "",
            "AL",
            "",
            "AM",
            "",
            "AP",
            "",
            "BA",
            "",
            "CE",
            "",
            "DF",
            "",
            "ES",
            "",
            "GO",
            "",
            "MA",
            "",
            "MG",
            "",
            "MS",
            "",
            "MT",
            "",
            "PA",
            "",
            "PB",
            "",
            "PE",
            "",
            "PI",
            "",
            "PR",
            "",
            "RJ",
            "",
            "RN",
            "",
            "RO",
            "",
            "RR",
            "",
            "RS",
            "",
            "SC",
            "",
            "SE",
            "",
            "SP",
            "",
            "TO",
            "",
            "",
            ""});
            this.cboEstados.Location = new System.Drawing.Point(269, 67);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(263, 21);
            this.cboEstados.TabIndex = 6;
            // 
            // cboNorte
            // 
            this.cboNorte.FormattingEnabled = true;
            this.cboNorte.Location = new System.Drawing.Point(269, 133);
            this.cboNorte.Name = "cboNorte";
            this.cboNorte.Size = new System.Drawing.Size(263, 21);
            this.cboNorte.TabIndex = 7;
            // 
            // cboNordeste
            // 
            this.cboNordeste.FormattingEnabled = true;
            this.cboNordeste.Location = new System.Drawing.Point(269, 201);
            this.cboNordeste.Name = "cboNordeste";
            this.cboNordeste.Size = new System.Drawing.Size(263, 21);
            this.cboNordeste.TabIndex = 8;
            // 
            // cboCentro
            // 
            this.cboCentro.FormattingEnabled = true;
            this.cboCentro.Location = new System.Drawing.Point(269, 275);
            this.cboCentro.Name = "cboCentro";
            this.cboCentro.Size = new System.Drawing.Size(263, 21);
            this.cboCentro.TabIndex = 9;
            // 
            // cboSudeste
            // 
            this.cboSudeste.FormattingEnabled = true;
            this.cboSudeste.Location = new System.Drawing.Point(269, 341);
            this.cboSudeste.Name = "cboSudeste";
            this.cboSudeste.Size = new System.Drawing.Size(263, 21);
            this.cboSudeste.TabIndex = 10;
            // 
            // cboSul
            // 
            this.cboSul.FormattingEnabled = true;
            this.cboSul.Location = new System.Drawing.Point(269, 411);
            this.cboSul.Name = "cboSul";
            this.cboSul.Size = new System.Drawing.Size(263, 21);
            this.cboSul.TabIndex = 11;
            // 
            // btnEstados
            // 
            this.btnEstados.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstados.Location = new System.Drawing.Point(586, 65);
            this.btnEstados.Name = "btnEstados";
            this.btnEstados.Size = new System.Drawing.Size(45, 23);
            this.btnEstados.TabIndex = 12;
            this.btnEstados.Text = "-";
            this.btnEstados.UseVisualStyleBackColor = true;
            // 
            // btnNorte
            // 
            this.btnNorte.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNorte.Location = new System.Drawing.Point(586, 134);
            this.btnNorte.Name = "btnNorte";
            this.btnNorte.Size = new System.Drawing.Size(45, 23);
            this.btnNorte.TabIndex = 13;
            this.btnNorte.Text = "-";
            this.btnNorte.UseVisualStyleBackColor = true;
            // 
            // btnNordeste
            // 
            this.btnNordeste.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNordeste.Location = new System.Drawing.Point(586, 199);
            this.btnNordeste.Name = "btnNordeste";
            this.btnNordeste.Size = new System.Drawing.Size(45, 23);
            this.btnNordeste.TabIndex = 14;
            this.btnNordeste.Text = "-";
            this.btnNordeste.UseVisualStyleBackColor = true;
            // 
            // btnCentro
            // 
            this.btnCentro.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCentro.Location = new System.Drawing.Point(586, 273);
            this.btnCentro.Name = "btnCentro";
            this.btnCentro.Size = new System.Drawing.Size(45, 23);
            this.btnCentro.TabIndex = 15;
            this.btnCentro.Text = "-";
            this.btnCentro.UseVisualStyleBackColor = true;
            // 
            // btnSudeste
            // 
            this.btnSudeste.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSudeste.Location = new System.Drawing.Point(586, 339);
            this.btnSudeste.Name = "btnSudeste";
            this.btnSudeste.Size = new System.Drawing.Size(45, 23);
            this.btnSudeste.TabIndex = 16;
            this.btnSudeste.Text = "-";
            this.btnSudeste.UseVisualStyleBackColor = true;
            // 
            // btnSul
            // 
            this.btnSul.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSul.Location = new System.Drawing.Point(586, 409);
            this.btnSul.Name = "btnSul";
            this.btnSul.Size = new System.Drawing.Size(45, 23);
            this.btnSul.TabIndex = 17;
            this.btnSul.Text = "-";
            this.btnSul.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 518);
            this.Controls.Add(this.btnSul);
            this.Controls.Add(this.btnSudeste);
            this.Controls.Add(this.btnCentro);
            this.Controls.Add(this.btnNordeste);
            this.Controls.Add(this.btnNorte);
            this.Controls.Add(this.btnEstados);
            this.Controls.Add(this.cboSul);
            this.Controls.Add(this.cboSudeste);
            this.Controls.Add(this.cboCentro);
            this.Controls.Add(this.cboNordeste);
            this.Controls.Add(this.cboNorte);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.ComboBox cboNorte;
        private System.Windows.Forms.ComboBox cboNordeste;
        private System.Windows.Forms.ComboBox cboCentro;
        private System.Windows.Forms.ComboBox cboSudeste;
        private System.Windows.Forms.ComboBox cboSul;
        private System.Windows.Forms.Button btnEstados;
        private System.Windows.Forms.Button btnNorte;
        private System.Windows.Forms.Button btnNordeste;
        private System.Windows.Forms.Button btnCentro;
        private System.Windows.Forms.Button btnSudeste;
        private System.Windows.Forms.Button btnSul;
    }
}

