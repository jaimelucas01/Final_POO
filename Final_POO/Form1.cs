namespace Final_POO
{
    public partial class Form1 : Form
    {
        private List<ProductoInformatico> productos = new List<ProductoInformatico>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
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

                txtMarca.Text = "";
                txtComp.Text = "";
                txtTipo.Text = "";
                txtPrecio.Text = "";
                txtStock.Text = "";
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

                txtMarca.Text = "";
                txtComp.Text = "";
                txtTipo.Text = "";
                txtPrecio.Text = "";
                txtStock.Text = "";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvPartes.CurrentRow.Index > -1)
            {
                dgvPartes.Rows.RemoveAt(dgvPartes.CurrentRow.Index);

                txtMarca.Text = "";
                txtComp.Text = "";
                txtTipo.Text = "";
                txtPrecio.Text = "";
                txtStock.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
