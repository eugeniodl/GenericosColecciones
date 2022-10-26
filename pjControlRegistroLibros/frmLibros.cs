using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjControlRegistroLibros
{
    public partial class frmLibros : Form
    {
        static int contador;
        public frmLibros()
        {
            InitializeComponent();
        }

        private void frmLibros_Load(object sender, EventArgs e)
        {
            lblNumero.Text = GenerarNumero();
        }

        Func<string> GenerarNumero = () =>
        {
            contador++;
            return contador.ToString("0000");
        };

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Valida() == "")
            {
                // Capturando los datos del formulario
                double costo = getCosto();
                string categoria = getCategoria();
                double descuento = AsignaDescuento(categoria, costo);
                double precioVenta = CalculaPrecioVenta(costo, descuento);

                // Enviando a la impresión
                ImprimirRegistro(descuento, precioVenta);
            }
            else
                MessageBox.Show("El error se encuentra en " +Valida());
        }

        // Imprimir el registro de ventas
        private void ImprimirRegistro(double descuento, double precioVenta)
        {
            ListViewItem fila = new ListViewItem(getNumero().ToString());
            fila.SubItems.Add(getTitulo());
            fila.SubItems.Add(getCategoria());
            fila.SubItems.Add(getCosto().ToString("0.00"));
            fila.SubItems.Add(descuento.ToString("0.00"));
            fila.SubItems.Add(precioVenta.ToString("0.00"));
            lvLibros.Items.Add(fila);
        }

        Func<double, double, double> CalculaPrecioVenta = (costo, descuento) => costo - descuento;

        Func<string, double, double> AsignaDescuento = (categoria, costo) =>
        {
            double descuento = 0;
            switch(categoria)
            {
                case "Gestión": descuento = 10.0 / 100 * costo; break;
                case "Ingeniería": descuento = 12.0 / 100 * costo; break;
                case "Programación": descuento = 20.0 / 100 * costo; break;
                case "Base de datos": descuento = 15.0 / 100 * costo; break;
            }
            return descuento;
        };

        // Métodos que capturan los valores
        private int getNumero()
        {
            return int.Parse(lblNumero.Text);
        }

        private string getTitulo()
        {
            return txtTitulo.Text;
        }


        private string getCategoria()
        {
            return cboCategoria.Text;
        }

        private double getCosto()
        {
            return double.Parse(txtCosto.Text);
        }

        private string Valida()
        {
            if(txtTitulo.Text.Trim().Length == 0)
            {
                txtTitulo.Focus();
                return "título del libro";
            }
            else if(cboCategoria.SelectedIndex == -1)
            {
                cboCategoria.Focus();
                return "categoría del libro";
            }
            else if(txtCosto.Text.Trim().Length == 0)
            {
                txtCosto.Focus();
                return "costo del libro";
            }
            return "";
        }
    }
}
