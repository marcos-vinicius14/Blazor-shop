using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class ProductModel
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "O produto deve conter um nome.")]
    [MaxLength(120, ErrorMessage = "O titulo deve conter no máximo 120 caracteres")]
    [MinLength(5, ErrorMessage = "O minímo de caracteres é 5.")]
    public string Title { get; set; } = String.Empty;

    public string Description { get; set; } = String.Empty;
    
    [Required(ErrorMessage = "Informe um preço.")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public CategoryModel Category { get; set; } = null!;
}