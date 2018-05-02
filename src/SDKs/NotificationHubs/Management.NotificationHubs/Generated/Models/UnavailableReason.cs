// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for UnavailableReason.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UnavailableReason
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "InvalidName")]
        InvalidName,
        [EnumMember(Value = "SubscriptionIsDisabled")]
        SubscriptionIsDisabled,
        [EnumMember(Value = "NameInUse")]
        NameInUse,
        [EnumMember(Value = "NameInLockdown")]
        NameInLockdown,
        [EnumMember(Value = "TooManyNamespaceInCurrentSubscription")]
        TooManyNamespaceInCurrentSubscription
    }
    internal static class UnavailableReasonEnumExtension
    {
        internal static string ToSerializedValue(this UnavailableReason? value)
        {
            return value == null ? null : ((UnavailableReason)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this UnavailableReason value)
        {
            switch( value )
            {
                case UnavailableReason.None:
                    return "None";
                case UnavailableReason.InvalidName:
                    return "InvalidName";
                case UnavailableReason.SubscriptionIsDisabled:
                    return "SubscriptionIsDisabled";
                case UnavailableReason.NameInUse:
                    return "NameInUse";
                case UnavailableReason.NameInLockdown:
                    return "NameInLockdown";
                case UnavailableReason.TooManyNamespaceInCurrentSubscription:
                    return "TooManyNamespaceInCurrentSubscription";
            }
            return null;
        }

        internal static UnavailableReason? ParseUnavailableReason(this string value)
        {
            switch( value )
            {
                case "None":
                    return UnavailableReason.None;
                case "InvalidName":
                    return UnavailableReason.InvalidName;
                case "SubscriptionIsDisabled":
                    return UnavailableReason.SubscriptionIsDisabled;
                case "NameInUse":
                    return UnavailableReason.NameInUse;
                case "NameInLockdown":
                    return UnavailableReason.NameInLockdown;
                case "TooManyNamespaceInCurrentSubscription":
                    return UnavailableReason.TooManyNamespaceInCurrentSubscription;
            }
            return null;
        }
    }
}
