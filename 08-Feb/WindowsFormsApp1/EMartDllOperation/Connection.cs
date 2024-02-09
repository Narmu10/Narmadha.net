using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Data;

namespace EMartDllOperation
{
    public class Connection
    {
        public SqlConnection cn;

        public int Insert(string Name, string Department, string DOB)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into EMart (Name,Department,DOB) values('" + Name + "','" + Department + "','" + DOB + "');" + "SELECT SCOPE_IDENTITY()";
            cmd.Connection = cn;


            try
            {
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                return id;
            }
            catch
            {

                return -1;
            }

        }

        public void CreateConnection()
        {
            this.cn = new SqlConnection();
            this.cn.ConnectionString = "data source=EPINHYDW0BED\\SQLEXPRESS;Initial Catalog=WordVoyager;Integrated Security=True;";
            cn.Open();
            Console.WriteLine("Connection Succesfull");
        }
        public void Close()
        {
            this.cn.Close();
            Console.WriteLine("Closed");
        }

        static void Main(string[] args)
        {
            Connection connection = new Connection();
            connection.CreateConnection();
            Console.ReadLine();
        }



        public int Update(int rollno, string Name, string Department, string DOB)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Update EMart SET Name='" + Name + "',Department='" + Department + "',DOB='" + DOB + "' WHERE RollNumber=" + rollno + ";";
            cmd.Connection = cn;
            int id = Convert.ToInt32(cmd.ExecuteNonQuery());
            return id;

     
    }
        public int Delete(int rollNumber)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM EMart WHERE RollNumber =" + rollNumber;
            cmd.Connection = cn;
            return cmd.ExecuteNonQuery();

        }




     /*   public void Display()                                                                                   // datareader
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT RollNumber, Name, Department, DOB FROM EMart";
            cmd.Connection = cn;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int rollNumber = reader.GetInt32(0);
                string name = reader.GetString(1);
                string department = reader.GetString(2);
                DateTime dob = reader.GetDateTime(3);

                Console.WriteLine($"RollNumber: {rollNumber}, Name: {name}, Department: {department}, DOB: {dob.ToShortDateString()}");
            }

            reader.Close();
        }*/

        public DataSet Display()                                              //dataset
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM EMart";
            cmd.Connection = cn;
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.TableMappings.Add("TABLE", "EMart");
            DataSet ds= new DataSet();
            adp.Fill(ds);
            return ds;
           
        } 
    }
}



//insert,update,delete, display,Close



