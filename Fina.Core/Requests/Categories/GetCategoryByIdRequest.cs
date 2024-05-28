using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories
{
    public class GetCategoryByIdRequest : Request
    {
        [Required(ErrorMessage = "É necessário o ID para seguir com essa ação!")]
        public long Id { get; set; }
    }
}