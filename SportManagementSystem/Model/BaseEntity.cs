namespace SportManagementSystem.Model
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Createdat {  get; set; }    
        public DateTime Updatedat { get; set; }
    }
}
