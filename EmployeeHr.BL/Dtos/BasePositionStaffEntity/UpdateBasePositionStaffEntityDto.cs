namespace Hr.BL.Dtos.BasePositionStaffEntity
{
    public class UpdateBasePositionStaffEntityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PositinId { get; set; }
        public int BranchId { get; set; }
        public int DepartmentId { get; set; }
    }
}
