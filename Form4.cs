using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_OfficeAssigment
{
    public partial class ManagerWindow : Form
    {
        BindingSource bs = new BindingSource();
        public ManagerWindow()
        {
            InitializeComponent();
            InitializeBindings();
            LoadData();
            update();
            
        }
        private void update ()
        {
            List<Manager> tempMan = new List<Manager>();
            foreach (Department dep in Form1.departments)
            {
                tempMan.Add(dep.myManager);
            }
            //List<Department> tempDep = new List<Department>();
            //tempDep = Form1.departments;
            List<Employee> tempEmp = new List<Employee>();
            foreach (Department dep in Form1.departments)
            {
                foreach (Employee emp in dep.myEmployees.ToList())
                {
                    tempEmp.Add(emp);
                }
            }

            foreach (Manager man in tempMan.ToList())
            {
                foreach (Employee emp in tempEmp.ToList())
                {
                    if (man.EmployeeId == emp.EmployeeId)
                    {
                        tempEmp.Remove(emp);
                    }
                }
            }

            EmpList.DataSource = tempEmp;
            EmpList.DisplayMember = "EmployeeName";
        }
        private void InitializeBindings()
        {

            bs.DataSource = Form1.departments.ToList();
            DepList.DataSource = bs;
            DepList.DisplayMember = "DepartmentName";
            
        }

        private void ManagerWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadData ()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Department Code", typeof(int));
            table.Columns.Add("Department Name", typeof(string));
            table.Columns.Add("Manager", typeof(string));
            table.Columns.Add("Manager ID", typeof(int));
            foreach (Department dep in Form1.departments)
            {
                table.Rows.Add(dep.DepartmentCode, dep.DepartmentName, dep.myManager.EmployeeName, dep.myManager.EmployeeId);
            }
            ManagersTable.DataSource = table;
        }
        private void DepList_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private int AssignDep(Employee selEmploy, Department selDepa)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LG4RSUG\\SQLEXPRESS;Initial Catalog=HR_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Employee set Department_Code= @Dep_Code" +
                " where Employee_ID=@newMan", con);
            cmd.Parameters.AddWithValue("@Dep_Code", selDepa.DepartmentCode);
            cmd.Parameters.AddWithValue("@newMan", selEmploy.EmployeeId);
            int test = cmd.ExecuteNonQuery();
            con.Close();
            return test;    
            
        }

        private void AssignMan_Click(object sender, EventArgs e)
        {
            Employee SelectedMan = new Employee();
            Department SelectedDep = new Department();
            SelectedDep = (Department)DepList.SelectedItem;
            SelectedMan = (Employee)EmpList.SelectedItem;
            if (AssignDep(SelectedMan,SelectedDep)!=  0)
            {
                //Form1.departments.Find(x => x.DepartmentCode == SelectedDep.DepartmentCode).myManager = SelectedMan;

                if (MessageBox.Show("Do you want to update this employee?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-LG4RSUG\\SQLEXPRESS;Initial Catalog=HR_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Manager set Manager_Id= @ManId" +
                        " where Manager_Id=@newMan" , con);
                    cmd.Parameters.AddWithValue("@ManId", SelectedMan.EmployeeId);
                    cmd.Parameters.AddWithValue("@newMan", SelectedDep.myManager.EmployeeId);
                
                    int test = cmd.ExecuteNonQuery();
                    if (test != 0)
                    {
                        MessageBox.Show("Manager assigned");
                        Form1.departments.Clear();
                        Program.FillData(Form1.departments);
                        bs.ResetBindings(true);
                        LoadData();

                    }
                    else
                    {
                        MessageBox.Show("Error Assigning Manager");
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Error Assigning Manager");
                }
            }
        }

        private void ManagersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 DepartmentFormInfo = new Form1();
            DepartmentFormInfo.Show();
            this.Visible = false;
        }

        private void EmpList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
