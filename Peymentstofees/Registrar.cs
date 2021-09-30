using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Entity;
using BLL;

namespace Peymentstofees
{
    public partial class Registrar : Form
    {
        double Prestamo, ValorCuota;
        double CantidadCuotas;
        CarteraServices CarteraServices;
        ClienteServices ClienteServices;
        public Registrar()
        {
            InitializeComponent();
            CarteraServices = new CarteraServices();
            ClienteServices = new ClienteServices();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CalcularCuotas();
        }

        private void TxtIdentificacion_Click(object sender, EventArgs e)
        {

        }

        private void CalcularCuotas()
        {
            if (ValidarCampos(1))
            {
                Prestamo = Convert.ToDouble(TxtPrestamo.Text.Trim());
                ValorCuota = Convert.ToDouble(TxtValorCuotas.Text.Trim());
                Prestamo += Prestamo * 0.16;
                double CantidadExacta = Prestamo / ValorCuota;
                CantidadCuotas = Math.Floor(CantidadExacta);
                CantidadExacta -= Math.Floor(CantidadExacta);
                if(CantidadExacta>0)
                {
                    CantidadCuotas++;
                }
                LblCantidadCuotas.Text = CantidadCuotas.ToString();
            }
        }

        private bool ValidarCampos(int Campos)
        {
            return Campos switch
            {
                1 => ValidarCamposCuota(),
                2 => ValidarCamposPrestamo(),
                _ => false,
            };
        }
        private bool ValidarCamposPrestamo()
        {
            if(TxtIdentificacion.Text.Trim() == "")
            {
                MessageBox.Show("Dijite la identificacion.");
                return false;
            }
            else
            {
                if (ValidarNumero(TxtIdentificacion.Text.Trim())|| TxtIdentificacion.Text.Length < 7 || TxtIdentificacion.Text.Length > 11)
                {
                    MessageBox.Show("Identificacion erronea.");
                    return false;
                }
                else
                {

                    if (TxtNombre.Text.Trim() == "")
                    { 
                        MessageBox.Show("Dijite el Nombre.");
                        return false;
                    }
                    else
                    {
                        if (TxtCorreo.Text.Trim() == "")
                            {
                                MessageBox.Show("Dijite el correo.");
                                return false;
                        }
                        else
                        {
                            
                                    if (TxtTelefono.Text.Trim() == "")
                                    {
                                        MessageBox.Show("Dijite el Telefono.");
                                        return false;
                                    }
                                    else
                                    {
                                        if (ValidarNumero(TxtTelefono.Text.Trim()))
                                        {
                                            MessageBox.Show("Telefono erroneo.");
                                            return false;
                                        }
                                        else
                                        {
                                            if (TxtDireccion.Text.Trim() == "")
                                            {
                                                MessageBox.Show("Dijite el la direccion.");
                                                return false;
                                            }
                                            else
                                            {
                                                if (!ValidarCamposCuota())
                                                {
                                                    return false;
                                                }
                                                else
                                                {
                                                    if (LblCantidadCuotas.Text == "")
                                                    {
                                                        MessageBox.Show("Debe Calcular la cantidad de cuotas.");
                                                        return false;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                
                            }
                        }
                    
                }
            }
            return true;
        }
        private bool ValidarCorreo()
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(TxtCorreo.Text.Trim(), expresion))
            {
                if (Regex.Replace(TxtCorreo.Text.Trim(), expresion, String.Empty).Length == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }
        private bool ValidarCamposCuota()
        {
            if(TxtPrestamo.Text.Trim() == "")
            {
                MessageBox.Show("Dijite el valor del prestamo.");
                return false;
            }
            else
            {
                if(ValidarNumero(TxtPrestamo.Text.Trim()))
                {
                    MessageBox.Show("Valor del prestamo erroneo.");
                    return false;
                }
                else
                {
                    if (ValidarCorreo())
                    {
                        MessageBox.Show("Correo erroneo");
                        return false;
                    }
                    else
                    {
                        if (Convert.ToDouble(TxtPrestamo.Text.Trim()) < 100000 || Convert.ToDouble(TxtPrestamo.Text.Trim()) > 3000000)
                        {
                            MessageBox.Show("No es posible prestar esa cantidad de dinero.");
                            return false;
                        }
                        else
                        {
                            if (CarteraServices.ValidarDineroRestante(Convert.ToDouble(TxtPrestamo.Text.Trim())))
                            {
                                MessageBox.Show("No hay capital suficiente para prestar esa cantidad de dinero.");
                                return false;
                            }
                            else
                            {
                                if (TxtValorCuotas.Text.Trim() == "")
                                {
                                    MessageBox.Show("Dijite el valor de cada cuota.");
                                    return false;
                                }
                                else
                                {

                                    if (ValidarNumero(TxtValorCuotas.Text.Trim()) || Convert.ToInt32(TxtValorCuotas.Text.Trim()) < 50 || Convert.ToInt32(TxtValorCuotas.Text.Trim()) > Convert.ToDouble(TxtPrestamo.Text.Trim()))
                                    {
                                        MessageBox.Show("Valor de las cuotas erroneo.");
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarPrestamo();
        }

        private void RegistrarPrestamo()
        {
            if (ValidarCampos(2))
            {
                Cliente cliente = new Cliente
                {
                    Identificacion = TxtIdentificacion.Text.Trim(),
                    Direccion = TxtDireccion.Text.Trim(),
                    Correo = TxtCorreo.Text.Trim(),
                    Estado = "Activo",
                    Nombre = TxtNombre.Text.Trim(),
                    Telefono = TxtTelefono.Text.Trim()
                };
                Credito credito = new Credito
                {
                    Id_Cliente = cliente.Identificacion,
                    NumeroCuotas = Convert.ToInt32(CantidadCuotas),
                    Saldo = Convert.ToDouble(TxtPrestamo.Text.Trim())*0.16+ Convert.ToDouble(TxtPrestamo.Text.Trim()),
                    Cuota = Convert.ToDouble(TxtValorCuotas.Text.Trim())
                };
                credito.Interes = credito.Cuota * 0.16;
                CarteraServices.ActualizarCanttidadDeudores();
                CarteraServices.ActualizarDineroPrestado(Convert.ToDouble(TxtPrestamo.Text.Trim()));

                MessageBox.Show(ClienteServices.Registrar(cliente, credito));
                Limpiar();
            }
        }
        private void Limpiar()
        {
            TxtCorreo.Text = "";
            TxtDireccion.Text = "";
            TxtIdentificacion.Text = "";
            TxtNombre.Text = "";
            TxtPrestamo.Text = "";
            TxtTelefono.Text = "";
            TxtValorCuotas.Text = "";
            LblCantidadCuotas.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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
    }
}
