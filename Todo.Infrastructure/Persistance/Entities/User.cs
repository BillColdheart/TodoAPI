using static Todo.Infrastructure.Persistance.Entities.User;

namespace Todo.Infrastructure.Persistance.Entities
{
    public class User : BaseAuditableEntity// Inherit from the BaseAuditableEntity class                
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
       
    } 
}
