using Fina.Core.Models;
using Fina.Core.Requests.Transaction;
using Fina.Core.Requests.Transactions;
using Fina.Core.Responses;

namespace Fina.Core.Handlers
{
    public interface ITransactionHandler
    {
        Task<Response<Transaction?>> CreateAsync(CreateTransactionRequest request);
        Task<Response<Transaction?>> UpateAsync(UpdateTransactionRequest request); 
        Task<Response<Transaction?>> DeleteAsync(DeleteTransactionRequest request); 
        Task<Response<Transaction?>> GetByIdAsync(GetTransactionByIdRequest request); 
        Task<PagedResponse<List<Category>?>> GetByPeriodRequest(GetTransactionByPeriodRequest request); 
    }
}