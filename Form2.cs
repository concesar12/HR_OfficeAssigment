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
using Microsoft.VisualBasic;

namespace HR_OfficeAssigment
{
    public partial class Form2 : Form
    {
        BindingSource bs = new BindingSource();
        public Form2()
        {

            InitializeComponent();
            InitializeBindings();
            //InitializeTables();


            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-LG4RSUG\\SQLEXPRESS;Initial Catalog=HR_Database;Integrated Security=True");
            //con.Open();
            //int Depcode = Form1.SetDepartmentCode; 
            //SqlCommand cmd = new SqlCommand("Select * from Employee where Department_Code=@DepCode", con);
            //cmd.Parameters.AddWithValue("@DepCode", Depcode);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //List<Employee> deps = new List<Employee>();
            //Employee TempEmp = new Employee();
            //foreach (DataRow dr in dt.Rows)
            //{
            //    TempEmp.EmployeeName = dr["Employee_Name"].ToString();
            //    TempEmp.EmployeeId = int.Parse(dr["Employee_ID"].ToString());
            //    comboBox1.Items.Add(TempEmp.EmployeeId);
            //}

            //con.Close();
        }
        private List<Employee> FillLists()
        {
            List<Employee> employees = new List<Employee>();
            foreach (Department dep in Form1.departments.ToList())
            {

                foreach (Employee emp in dep.myEmployees.ToList())
                {
                    employees.Add(emp);
                }

            }

            return employees;
        }
         
        private void InitializeBindings ()
        {

            bs.DataSource = Form1.departments;
            comboBox2.DataSource = bs;
            comboBox2.DisplayMember = "DepartmentCode";
            DepartmentModifier.DataSource = bs;
            DepartmentModifier.DisplayMember = "DepartmentName";
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee SelectedEmployee = (Employee)comboBox1.SelectedItem;
            /*SqlConnection con = new SqlConnection("Data Source=DESKTOP-LG4RSUG\\SQLEXPRESS;Initial Catalog=HR_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Employee_ID from Employee", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Employee> deps = new List<Employee>();
            foreach (DataRow dr in dt.Rows)
            {
                Employee TempEmp = new Employee();
                TempEmp.EmployeeId = int.Parse(dr["Employee_ID"].ToString());
                comboBox1.Items.Add(TempEmp.EmployeeId);
            }
            con.Close();
            */
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1 DepartmentFormInfo = new Form1();
            DepartmentFormInfo.Show();
            this.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            bs.ResetBindings(true);
            Employee SelectedEmployee = (Employee)comboBox1.SelectedItem;
            textBox7.Text = SelectedEmployee.EmployeeName;
            textBox1.Text = SelectedEmployee.EmployeeId.ToString();
            BirthDatePicker.Value = SelectedEmployee.BirthDate;
            HireDatePicker.Value = SelectedEmployee.DateHired;
            textBox2.Text = SelectedEmployee.EmployeeSalary.ToString();
            textBox8.Text = SelectedEmployee.AllowedSickLeave.ToString();
            textBox3.Text = SelectedEmployee.TakenSickLeave.ToString();
            if(GetManagers().Exists(x=>x.EmployeeId== int.Parse(textBox1.Text)))
            {
                DepartmentModifier.Hide();
            }
            else
            {
                DepartmentModifier.Show();
            }
            Department SelectedDepartment = (Department)comboBox2.SelectedItem;
           // DepartmentModifier = SelectedDepartment.DepartmentCode.ToString();
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-LG4RSUG\\SQLEXPRESS;Initial Catalog=HR_Database;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("Select * from Employee where Employee_ID=@EmployeeId", con);
            //cmd.Parameters.AddWithValue("@EmployeeId", comboBox1.SelectedItem);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    textBox7.Text = dr["Employee_Name"].ToString();
            //    textBox1.Text = dr["Employee_ID"].ToString();
            //    textBox6.Text = DateTime.Parse(dr["Birth_Date"].ToString()).ToShortDateString();
            //    textBox5.Text = DateTime.Parse(dr["Hire_Date"].ToString()).ToShortDateString();
            //    textBox2.Text = dr["Annual_Salary"].ToString();
            //    textBox8.Text = dr["Allowable_SickLeave"].ToString();
            //    textBox3.Text = dr["Taken_SickLeave"].ToString();
            //    textBox4.Text = dr["Department_Code"].ToString();
            //}

            //con.Close();
        }

