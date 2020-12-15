using ProyectoAdo.Data;
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
    public partial class Form11HospitalesPlantilla : Form
    {
        PlantillaContext context;
        public Form11HospitalesPlantilla()
        {
            InitializeComponent();
            this.context = new PlantillaContext();
            this.CargarHospitales();
        }

        private void CargarHospitales()
        {
            List<String> hospitales = this.context.GetHospitales();
            int cont = 50;
            for (int i = 0; i<hospitales.Count; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = hospitales[i];
                checkBox.Location = new Point(60, cont);
                this.panel1.Controls.Add(checkBox);

                cont += 50;
            }
        }
    }
}
