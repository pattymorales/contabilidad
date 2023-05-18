using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilidad
{
    public partial class FBusqueda : Form
    {
        List<Cuenta> datosCuentas = new List<Cuenta>();
        List<Centro> datosCentros = new List<Centro>();
        List<Tercero> datosTerceros = new List<Tercero>();
        List<tipo_transacciones> datosTipoTran = new List<tipo_transacciones>();
        List<tipo_transacciones> datosTipoTran2 = new List<tipo_transacciones>();
        public static string strFormCall = "";
        ICuentaRequest callingFormCuenta;
        ICentroRequest callingFormCentro;
        ITerceroRequest callingFormTercero;
        ITipo_TranRequest callingFormTipoTran;
        IMovimientoRequest callingFormMovimiento;
        public string strNit = "";
        public string strNombres = "";
        public string strApellidos = "";


        public FBusqueda(string Forma, ICuentaRequest caller)
        {
            InitializeComponent();
            strFormCall = Forma;
            callingFormCuenta = caller;
        }

        public FBusqueda(string Forma, ICentroRequest callerC)
        {
            InitializeComponent();
            strFormCall = Forma;
            callingFormCentro = callerC;
        }

        public FBusqueda(string Forma, ITerceroRequest callerT, Tercero TerceroModel)
        {
            InitializeComponent();
            strFormCall = Forma;
            callingFormTercero = callerT;
            strNit = TerceroModel.nit;
            strNombres = TerceroModel.nombres;
            strApellidos = TerceroModel.apellidos;
        }

        public FBusqueda(string Forma, ITipo_TranRequest callerT)
        {
            InitializeComponent();
            strFormCall = Forma;
            callingFormTipoTran = callerT;
        }

        public FBusqueda(string Forma, IMovimientoRequest callerT)
        {
            InitializeComponent();
            strFormCall = Forma;
            callingFormMovimiento = callerT;
        }
        

        private void UpdateDatosCuentas()
        {
            grdViewDatos.DataSource = datosCuentas;
        }

        private void UpdateDatosCentros()
        {
            grdViewDatos.DataSource = datosCentros;
        }

        private void UpdateDatosTerceros()
        {
            grdViewDatos.DataSource = datosTerceros;
        }

        private void UpdateDatosTipoTran()
        {
            grdViewDatos.DataSource = datosTipoTran;
        }

        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            DataAcces_Tipo_Tran dbTipoTran = new DataAcces_Tipo_Tran();
            switch (strFormCall)
            {
                case "Centro":
                    DataAcces_Centros dbCentro = new DataAcces_Centros();
                    datosCentros = dbCentro.GetCentros();
                    UpdateDatosCentros();
                    break;
                case "Cuenta":
                    DataAcces_Cuentas db = new DataAcces_Cuentas();
                    datosCuentas = db.GetCuentas();
                    UpdateDatosCuentas();
                    break;
                case "Tercero":
                    DataAcces_Terceros dbTerceros = new DataAcces_Terceros();
                    //datosTerceros = dbTerceros.GetTerceros(terceroModelBusqueda.nit, terceroModelBusqueda.nombres, terceroModelBusqueda.apellidos);
                    datosTerceros = dbTerceros.GetTerceros(strNit, strNombres, strApellidos);
                    UpdateDatosTerceros();
                    break;
                case "TipoTran":
                    datosTipoTran = dbTipoTran.GetTipo_Tran("");
                    UpdateDatosTipoTran();
                    break;
                case "TipoTranMov":
                    datosTipoTran = dbTipoTran.GetTipo_Tran("5");
                    UpdateDatosTipoTran();
                    break;
                case "CuentaMovimiento":
                    DataAcces_Cuentas db2 = new DataAcces_Cuentas();
                    datosCuentas = db2.GetCuentasAfectables();
                    UpdateDatosCuentas();
                    break;
            }
        }


        private void btnEscoger_Click(object sender, EventArgs e)
        {
            try
            {
                //set parameters of your event args
                var eventArgs = new DataGridViewCellEventArgs(0, Int32.Parse(grdViewDatos.CurrentRow.Index.ToString()));
                grdViewDatos_CellContentClick(sender, eventArgs);
            }
            catch {
                this.Close();
             }
        }

        private void grdViewDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow;
            tipo_transacciones modeloTipoTran = new tipo_transacciones();
            try
            {
                switch (strFormCall)
                {
                    case "Centro":
                        Centro modeloCentro = new Centro();
                        selectedRow = Convert.ToInt32(grdViewDatos.RowCount);
                        if (selectedRow > -1)
                        {
                            string selectedId = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[0].Value);
                            modeloCentro.id = Int32.Parse(selectedId);
                            string selectedCentro = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[1].Value);
                            modeloCentro.centro = selectedCentro;
                            string selectedDescription = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[2].Value);
                            modeloCentro.descripcion = selectedDescription;
                            callingFormCentro.CentroComplete(modeloCentro);
                            this.Close();
                        }
                        break;
                    case "Cuenta":
                        Cuenta modeloCuenta = new Cuenta();
                        selectedRow = Convert.ToInt32(grdViewDatos.RowCount);
                        if (selectedRow > -1)
                        {
                            string selectedId = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[0].Value);
                            modeloCuenta.id = Int32.Parse(selectedId);
                            string selectedCuenta = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[1].Value);
                            modeloCuenta.cuenta = selectedCuenta;
                            string selectedDescription = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[2].Value);
                            modeloCuenta.descripcion = selectedDescription;
                            string selectedAfe = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[3].Value);
                            modeloCuenta.afe = Int32.Parse(selectedAfe);
                            string selectedNaturaleza = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[10].Value);
                            modeloCuenta.naturaleza = Int32.Parse(selectedNaturaleza);
                            callingFormCuenta.CuentaComplete(modeloCuenta);
                            this.Close();
                        }
                        break;
                    case "Tercero":
                        Tercero modeloTercero = new Tercero();
                        selectedRow = Convert.ToInt32(grdViewDatos.RowCount);
                        if (selectedRow > -1)
                        {
                            string selectedId = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[0].Value);
                            modeloTercero.id = Int32.Parse(selectedId);
                            string selectedNit = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[1].Value);
                            modeloTercero.nit= selectedNit;
                            string selectedNombresT = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[2].Value);
                            modeloTercero.nombres = selectedNombresT;
                            string selectedApellidosT = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[3].Value);
                            modeloTercero.apellidos = selectedApellidosT;
                            string selectedTipoIdentificacion = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[4].Value);
                            modeloTercero.tipo_identificacion = selectedTipoIdentificacion;
                            string selectedEstado = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[5].Value);
                            modeloTercero.estado = selectedEstado;
                            string selectedMail = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[6].Value);
                            modeloTercero.email = selectedMail;
                            callingFormTercero.TerceroComplete(modeloTercero);
                            this.Close();
                        }
                        break;
                    case "TipoTran":
                        selectedRow = Convert.ToInt32(grdViewDatos.RowCount);
                        if (selectedRow > -1)
                        {
                            string selectedId = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[0].Value);
                            modeloTipoTran.id = Int32.Parse(selectedId);
                            string selectedTipo = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[1].Value);
                            modeloTipoTran.tipo = selectedTipo;
                            string selectedDescription = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[2].Value);
                            modeloTipoTran.descripcion = selectedDescription;
                            string selectedSw = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[3].Value);
                            modeloTipoTran.sw = selectedSw;
                            string selectedSiguiente = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[4].Value);
                            modeloTipoTran.siguiente = Int32.Parse(selectedSiguiente);
                            callingFormTipoTran.Tipo_Tran_Complete(modeloTipoTran);
                            this.Close();
                        }
                        break;
                    case "TipoTranMov":
                        selectedRow = Convert.ToInt32(grdViewDatos.RowCount);
                        if (selectedRow > -1)
                        {
                            string selectedId = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[0].Value);
                            modeloTipoTran.id = Int32.Parse(selectedId);
                            string selectedTipo = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[1].Value);
                            modeloTipoTran.tipo = selectedTipo;
                            string selectedDescription = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[2].Value);
                            modeloTipoTran.descripcion = selectedDescription;
                            string selectedSw = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[3].Value);
                            modeloTipoTran.sw = selectedSw;
                            string selectedSiguiente = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[4].Value);
                            modeloTipoTran.siguiente = Int32.Parse(selectedSiguiente);
                            callingFormMovimiento.Movimiento_Complete(modeloTipoTran);
                            this.Close();
                        }
                        break;
                    case "CuentaMovimiento":
                        Cuenta modeloCuentaMovimiento = new Cuenta();
                        selectedRow = Convert.ToInt32(grdViewDatos.RowCount);
                        if (selectedRow > -1)
                        {
                            string selectedId = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[0].Value);
                            modeloCuentaMovimiento.id = Int32.Parse(selectedId);
                            string selectedCuenta = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[1].Value);
                            modeloCuentaMovimiento.cuenta = selectedCuenta;
                            string selectedDescription = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[2].Value);
                            modeloCuentaMovimiento.descripcion = selectedDescription;
                            string selectedAfe = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[3].Value);
                            modeloCuentaMovimiento.afe = Int32.Parse(selectedAfe);
                            string selectedNaturaleza = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[10].Value);
                            modeloCuentaMovimiento.naturaleza = Int32.Parse(selectedNaturaleza);
                            callingFormMovimiento.CuentaComplete(modeloCuentaMovimiento);
                            this.Close();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        
    }
}
