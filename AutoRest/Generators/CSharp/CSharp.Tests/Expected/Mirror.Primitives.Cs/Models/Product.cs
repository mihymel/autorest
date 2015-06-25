namespace Fixtures.MirrorPrimitives.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// </summary>
    public partial class Product
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "integer")]
        public int? Integer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "int")]
        public int? IntProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "long")]
        public long? LongProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "number")]
        public double? Number { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "float")]
        public double? FloatProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "double")]
        public double? DoubleProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "byte")]
        public byte[] ByteProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "string")]
        public string StringProperty { get; set; }

        /// <summary>
        /// Possible values for this property include: 'red', 'blue', 'green'
        /// </summary>
        [JsonProperty(PropertyName = "enum")]
        public string EnumProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "boolean")]
        public bool? Boolean { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateTime")]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "integerArray")]
        public IList<int?> IntegerArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "intArray")]
        public IList<int?> IntArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "longArray")]
        public IList<long?> LongArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "numberArray")]
        public IList<double?> NumberArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "floatArray")]
        public IList<double?> FloatArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "doubleArray")]
        public IList<double?> DoubleArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "byteArray")]
        public IList<byte[]> ByteArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "booleanArray")]
        public IList<bool?> BooleanArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stringArray")]
        public IList<string> StringArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateArray")]
        public IList<DateTime?> DateArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateTimeArray")]
        public IList<DateTime?> DateTimeArray { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
        }
    }
}