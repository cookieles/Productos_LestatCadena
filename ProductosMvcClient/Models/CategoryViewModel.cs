using System.ComponentModel.DataAnnotations;

public class CategoryViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre de la categoría es requerido")]
    [StringLength(50, ErrorMessage = "El nombre no puede exceder 50 caracteres")]
    public string Name { get; set; }

    public string Description { get; set; }
}