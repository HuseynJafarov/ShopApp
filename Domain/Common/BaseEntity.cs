
namespace Domain.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool SoftDeleted { get; set; }
        public DateTime Date { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
