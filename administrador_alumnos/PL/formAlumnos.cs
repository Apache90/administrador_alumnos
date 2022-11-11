using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using administrador_alumnos.DAL;
using administrador_alumnos.BLL;
using System.IO;



namespace administrador_alumnos
{
    public partial class formAlumnos : Form
    {

        alumnosDAL oAlumnosDAL;
        Byte[] imagenByte;
        public formAlumnos()
        {
            oAlumnosDAL = new alumnosDAL();
            InitializeComponent();
            llenarGrid();


        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {      

            oAlumnosDAL.agregar(recuperarInformacion());
            llenarGrid();
            LimpiarEntradas();
        }

        private alumnosBLL recuperarInformacion()
        {
            alumnosBLL oAlumnosBLL = new alumnosBLL();

            int ID = 0; int.TryParse(txtID.Text,out ID);

            oAlumnosBLL.ID = ID;

            oAlumnosBLL.Escuela = txtESCUELA.Text;
            oAlumnosBLL.Año = txtAÑO.Text;
            oAlumnosBLL.Nombre = txtNOMBRE.Text;
            oAlumnosBLL.Apellido = txtAPELLIDO.Text;
            oAlumnosBLL.Materia = txtMATERIA.Text;
            oAlumnosBLL.Nota = txtNOTA.Text;
            oAlumnosBLL.Foto = imagenByte;


            return oAlumnosBLL;

        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            dgvALUMNOS.ClearSelection();

            if (indice >= 0)
            {
                txtID.Text = dgvALUMNOS.Rows[indice].Cells[0].Value.ToString();
                txtESCUELA.Text = dgvALUMNOS.Rows[indice].Cells[1].Value.ToString();
                txtAÑO.Text = dgvALUMNOS.Rows[indice].Cells[2].Value.ToString();
                txtNOMBRE.Text = dgvALUMNOS.Rows[indice].Cells[3].Value.ToString();
                txtAPELLIDO.Text = dgvALUMNOS.Rows[indice].Cells[4].Value.ToString();
                txtMATERIA.Text = dgvALUMNOS.Rows[indice].Cells[5].Value.ToString();
                txtNOTA.Text = dgvALUMNOS.Rows[indice].Cells[6].Value.ToString();

                btnAGREGAR.Enabled = false;
                btnMODIFICAR.Enabled = true;
                btnBORRAR.Enabled = true;
                btnCANCELAR.Enabled = true;
                btnADJUNTAR.Enabled = true;


            }

            
        }

        private void btnBORRAR_Click(object sender, EventArgs e)
        {
            oAlumnosDAL.eliminar(recuperarInformacion());
            llenarGrid();
            LimpiarEntradas();

        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            oAlumnosDAL.modificar(recuperarInformacion());
            llenarGrid();
            LimpiarEntradas();

        }
        public void llenarGrid()
        {
            dgvALUMNOS.DataSource = oAlumnosDAL.mostrarDepartamentos().Tables[0];

            dgvALUMNOS.Columns[0].HeaderText = "ID";
            dgvALUMNOS.Columns[1].HeaderText = "Escuela";
            dgvALUMNOS.Columns[2].HeaderText = "Año";
            dgvALUMNOS.Columns[3].HeaderText = "Nombre";
            dgvALUMNOS.Columns[4].HeaderText = "Apellido";
            dgvALUMNOS.Columns[5].HeaderText = "Materia";
            dgvALUMNOS.Columns[6].HeaderText = "Nota";
            dgvALUMNOS.Columns[7].HeaderText = "Foto";
        }
        public void LimpiarEntradas()
        {
            txtESCUELA.Text = "";
            txtAÑO.Text = "";
            txtNOMBRE.Text = "";
            txtAPELLIDO.Text = "";
            txtMATERIA.Text = "";
            txtNOTA.Text = "";
            picFOTO.Image = null;


            btnAGREGAR.Enabled = true;
            btnMODIFICAR.Enabled = false;
            btnBORRAR.Enabled = false;
            btnCANCELAR.Enabled = false;
            btnADJUNTAR.Enabled = true;

        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            LimpiarEntradas();
        }

        private void btnADJUNTAR_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar Imagen";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                picFOTO.Image=Image.FromStream(selectorImagen.OpenFile());
                MemoryStream memoria = new MemoryStream();

                picFOTO.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);
                imagenByte = memoria.ToArray();
            }
        }

        private void formAlumnos_Load(object sender, EventArgs e)
        {

        }
    }
}
