namespace Hr.BL.Entities
{
    public class Settlement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Municipality Municipality { get; set; }
        public int MunicipalityId { get; set; }
    }
}
