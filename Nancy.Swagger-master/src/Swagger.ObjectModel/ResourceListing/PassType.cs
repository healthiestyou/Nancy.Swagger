using Swagger.ObjectModel.Attributes;

namespace Swagger.ObjectModel.ResourceListing
{
    /// <summary>
    /// Used in <see cref="Authorization"/> to denote how an API key should be passed.
    /// </summary>
    [SwaggerData]
    public enum PassType
    {
        /// <summary>
        /// Denotes a header value.
        /// </summary>
        [SwaggerEnumValue("header")] Header,

        /// <summary>
        /// Denotes a query value.
        /// </summary>
        [SwaggerEnumValue("query")] Query
    }
}