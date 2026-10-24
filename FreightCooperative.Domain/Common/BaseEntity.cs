namespace FreightCooperative.Domain.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;//Datetime.UtcNow
        public DateTime? UpdatedAt {  get; set; }
        //Soft delete: row stays in the database but is hidden from queries       
        public bool IsDeleted { get; set; }

    }
}
