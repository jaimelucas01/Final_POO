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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvPartes = new DataGridView();
            label1 = new Label();
            txtID = new TextBox();
            txtComp = new TextBox();
            label2 = new Label();
            txtPrecio = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            btnMod = new Button();
            btnDel = new Button();
            txtStock = new TextBox();
            label4 = new Label();
            txtMarca = new TextBox();
            label5 = new Label();
            btnExit = new Button();
            gboLista = new GroupBox();
            btnMayor = new Button();
            btnMenor = new Button();
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
            dgvPartes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPartes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartes.Location = new Point(12, 22);
            dgvPartes.Name = "dgvPartes";
            dgvPartes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvPartes.Size = new Size(646, 337);
            dgvPartes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 40);
            txtID.Name = "txtID";
            txtID.Size = new Size(230, 23);
            txtID.TabIndex = 3;
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
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
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
            btnMod.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
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
            btnDel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
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
            // txtMarca
            // 
            txtMarca.Location = new Point(12, 128);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(230, 23);
            txtMarca.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 110);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 13;
            label5.Text = "Marca";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(552, 390);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 39);
            btnExit.TabIndex = 15;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // gboLista
            // 
            gboLista.Controls.Add(btnMayor);
            gboLista.Controls.Add(btnMenor);
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
            // btnMayor
            // 
            btnMayor.BackColor = SystemColors.ActiveCaption;
            btnMayor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMayor.Location = new Point(474, 365);
            btnMayor.Name = "btnMayor";
            btnMayor.Size = new Size(72, 41);
            btnMayor.TabIndex = 17;
            btnMayor.Text = "Mayor";
            btnMayor.UseVisualStyleBackColor = false;
            btnMayor.Click += btnMayor_Click;
            // 
            // btnMenor
            // 
            btnMenor.BackColor = SystemColors.ActiveCaption;
            btnMenor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMenor.Location = new Point(396, 365);
            btnMenor.Name = "btnMenor";
            btnMenor.Size = new Size(72, 41);
            btnMenor.TabIndex = 16;
            btnMenor.Text = "Menor";
            btnMenor.UseVisualStyleBackColor = false;
            btnMenor.Click += btnMenor_Click;
            // 
            // gboIngreso
            // 
            gboIngreso.Controls.Add(btnCanc);
            gboIngreso.Controls.Add(btnGuardar);
            gboIngreso.Controls.Add(txtMarca);
            gboIngreso.Controls.Add(label1);
            gboIngreso.Controls.Add(label5);
            gboIngreso.Controls.Add(txtID);
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
            btnCanc.BackColor = Color.IndianRed;
            btnCanc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCanc.Location = new Point(136, 390);
            btnCanc.Name = "btnCanc";
            btnCanc.Size = new Size(107, 39);
            btnCanc.TabIndex = 17;
            btnCanc.Text = "Cancelar";
            btnCanc.UseVisualStyleBackColor = false;
            btnCanc.Click += btnCanc_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private TextBox txtID;
        private TextBox txtComp;
        private Label label2;
        private TextBox txtPrecio;
        private Label label3;
        private Button btnAdd;
        private Button btnMod;
        private Button btnDel;
        private TextBox txtStock;
        private Label label4;
        private TextBox txtMarca;
        private Label label5;
        private Button btnExit;
        private GroupBox gboLista;
        private GroupBox gboIngreso;
        private Button btnGuardar;
        private Button btnCanc;
        private Button btnMenor;
        private Button btnMayor;
    }
}
