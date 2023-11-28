using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TrueLayer_API.Model;

namespace TrueLayer_API.Interfaces
{
    public  interface IAccountsService
    {
        HttpResponseMessage GetAccount(string id);
        HttpResponseMessage GetAccounts();
        HttpResponseMessage GetTransactionsOnAccount(string id);
        Task<TransactionDetailResponse> GetTransactionsMinMaxDetails(string id);
    }
}
