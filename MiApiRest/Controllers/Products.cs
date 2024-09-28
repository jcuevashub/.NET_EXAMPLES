using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static List<Product> products = new List<Product>() {
        new Product { Id = 1, Name = "Laptop", Price = 1500},
        new Product { Id = 2, Name = "Smartphone", Price = 800}
    };

    [HttpGet]
    public ActionResult<List<Product>> Get()
    {
        return products;
    }

    [HttpGet("{id}")]
    public ActionResult<Product> Get(int id)
    {
        var product = products.Find(x => x.Id == id);
        if (product == null)
        {
            return NotFound();
        }

        return product;
    }

    [HttpPost]
    public ActionResult<Product> Post(Product product)
    {
        product.Id = products.Count + 1;
        products.Add(product);
        return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Product productToUpdate)
    {
        var product = products.FirstOrDefault(x => x.Id == id);
        if (product == null)
        {
            return NotFound();
        }

        product.Name = productToUpdate.Name;
        product.Price = productToUpdate.Price;

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var product = products.FirstOrDefault(x => x.Id == id);
        if (product == null)
        {
            return NotFound();
        }

        products.Remove(product);
        return NoContent();

    }

}