using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Transactions
{
    public class GetTransactionByPeriodRequest
    {
        [Required(ErrorMessage = "É necessário a data inicial!")]
        public DateTime? StartDat { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "É necessário a data final!")]
        public DateTime? EnDate { get; set; } = DateTime.Now.AddMonths(1);
    }
}