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
    public partial class Abono : Form
    {
        Credito Credito;
        Cliente cliente;

        CarteraServices CarteraServices;
        ClienteServices ClienteServices;
        CreditoServices CreditoServices;
        PagoServices PagoServices;
        public Abono()
        {
            InitializeComponent();
            LblCantidad.Text = "Cantidad...";
            CmbQueAbonara.SelectedIndex = 0;
            CarteraServices = new CarteraServices();
            ClienteServices = new ClienteServices();
            CreditoServices = new CreditoServices();
            PagoServices = new PagoServices();
        }
        public Abono(Credito credito)
        {
            InitializeComponent();
            Inicializar(credito);
            CarteraServices = new CarteraServices();
            ClienteServices = new ClienteServices();
            CreditoServices = new CreditoServices();
            PagoServices = new PagoServices();
        }

        private void Inicializar(Credito credito)
        {
            Credito = credito;
            lblIdentificacion.Visible = false;
            TxtIdentificacion.Visible = false;
            BtnBuscar.Visible = false;
            PnlDecorativoBtnBuscar.Visible = false;
            BtnCerrar.Visible = false;
            panel5.Visible = false;
            LblCantidad.Text = "Cantidad...";
            CmbQueAbonara.SelectedIndex = 0;
            PintarLabel();

        }
        private void PintarLabel()
        {
            LblInfoCredito.Text = $"Identificacion del cliente: {Credito.Id_Cliente}, saldo restante: {Credito.Saldo}, cuotas restantes: {Credito.NumeroCuotas}, valor cuota: {Credito.Cuota.ToString()}";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarTextoCantidad();
        }

        private void CambiarTextoCantidad()
        {
            switch (CmbQueAbonara.SelectedIndex)
            {
                case 0:
                    LblCantidad.Text = "Candidad....";
                    break;
                case 1:
                    LblCantidad.Text = "Candidad de cuotas a pagar";
                    break;
                case 2:
                    LblCantidad.Text = "Candidad de dinero a pagar";
                    break;
            }
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abonar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Abonar()
        {
            if (ValidarAlAbonar())
            {
                Pago pago = new Pago
                {
                    Fecha = DateTime.Now,
                    IdCliente = Credito.Id_Cliente,
                    IdCredito = Credito.IdCredito
                };
                if (CmbQueAbonara.SelectedIndex == 1)
                {
                    double cuota = Credito.Cuota;
                    Credito.Abonar(CmbQueAbonara.Text, 0, Convert.ToInt32(TxtCantidad.Text.Trim()));
                    pago.ValorPago = cuota * Convert.ToDouble(TxtCantidad.Text.Trim());
                    CarteraServices.ActualizarDineroRestante(pago.ValorPago);
                }
                else
                {
                    Credito.Abonar(CmbQueAbonara.Text, Convert.ToInt32(TxtCantidad.Text.Trim()), 0);
                    pago.ValorPago = Convert.ToDouble(TxtCantidad.Text.Trim());
                    CarteraServices.ActualizarDineroRestante(pago.ValorPago);
                }
                if(Credito.Saldo == 0)
                {
                    ClienteServices.ActualizarEstado(Credito.Id_Cliente);
                    CarteraServices.ActualizarCanttidadDeudoresMenos();
                }
                PagoServices.RegistrarPago(pago);
                CreditoServices.ActualizarCredito(Credito);
                PintarLabel();
            }
        }
        private bool ValidarAlAbonar()
        {
            if(LblInfoCredito.Text == "")
            {
                MessageBox.Show("Debe primero buscar a un cliente.");
                return false;
            }
            else
            {
                if(CmbQueAbonara.SelectedIndex == 0)
                {
                    MessageBox.Show("Debe seleccionar como abonara.");
                    return false;
                }
                else
                {
                    if(TxtCantidad.Text.Trim() == "")
                    {
                        MessageBox.Show("Debe ingresar La candidad de lo que abonara.");
                        return false;
                    }
                    else
                    {
                        return ValidarPagar();
                    }
                }
            }
        }
        private bool ValidarPagar()
        {
            if (ValidarNumero(TxtCantidad.Text.Trim()))
            {
                MessageBox.Show("Cantidad a pagar erronea.");
                return false;
            }
            else
            {
                if (CmbQueAbonara.SelectedIndex == 1)
                {
                    if (Convert.ToInt32(TxtCantidad.Text.Trim()) > Credito.NumeroCuotas || Convert.ToInt32(TxtCantidad.Text.Trim()) < 1)
                    {
                        MessageBox.Show("Cantidad de cuotas erroneo, No puede pagar mas de las cuotas que debe o ingresar una cantidad neativa.");
                        return false;
                    }
                }
                else
                {
                    if (Convert.ToDouble(TxtCantidad.Text.Trim()) > Credito.Saldo || Convert.ToDouble(TxtCantidad.Text.Trim()) < Credito.Cuota)
                    {
                        MessageBox.Show("Cantidad de dinero erroneo, no puede pagar mas de lo que debe ni menos del valor de una cuota");
                        return false;
                    }
                }
            }
            return true;
        }
        private bool ValidarNumero(String Numero)
        {
            bool EsNumero;
            EsNumero = Double.TryParse(Convert.ToString(Numero),
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out _);
            return !EsNumero;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar()
        {
            if (ValidarAlBuscar())
            {
                if (ClienteServices.BuscarInformacion(TxtIdentificacion.Text.Trim()))
                {
                    cliente = ClienteServices.InformacionCliente();
                    if(cliente.Estado == "Activo")
                    {
                        Credito = CreditoServices.BuscarCedito(cliente.Identificacion);
                        PintarLabel();
                    }
                    else
                    {
                        MessageBox.Show("Se encontro un cliente con esta identificacion pero no debe dinero en estos momentos.");
                    }

                }
                else
                {
                    MessageBox.Show("No existe un cliente con esa identificacion.");
                }
            }
        }
        private bool ValidarAlBuscar()
        {
            if (TxtIdentificacion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la identtificacion del cliente");
                return false;
            }
            return true;
        }

    }
}
