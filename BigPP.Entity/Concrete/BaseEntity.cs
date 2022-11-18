namespace BigPP.Entity.Concrete
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public Guid Identity { get; set; }
    }
}
