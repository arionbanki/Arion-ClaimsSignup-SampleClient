namespace Arion.ClaimsSignup.SampleClient.Models.Enums
{
    /// <summary>
    /// Tells which value appears in the reference explanation area of ​​the payer's invoice statement.
    /// </summary>
    /// <value>Tells which value appears in the reference explanation area of ​​the payer's invoice statement.</value>
    public enum PayorStatementExtendedReferenceType
    {
        /// <summary>
        /// Claimant Id
        /// </summary>
        /// <value>Claimant Id</value>
        ClaimantId,

        /// <summary>
        /// First 12 numbers of the reference number
        /// </summary>
        /// <value>First 12 numbers of the reference number</value>
        ReferenceNumber,

        /// <summary>
        /// First 12 letters of the transaction number
        /// </summary>
        /// <value>First 12 letters of the transaction number</value>
        CustomerNumber,

        /// <summary>
        /// Bank, ledger and claim number.
        /// </summary>
        /// <value>Bank, ledger, and claim number</value>
        ClaimId,

        /// <summary>
        /// Id (kennitala) of the payor
        /// </summary>
        /// <value>Id (kennitala) of the payor</value>
        PayorId,

        /// <summary>
        /// Due date of the claim
        /// </summary>
        /// <value>Due date of the claim</value>
        DueDate
    }
}
