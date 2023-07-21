namespace WebApiProjectCQRS.Response
{
    public class EmployeeResponse
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public decimal Salary { get; set; }
        public string? Department { get; set; }
        public DateTime JoiningDate { get; set; }
        public long ContactNumber { get; set; }
        public string? Address { get; set; }
        public DateTime DOB { get; set; }
    }
}