using ProyectoAdo.Data;
using ProyectoAdo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAdo
{
    public partial class Form09ClasesEnfermo : Form
    {
        EnfermoContext context;
        public Form09ClasesEnfermo()
        {
            InitializeComponent();
            this.context = new EnfermoContext();
            this.CargarEnfermos();
        }

        private void CargarEnfermos()
        {
            List<Enfermo> enfermos = this.context.GetEnfermos();
            this.lsvEnfermos.Items.Clear();
            foreach(Enfermo enf in enfermos)
            {
                ListViewItem it = new ListViewItem();
                it.Text = enf.Inscripcion.ToString();
                it.SubItems.Add(enf.Apellido);
                it.SubItems.Add(enf.Direccion);
                it.SubItems.Add(enf.FechaNacimiento.ToShortDateString());
                this.lsvEnfermos.Items.Add(it);

            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            ListViewItem it = this.lsvEnfermos.SelectedItems[0];
            this.btEliminar.Text = it.Text;
            int inscripcion = int.Parse(it.Text);
            this.context.EliminarEnfermo(inscripcion);
            this.CargarEnfermos();
        }

        private void lsvEnfermos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lsvEnfermos.SelectedItems.Count != 0)
            {
                ListViewItem it = this.lsvEnfermos.SelectedItems[0];
                this.btEliminar.Text = it.Text;

            }
        }
    }
}
