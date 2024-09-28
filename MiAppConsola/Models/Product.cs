public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description {get; set;}   

    //Relación Uno a Muchos
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    //Relación Muchos a Muchos
    public List<Tag> Tags { get; set; }
}