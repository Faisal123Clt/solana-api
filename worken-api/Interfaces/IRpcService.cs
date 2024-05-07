using Solnet.Rpc;
using Solnet.Rpc.Models;

namespace worken_api.Interfaces
{
    public interface IRpcService
    {
        Task<AccountInfo> GetAccountInfo(IRpcClient client, string publicKey);
        IRpcClient GetClient(Cluster client);
        IRpcClient GetClientMainNet();
        IRpcClient GetClientDevNet();
        IRpcClient GetClientTestNet();
        Task<IEnumerable<TokenAccount>> GetTokenAccountsByOwner(IRpcClient client, string ownerPublicKey);
        Task<string> SendTransaction(IRpcClient client, string transaction);
        Task<string> SendTransaction(IRpcClient client, byte[] transaction);
        Task<LatestBlockHash> GetRecentBlockHash(IRpcClient client);
    }
}