using Solnet.Rpc;
using Solnet.Rpc.Models;

namespace worken_api.Interfaces
{
    public interface IRpcService
    {
        Task<AccountInfo> GetAccountInfo(IRpcClient client, string publicKey);
        IRpcClient GetClient(Cluster client);
        Task<IEnumerable<TokenAccount>> GetTokenAccountsByOwner(IRpcClient client, string ownerPublicKey);
        Task<string> SendTransaction(IRpcClient client, string transaction);
    }
}