        private List<Manager> GetManagers()
        {
            List<Manager> managers = new List<Manager>();
            foreach (Department dep in Form1.departments)
            {
                managers.Add(dep.myManager);
            }
            return managers;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Department SelectedDepartment = (Department)DepartmentModifier.SelectedItem;
            
            //MessageBox.Show(SelectedEmployee.EmployeeName);
            //SelectedEmployee.EmployeeName = textBox7.Text;
            //SelectedEmployee.EmployeeName = textBox7.Text;
            if (MessageBox.Show("Do you want to update this employee?","Message",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                try
                {
                    
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-LG4RSUG\\SQLEXPRESS;Initial Catalog=HR_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Employee set Employee_Name= @EmpName, " +
                        "Employee_ID=@EmpId, " +
                        "Birth_Date=@BirthDate, " +
                        "Hire_Date=@HireDate, " +
                        "Annual_Salary=@AnnualSalary, " +
                        "Allowable_SickLeave=@AllowSickLeave, " +
                        "Taken_SickLeave=@TakenSickLeave, " +
                        "Department_Code=@DepCode " +
                        "where Employee_ID=@EmpId", con);
                    cmd.Parameters.AddWithValue("@EmpName", textBox7.Text);
                    cmd.Parameters.AddWithValue("@EmpId", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@BirthDate", BirthDatePicker.Value);
                    cmd.Parameters.AddWithValue("@HireDate", HireDatePicker.Value);
                    cmd.Parameters.AddWithValue("@AnnualSalary", decimal.Parse(textBox2.Text));
                    cmd.Parameters.AddWithValue("@AllowSickLeave", int.Parse(textBox8.Text));
                    cmd.Parameters.AddWithValue("@TakenSickLeave", int.Parse(textBox3.Text));
                    cmd.Parameters.AddWithValue("@DepCode", SelectedDepartment.DepartmentCode);
                    int test = cmd.ExecuteNonQuery();
                    if (test != 0)
                    {
                        //SqlCommand cmd2 = new SqlCommand("Update Manager set Department_Code=@Dep_Code where Manager_ID", con);
                        Form1.departments.Clear();
                        Program.FillData(Form1.departments);
                        bs.ResetBindings(true);
                        MessageBox.Show("Data Updated");
                    }
                    else
                    {
                        MessageBox.Show("Error Updating");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
                

            }
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.Refresh();
            Department selectedDepartment = (Department)comboBox2.SelectedItem;
            comboBox1.DataSource = selectedDepartment.myEmployees;
            comboBox1.DisplayMember = "EmployeeId";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Employee SelectedEmployee = (Employee)comboBox1.SelectedItem;
            try
            {
                if (Form1.departments.Exists(x=> x.myManager.EmployeeId == SelectedEmployee.EmployeeId))
                {
                    MessageBox.Show("This Employee cannot be deleted because is a Manager, Please change Manager and then Delete the Employee","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-LG4RSUG\\SQLEXPRESS;Initial Catalog=HR_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete Employee where Employee_ID=@EmpId", con);
                cmd.Parameters.AddWithValue("@EmpId", SelectedEmployee.EmployeeId);
                
                int test = cmd.ExecuteNonQuery();
                if (test != 0)
                {
                    MessageBox.Show("Data Updated");
                    Form1.departments.Clear();
                    Program.FillData(Form1.departments);
                    bs.ResetBindings(true);
                }
                else
                {
                    MessageBox.Show("Error Updating");
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void InsertEmployee_Click(object sender, EventArgs e)
        {
            
            try
            {
                Department SelectedDepartment = (Department)DepartmentModifier.SelectedItem;
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-LG4RSUG\\SQLEXPRESS;Initial Catalog=HR_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Employee(Employee_Name, Employee_ID ,Birth_Date ," +
                    " Hire_Date, Annual_Salary, Allowable_SickLeave, Taken_SickLeave, Department_Code) " +
                    " values (@EmpName, @EmpId, @BirthDate, @HireDate, @AnnualSalary, @AllowSickLeave, @TakenSickLeave, @DepCode); ", con);
                cmd.Parameters.AddWithValue("@EmpName", textBox7.Text);
                cmd.Parameters.AddWithValue("@EmpId", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@BirthDate", BirthDatePicker.Value);
                cmd.Parameters.AddWithValue("@HireDate", HireDatePicker.Value);
                cmd.Parameters.AddWithValue("@AnnualSalary", decimal.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@AllowSickLeave", int.Parse(textBox8.Text));
                cmd.Parameters.AddWithValue("@TakenSickLeave", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@DepCode", SelectedDepartment.DepartmentCode);
                foreach (Department dep in Form1.departments)
                {
                    if (dep.myEmployees.Exists(x => x.EmployeeId == int.Parse(textBox1.Text)))
                    {
                        MessageBox.Show("This Employee Id already Exists, please Change it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        return;
                    }
                }

                int test = cmd.ExecuteNonQuery();
                if (test != 0)
                {
                    MessageBox.Show("Data Saved");
                    Form1.departments.Clear();
                    Program.FillData(Form1.departments);
                    bs.ResetBindings(true);
                }
                else
                {
                    MessageBox.Show("Error saving");
                }
                con.Close();
                //Department dep = new Department();
                //if (Form1.departments.
                //{
                //    MessageBox.Show("Department already Exists");
                //}
                //else
                //{
                //    dep.DepartmentCode = int.Parse(textBox2.Text);
                //    dep.DepartmentName = textBox1.Text;
                //    departments.Add(dep);
                //    MessageBox.Show("Department Saved succesfully");

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void DepartmentModifier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>();
            employees = FillLists();
            foreach (Employee emp in employees.ToList())
            {
                DateTime hiredDate = DateTime.Now.AddYears(-2);
                if (emp.DateHired > hiredDate)
                {
                    employees.Remove(emp);
                }
            }
            DataTable table = new DataTable();
            table.Columns.Add("Employee Id", typeof(int));
            table.Columns.Add("Employee Name", typeof(string));
            table.Columns.Add("Date Hired", typeof(DateTime));
            foreach (Employee emp in employees.ToList())
            {
                table.Rows.Add(emp.EmployeeId, emp.EmployeeName, emp.DateHired);
            }
            YearHiredTable.DataSource = table;
            YearHiredTable.AutoResizeColumns();
            label13.Text = "People hired for more than 5 years.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>();
            employees = FillLists();
            foreach (Employee emp in employees.ToList())
            {
                if (emp.TakenSickLeave <= 5)
                {
                    employees.Remove(emp);
                }
            }
            DataTable table = new DataTable();
            table.Columns.Add("Employee Id", typeof(int));
            table.Columns.Add("Employee Name", typeof(string));
            table.Columns.Add("Taken Sick Leaves", typeof(int));
            foreach (Employee emp in employees.ToList())
            {
                table.Rows.Add(emp.EmployeeId, emp.EmployeeName, emp.TakenSickLeave);
            }
            YearHiredTable.DataSource = table;
            YearHiredTable.AutoResizeColumns();
            label13.Text = "People who took more than 5 leaves.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>();


            employees = FillLists();
            foreach (Employee emp in employees.ToList())
            {
                DateTime hiredDate = DateTime.Now.AddMonths(-6);
                if (emp.DateHired < hiredDate)
                {
                    employees.Remove(emp);
                }
            }
            DataTable table2 = new DataTable();
            table2.Columns.Add("Employee Id", typeof(int));
            table2.Columns.Add("Employee Name", typeof(string));
            table2.Columns.Add("Date Hired", typeof(DateTime));
            foreach (Employee emp in employees.ToList())
            {
                table2.Rows.Add(emp.EmployeeId, emp.EmployeeName, emp.DateHired);
            }
            YearHiredTable.DataSource = table2;
            YearHiredTable.AutoResizeColumns();
            label13.Text = "People Hired for less than 6 Months.";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string val = Interaction.InputBox("Type the amount to view", "Salary over limit", "0");
                List<Employee> employees = new List<Employee>();


                employees = FillLists();
                foreach (Employee emp in employees.ToList())
                {

                    if (emp.EmployeeSalary < decimal.Parse(val))
                    {
                        employees.Remove(emp);
                    }
                }
                DataTable table2 = new DataTable();
                decimal.Parse(val);
                table2.Columns.Add("Employee Id", typeof(int));
                table2.Columns.Add("Employee Name", typeof(string));
                table2.Columns.Add("Annual Salary", typeof(decimal));
                foreach (Employee emp in employees.ToList())
                {
                    table2.Rows.Add(emp.EmployeeId, emp.EmployeeName, emp.EmployeeSalary);
                }
                YearHiredTable.DataSource = table2;
                YearHiredTable.AutoResizeColumns();
                label13.Text = "Employees with Salaries over " + int.Parse(val) + "$";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            
        }

        private void ShowEmployees_Click(object sender, EventArgs e)
        {
            Department SelectedDepartment = (Department)comboBox2.SelectedItem;
            
            DataTable table = new DataTable();
            table.Columns.Add("Employee Id", typeof(int));
            table.Columns.Add("Employee Name", typeof(string));
            foreach (Employee emp in SelectedDepartment.myEmployees.ToList())
            {
                table.Rows.Add(emp.EmployeeId, emp.EmployeeName);
            }
            YearHiredTable.DataSource = table;
            YearHiredTable.AutoResizeColumns();
            label13.Text = "Employees of the department "+ SelectedDepartment.DepartmentName+" with manager: " +SelectedDepartment.myManager.EmployeeName+".";
            label13.ForeColor = Color.Red;
        }
    }
}
