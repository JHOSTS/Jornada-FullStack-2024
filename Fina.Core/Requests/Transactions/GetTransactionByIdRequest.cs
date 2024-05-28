using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Transactions
{
    public class GetTransactionByIdRequest
    {
        [Required(ErrorMessage = "É necessário o ID para seguir com a ação!")]
        public long Id { get; set; }
    }
}