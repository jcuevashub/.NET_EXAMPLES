public class Product
{
    public int? Id { get; set; }

    // [Required]
    // [StringLength(100)]
    public string? Name { get; set; }

    // [Range(1, 10000)]
    public decimal? Price { get; set; }
    public string? Description {get; set;}   

    //Relación Uno a Muchos
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }

    //Relación Muchos a Muchos
    public List<Tag>? Tags { get; set; }
}