using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioApp_V
{
    public partial class Form1 : Form
    {
        List<Producto> inventario = new List<Producto>();

        //Producto de ejemplo para mostrar en el DataGridView
        { new Producto ("1ADFAK","Arroz",4.99,267),
          new Producto ("DL38AF","Agua Alpina 500ml",0.45,551),
            new Producto ("AA043L","Agua Cristal 500ml",0.69,113),
            new Producto ("PP292C","Papel Higienico",6.99,921),
            };
 
        public Form1()
        {
            InitializeComponent();
            ActualizarInventario();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

           //test

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            { Producto nuevoProducto = new Producto
                    (txtCodigo.Text, 
                     txtNombre.Text, 
                     double.Parse(txtPrecio.Text), 
                     int.Parse(txtCantidad.Text));

                inventario.Add(nuevoProducto);
                MessageBox.Show("Producto agregado correctamente");

                txtCodigo.Clear();
                txtNombre.Clear();
                txtPrecio.Clear();
                txtCantidad.Clear();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
            
            ActualizarInventario();
            LimpiarCampos();
        }
        private void ActualizarInventario()
        {
            Label precioTotal_label = lblStat2Val;
            Label totalProductosUnicos_label = lblStat3Val;
            Label totalArticulos_label = lblStat1Val;

            float precioTotal = 0f;
            int totalProductos = 0;
            int totalArticulos = inventario.Count;

            foreach (Producto p in inventario)

            {
                precioTotal += (float)(p.Precio * p.Cantidad);
                totalProductosUnicos += p.Cantidad;
            }
            precioTotal_label.Text = $"{precioTotal:C}";
            totalProductosUnicos_label.Text =$"{totalProductosUnicos}";
            totalArticulos_label.Text = $"{totalArticulos}";
        }

        private void ActualizarInventario()

        { 

        ActualizarInformacionInventario() ; 
        ActualizarGrid()
        
        }

        private void btnMostar_Click(object sender, EventArgs e)

        {
          dataGridView1.DataSource = null;
          dataGridView1.DataSource = inventario;

        }
        
}
}
