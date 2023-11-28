using Arion.ClaimsSignup.SampleClient.Models.Entities;
using Arion.ClaimsSignup.SampleClient.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Arion.ClaimsSignup.SampleClient.Models.Requests
{
    /// <summary>
    /// Create or alter claim template details. 
    /// </summary>
    public class TemplateRequest
    {
        /// <summary>
        /// Indicates which value appears in the reference area of the creditor&#x27;s account statement.  This can be one of the following values:   - ReferenceNumber - The first 12 letters of the reference number.   - CustomerNumber - The first 12 letters of the transaction number.   - ClaimId - Branch number, ledger and claim number.   - PayorId - Id (kennitala) of the payor   - DueDate - Due date of the claim in the format (yyyymmdd) 
        /// </summary>
        /// <value>Indicates which value appears in the reference area of the creditor&#x27;s account statement.  This can be one of the following values:   - ReferenceNumber - The first 12 letters of the reference number.   - CustomerNumber - The first 12 letters of the transaction number.   - ClaimId - Branch number, ledger and claim number.   - PayorId - Id (kennitala) of the payor   - DueDate - Due date of the claim in the format (yyyymmdd) </value>
        [Required]
        public ClaimantStatementExtendedReferenceType ClaimantStatementExtendedReferenceType { get; set; }

        /// <summary>
        /// Indicates which value appears in the reference area on the creditor&#x27;s account statement.  This can be one of the following values:   - DueDate - Due date of the claim in the format (yyyymmdd)   - BillNumber - Bill number of the claim   - ClaimNumber - Claimnumber (last 6 digits) 
        /// </summary>
        /// <value>Indicates which value appears in the reference area on the creditor&#x27;s account statement.  This can be one of the following values:   - DueDate - Due date of the claim in the format (yyyymmdd)   - BillNumber - Bill number of the claim   - ClaimNumber - Claimnumber (last 6 digits) </value>
        [Required]
        public ClaimantStatementReferenceType ClaimantStatementReferenceType { get; set; }

        /// <summary>
        /// Gets or Sets ClaimantId, ClaimantId is 10 digits
        /// </summary>
        /// <value >Gets or Sets ClaimantId, ClaimantId is 10 digits </value>
        [Required]
        public string ClaimantId { get; set; }

        /// <summary>
        /// Gets or Sets Bank, Bank code is 4 digits
        /// </summary>
        /// <value> Gets or Sets Bank, Bank code is 4 digits</value>
        [Required]
        public string Bank { get; set; }

        /// <summary>
        /// Gets or Sets TemplateCode, Template code is 3 letters and/or numbers
        /// </summary>
        /// <value> Gets or Sets TemplateCode, Template code is 3 letters and/or numbers</value>
        [Required]
        public string TemplateCode { get; set; }

        /// <summary>
        /// Gets or Sets Category, Category is 2 letters, Explanation of payment
        /// </summary>
        /// 
        [MaxLength(2)]
        public string Category { get; set; }

        /// <summary>
        /// Tells which value appears in the reference explanation area of ​​the payer's invoice statement.
        /// </summary>
        /// <value>Tells which value appears in the reference explanation area of ​​the payer's invoice statement.</value>
        [Required]
        public PayorStatementExtendedReferenceType PayorStatementExtendedReferenceType { get; set; } = PayorStatementExtendedReferenceType.ClaimantId;

        /// <summary>
        /// Information on the main disposal account.
        /// </summary>
        /// <value>Information on the main disposal account.</value>
        public DepositAccount DepositAccount { get; set; }

        /// <summary>
        /// Debit account used to pay the creditor's expenses to the bank. If omitted, the main disposition account of the claim template is used.
        /// </summary>
        /// <value>Debit account used to pay the creditor's expenses to the bank. If omitted, the main disposition account of the claim template is used.</value>
        public string WithdrawalAccount { get; set; }

        /// <summary>
        /// Used to allocate fees, costs or part of the payment of the claim. Maximum of 98 accounts per ID.
        /// </summary>
        /// <value>Used to allocate fees, costs or part of the payment of the claim. Maximum of 98 accounts per ID.</value></value>
        public List<AdditionalDepositAccount>? AdditionalDepositAccounts { get; set; }
    }
}
