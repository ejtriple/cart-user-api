namespace Cart.User.Domain.Models
{
    public class UserModel : BaseModel
    {
        // TODO: Revist
        // Currently basing these off of what is in Auth0
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string Website { get; set; }
        public string Revenue { get; set; }
        public string SalesChannel { get; set; }
    }
}