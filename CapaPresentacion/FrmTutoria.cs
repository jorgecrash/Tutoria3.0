using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FrmTutoria : Form
    {
        N_Tutoria oTutoria = new N_Tutoria();
        public FrmTutoria()
        {
            InitializeComponent();
            MostrarTablaTutoria();
            OcultarMoverAncharColumnas();
        }
        public void OcultarMoverAncharColumnas()
        {
            TablaTutoria.Columns[0].DisplayIndex = 6;//0
            TablaTutoria.Columns[1].DisplayIndex = 6;//1

            TablaTutoria.Columns[0].Width = 10;
            TablaTutoria.Columns[1].Width = 10;
            TablaTutoria.Columns[2].Width = 200;
            TablaTutoria.Columns[3].Width = 200;
            TablaTutoria.Columns[4].Width = 250;
            TablaTutoria.Columns[5].Width = 200;
            TablaTutoria.Columns[6].Width = 170;
        }
        public void MostrarTablaTutoria()
        {
            N_Tutoria oTutoria = new N_Tutoria();
            TablaTutoria.DataSource = oTutoria.ListingTutorias();
        }
        public void BuscarTutoria(string search)
        {
            N_Tutoria oTutoria = new N_Tutoria();
            TablaTutoria.DataSource = oTutoria.SearchingTutorias(search);

        }
        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarTutoria(textBuscar.Text);
        }
        private void btnAgregarTutoria_Click(object sender, EventArgs e)
        {
            FrmMantTutoria frm = new FrmMantTutoria();
            frm.ShowDialog();
            frm.Update = false;
            MostrarTablaTutoria();
        }

        private void TablaTutoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {

        }

        private void TablaTutoria_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
