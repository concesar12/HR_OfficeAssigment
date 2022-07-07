using System.Collections.Generic;

namespace HR_OfficeAssigment
{
    public class Department
    {
        public string DepartmentName { get; set; }
        public int DepartmentCode { get; set; }
        public List<Employee> myEmployees { get; set; }
        public Manager myManager { get; set; }

    }

}
