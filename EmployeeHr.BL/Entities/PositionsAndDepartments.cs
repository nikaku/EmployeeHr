namespace EmployeeHr.BL.Entities
{
    public class PositionsAndDepartments
    {
        public int Id { get; set; }
        public Position Position { get; set; }
        public int PositionId { get; set; }
        public DepartmentsAndBranches DepartmentsAndBranches { get; set; }
        public int DepartmentsAndBranchesId { get; set; }
        public int StaffNumber { get; set; }
    }
}
