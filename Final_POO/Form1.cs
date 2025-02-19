namespace Final_POO
{
    public partial class Form1 : Form
    {
        private List<ProductoInformatico> productos = new List<ProductoInformatico>();
        public string Acción;
        public Form1()
        {
            InitializeComponent();
            ModoLista();
        }

        public void ModoIngreso()
        {
            gboIngreso.Enabled = true;
            gboLista.Enabled = false;
        }

        public void ModoLista()
        {
            gboIngreso.Enabled = false;
            gboLista.Enabled = true;
        }

        public void ClearTXT()
        {
            txtMarca.Clear();
            txtComp.Clear();
            txtTipo.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModoIngreso();
            Acción = "A";
            ModoIngreso();
            ClearTXT();

            if (txtMarca.Text == "" || txtComp.Text == "" || txtTipo.Text == "" || txtPrecio.Text == "" || txtStock.Text == "")
            {
                MessageBox.Show("No se ha podido crear.");
            }
            else
            {
                int i = dgvPartes.Rows.Add();

                dgvPartes.Rows[i].Cells[0].Value = txtMarca.Text;
                dgvPartes.Rows[i].Cells[1].Value = txtComp.Text;
                dgvPartes.Rows[i].Cells[2].Value = txtTipo.Text;
                dgvPartes.Rows[i].Cells[3].Value = txtPrecio.Text;
                dgvPartes.Rows[i].Cells[4].Value = txtStock.Text;

                ClearTXT();
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (this.dgvPartes.SelectedRows.Count == 1)
            {
                int fila = dgvPartes.CurrentRow.Index;

                dgvPartes.Rows[fila].Cells[0].Value = txtMarca.Text;
                dgvPartes.Rows[fila].Cells[1].Value = txtComp.Text;
                dgvPartes.Rows[fila].Cells[2].Value = txtTipo.Text;
                dgvPartes.Rows[fila].Cells[3].Value = txtPrecio.Text;
                dgvPartes.Rows[fila].Cells[4].Value = txtStock.Text;

                ClearTXT();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvPartes.CurrentRow.Index > -1)
            {
                dgvPartes.Rows.RemoveAt(dgvPartes.CurrentRow.Index);

                ClearTXT();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            ClearTXT();
            ModoLista();
        }

        private void Recargar()
        {

        }

        private void dgvPartes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvPartes.SelectedRows.Count == 1)
            {
                int fila = dgvPartes.CurrentRow.Index;

                txtMarca.Text = dgvPartes.Rows[fila].Cells[0].Value.ToString();
                txtComp.Text = dgvPartes.Rows[fila].Cells[1].Value.ToString();
                txtTipo.Text = dgvPartes.Rows[fila].Cells[2].Value.ToString();
                txtPrecio.Text = dgvPartes.Rows[fila].Cells[3].Value.ToString();
                txtStock.Text = dgvPartes.Rows[fila].Cells[4].Value.ToString();
            }
        }

    }
}
