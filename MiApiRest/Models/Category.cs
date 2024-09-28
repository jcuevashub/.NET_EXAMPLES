public class Category
{
    public int Id { get; set;}
    public string Name { get; set;}

    //Relación Uno a Muchos
    public List<Product> Products { get; set;}
}