using Solnet.Rpc;
using Solnet.Rpc.Core.Http;
using Solnet.Rpc.Messages;
using Solnet.Rpc.Models;
using worken_api.Interfaces;

namespace worken_api.Services
{
    public class RpcService : IRpcService
    {

        public RpcService() { }

        public IRpcClient GetClient(Cluster client)
        {
            return ClientFactory.GetClient(client);
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
            var result = await client.GetTokenAccountsByOwnerAsync(ownerPublicKey);

            if (!result.WasSuccessful) return null;

            var tokenAccount = result.Result.Value;

            return tokenAccount;
        }

        public async Task<string> SendTransaction(IRpcClient client, string transaction)
        {
            var t = await client.SendTransactionAsync(transaction);

            if (!t.WasSuccessful) return null;

            return t.Result;
        }
    }
}
