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
    public partial class Form10ClasesEmpleado : Form
    {
        EmpleadoContext context;
        public Form10ClasesEmpleado()
        {
            InitializeComponent();
            this.context = new EmpleadoContext();
            this.CargarEmpleados();
            this.CargarOficios();

        }

        private void CargarEmpleados()
        {
            List<Empleado> empleados = this.context.GetEmpleados();
            this.lsvEmpleados.Items.Clear();
            foreach(Empleado emp in empleados)
            {
                ListViewItem it = new ListViewItem();
                it.Text = emp.IdEmpleado.ToString(); ;
                it.SubItems.Add(emp.Apellido);
                it.SubItems.Add(emp.Oficio);
                it.SubItems.Add(emp.Salario.ToString());
                this.lsvEmpleados.Items.Add(it);
            }
        }

        private void CargarOficios() 
        {
            List<String> oficios = this.context.GetOficios();
            for(int i = 0; i<oficios.Count; i++)
            {
                this.cbOficios.Items.Add(oficios[i]);
            }
        }
        private void CargarEmpleadosOficio(String oficio)
        {
            List<Empleado> empleados = this.context.GetEmpleadosOficio(oficio);
            this.lsvEmpleados.Items.Clear();
            foreach (Empleado emp in empleados)
            {
                ListViewItem it = new ListViewItem();
                it.Text = emp.IdEmpleado.ToString(); ;
                it.SubItems.Add(emp.Apellido);
                it.SubItems.Add(emp.Oficio);
                it.SubItems.Add(emp.Salario.ToString());
                this.lsvEmpleados.Items.Add(it);
            }
        }

        private void cbOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            String oficio = this.cbOficios.SelectedItem.ToString();
            this.CargarEmpleadosOficio(oficio);
        }

        private void btIncrementar_Click(object sender, EventArgs e)
        {
            String oficio = this.cbOficios.SelectedItem.ToString();
            int aumento = int.Parse(this.txtIncremento.Text);
            this.context.IncrementarSalarios(aumento, oficio);
            this.CargarEmpleadosOficio(oficio);
        }
    }
}
