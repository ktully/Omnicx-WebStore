﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Omnicx.API.SDK.Recomendation.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for EventType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventType
    {
        [EnumMember(Value = "Custom")]
        Custom,
        [EnumMember(Value = "Click")]
        Click,
        [EnumMember(Value = "RecommendationClick")]
        RecommendationClick,
        [EnumMember(Value = "AddShopCart")]
        AddShopCart,
        [EnumMember(Value = "RemoveShopCart")]
        RemoveShopCart,
        [EnumMember(Value = "Purchase")]
        Purchase
    }
}
