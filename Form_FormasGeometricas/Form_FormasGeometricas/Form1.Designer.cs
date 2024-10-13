namespace Form_FormasGeometricas
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
            this.comboBoxFiguras = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblRaio = new System.Windows.Forms.Label();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pictureBoxFigura = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultadoArea = new System.Windows.Forms.Label();
            this.lblPerimetroResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFigura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a Forma Geometrica:";
            // 
            // comboBoxFiguras
            // 
            this.comboBoxFiguras.FormattingEnabled = true;
            this.comboBoxFiguras.Items.AddRange(new object[] {
            "Círculo",
            "Hexágono",
            "Octógono",
            "Pentágono",
            "Quadrado",
            "Retângulo",
            "Triângulo Equilátero",
            "Triângulo Escaleno",
            "Triângulo Isósceles"});
            this.comboBoxFiguras.Location = new System.Drawing.Point(17, 36);
            this.comboBoxFiguras.Name = "comboBoxFiguras";
            this.comboBoxFiguras.Size = new System.Drawing.Size(228, 24);
            this.comboBoxFiguras.TabIndex = 1;
            this.comboBoxFiguras.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiguras_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preencha os campos a seguir:";
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Location = new System.Drawing.Point(21, 120);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(41, 16);
            this.lblLado1.TabIndex = 3;
            this.lblLado1.Text = "Lado:";
            this.lblLado1.Visible = false;
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Location = new System.Drawing.Point(21, 150);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(51, 16);
            this.lblLado2.TabIndex = 4;
            this.lblLado2.Text = "Lado 2:";
            this.lblLado2.Visible = false;
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Location = new System.Drawing.Point(21, 182);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(51, 16);
            this.lblLado3.TabIndex = 5;
            this.lblLado3.Text = "Lado 3:";
            this.lblLado3.Visible = false;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(21, 210);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(44, 16);
            this.lblAltura.TabIndex = 6;
            this.lblAltura.Text = "Altura:";
            this.lblAltura.Visible = false;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(21, 243);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(42, 16);
            this.lblBase.TabIndex = 7;
            this.lblBase.Text = "Base:";
            this.lblBase.Visible = false;
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Location = new System.Drawing.Point(21, 277);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(39, 16);
            this.lblRaio.TabIndex = 8;
            this.lblRaio.Text = "Raio:";
            this.lblRaio.Visible = false;
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(79, 120);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 22);
            this.txtLado1.TabIndex = 9;
            this.txtLado1.Visible = false;
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(79, 150);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 22);
            this.txtLado2.TabIndex = 10;
            this.txtLado2.Visible = false;
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(79, 182);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 22);
            this.txtLado3.TabIndex = 11;
            this.txtLado3.Visible = false;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(79, 211);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 12;
            this.txtAltura.Visible = false;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(79, 243);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 22);
            this.txtBase.TabIndex = 13;
            this.txtBase.Visible = false;
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(79, 277);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(100, 22);
            this.txtRaio.TabIndex = 14;
            this.txtRaio.Visible = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCalcular.Location = new System.Drawing.Point(79, 319);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 32);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pictureBoxFigura
            // 
            this.pictureBoxFigura.Location = new System.Drawing.Point(380, 36);
            this.pictureBoxFigura.Name = "pictureBoxFigura";
            this.pictureBoxFigura.Size = new System.Drawing.Size(340, 315);
            this.pictureBoxFigura.TabIndex = 16;
            this.pictureBoxFigura.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(13, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Resultados:";
            // 
            // lblResultadoArea
            // 
            this.lblResultadoArea.AutoSize = true;
            this.lblResultadoArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResultadoArea.Location = new System.Drawing.Point(125, 367);
            this.lblResultadoArea.Name = "lblResultadoArea";
            this.lblResultadoArea.Size = new System.Drawing.Size(129, 18);
            this.lblResultadoArea.TabIndex = 18;
            this.lblResultadoArea.Text = "Resultado Área.....";
            // 
            // lblPerimetroResultado
            // 
            this.lblPerimetroResultado.AutoSize = true;
            this.lblPerimetroResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPerimetroResultado.Location = new System.Drawing.Point(128, 399);
            this.lblPerimetroResultado.Name = "lblPerimetroResultado";
            this.lblPerimetroResultado.Size = new System.Drawing.Size(156, 18);
            this.lblPerimetroResultado.TabIndex = 19;
            this.lblPerimetroResultado.Text = "Resultado Perimetro...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPerimetroResultado);
            this.Controls.Add(this.lblResultadoArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxFigura);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.lblRaio);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.lblLado1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFiguras);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form_Formas_Geometricas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFigura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFiguras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox pictureBoxFigura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultadoArea;
        private System.Windows.Forms.Label lblPerimetroResultado;
    }
}

