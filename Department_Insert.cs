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
    public partial class Department_Insert : Form
    {
        BindingSource bs = new BindingSource();

        public Department_Insert()
        {
            InitializeComponent();
            InitializeBindings();
        }
        private List<Employee> LoadData(List<Department> deps)
        {
            List<Employee> emps = new List<Employee>();
            
            foreach (Department dep in deps)
            {
                foreach (Employee emp in dep.myEmployees)
                {
                   
                    {
                        emps.Add(emp);
                    }
                }
                if(emps.Exists(x => x.EmployeeId == dep.myManager.EmployeeId))
                {
                    emps.Remove(emps.Find(x => x.EmployeeId == dep.myManager.EmployeeId));
                }
                
            }
            
            return emps; 
        }
        private void InitializeBindings()
        {
            bs.DataSource = LoadData(Form1.departments);
            EmployeeList.DataSource = bs;
            EmployeeList.DisplayMember = "EmployeeName";
        }

        private void CreateDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                Department dep = new Department();
                if (Form1.departments.Exists(e => e.DepartmentCode == int.Parse(DepCodeBox.Text)))
                {
                    MessageBox.Show("Department already Exists");
                }
                else
                {
                    dep.DepartmentCode = int.Parse(DepCodeBox.Text);
                    dep.DepartmentName = DepNamebox.Text;
                    Employee SelectedMan = (Employee)EmployeeList.SelectedItem;
                    Form1.departments.Add(dep);
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-LG4RSUG\\SQLEXPRESS;Initial Catalog=HR_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Department(Dep_Name,Dep_Code) values('" + DepNamebox.Text + "','" + DepCodeBox.Text + "')", con);

                    int test = cmd.ExecuteNonQuery();
                    if (test != 0)
                    {
                        //MessageBox.Show("Data Saved");
                        SqlCommand cmd2 = new SqlCommand("Update Employee set Department_Code=@Dep_Code" +
                            " where Employee_ID=@newMan", con);
                        cmd2.Parameters.AddWithValue("@Dep_Code", int.Parse(DepCodeBox.Text));
                        cmd2.Parameters.AddWithValue("@newMan", SelectedMan.EmployeeId);
                        int test2 = cmd2.ExecuteNonQuery();
                        if(test!=0)
                        {
                            SqlCommand cmd3 = new SqlCommand("insert into Manager (Manager_Id) values('" + SelectedMan.EmployeeId + "')", con);
                            cmd3.ExecuteNonQuery();
                            if (test != 0)
                            {
                                MessageBox.Show("Department created and updated");
                                Form1.departments.Clear();
                                Program.FillData(Form1.departments);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error saving");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DepNamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Depform = new Form1();
            Depform.Show();
            this.Visible = false;
        }
    }
}
