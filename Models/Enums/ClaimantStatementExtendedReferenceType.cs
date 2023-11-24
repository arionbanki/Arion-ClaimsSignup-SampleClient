namespace Arion.ClaimsSignup.SampleClient.Models.Enums
{
    public enum ClaimantStatementExtendedReferenceType
    {
        /// <summary>
        /// 12 fyrstu stafir tilvísunarnúmers
        /// </summary>
        ReferenceNumber,
        /// <summary>
        /// 12 fyrstu stafir viðskiptanúmers
        /// </summary>
        CustomerNumber,
        /// <summary>
        /// Banki, höfuðbók og númer kröfunnar
        /// </summary>
        ClaimId,
        /// <summary>
        /// Kennitala greiðanda á kröfunni
        /// </summary>
        PayorId,
        /// <summary>
        /// Gjalddagi kröfunnar
        /// </summary>
        DueDate
    }
}
