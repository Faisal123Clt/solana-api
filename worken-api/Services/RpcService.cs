using Solnet.Rpc;
using Solnet.Rpc.Core.Http;
using Solnet.Rpc.Messages;
using Solnet.Rpc.Models;
using System.Diagnostics;
using System.Transactions;
using worken_api.Interfaces;
using worken_api.Models;

namespace worken_api.Services
{
    public class RpcService : IRpcService
    {

        public RpcService() { }

        public IRpcClient GetClient(Cluster client)
        {
            return ClientFactory.GetClient(client);
        }
        public IRpcClient GetClientMainNet()
        {
            return ClientFactory.GetClient(Cluster.MainNet);
        }

        public IRpcClient GetClientDevNet()
        {
            return ClientFactory.GetClient(Cluster.DevNet);
        }

        public IRpcClient GetClientTestNet()
        {
            return ClientFactory.GetClient(Cluster.TestNet);
        }

        public async Task<AccountInfo> GetAccountInfo(IRpcClient client, string publicKey)
        {
            var result = await client.GetAccountInfoAsync(publicKey);
            if (!result.WasSuccessful) return null;

            var accountInfo = result.Result.Value;

            return accountInfo;
        }

        public async Task<IEnumerable<TokenAccount>> GetTokenAccountsByOwner(IRpcClient client, string ownerPublicKey)
        {
            var result = await client.GetTokenAccountsByOwnerAsync(ownerPublicKey,Program.WorkenMintPublicKeyString);

            if (!result.WasSuccessful) return null;

            var tokenAccount = result.Result.Value;

            return tokenAccount;
        }

        public async Task<TransactionResult> SendTransaction(IRpcClient client, string transaction)
        {
            var t = await client.SendTransactionAsync(transaction);

            if (!t.WasSuccessful) return new TransactionResult(null, new Exception(t.RawRpcResponse));

            return new TransactionResult(t.Result);
        }

        public async Task<TransactionResult> SendTransaction(IRpcClient client, byte[] transaction)
        {
            var t = await client.SendTransactionAsync(transaction);

            if (!t.WasSuccessful) return new TransactionResult(null, new Exception(t.RawRpcResponse));

            return new TransactionResult(t.Result);
        }

        public async Task<LatestBlockHash> GetRecentBlockHash(IRpcClient client)
        {
            var t = await client.GetLatestBlockHashAsync();

            if (!t.WasSuccessful) return null;

            return t.Result.Value;
        }
    }
}
