namespace Arion.ClaimsSignup.SampleClient.Models.Entities
{
    public class DepositAccountInfo
    {
        /// <summary>
        /// An Id consists of a branch number - First 4 digits, a ledger number - Next 2 digits and an account number - Last 6 digits.
        /// </summary>
        /// <value>An Id consists of a branch number - First 4 digits, a ledger number - Next 2 digits and an account number - Last 6 digits.</value>
        public string Id { get; set; }

        /// <summary>
        /// Id (Kennitala) of the owner of the account.
        /// </summary>
        /// <value>Id (Kennitala) of the owner of the account</value>
        public string OwnerId { get; set; }
    }
}
