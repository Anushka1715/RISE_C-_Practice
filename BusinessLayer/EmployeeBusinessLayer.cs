using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetAllEmployees()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

            List<Employee> employees = new List<Employee>();

            using(SqlConnection connection = new SqlConnection(connectionString))
            {   
                SqlCommand cmd = new SqlCommand("GetEmployees", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Employee employee = new Employee();
                    employee.Empid = Convert.ToInt32(rdr["Empid"]);
                    employee.Name = rdr["Name"].ToString();
                    employee.City = rdr["City"].ToString();
                    employee.Address = rdr["Address"].ToString();

                    employees.Add(employee);
                }
                return employees;
            }
        }

        public void AddEmployee(Employee employee)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AddNewEmpDetails", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraName = new SqlParameter();
                paraName.ParameterName = "Name";
                paraName.Value = employee.Name; 
                cmd.Parameters.Add(paraName);

                SqlParameter paraCity = new SqlParameter();
                paraCity.ParameterName = "City";
                paraCity.Value = employee.City;
                cmd.Parameters.Add(paraCity);

                SqlParameter paraAddress = new SqlParameter();
                paraAddress.ParameterName = "Address";
                paraAddress.Value = employee.City;
                cmd.Parameters.Add(paraAddress);

                connection.Open();
                cmd.ExecuteNonQuery();

            }
        }

        public void UpdateEmployee(Employee employee)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateEmpDetails", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraId = new SqlParameter();
                paraId.ParameterName = "@EmpId";
                paraId.Value = employee.Empid;
                cmd.Parameters.Add(paraId);

                SqlParameter paraName = new SqlParameter();
                paraName.ParameterName = "@Name";
                paraName.Value = employee.Name;
                cmd.Parameters.Add(paraName);

                SqlParameter paraCity = new SqlParameter();
                paraCity.ParameterName = "@City";
                paraCity.Value = employee.City;
                cmd.Parameters.Add(paraCity);

                SqlParameter paraAddress = new SqlParameter();
                paraAddress.ParameterName = "@Address";
                paraAddress.Value = employee.Address;
                cmd.Parameters.Add(paraAddress);

                connection.Open();
                cmd.ExecuteNonQuery();

            }
        }

        public void DeleteEmployee(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DeleteEmpById", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraId = new SqlParameter();
                paraId.ParameterName = "@EmpId";
                paraId.Value = id;
                cmd.Parameters.Add(paraId);

                connection.Open();
                cmd.ExecuteNonQuery();

            }
        }
    }
}
