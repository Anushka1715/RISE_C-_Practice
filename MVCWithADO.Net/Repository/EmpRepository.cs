using MVCWithADO.Net.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MVCWithADO.Net.Repository
{
    public class EmpRepository
    {
        private SqlConnection _connection;

        private void connection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["Conn"].ToString();
            _connection = new SqlConnection(connStr);
        }

        //To Add Employee details    
        public bool AddEmployee(EmpModel obj)
        {

            connection();
            SqlCommand com = new SqlCommand("AddNewEmpDetails", _connection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Name", obj.Name);
            com.Parameters.AddWithValue("@City", obj.City);
            com.Parameters.AddWithValue("@Address", obj.Address);

            _connection.Open();
            int i = com.ExecuteNonQuery();
            _connection.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }


        }

        //To view employee details with generic list     
        public List<EmpModel> GetAllEmployees()
        {
            connection();
            List<EmpModel> EmpList = new List<EmpModel>();


            SqlCommand com = new SqlCommand("GetEmployees", _connection);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            _connection.Open();
            da.Fill(dt);
            _connection.Close();
            //Bind EmpModel generic list using dataRow     
            foreach (DataRow dr in dt.Rows)
            {

                EmpList.Add(

                    new EmpModel
                    {

                        Empid = Convert.ToInt32(dr["Empid"]),
                        Name = Convert.ToString(dr["Name"]),
                        City = Convert.ToString(dr["City"]),
                        Address = Convert.ToString(dr["Address"])

                    }
                    );
            }

            return EmpList;
        }

        //To Update Employee details    
        public bool UpdateEmployee(EmpModel obj)
        {

            connection();
            SqlCommand com = new SqlCommand("UpdateEmpDetails", _connection);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@EmpId", obj.Empid);
            com.Parameters.AddWithValue("@Name", obj.Name);
            com.Parameters.AddWithValue("@City", obj.City);
            com.Parameters.AddWithValue("@Address", obj.Address);
            _connection.Open();
            int i = com.ExecuteNonQuery();
            _connection.Close();
            if (i >= 1)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        //To delete Employee details    
        public bool DeleteEmployee(int Id)
        {

            connection();
            SqlCommand com = new SqlCommand("DeleteEmpById", _connection);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@EmpId", Id);

            _connection.Open();
            int i = com.ExecuteNonQuery();
            _connection.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {

                return false;
            }
        }


    }
}