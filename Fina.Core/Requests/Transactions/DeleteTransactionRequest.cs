using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace Fina.Core.Requests.Transactions
{
    public class DeleteTransactionRequest : Request
    {
        [Required(ErrorMessage = "É necessário o ID para seguir com a ação!")]
        public long Id { get; set; }
    }
}