using Newtonsoft.Json;
using Examen.Servicios.Clases;
using Examen.Servicios.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen.Servicios.Patrones;

namespace Examen.Servicios

{
    public partial class frmPrincipal : Form
    {
        CotizadorFacade Facade;
        Paquete paquete;
        Adicionales adicionales;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            List<ServiciosLista> ListaServicios = new List<ServiciosLista>()
            {
                new ServiciosLista(){ Codigo = "S001", Nombre = "Electricista", Precio = "20000" },
                new ServiciosLista(){ Codigo = "S002", Nombre = "Pintor", Precio = "15000" },
                new ServiciosLista(){ Codigo = "S003", Nombre = "Fontanero", Precio = "18000" }
            };
            foreach (ServiciosLista sl in ListaServicios)
            {
                cmbServicios.Items.Add(sl);
                cmbServicios.DisplayMember = sl.ToString();
            }
            cmbServicios.SelectedIndex = 0;

            lstPaquetes.DataSource = new List<Paquete> { new Basico(), new Economico(), new Premium() };
            lstPaquetes.DisplayMember = "Descripccion";


        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Validaciones())
                {
                    string ruta = "Servicio.xml";

                    var oOpc = (dgvDatos as DataGridView).CurrentRow;
                    oOpc.Cells[1].Value.ToString();

                    Opciones opciones = oOpc.DataBoundItem as Opciones;

                    IServicio servicio = new ServicioFactory().CrearServicio(cmbServicios.Text, opciones);

                    if (lstPaquetes.SelectedIndex == 2)
                    {
                        paquete = new Premium()
                        {
                            CantidadHoras = (int)nudCantidadHrs.Value,

                        };
                    }
                    else if (lstPaquetes.SelectedIndex == 0)
                    {
                        paquete = new Basico()
                        {
                            CantidadHoras = (int)nudCantidadHrs.Value,

                        };
                    }
                    else if (lstPaquetes.SelectedIndex == 1)
                    {
                        paquete = new Economico()
                        {
                            CantidadHoras = (int)nudCantidadHrs.Value,

                        };
                    }

                    if (chkJardineria.Checked)
                    {
                        adicionales = Adicionales.Jardineria;
                        paquete.AgregarAdicional(adicionales);
                    }
                    if (chkLavadoA.Checked)
                    {
                        adicionales = Adicionales.LavadoAcera;
                        paquete.AgregarAdicional(adicionales);

                    }
                    if (chkLimpiezaC.Checked)
                    {
                        adicionales = Adicionales.LimpiezaCanoas;
                        paquete.AgregarAdicional(adicionales);
                    }

                    Cliente cliente = new Cliente()
                    {
                        Identificacion = mtxId.Text,
                        Nombre = txtNombre.Text,
                        Paquete = paquete,
                        Servicio = servicio
                    };
                    Facade = new CotizadorFacade();
                    Facade.AgregarCliente(cliente);


                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Facade.ExportarXML(saveFileDialog.FileName);
                        webBrowser.Url = new Uri(saveFileDialog.FileName);
                    }




                }




            }
            catch (Exception error)
            {
                MessageBox.Show("Error :", error.Message + MessageBoxIcon.Error);
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;
            row.Cells[1].Value.ToString();
            //row.DataBoundItem as
        }


        private void btnMostrarServicios_Click(object sender, EventArgs e)
        {

            Opciones opciones = new Opciones();
            ServiciosLista servicios = (ServiciosLista)cmbServicios.SelectedItem;
            List<Opciones> ListaFiltrada = opciones.ObtenerOpcionesporServicio(servicios.Nombre);
            this.dgvDatos.DataSource = ListaFiltrada;
        }

        public bool Validaciones()
        {
            if (mtxId.Text.Equals(""))
            {
                this.errorProvider1.SetError(this.mtxId, "No puesde estar vacio");
                MessageBox.Show("Debe de estar lleno", "Atención", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                mtxId.Focus();
                return false;
            }


            if (txtNombre.Text.Equals(""))
            {
                this.errorProvider1.SetError(this.txtNombre, "No puede estar vacio");
                MessageBox.Show("Debe de estar lleno", "Atención", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return false;
            }

            if (nudCantidadHrs.Value == 0)
            {
                this.errorProvider1.SetError(this.txtNombre, "Debe de tener Horas");
                MessageBox.Show("Debe de tener Horas", "Atención", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                nudCantidadHrs.Focus();
                return false;
            }
            return true;
        }
    }
}
