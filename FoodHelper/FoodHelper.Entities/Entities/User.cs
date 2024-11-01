using FoodHelper.Entities.Interfaces;
namespace FoodHelper.Entities.Entities;
internal class User : IEntity<Guid>
{
    public Guid Id { get; set; }
}

