namespace analizador
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textErrorLexico = new System.Windows.Forms.TextBox();
            this.textErrorSeman = new System.Windows.Forms.TextBox();
            this.textArbol = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textLexico = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(12, 12);
            this.textCodigo.Multiline = true;
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textCodigo.Size = new System.Drawing.Size(604, 258);
            this.textCodigo.TabIndex = 0;
            // 
            // textErrorLexico
            // 
            this.textErrorLexico.Location = new System.Drawing.Point(12, 319);
            this.textErrorLexico.Multiline = true;
            this.textErrorLexico.Name = "textErrorLexico";
            this.textErrorLexico.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textErrorLexico.Size = new System.Drawing.Size(311, 188);
            this.textErrorLexico.TabIndex = 1;
            // 
            // textErrorSeman
            // 
            this.textErrorSeman.Location = new System.Drawing.Point(12, 541);
            this.textErrorSeman.Multiline = true;
            this.textErrorSeman.Name = "textErrorSeman";
            this.textErrorSeman.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textErrorSeman.Size = new System.Drawing.Size(311, 193);
            this.textErrorSeman.TabIndex = 2;
            // 
            // textArbol
            // 
            this.textArbol.Location = new System.Drawing.Point(801, 34);
            this.textArbol.Multiline = true;
            this.textArbol.Name = "textArbol";
            this.textArbol.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textArbol.Size = new System.Drawing.Size(328, 462);
            this.textArbol.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pila,
            this.Salida});
            this.dataGridView1.Location = new System.Drawing.Point(351, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(420, 414);
            this.dataGridView1.TabIndex = 4;
            // 
            // Pila
            // 
            this.Pila.HeaderText = "Pila";
            this.Pila.Name = "Pila";
            // 
            // Salida
            // 
            this.Salida.HeaderText = "Salida";
            this.Salida.Name = "Salida";
            // 
            // textLexico
            // 
            this.textLexico.Location = new System.Drawing.Point(801, 541);
            this.textLexico.Multiline = true;
            this.textLexico.Name = "textLexico";
            this.textLexico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLexico.Size = new System.Drawing.Size(328, 193);
            this.textLexico.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(658, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Errores Lexicos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Errores Semanticos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(358, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Analizador Sintactico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(801, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Arbol Sintactico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(801, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Analizador Lexico";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 749);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textLexico);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textArbol);
            this.Controls.Add(this.textErrorSeman);
            this.Controls.Add(this.textErrorLexico);
            this.Controls.Add(this.textCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Analizador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textCodigo;
        private TextBox textErrorLexico;
        private TextBox textErrorSeman;
        private TextBox textArbol;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Pila;
        private DataGridViewTextBoxColumn Salida;
        private TextBox textLexico;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}