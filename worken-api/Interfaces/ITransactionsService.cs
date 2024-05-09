using Solnet.Rpc.Models;
using Solnet.Wallet;

namespace worken_api.Interfaces
{
    public interface ITransactionsService
    {
        byte[] CreateTransaction(Account from, PublicKey to, LatestBlockHash blockHash, ulong lamports);
        byte[] CreateTransaction(Account from, PublicKey to, LatestBlockHash blockHash, ulong lamports, string memo);
        byte[] CreateBurn(Account from, ulong amount);
        byte[] CreateBurn(Account from, ulong amount, string memo);
    }
}