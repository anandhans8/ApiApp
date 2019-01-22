using ApiApp.Domain.ValueObjects;

namespace ApiApp.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        public AdAccount AdAccount { get; set; }
    }
}
