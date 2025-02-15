namespace Final_POO
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtMarca = new TextBox();
            txtComp = new TextBox();
            label2 = new Label();
            txtPrecio = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            btnMod = new Button();
            btnDel = new Button();
            txtStock = new TextBox();
            label4 = new Label();
            txtTipo = new TextBox();
            label5 = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(646, 337);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(676, 12);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(676, 30);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(230, 23);
            txtMarca.TabIndex = 3;
            // 
            // txtComp
            // 
            txtComp.Location = new Point(676, 74);
            txtComp.Name = "txtComp";
            txtComp.Size = new Size(230, 23);
            txtComp.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(676, 56);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 4;
            label2.Text = "Componente";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(676, 206);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(230, 23);
            txtPrecio.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(676, 188);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Precio";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(676, 235);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(230, 41);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(12, 355);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(107, 39);
            btnMod.TabIndex = 9;
            btnMod.Text = "Modificar";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(125, 355);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(107, 39);
            btnDel.TabIndex = 10;
            btnDel.Text = "Eliminar";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(676, 162);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(230, 23);
            txtStock.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(676, 144);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 11;
            label4.Text = "Stock";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(676, 118);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(230, 23);
            txtTipo.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(676, 100);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 13;
            label5.Text = "Tipo";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(801, 390);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 39);
            btnExit.TabIndex = 15;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 441);
            Controls.Add(btnExit);
            Controls.Add(txtTipo);
            Controls.Add(label5);
            Controls.Add(txtStock);
            Controls.Add(label4);
            Controls.Add(btnDel);
            Controls.Add(btnMod);
            Controls.Add(btnAdd);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtComp);
            Controls.Add(label2);
            Controls.Add(txtMarca);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Final POO";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtMarca;
        private TextBox txtComp;
        private Label label2;
        private TextBox txtPrecio;
        private Label label3;
        private Button btnAdd;
        private Button btnMod;
        private Button btnDel;
        private TextBox txtStock;
        private Label label4;
        private TextBox txtTipo;
        private Label label5;
        private Button btnExit;
    }
}
