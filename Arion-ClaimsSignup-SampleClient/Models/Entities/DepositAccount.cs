using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Arion.ClaimsSignup.SampleClient.Models.Entities
{
    /// <summary>
    /// Information on the main disposal account.
    /// </summary>
    /// <value>Information on the main disposal account.</value>
    [DataContract]
    public partial class DepositAccount
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <value>Gets or Sets Id</value>
        [RegularExpression("[0-9]{4}[0-9]{2}[0-9]{6}")]
        [DataMember(Name = "id")]
        public string Id { get; set; }
    }
}
