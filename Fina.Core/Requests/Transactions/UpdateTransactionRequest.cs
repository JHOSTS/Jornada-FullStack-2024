using System.ComponentModel.DataAnnotations;
using Fina.Core.Enums;

namespace Fina.Core.Requests.Transactions
{
    public class UpdateTransactionRequest
    {
        [Required(ErrorMessage = "É necessário o ID!")]
        public long Id { get; set; }
        [Required(ErrorMessage = "Título inválido!")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "Tipo inválido!")]
        public ETransactionType Type { get; set; } = ETransactionType.Withdraw;
        [Required(ErrorMessage = "Valor inválido!")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage = "Categoria inválido!")]
        public long CategoryId { get; set; }
        [Required(ErrorMessage = "Data inválido!")]
        public DateTime? PaidOrReceivedAt{ get; set; }
    }
}