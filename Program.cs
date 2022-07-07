using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_OfficeAssigment
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                List<Department> departments = new List<Department>();
                FillData(departments);
                Application.Run(new Form1(departments));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void FillData (List<Department> departments)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LG4RSUG\\SQLEXPRESS;Initial Catalog=HR_Database;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Department", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            foreach (DataRow dr in dt.Rows)
            {
                Department TempDep = new Department();
                TempDep.DepartmentName = dr["Dep_Name"].ToString();
                TempDep.DepartmentCode = int.Parse(dr["Dep_Code"].ToString());
                TempDep.myEmployees = new List<Employee>();
                FillData(TempDep.myEmployees,TempDep.DepartmentCode);

                foreach (Employee emp in TempDep.myEmployees)
                {
                    if (FindManager(emp.EmployeeId) == emp.EmployeeId)
                    {
                        TempDep.myManager = new Manager();
                        TempDep.myManager.EmployeeId = emp.EmployeeId;
                        TempDep.myManager.EmployeeName = emp.EmployeeName;
                        TempDep.myManager.EmployeeSalary = emp.EmployeeSalary;
                        TempDep.myManager.AllowedSickLeave = emp.AllowedSickLeave;
                        TempDep.myManager.BirthDate = emp.BirthDate;
                        TempDep.myManager.DateHired = emp.DateHired;
                        TempDep.myManager.TakenSickLeave = emp.TakenSickLeave;

                    }
                   
                }

                departments.Add(TempDep);

            }
            con.Close();
        }
        public static void FillData (List<Employee> employees, int depCode)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LG4RSUG\\SQLEXPRESS;Initial Catalog=HR_Database;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Employee where Department_Code=@DepCode", con);
            cmd.Parameters.AddWithValue("@DepCode", depCode);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

                Employee temEmployee = new Employee();
                temEmployee.EmployeeName = dr["Employee_Name"].ToString();
                temEmployee.EmployeeId = int.Parse(dr["Employee_ID"].ToString());
                temEmployee.BirthDate = DateTime.Parse(dr["Birth_Date"].ToString());
                temEmployee.DateHired = DateTime.Parse(dr["Hire_Date"].ToString());
                temEmployee.EmployeeSalary = decimal.Parse(dr["Annual_Salary"].ToString());
                temEmployee.AllowedSickLeave = int.Parse(dr["Allowable_SickLeave"].ToString());
                temEmployee.TakenSickLeave = int.Parse(dr["Taken_SickLeave"].ToString());
                employees.Add(temEmployee);
            }
            con.Close();
        }

        public static int FindManager(int ManagerId)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LG4RSUG\\SQLEXPRESS;Initial Catalog=HR_Database;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Manager where Manager_Id=@ManId", con);
            cmd.Parameters.AddWithValue("@ManId", ManagerId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int ManID=0;
            foreach (DataRow dr in dt.Rows)
            {
                ManID = int.Parse(dr["Manager_Id"].ToString());
            }

            con.Close();

            return ManID;

        }    
    }
    
}
