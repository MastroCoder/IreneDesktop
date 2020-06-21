namespace IreneDesktop
{
    partial class Vendedores
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAtualizarVendedores = new System.Windows.Forms.Button();
            this.btnCadastrarVendedores = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(637, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarVendedores
            // 
            this.btnAtualizarVendedores.Location = new System.Drawing.Point(12, 390);
            this.btnAtualizarVendedores.Name = "btnAtualizarVendedores";
            this.btnAtualizarVendedores.Size = new System.Drawing.Size(221, 48);
            this.btnAtualizarVendedores.TabIndex = 3;
            this.btnAtualizarVendedores.Text = "Atualizar Vendedor";
            this.btnAtualizarVendedores.UseVisualStyleBackColor = true;
            this.btnAtualizarVendedores.Click += new System.EventHandler(this.BtnAtualizarVendedores_Click);
            // 
            // btnCadastrarVendedores
            // 
            this.btnCadastrarVendedores.Location = new System.Drawing.Point(287, 390);
            this.btnCadastrarVendedores.Name = "btnCadastrarVendedores";
            this.btnCadastrarVendedores.Size = new System.Drawing.Size(221, 48);
            this.btnCadastrarVendedores.TabIndex = 4;
            this.btnCadastrarVendedores.Text = "Cadastrar Vendedor";
            this.btnCadastrarVendedores.UseVisualStyleBackColor = true;
            this.btnCadastrarVendedores.Click += new System.EventHandler(this.BtnCadastrarVendedores_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(567, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(221, 48);
            this.button4.TabIndex = 5;
            this.button4.Text = "Deletar Vendedor";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 345);
            this.dataGridView1.TabIndex = 6;
            // 
            // Vendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnCadastrarVendedores);
            this.Controls.Add(this.btnAtualizarVendedores);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Vendedores";
            this.Text = "Vendedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAtualizarVendedores;
        private System.Windows.Forms.Button btnCadastrarVendedores;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}