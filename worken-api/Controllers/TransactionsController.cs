using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Solnet.Rpc;
using Solnet.Rpc.Models;
using Solnet.Wallet;
using worken_api.Interfaces;

namespace worken_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var client = rpcService.GetClientMainNet();
            var blockHash = await rpcService.GetRecentBlockHash(client);

            Account fromAccount = new(transactionRequest.FromAccountPrivateKey, transactionRequest.FromAccountPublicKey);
            PublicKey toAccount = new PublicKey(transactionRequest.ToAccountPublicKey);

            var transactionData = transactionsService.CreateTransaction(fromAccount, toAccount, blockHash, transactionRequest.LanPorts);

            return Content(Convert.ToBase64String(transactionData));
        }
    }
}
