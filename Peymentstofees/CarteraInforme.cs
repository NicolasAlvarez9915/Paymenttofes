using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;


namespace Peymentstofees
{
    public partial class CarteraInforme : Form
    {
        Cartera Cartera;
        List<Credito> Creditos;
        List<Pago> Pagos;
        List<Cliente> Clientes;
        CarteraServices CarteraServices;
        ClienteServices ClienteServices;
        CreditoServices CreditoServices;
        PagoServices PagoServices;
        public CarteraInforme()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            CarteraServices = new CarteraServices();
            ClienteServices = new ClienteServices();
            CreditoServices = new CreditoServices();
            PagoServices = new PagoServices();
            Cartera = CarteraServices.MostrarCartera();
            Pagos = PagoServices.MostrarPagos();
            Clientes = ClienteServices.MostrarClientes();
            Creditos = CreditoServices.MostrarCredito();

            PintarCartera();
            PintarTablas();
        }
        private void PintarCartera()
        {
            LblCantidadDeudores.Text = Cartera.CantidadDeudores.ToString();
            LblCapital.Text = Cartera.Capital.ToString();
            LblDineroDisponible.Text = Cartera.DineroRestante.ToString();
            LblDineroPrestado.Text = Cartera.DineroPrestado.ToString();
        }
        private void PintarTablas()
        {
            DgvClientes.DataSource = Clientes;
            DgvCreditos.DataSource = Creditos;
            DgvPagos.DataSource = Pagos;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Cartera_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteServices.GenerarExcel();
            CreditoServices.GenerarExcel();
            PagoServices.GenerarExcel();
            MessageBox.Show("Reportes Generados correctamente.");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
