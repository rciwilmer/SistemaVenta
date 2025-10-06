using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace SistemaVenta
{
    public partial class Agregar_Clientes : Form
    {

        //ConexionBD conexionBD = new ConexionBD();


        public Agregar_Clientes()
        {
            InitializeComponent();
            this.BTN_MOSTRARCLIENTES.MouseEnter += new System.EventHandler(this.BTN_MOSTRARCLIENTES_MouseEnter);
            this.BTN_MOSTRARCLIENTES.MouseLeave += new System.EventHandler(this.BTN_MOSTRARCLIENTES_MouseLeaver);
        }

        //PARA LOS ESTILOS DEL BUTTON
         private void BTN_MOSTRARCLIENTES_MouseEnter(object sender, EventArgs e)
        {
            BTN_MOSTRARCLIENTES.BackColor = Color.Blue; //FONDO AZUL
            BTN_MOSTRARCLIENTES.ForeColor = Color.White;//LETRAS BLANCAS
        }

        private void BTN_MOSTRARCLIENTES_MouseLeaver(object sender, EventArgs e)
        {
            BTN_MOSTRARCLIENTES.BackColor = SystemColors.Control;//VUELVE AL COLOR NORMAL
            BTN_MOSTRARCLIENTES.ForeColor = Color.Black;//LETRAS NEGRAS NUEVAMENTE

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //verificar que se haya seleccionado una fila
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila= dataGridView1.Rows[e.RowIndex];

                //Asignamos los valores a las posiciones segun corresponda
                txtcodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtdni.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtnombres.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtapellidos.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtdireccion.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txttelefono.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtcorreo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                //combobx:
                comboBox1.SelectedValue= dataGridView1.CurrentRow.Cells[1].Value.ToString();

            }
        }
    }
}
