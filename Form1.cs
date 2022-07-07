using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HR_OfficeAssigment
{
    public partial class Form1 : Form
    {

        //public static int SetDepartmentCode { get; set; }
        public static List<Department> departments { get; set; }

        public Form1(List<Department> DepartmentsList)
        {
            InitializeComponent();
            departments = DepartmentsList;
            InitialTable();
        }
        public Form1()
        {
            InitializeComponent();
            InitialTable();
        }
        private void InitialTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Department Code", typeof(int));
            table.Columns.Add("Department Name", typeof(string));
            foreach (Department dep in departments)
            {
                table.Rows.Add(dep.DepartmentCode, dep.DepartmentName);
            }
            dataGridView1.DataSource = table;
            dataGridView1.AutoResizeColumns();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Department_Insert newDep = new Department_Insert();
            newDep.Show();
            this.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (departments.Exists(x => x.DepartmentCode == int.Parse(textBox2.Text)))
                {
                    departments.Find(x => x.DepartmentCode == int.Parse(textBox2.Text)).DepartmentName = textBox1.Text;

                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-LG4RSUG\\SQLEXPRESS;Initial Catalog=HR_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Department set Dep_Name= @DepName, Dep_Code=@DepCode where Dep_Code=@DepCode", con);
                    cmd.Parameters.AddWithValue("@DepName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@DepCode", int.Parse(textBox2.Text));

                    int test = cmd.ExecuteNonQuery();
                    if (test != 0)
                    {
                        MessageBox.Show("Data Updated");
                        InitialTable();
                    }
                    else
                    {
                        MessageBox.Show("Error Updating");
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Department Code was not found");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (departments.Exists(x => x.DepartmentCode == int.Parse(textBox2.Text)))
                {
                    Department dep = departments.Find(x => x.DepartmentCode == int.Parse(textBox2.Text));

                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-LG4RSUG\\SQLEXPRESS;Initial Catalog=HR_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete Department where Dep_Code=@DepCode", con);
                    cmd.Parameters.AddWithValue("@DepCode", int.Parse(textBox2.Text));
                    int test = cmd.ExecuteNonQuery();
                    if (test != 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("Delete Manager where Manager_Id=@ManId", con);
                        cmd2.Parameters.AddWithValue("@ManId", dep.myManager.EmployeeId);
                        int test2 = cmd2.ExecuteNonQuery();
                        if (test2 != 0)
                        {
                            Form1.departments.Clear();
                            Program.FillData(Form1.departments);
                            MessageBox.Show("Department Deleted");
                            InitialTable();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Error Deleating");
                    }
                    con.Close();

                }
                else
                {
                    MessageBox.Show("Department does not exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-LG4RSUG\\SQLEXPRESS;Initial Catalog=HR_Database;Integrated Security=True");
            //con.Open();

            //SqlCommand cmd = new SqlCommand("Select * from Department", con);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);



            //List<Department> deps = new List<Department>();
            //foreach (DataRow dr in dt.Rows)
            //{
            //    Department TempDep = new Department();
            //    TempDep.DepartmentName = dr["Dep_Name"].ToString();
            //    TempDep.DepartmentCode = int.Parse(dr["Dep_Code"].ToString());
            //    deps.Add(TempDep);
            //}

            //MessageBox.Show( deps[2].DepartmentName);

            //con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //SetDepartmentCode = int.Parse(textBox2.Text);
            Form2 FormHrEmployee = new Form2();
            FormHrEmployee.Show();
            this.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ManagerWindow FormManager = new ManagerWindow();
            FormManager.Show();
            this.Visible = false;
        }

    }

}
