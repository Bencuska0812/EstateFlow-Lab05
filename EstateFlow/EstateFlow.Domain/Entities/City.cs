using System.Text.Json.Serialization;

namespace EstateFlow.Domain.Entities
{
    public class City
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public ICollection<Property> Properties { get; set; } = new List<Property>();
    }
}
