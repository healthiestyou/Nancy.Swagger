using Nancy.Swagger.Services;

namespace Nancy.Swagger.Modules
{
    [SwaggerApi]
    public class SwaggerModule : NancyModule
    {
        public SwaggerModule(ISwaggerMetadataConverter converter)
            : base(SwaggerConfig.ResourceListingPath)
        {
            Get["/"] = _ =>
            {
                var listing = converter.GetResourceListing();
                var json = listing.ToJson();
                return json;
            };

            Get["/{resourcePath*}"] = _ => converter.GetApiDeclaration("/" + _.resourcePath).ToJson();
        }
    }
}