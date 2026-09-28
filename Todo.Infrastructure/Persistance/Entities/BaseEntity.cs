namespace Todo.Infrastructure.Persistance.Entities
{
    //Create an abstract class
    public abstract class BaseEntity 
        { 
          public Guid Id { get; set; }= Guid.NewGuid();
        }


    
}
