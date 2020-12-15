using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using ProyectoAdo.Models;

namespace ProyectoAdo.Data
{
    public class PlantillaContext
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public PlantillaContext()
        {
            String cadena = ConfigurationManager.ConnectionStrings["conexionhospital"].ConnectionString;
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<String> GetHospitales()
        {
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = "SELECT NOMBRE FROM HOSPITAL";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<String> hospitales = new List<string>();
            while (this.reader.Read())
            {
                hospitales.Add(this.reader["NOMBRE"].ToString());
            }
            return hospitales;

        }

        public List<Plantilla> GetPlantilla(String oficio)
        {
            this.com.Parameters.AddWithValue("@OFICIO", oficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = "SELECT";
        }
    }
}
