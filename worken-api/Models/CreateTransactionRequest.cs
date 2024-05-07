using System.ComponentModel.DataAnnotations;

namespace worken_api.Controllers
{
    public class CreateTransactionRequest
    {
        [Required(ErrorMessage = $"{nameof(FromAccountPublicKey)} must be provided")]
        public string FromAccountPublicKey { get; set; }

        [Required(ErrorMessage = $"{nameof(FromAccountPrivateKey)} must be provided")]
        public string FromAccountPrivateKey { get; set; }

        [Required(ErrorMessage = $"{nameof(ToAccountPublicKey)} must be provided")]
        public string ToAccountPublicKey { get; set; }

        [Required(ErrorMessage = $"{nameof(LanPorts)} must be provided")]
        public ulong LanPorts {  get; set; }
    }
}