using System.Collections.Generic;

namespace Hr.BL.Entities
{
    public class Municipality
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Region Region { get; set; }
        public int RegionId { get; set; }
        public IEnumerable<Settlement> Settlements { get; set; }
    }
}
