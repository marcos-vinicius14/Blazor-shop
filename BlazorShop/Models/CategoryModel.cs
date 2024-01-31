using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class CategoryModel
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Informe p título.")]
    [MaxLength(120, ErrorMessage = "A título deve conter no máximo 60 caracteres.")]
    [MinLength(5, ErrorMessage = "O título deve conter no mínimo 5 caracteres.")]
    public string Title { get; set; } = String.Empty;
}