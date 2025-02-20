﻿using Solnet.Programs;
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
            //https://github.com/bmresearch/Solnet/blob/5fbb059997ba1a2cc61f31f2936b16d7325b5b72/src/Solnet.Extensions/TokenWallet.cs#L556
            //resource

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

        public byte[] CreateBurn(Account from, ulong amount)
        {
            var tx = new TransactionBuilder().
                   SetFeePayer(from).
                   AddInstruction(TokenProgram.Burn(from, Program.WorkenMintPublicKey, amount, from)).
                   AddInstruction(MemoProgram.NewMemo(from, Guid.NewGuid().ToString())).
                   Build(from);

            return tx;
        }

        public byte[] CreateBurn(Account from, ulong amount, string memo)
        {
            var tx = new TransactionBuilder().
                   SetFeePayer(from).
                   AddInstruction(TokenProgram.Burn(from, Program.WorkenMintPublicKey, amount, from)).
                   AddInstruction(MemoProgram.NewMemo(from, memo)).
                   Build(from);

            return tx;
        }
    }
}
