namespace EmployeeHr.BL.Entities
{
    public class DepartmentsAndBranches
    {
        public int Id { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public Branch Branch { get; set; }
        public int BranchId { get; set; }
    }
}
