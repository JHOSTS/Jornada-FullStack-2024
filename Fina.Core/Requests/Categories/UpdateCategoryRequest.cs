using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories
{
    public class UpdateCategoryRequest : Request
    {
        [Required(ErrorMessage = "É necessário o ID para seguir com essa ação!")]
        public long Id { get; set; }
        [Required(ErrorMessage = "Título inválido!")]
        [MaxLength(80, ErrorMessage = "O título deve conter até 80 caracteres.")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "Descrição inválida!")]
        public string? Description { get; set; } = string.Empty;
    }
}