using Bunq.Sdk.Exception;
using Bunq.Sdk.Model.Core;
using Bunq.Sdk.Model.Generated.Endpoint;
using Newtonsoft.Json;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class DraftPaymentAnchorObject : BunqModel, IAnchorObjectInterface
    {
        /// <summary>
        ///     Error constants.
        /// </summary>
        private const string ERROR_NULL_FIELDS = "All fields of an extended model or object are null.";


        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Payment")]
        public Payment Payment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PaymentBatch")]
        public PaymentBatch PaymentBatch { get; set; }


        /// <summary>
        /// </summary>
        public BunqModel GetReferencedObject()
        {
            if (Payment != null) return Payment;

            if (PaymentBatch != null) return PaymentBatch;

            throw new BunqException(ERROR_NULL_FIELDS);
        }

        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (Payment != null) return false;

            if (PaymentBatch != null) return false;

            return true;
        }

        /// <summary>
        /// </summary>
        public static DraftPaymentAnchorObject CreateFromJsonString(string json)
        {
            return CreateFromJsonString<DraftPaymentAnchorObject>(json);
        }
    }
}