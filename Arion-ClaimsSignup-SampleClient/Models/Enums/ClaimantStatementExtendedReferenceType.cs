namespace Arion.ClaimsSignup.SampleClient.Models.Enums
{
    public enum ClaimantStatementExtendedReferenceType
    {
        /// <summary>
        /// First 12 of reference number
        /// </summary>
        ReferenceNumber,
        /// <summary>
        /// First 12 of customer number
        /// </summary>
        CustomerNumber,
        /// <summary>
        /// An Id consists of a branch number - First 4 digits, a ledger number - Next 2 digits and an account number - Last 6 digits.
        /// </summary>
        ClaimId,
        /// <summary>
        /// Id (kennitala) of the payor
        /// </summary>
        PayorId,
        /// <summary>
        /// Due date of the claim
        /// </summary>
        DueDate
    }
}
