using System.Collections.Generic;

namespace Assignment.DTO
{
    public class DEpartmentDEtailsWithEmployeeNAme
    {
        public int ID { get; set; }
        public string DeptName { get; set; }
        public List<string> EmployeesName { get; set; } = new List<string>();
    }
}
