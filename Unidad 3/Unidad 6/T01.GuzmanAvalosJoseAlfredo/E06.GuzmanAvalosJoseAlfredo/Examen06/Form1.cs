using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen06
{
    public partial class FrmTarea : Form
    {
        //Instanciamos las clases
        Tarea ta = new Tarea();
        List<Tarea> lista = new List<Tarea>();
        frmDatos datos = new frmDatos();
       
        public FrmTarea()
        {
            InitializeComponent();
        }

        //Metodo para agregar tareas
        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            //creamos la condicion para crear la lista
          for (int n = 0; n < 1000; n++)
          {
            if (datos.ShowDialog() == DialogResult.OK)
            {
             Tarea t = new Tarea();

             //Agregramos la informacion de cada tarea
             dgvDatos.Rows.Add();
             dgvDatos.Rows[n].Cells[0].Value = datos.TxtUsuario.Text;
             t.Usuario = datos.TxtUsuario.Text;
             dgvDatos.Rows[n].Cells[1].Value = datos.txtTarea.Text;
             t.Nombre = datos.txtTarea.Text;
             dgvDatos.Rows[n].Cells[2].Value = datos.txtDescripcion.Text;
             t.Descripcion = datos.txtDescripcion.Text;
             dgvDatos.Rows[n].Cells[3].Value = datos.txtFecha.Text;
             t.Fecha = datos.txtFecha.Text;
             dgvDatos.Rows[n].Cells[4].Value = datos.txtHora.Text;
             t.Hora = datos.txtHora.Text;
             dgvDatos.Rows[n].Cells[5].Value = datos.txtStatus.Text;
             t.Status= datos.txtStatus.Text;
             lista.Add(t);

             //borramos los datos que se metieron en las cajas de texto
             datos.TxtUsuario.Text = "";
             datos.txtTarea.Text = "";
             datos.txtDescripcion.Text = "";
             datos.txtFecha.Text = "";
             datos.txtHora.Text = "";
             datos.txtStatus.Text = "";
            }
          }
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiamos los datasGridView
            dgvDatos.Columns.Clear();
            dgvDatos.Columns.Clear();
        }

        //Buscamos una tarea
        private void cmdDetalle_Click(object sender, EventArgs e)
        {
            //instanciamos el form de detalles
            FrmDetalles de = new FrmDetalles();
            //creamos la condicion para buscar en la lista la tarea
            if (de.ShowDialog() == DialogResult.OK)
            {
                if (de.txtTarea.Text != "")
                {
                    dgvDatos.CurrentCell = null;
                    //aqui pedimos comparar el nombre escrito con los ya existentes en la lista y asi imprimir esa tarea
                    foreach (DataGridViewRow r in dgvDatos.Rows)
                    {
                        if (de.txtTarea.Text == Convert.ToString(r.Cells["Tarea"].Value))
                        {
                            dgvDetalles.Rows.Add(r.Cells[0].Value, r.Cells[1].Value,
                                              r.Cells[2].Value, r.Cells[3].Value,
                                              r.Cells[4].Value, r.Cells[5].Value);
                            break;
                        }
                    } 
                }
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            //metodo para cerrar el programa
           Application.Exit();
        }

        private void cmdStatus_Click(object sender, EventArgs e)
        {
            //instanciamos el form Status
            frmStatus sta = new frmStatus();

            if (sta.ShowDialog() == DialogResult.OK)
            {
                //Buscamos la tarea que deseamos cambiar su status
                if (sta.txtNombre.Text != "")
                {
                    foreach (DataGridViewRow r in dgvDatos.Rows)
                    {
                        if (sta.txtNombre.Text == Convert.ToString(r.Cells["Tarea"].Value))
                        {
                            //Adicionamos el nuevo status a la celda de status y asi se cambia de status
                            dgvDetalles.Rows[r.Index].Cells[5].Value = sta.txtStatus.Text;
                            break;
                        }
                    }

                }
            }
        }
    }
}
