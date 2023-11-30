namespace Arion.ClaimsSignup.SampleClient.Models.Entities
{
    /// <summary>
    /// The amount to be deposited, can be a fixed amount or percentage.
    /// </summary>
    /// <value>The amount to be deposited, can be a fixed amount or percentage.</value>
    public class DepositAmount
    {
        /// <summary>
        /// The value of the percentage or fixed amount.
        /// </summary>
        /// <value>The value of the percentage or fixed amount.</value>
        public decimal Value { get; set; }

        /// <summary>
        /// Indicates whether the value is a percentage or a fixed amount.
        /// </summary>
        /// <value>Indicates whether the value is a percentage or a fixed amount.</value>
        public ValueType ValueType { get; set; }
    }
}
