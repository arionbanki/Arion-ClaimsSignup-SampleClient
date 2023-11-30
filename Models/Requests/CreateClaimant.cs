using System.ComponentModel.DataAnnotations;

namespace Arion.ClaimsSignup.SampleClient.Models.Requests
{
    /// <summary>
    /// Create claimant signup object  Description: 
    /// </summary>
    public partial class CreateClaimant
    { 
        /// <summary>
        /// Gets or Sets ClaimantId
        /// </summary>
        [Required]
        [RegularExpression("[0-9]{10}")]
        public string ClaimantId { get; set; }
    }
}
