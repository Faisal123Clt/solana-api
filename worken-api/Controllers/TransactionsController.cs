using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Solnet.Rpc;
using Solnet.Rpc.Models;
using Solnet.Wallet;
using worken_api.Interfaces;

namespace worken_api.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly IRpcService rpcService;
        private readonly ITransactionsService transactionsService;

        public TransactionsController(IRpcService rpcService, ITransactionsService transactionsService )
        {
            this.rpcService = rpcService;
            this.transactionsService = transactionsService;
        }

        [HttpPost("CreateTransaction")]
        public async Task<IActionResult> CreateTransaction([FromBody] CreateTransactionRequest transactionRequest)
        {
            var client = rpcService.GetClientMainNet();
            var blockHash = await rpcService.GetRecentBlockHash(client);

            Account fromAccount = new(transactionRequest.fromAccountPrivateKey, transactionRequest.fromAccountPublicKey);
            PublicKey toAccount = new PublicKey(transactionRequest.toAccountPublicKey);

            var transactionData = transactionsService.CreateTransaction(fromAccount, toAccount, blockHash, transactionRequest.lanPorts);

            return Content(Convert.ToBase64String(transactionData));
        }
    }
}
