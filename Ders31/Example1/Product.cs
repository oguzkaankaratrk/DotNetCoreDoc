

namespace Example1
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }

        public Product(int id, string name, string description, string code)
        {
            Id = id;
            Name = name;
            Description = description;
            Code = code;
        }
    }
}
    