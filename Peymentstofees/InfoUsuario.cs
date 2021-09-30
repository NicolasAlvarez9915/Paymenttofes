using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Peymentstofees
{
    public partial class InfoUsuario : Form
    {
        Cliente cliente;
        Credito Credito;
        ClienteServices ClienteServices;
        CreditoServices CreditoServices;
        public InfoUsuario()
        {
            InitializeComponent();
            ClienteServices = new ClienteServices();
            CreditoServices = new CreditoServices();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abonar();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InfoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Abonar()
        {
            if (ValidarCampos(2))
            {
                Abono abono = new Abono(Credito);
                abono.ShowDialog();
                Buscar();
            }
        }
        private void Buscar()
        {
            if (ValidarCampos(1))
            {
                if (ClienteServices.BuscarInformacion(TxtIdentificacion.Text.Trim()))
                {
                    cliente = ClienteServices.InformacionCliente();
                    LblIdentificacion.Text = cliente.Identificacion;
                    LblCorreo.Text = cliente.Correo;
                    LblDireccion.Text = cliente.Direccion;
                    lblNombre.Text = cliente.Nombre;
                    LblTelefono.Text = cliente.Telefono;
                    LblEstado.Text = cliente.Estado;
                    if(cliente.Estado == "Activo")
                    {
                        Credito = CreditoServices.BuscarCedito(cliente.Identificacion);
                        LblCuotas.Text = Credito.NumeroCuotas.ToString();
                        LblValorPorCuota.Text = Credito.Cuota.ToString();
                        LblSaldo.Text = Credito.Saldo.ToString();
                    }
                    else
                    {
                        LblCuotas.Text = "No debe dinero.";
                        LblSaldo.Text = "No debe dinero.";
                        LblValorPorCuota.Text = "No debe dinero.";
                    }
                }
                else
                {
                    MessageBox.Show("No existe un cliente registrado con esa identificacion.");
                }

            }
        }
        private bool ValidarCampos(int campos)
        {
            switch (campos)
            {
                case 1:
                    if (ValidarNumero(TxtIdentificacion.Text.Trim()))
                    {
                        MessageBox.Show("Identificacion erronea.");
                        return false;
                    }
                    else
                    {
                        if (TxtIdentificacion.Text.Trim().Length < 7 || TxtIdentificacion.Text.Trim().Length > 11)
                        {
                            MessageBox.Show("Identificacion erronea.");
                            return false;
                        }
                    }
                    return true;
                case 2:
                    if(LblIdentificacion.Text == "")
                    {
                        MessageBox.Show("Debe buscar primero.");
                        return false;
                    }
                    return true;
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

        private void button8_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(2))
            {

                Credito.AplicarInteres();
                Buscar();
            }
        }
    }
}
