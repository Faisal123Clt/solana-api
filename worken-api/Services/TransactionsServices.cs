using Solnet.Programs;
using Solnet.Rpc;
using Solnet.Rpc.Builders;
using Solnet.Rpc.Models;
using Solnet.Wallet;
using worken_api.Interfaces;

namespace worken_api.Services
{
    public class TransactionsServices : ITransactionsService
    {

        public TransactionsServices() { }

        public byte[] CreateTransaction(Account from, PublicKey to, LatestBlockHash blockHash, ulong lamports)
        {
            var tx = new TransactionBuilder().
                    SetRecentBlockHash(blockHash.Blockhash).
                    SetFeePayer(from).
                    AddInstruction(MemoProgram.NewMemo(from, Guid.NewGuid().ToString())).
                    AddInstruction(SystemProgram.Transfer(from, to, lamports)).
                    Build(from);

            return tx;
        }

        public byte[] CreateTransaction(Account from, PublicKey to, LatestBlockHash blockHash, ulong lamports, string memo)
        {
            var tx = new TransactionBuilder().
                    SetRecentBlockHash(blockHash.Blockhash).
                    SetFeePayer(from).
                    AddInstruction(MemoProgram.NewMemo(from, memo)).
                    AddInstruction(SystemProgram.Transfer(from, to, lamports)).
                    Build(from);

            return tx;
        }
    }
}
