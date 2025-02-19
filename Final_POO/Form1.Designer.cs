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
            dgvPartes = new DataGridView();
            Marca = new DataGridViewTextBoxColumn();
            Componente = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
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
            gboLista = new GroupBox();
            gboIngreso = new GroupBox();
            btnCanc = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPartes).BeginInit();
            gboLista.SuspendLayout();
            gboIngreso.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPartes
            // 
            dgvPartes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartes.Columns.AddRange(new DataGridViewColumn[] { Marca, Componente, Tipo, Stock, Precio });
            dgvPartes.Location = new Point(12, 22);
            dgvPartes.Name = "dgvPartes";
            dgvPartes.Size = new Size(646, 337);
            dgvPartes.TabIndex = 0;
            dgvPartes.CellClick += dgvPartes_CellClick;
            // 
            // Marca
            // 
            Marca.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            // 
            // Componente
            // 
            Componente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Componente.HeaderText = "Componente";
            Componente.Name = "Componente";
            // 
            // Tipo
            // 
            Tipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            // 
            // Stock
            // 
            Stock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            // 
            // Precio
            // 
            Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(12, 40);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(230, 23);
            txtMarca.TabIndex = 3;
            // 
            // txtComp
            // 
            txtComp.Location = new Point(12, 84);
            txtComp.Name = "txtComp";
            txtComp.Size = new Size(230, 23);
            txtComp.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 4;
            label2.Text = "Componente";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(12, 216);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(230, 23);
            txtPrecio.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 198);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Precio";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(16, 364);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 41);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(129, 364);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(107, 39);
            btnMod.TabIndex = 9;
            btnMod.Text = "Modificar";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(242, 364);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(107, 39);
            btnDel.TabIndex = 10;
            btnDel.Text = "Eliminar";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(12, 172);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(230, 23);
            txtStock.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 154);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 11;
            label4.Text = "Stock";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(12, 128);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(230, 23);
            txtTipo.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 110);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 13;
            label5.Text = "Tipo";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(552, 390);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 39);
            btnExit.TabIndex = 15;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // gboLista
            // 
            gboLista.Controls.Add(dgvPartes);
            gboLista.Controls.Add(btnExit);
            gboLista.Controls.Add(btnMod);
            gboLista.Controls.Add(btnAdd);
            gboLista.Controls.Add(btnDel);
            gboLista.Location = new Point(0, 0);
            gboLista.Name = "gboLista";
            gboLista.Size = new Size(670, 439);
            gboLista.TabIndex = 16;
            gboLista.TabStop = false;
            gboLista.Text = "Lista";
            // 
            // gboIngreso
            // 
            gboIngreso.Controls.Add(btnCanc);
            gboIngreso.Controls.Add(btnGuardar);
            gboIngreso.Controls.Add(txtTipo);
            gboIngreso.Controls.Add(label1);
            gboIngreso.Controls.Add(label5);
            gboIngreso.Controls.Add(txtMarca);
            gboIngreso.Controls.Add(txtStock);
            gboIngreso.Controls.Add(label2);
            gboIngreso.Controls.Add(label4);
            gboIngreso.Controls.Add(txtComp);
            gboIngreso.Controls.Add(label3);
            gboIngreso.Controls.Add(txtPrecio);
            gboIngreso.Location = new Point(665, 0);
            gboIngreso.Name = "gboIngreso";
            gboIngreso.Size = new Size(256, 439);
            gboIngreso.TabIndex = 17;
            gboIngreso.TabStop = false;
            gboIngreso.Text = "Ingreso";
            // 
            // btnCanc
            // 
            btnCanc.Location = new Point(136, 390);
            btnCanc.Name = "btnCanc";
            btnCanc.Size = new Size(107, 39);
            btnCanc.TabIndex = 17;
            btnCanc.Text = "Cancelar";
            btnCanc.UseVisualStyleBackColor = true;
            btnCanc.Click += btnCanc_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(11, 245);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(230, 41);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 441);
            Controls.Add(gboLista);
            Controls.Add(gboIngreso);
            Name = "Form1";
            Text = "Final POO";
            ((System.ComponentModel.ISupportInitialize)dgvPartes).EndInit();
            gboLista.ResumeLayout(false);
            gboIngreso.ResumeLayout(false);
            gboIngreso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPartes;
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
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Componente;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Precio;
        private GroupBox gboLista;
        private GroupBox gboIngreso;
        private Button btnGuardar;
        private Button btnCanc;
    }
}
