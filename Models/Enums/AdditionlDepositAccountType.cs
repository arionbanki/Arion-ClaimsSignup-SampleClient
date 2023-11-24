using System.Runtime.Serialization;

namespace Arion.ClaimsSignup.SampleClient.Models.Enums
{
    public enum AdditionalDepositAccountType
    {
        // Penalty interest.
        [EnumMember(Value = "default_interest")]
        DefaultInterest,

        // Default cost.
        [EnumMember(Value = "default_charge")]
        DefaultCharge,

        // Other default costs.
        [EnumMember(Value = "other_default_costs")]
        OtherDefaultCosts,

        // All default costs.
        [EnumMember(Value = "all_default_charges")]
        AllDefaultCharges,

        // Other costs.
        [EnumMember(Value = "other_costs")]
        OtherCosts,

        // Notification fee.
        [EnumMember(Value = "notice_and_payment_fee")]
        NoticeAndPaymentFee,

        // All costs and fees imposed on the claim.
        [EnumMember(Value = "all_costs")]
        AllCosts,

        // A fixed amount is deducted from the amount of the payment and deposited in a disposable account.
        [EnumMember(Value = "fixed_amount")]
        FixedAmount,

        // Percentage of the amount of the payment deposited in the disposable account.
        [EnumMember(Value = "percentage")]
        Percentage,

        // Amount of the principal of the payment deposited in a disposable account.
        [EnumMember(Value = "principal_detail")]
        PrincipalDetail
    }
}