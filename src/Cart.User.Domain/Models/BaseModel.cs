using System;

/*
 * This base class is meant to define properties that will need to exist on models.
 * This may be overkill and can be moved strictly to the database layer.
 */
namespace Cart.User.Domain.Models
{
    public interface IBaseModel
    {
        long? Id { get; set; }
        Guid? Uuid { get; set; }
        string CreatedBy { get; set; }
        DateTime? CreatedOn { get; set; }
        string UpdatedBy { get; set; }
        DateTime? UpdatedOn { get; set; }
    }
    
    public abstract class BaseModel : IBaseModel
    {
        public long? Id { get; set; }
        public Guid? Uuid { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}