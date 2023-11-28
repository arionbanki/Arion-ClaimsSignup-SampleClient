using Arion.ClaimsSignup.SampleClient.Models.Enums;

namespace Arion.ClaimsSignup.SampleClient.Models.Entities
{
    /// <summary>
    /// Used to allocate fees, costs or part of the payment of the claim. Maximum of 98 accounts per ID.
    /// </summary>
    /// <value>Used to allocate fees, costs or part of the payment of the claim. Maximum of 98 accounts per ID.</value></value></value>
    public class AdditionalDepositAccount : DepositAccountInfo
    {
        /// <summary>
        /// Type of additional deposit account
        /// </summary>
        /// <value>Type of additional deposit account</value>
        public AdditionalDepositAccountType Type { get; set; }

        /// <summary>
        /// Code only needs to be selected for FixedAmount,Percentage and PrincipalDetail types. Other types have reserved identifiers.
        /// </summary>
        /// <value>Code only needs to be selected for FixedAmount,Percentage and PrincipalDetail types. Other types have reserved identifiers.</value>
        public string? Code { get; set; }

        /// <summary>
        /// Priority determines which parts of the payment to the creditor should be disposed of first. Priority only needs to be selected for FixedAmount and Percentage types. Other types have reserved priority.
        /// </summary>
        /// Priority determines which parts of the payment to the creditor should be disposed of first. Priority only needs to be selected for FixedAmount and Percentage types. Other types have reserved priority.
        public int? Priority { get; set; }

        /// <summary>
        /// The amount to be deposited, can be a fixed amount or percentage.
        /// </summary>
        /// <value>The amount to be deposited, can be a fixed amount or percentage.</value>
        public DepositAmount DepositAmount { get; set; }
    }
}
