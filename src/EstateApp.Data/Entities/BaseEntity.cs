namespace EstateApp.Data.Entities
{
    public abstract  class BaseEntity
    {
        public bool IsDeleted { get; set;}
        public string? Id { get; set;}
        public DateTime CreatedAt { get; set;}
        public DateTime ModifiedAt { get; set;}
        public DateTime DeletedAt { get; set;}
    }
}