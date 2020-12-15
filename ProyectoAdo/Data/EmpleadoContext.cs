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
    public class EmpleadoContext
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public EmpleadoContext()
        {
            String cadena = ConfigurationManager.ConnectionStrings["conexionhospital"].ConnectionString;
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<Empleado> GetEmpleados()
        {
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = "SELECT * FROM EMP";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<Empleado> empleados = new List<Empleado>();
            while (this.reader.Read())
            {
                Empleado emp = new Empleado();
                emp.IdEmpleado = Convert.ToInt32(this.reader["EMP_NO"]);
                emp.Apellido = this.reader["APELLIDO"].ToString();
                emp.Oficio = this.reader["OFICIO"].ToString();
                emp.Direccion = Convert.ToInt32(this.reader["DIR"]);
                emp.FechaAlta = Convert.ToDateTime(this.reader["FECHA_ALT"]);
                emp.Salario = Convert.ToInt32(this.reader["SALARIO"]);
                emp.Dept_NO = Convert.ToInt32(this.reader["DEPT_NO"]);
                empleados.Add(emp);
            }
            this.reader.Close();
            this.cn.Close();
            return empleados;
        }
        public List<Empleado> GetEmpleadosOficio(String oficio)
        {
            this.com.Parameters.AddWithValue("@OFICIO", oficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = "SELECT * FROM EMP WHERE OFICIO=@OFICIO";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<Empleado> empleados = new List<Empleado>();
            while (this.reader.Read())
            {
                Empleado emp = new Empleado();
                emp.IdEmpleado = Convert.ToInt32(this.reader["EMP_NO"]);
                emp.Apellido = this.reader["APELLIDO"].ToString();
                emp.Oficio = this.reader["OFICIO"].ToString();
                emp.Direccion = Convert.ToInt32(this.reader["DIR"]);
                emp.FechaAlta = Convert.ToDateTime(this.reader["FECHA_ALT"]);
                emp.Salario = Convert.ToInt32(this.reader["SALARIO"]);
                emp.Dept_NO = Convert.ToInt32(this.reader["DEPT_NO"]);
                empleados.Add(emp);
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return empleados;
        }

        public List<String> GetOficios()
        {
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = "SELECT DISTINCT OFICIO FROM EMP";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<String> oficios = new List<string>();
            while (this.reader.Read())
            {
                oficios.Add(this.reader.GetString(0));
            }
            this.reader.Close();
            this.cn.Close();
            return oficios;
        }

        public int IncrementarSalarios(int aumento, String oficio)
        {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "INCREMENTOSALARIOOFIO";
            this.com.Parameters.AddWithValue("@AUMENTO", aumento);
            this.com.Parameters.AddWithValue("@OFICIO", oficio);
            this.cn.Open();
            int updates = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return updates;
        }

    }
}
