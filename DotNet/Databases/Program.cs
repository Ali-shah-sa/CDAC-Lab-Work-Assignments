
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using Microsoft.Data.SqlClient;
using System.Data;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Transactions;

namespace Databases
{
    internal class Program
    {
        static void Main()

        {
            Employee obj = new Employee { EmpNo = 10, Name = "Alfred D'Mello", Basic = 10000, DeptNo = 20 };


            // Insert2(obj);
            InsertWithParameters(obj);

            //InsertWithStoredProcedure(obj);
            // SelectSingleValue();
           // MultipleValuesUsingDataReader();

            // Select();
            // Delete(2);
        }


        static void Main2()
        {
            List<Employee> list = GetAllEmployee();
            foreach (var item in list)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Name);
            }

        }





        static void Main3()
        {
            Employee emp = GetSingleEmployee(10);
            if (emp != null)
            {
                Console.WriteLine(emp.Name);

            }
            else
            {
                Console.WriteLine("NotFound");
            }
        }

        static void Main1()
        {
            //NextResult();
            //MARS();
            //CallFuncReturningSqlDataReader();
            //Transaction();







            //AsyncConnCode2();
            //AsyncConnCode();
            //AsyncCommand();
            //AsyncCommand2DataReader();








        }



        //private static void CallFuncReturningSqlDataReader()
        //{
        //    throw new NotImplementedException();
        //}

        //private static void Transactions()
        //{
        //    throw new NotImplementedException();
        //}

        static void Connect()
        {

            SqlConnection cn = new SqlConnection();
            // Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HydMay25; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False;

            // cn.ConnectionString=@"Data source=(localdb)\MSSQLLocalDB;Initial Catalog = HydMay25;User Id=sa;Password=sa";

            cn.ConnectionString =
       @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HydMay25;Integrated Security=True";
            try
            {
                cn.Open();
                Console.WriteLine("Connected");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }


        }

        static void Insert()
        {
            SqlConnection cn = new SqlConnection();

            cn.ConnectionString =
           @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HydMay25;Integrated Security=True";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Employees values(4,'Shweta',20000,10)";
                cmd.ExecuteNonQuery();
                Console.WriteLine("Connected");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();

            }

        }

        static void Select()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HydMay25;Integrated Security=True";

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Employees";

                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("Employee Details:");
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["EmployeeId"]}, Name: {reader["Name"]}, Salary: {reader["Salary"]}, Dept: {reader["DepartmentId"]}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while selecting records: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        static void Delete(int employeeId)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HydMay25;Integrated Security=True";

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Employees WHERE EmpNo = @empId";
                cmd.Parameters.AddWithValue("@empId", employeeId);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine($"Employee with ID {employeeId} deleted successfully.");
                }
                else
                {
                    Console.WriteLine($"No employee record found with ID {employeeId}.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while deleting record: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }




        static void Insert2(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString =
       @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HydMay25;Integrated Security=True";
            try
            {
                cn.Open();
                //command
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                $"insert into Employees values({obj.EmpNo},'{obj.Name}',{obj.Basic}, {obj.DeptNo})";

                Console.WriteLine(cmd.CommandText);
                Console.ReadLine();
                cmd.ExecuteNonQuery();

                Console.WriteLine("inserted");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }
        static void InsertWithParameters(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HydMay25;Integrated Security=True";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)";

                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);
                cmd.ExecuteNonQuery();
                Console.WriteLine("inserted");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }


        }

        static void InsertWithStoredProcedure(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HydMay25;Integrated Security=True";

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertEmployee";
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);

                cmd.Parameters.AddWithValue("@Basic", obj.Basic);

                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Inserted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { cn.Close(); }
        }


        static void SelectSingleValue()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HydMay25;Integrated Security=True";



            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count (*) from Employees";


                //cmd.CommandText = "Select * from Employee";
                object retval = cmd.ExecuteScalar();
                Console.WriteLine(retval);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { cn.Close(); }

        }



        static void MultipleValuesUsingDataReader()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HydMay25;Integrated Security=True";

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Employees";

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[1]);
                    Console.WriteLine(dr["Name"]);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { cn.Close(); }
        }

        /// exam<summary>
        /// databases
        /// file handling 
        /// serialization
        /// </summary>
        /// <returns></returns>

        static List<Employee> GetAllEmployee()
        {//db file handling Serialization

            List<Employee> lstEmps = new List<Employee>();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString =
                 @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HydMay25;Integrated Security=True";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Employees";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Employee emp = new Employee();

                    emp.EmpNo = dr.GetInt32("EmpNo");
                    emp.Name = dr.GetString("Name");
                    emp.Basic = dr.GetDecimal("Basic");
                    emp.DeptNo = dr.GetInt32("DeptNo");
                    lstEmps.Add(emp);




                }

                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }
            finally
            {
                cn.Close();
            }
            return lstEmps;
        }

        static Employee GetSingleEmployee(int EmpNo)
        {
            Employee? emp = null;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HydMay25;Integrated Security=True";

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Employees where EmpNo=@EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    emp = new Employee();
                    emp.EmpNo = dr.GetInt32("EmpNo");
                    emp.Name = dr.GetString("Name");
                    emp.Basic = dr.GetDecimal("Basic");
                    emp.DeptNo = dr.GetInt32("DeptNo");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return emp!;



        }

        static void NextResult()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HydMay25;Integrated Security=True";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Employees;select * from Departments";

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["Name"]);

                }
                Console.WriteLine();
                dr.NextResult();
                while (dr.Read())
                {
                    Console.WriteLine(dr["DeptName"]);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                cn.Close();
            }

        }


        static void MARS()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=HydMay25;Integrated Security=true;MultipleActiveResultSets=true";
            cn.Open();

            SqlCommand cmdDept = new SqlCommand();
            cmdDept.Connection = cn;
            cmdDept.CommandType = CommandType.Text;
            cmdDept.CommandText = "Select * from Departments";
            SqlCommand cmdEmps = new SqlCommand();
            cmdEmps.Connection = cn;
            cmdEmps.CommandType = CommandType.Text;

            SqlDataReader drDepts = cmdDept.ExecuteReader();
            while (drDepts.Read())
            {
                Console.WriteLine(drDepts["Name"]);
                cmdEmps.CommandText = "Select * from Employees where DeptNo = " + drDepts["DeptNo"];
                SqlDataReader drEmps = cmdEmps.ExecuteReader();
                while (drEmps.Read())
                {
                    Console.WriteLine(("    " + drEmps["Name"]));
                }
                drEmps.Close();
            }
            drDepts.Close();
            cn.Close();

        }

        static void CallFuncReturnSqlDataReader()
        {
            // SqlConnection cn = new SqlConnection();
            SqlDataReader dr = GetDataReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[1]);
                dr.Close();
            }
            static SqlDataReader GetDataReader()
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HydMay25;Integrated Security=True";

                cn.Open();
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = System.Data.CommandType.Text;

                cmdInsert.CommandText = "select * from Employee";
                cmdInsert.ExecuteReader();
                SqlDataReader dr = cmdInsert.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }

            static void Transactions()
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HydMay25;Integrated Security=True";

                cn.Open();
                SqlTransaction t = cn.BeginTransaction();
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.Transaction = t;
                cmdInsert.CommandType = System.Data.CommandType.Text;

                cmdInsert.CommandText = "insert into Employees values(10, 'Shweta', 12345, 30)";

                SqlCommand cmdInsert2 = new SqlCommand();
                cmdInsert2.Connection = cn;
                cmdInsert2.Transaction = t;

                cmdInsert2.CommandType = System.Data.CommandType.Text;
                cmdInsert2.CommandText = "insert into Employees values(1, 'Shweta', 12345, 30)";
                try
                {
                    cmdInsert.ExecuteNonQuery();
                    cmdInsert2.ExecuteNonQuery();
                    t.Commit();
                    Console.WriteLine("no errors- commit");
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    Console.WriteLine("Rollback");
                    Console.WriteLine(ex.Message);
                }
                cn.Close();



            }
        }


        ////AsyncCode
        //static async void AsyncConnCode2()
        //{
        //    SqlConnection conn=new SqlConnection();
        //    conn.ConnectionString = "";
        //    await conn.OpenAsync();
        //    await conn.CloseAsync();
        //}
        //static async void AsyncConnCode()
        //{
        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString = "";
        //    Task t = conn.OpenAsync();
        //    Console.WriteLine("Waiting for code");

        //    if (!t.IsCompleted)
        //        t.Wait();

        //    await conn.CloseAsync();
        //}
        //static async void AsyncCommand()
        //{
        //    SqlConnection cn = new SqlConnection();
        //    cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ActsJan23;Integrated Security=True";

        //    await cn.OpenAsync();//async connection
        //    try
        //    {
        //        SqlCommand cmdInsert = new SqlCommand();
        //        cmdInsert.Connection = cn;
        //        cmdInsert.CommandType = CommandType.Text;
        //        cmdInsert.CommandText = "insert into Employees values(40,'Ganesh',10000,20)";


        //        await cmdInsert.ExecuteNonQueryAsync();
        //        Console.WriteLine("Okay");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //    if (cn.State == ConnectionState.Open)
        //        cn.Close();
        //}


        //static async void AsyncCommand2DataReader()
        //{
        //    SqlConnection cn=new SqlConnection();
        //    cn.ConnectionString= @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ActsJan23;Integrated Security=True";
        //    cn.Open();
        //    SqlCommand cmdInsert = new SqlCommand();
        //    cmdInsert.Connection = cn;
        //    cmdInsert.CommandType= CommandType.Text;
        //    cmdInsert.CommandText = "Select * from Employees";

        //    //SqlDataReader dr = await cmdInsert.ExecuteReaderAsync();
        //    Task<SqlDataReader> t1=cmdInsert.ExecuteReaderAsync();
        //    t1.Start();
        //    t1.Wait();
        //    SqlDataReader dr = t1.Result;
        //    Console.ReadLine();


        //}

        //static void AsyncDataReader2()
        //{
        //    SqlConnection cn=new SqlConnection();
        //    cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpApr25;Integrated Security=True;";
        //    try
        //    {
        //        cn.Open();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = cn;
        //        cmd.CommandType = System.Data.CommandType.Text;
        //        cmd.CommandText = "select * from Employees";


        //        Console.WriteLine("Before calling data Reader");
        //        cmd.BeginExecuteReader(delegate (IAsyncResult ar)
        //            {
        //                SqlDataReader dr = cmd.EndExecuteReader(ar);
        //                while (dr.Read())
        //                {
        //                    Console.WriteLine(dr[0]);
        //                }
        //                dr.Close();
        //            }, null);
        //        Console.WriteLine("After Calling Data Reader");

        //        Console.WriteLine("press enter to end");
        //        Console.ReadLine();
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }


        //    }

        //}
    }
            class Employee
    {
        public int EmpNo { get; set; }
        public decimal Basic { get; set; }
        public string? Name { get; set; }

        public int DeptNo { get; set; }
    }

}
