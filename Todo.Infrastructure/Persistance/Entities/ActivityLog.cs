using System;

namespace Todo.Infrastructure.Persistance.Entities
{
    public class ActivityLog: BaseEntity
    {
        public string EntityName { get; set; }
        public string EntityID { get; set; }
        public string Action { get; set; }
        public string PerfromedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string Oldvalues { get; set; }
        public string NewValues { get; set; }

    }
}
