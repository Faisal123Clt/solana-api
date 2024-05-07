namespace worken_api.Controllers
{
    public class CreateTransactionRequest
    {
        public string fromAccountPublicKey { get; set; }
        public string fromAccountPrivateKey { get; set; }

        public string toAccountPublicKey { get; set; }

        public ulong lanPorts {  get; set; }
    }
}