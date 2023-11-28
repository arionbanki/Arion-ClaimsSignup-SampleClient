using System.Runtime.Serialization;

namespace Arion.ClaimsSignup.SampleClient.Models.Enums
{
    public enum AdditionalDepositAccountType
    {
        /// <summary>
        /// Penalty interest.
        /// </summary>
        /// <value>Penalty interest.</value>
        DefaultInterest,

        /// <summary>
        /// Default cost.
        /// </summary>
        /// <value>Default cost.</value>
        DefaultCharge,

        /// <summary>
        /// Other default costs.
        /// </summary>
        /// <value>Other default costs.</value>
        OtherDefaultCosts,

        /// <summary>
        /// All default costs.
        /// </summary>
        /// <value>All default costs.</value>
        AllDefaultCharges,

        /// <summary>
        /// Other costs.
        /// </summary>
        /// <value>Other costs.</value>
        OtherCosts,

        /// <summary>
        /// Notification fee.
        /// </summary>
        /// <value>Notification fee.</value>
        NoticeAndPaymentFee,

        /// <summary>
        /// All costs and fees imposed on the claim.
        /// </summary>
        /// <value>All costs and fees imposed on the claim.</value>
        AllCosts,

        /// <summary>
        /// A fixed amount is deducted from the amount of the payment and deposited in a disposable account.
        /// </summary>
        /// <value>A fixed amount is deducted from the amount of the payment and deposited in a disposable account.</value>
        FixedAmount,

        /// <summary>
        /// Percentage of the amount of the payment deposited in the disposable account.
        /// </summary>
        /// <value>Percentage of the amount of the payment deposited in the disposable account.</value>
        Percentage,

        /// <summary>
        /// Amount of the principal of the payment deposited in a disposable account.
        /// </summary>
        /// <value>Amount of the principal of the payment deposited in a disposable account.</value>
        PrincipalDetail
    }
}