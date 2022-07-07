using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_OfficeAssigment
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DateHired { get; set; }
        public decimal EmployeeSalary { get; set; }
        public int AllowedSickLeave { get; set; }
        public int TakenSickLeave { get; set; }
        
    }
}
