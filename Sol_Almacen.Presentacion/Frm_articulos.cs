using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Almacen.Presentacion
{
    public partial class Frm_articulos : Form
    {
        public Frm_articulos()
        {
            InitializeComponent();
        }
        #region "Mis métedos"

        private void Formato_ar()
        {
            Dgv_articulos.Columns[0].Width = 80;
            Dgv_articulos.Columns[0].HeaderText = "CODIGO";
            Dgv_articulos.Columns[1].Width = 250;
            Dgv_articulos.Columns[1].HeaderText = "ARTICULO";
            Dgv_articulos.Columns[2].Width = 150;
            Dgv_articulos.Columns[2].HeaderText = "MARCA";
            Dgv_articulos.Columns[3].Width = 80;
            Dgv_articulos.Columns[3].HeaderText = "MEDIDA";
            Dgv_articulos.Columns[4].Width = 150;
            Dgv_articulos.Columns[4].HeaderText = "CATEGORIA";
            Dgv_articulos.Columns[5].Width = 150;
            Dgv_articulos.Columns[5].HeaderText = "STOCK ACTUAL";
            Dgv_articulos.Columns[6].Visible = false;
            Dgv_articulos.Columns[7].Visible = false;
        }
        private void Listado_ar(string cTexto) 
        {
            D_Articulos Datos = new D_Articulos();
            Dgv_articulos.DataSource = Datos.Listado_ar(cTexto);
            this.Formato_ar();
        }

        private void Estado_texto(bool lEstado)
        {
            Txt_descripcion_ar.ReadOnly = !lEstado;
            Txt_marca_ar.ReadOnly = !lEstado;
            Txt_stock_actual.ReadOnly = !lEstado;
        }

        private void Estado_botones_procesos(bool lEstado)
        {
            Btn_lupa_um.Enabled = lEstado;
            Btn_lupa_ca.Enabled = lEstado;

            Btn_guardar.Visible = lEstado;
            Btn_cancelar.Visible = lEstado;

            //Otros detalles
            Txt_buscar.ReadOnly = lEstado;
            Btn_buscar.Enabled = !lEstado;
            Dgv_articulos.Enabled = !lEstado;
        }

        private void Estado_botones_principales(bool lEstado)
        {
            Btn_nuevo.Enabled = lEstado;
            Btn_actualizar.Enabled = lEstado;
            Btn_eliminar.Enabled = lEstado;
            Btn_reporte.Enabled = lEstado;
            Btn_salir.Enabled = lEstado;
        }

        private void Limpia_text()
        {
            Txt_descripcion_ar.Text = "";
            Txt_marca_ar.Text = "";
            Txt_descripcion_um.Text = "";
            txt_descripcion_ca.Text = "";
            Txt_stock_actual.Text = "";

        }

        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void Frm_articulos_Load(object sender, EventArgs e)
        {
            this.Listado_ar("%");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_lupa_um_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_marca_ar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Limpia_text();
            this.Estado_texto(false);
            this.Estado_botones_procesos(false);
            this.Estado_botones_principales(true);
            Txt_buscar.Focus();


        }

        private void Btn_lupa_ca_Click(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_ar("%" + Txt_buscar.Text.Trim() + "%");
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.Limpia_text();
            this.Estado_texto(true);
            this.Estado_botones_procesos(true);
            this.Estado_botones_principales(false);
            Txt_descripcion_ar.Focus();
        }
    }
}
