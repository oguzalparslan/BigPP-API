using System.ComponentModel.DataAnnotations;

namespace BigPP.Entity.Concrete
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public Guid Identity { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
