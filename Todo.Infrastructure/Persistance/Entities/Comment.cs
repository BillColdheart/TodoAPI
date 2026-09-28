
using Todo.Infrastructure.Persistence.Entities;

namespace Todo.Infrastructure.Persistance.Entities
{
    public  class Comment : BaseEntity
    {
        public Guid TodoItemId { get; set; }
        public TodoItem TodoItem { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Message { get; set; }

    }
}
