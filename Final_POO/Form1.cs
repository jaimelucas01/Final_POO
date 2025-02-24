using System;
using System.Windows.Forms;

namespace Final_POO
{
    public partial class Form1 : Form
    {
        public Almacén Oalmacén;
        public ProductoInformatico Oinformatico;
        public string Acción;
        public Form1()
        {
            InitializeComponent();
            Oalmacén = new Almacén();
            ModoLista();
        }

        public void Recargar()
        {
            dgvPartes.DataSource = null;
            dgvPartes.DataSource = Oalmacén.Productos;
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
            txtID.Clear();
            txtComp.Clear();
            txtMarca.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Oinformatico = new ProductoInformatico();
            Acción = "A";
            ModoIngreso();
            ClearTXT();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (dgvPartes.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Por favor, seleccione una celda.");
                return;
            }

            Oinformatico = (ProductoInformatico)dgvPartes.CurrentRow.DataBoundItem;
            txtID.Text = Oinformatico.ID.ToString();
            txtComp.Text = Oinformatico.Nombre;
            txtMarca.Text = Oinformatico.Marca;
            txtStock.Text = Oinformatico.Stock.ToString();
            txtPrecio.Text = Oinformatico.Precio.ToString();

            ModoIngreso();
            Acción = "M";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvPartes.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Por favor, seleccione una celda.");
                return;
            }

            Oinformatico = (ProductoInformatico)dgvPartes.CurrentRow.DataBoundItem;

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el producto " + Oinformatico.Marca + " de la lista?", "Atención", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Oalmacén.Productos.Remove(Oinformatico);
                Recargar();
                ModoLista();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES

            int id;
            if (!int.TryParse(txtID.Text, out id) || id <= 0)
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtComp.Text))
            {
                MessageBox.Show("Ingrese un Componente válido.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("Ingrese una Marca válida.");
                return;
            }
            int stock;
            if (!int.TryParse(txtStock.Text, out stock) || stock <= 0)
            {
                MessageBox.Show("Ingrese un Stock mayor a 0");
                return;
            }
            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un Precio mayor a 0");
                return;
            }
            #endregion

            Oinformatico.ID = id;
            Oinformatico.Nombre = txtComp.Text;
            Oinformatico.Marca = txtMarca.Text;
            Oinformatico.Stock = stock;
            Oinformatico.Precio = precio;

            if (Acción == "A")
            {
                Oalmacén.Productos.Add(Oinformatico);
            }

            Recargar();
            ClearTXT();
            ModoLista();
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

        private void btnMayor_Click(object sender, EventArgs e)
        {
            if (dgvPartes.DataSource == null)
            {
                MessageBox.Show("Primero ingrese un Producto.");
                return;
            }
            else
            {
                dgvPartes.DataSource = Oalmacén.ObtenerProductosOrdenadosMayor();
            }
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            if (dgvPartes.DataSource == null)
            {
                MessageBox.Show("Primero ingrese un Producto.");
                return;
            }
            else
            {
                dgvPartes.DataSource = Oalmacén.ObtenerProductosOrdenadosMenor();
            }
        }
    }
}
