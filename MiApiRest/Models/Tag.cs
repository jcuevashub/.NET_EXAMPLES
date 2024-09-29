public class Tag
{
    public int? Id { get; set; }
    public string? Name { get; set; }

    //Relación Muchos a Muchos
    public List<Product>? Products { get; set; }
}