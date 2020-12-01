namespace Hr.BL.Entities
{
    public class PositionsAndDepartments
    {
        public int Id { get; set; }
        public Position Position { get; set; }
        public int PositionId { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public Branch Branch { get; set; }
        public int BranchId { get; set; }
        public int StaffNumber { get; set; }
    }
}
