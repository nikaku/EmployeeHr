namespace Hr.BL.Entities
{
    public class BasePositionStaffEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PositionsAndDepartments PositionsAndDepartments { get; set; }
        public int PositionsAndDepartmentsId { get; set; }
    }
}
