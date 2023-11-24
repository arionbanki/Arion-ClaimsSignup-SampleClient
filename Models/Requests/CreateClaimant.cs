using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Arion.ClaimsSignup.SampleClient.Models.Requests
{
    public partial class CreateClaimant
    {
        /// <summary>
        /// Gets or Sets ClaimantId
        /// </summary>
        [Required]
        [RegularExpression("[0-9]{10}")]
        [DataMember(Name = "claimantId")]
        public string ClaimantId { get; set; }
    }
}
