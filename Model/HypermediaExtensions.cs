namespace Kickstarter.Api.Model
{
    public static class HypermediaExtensions
    {
        public static string ApiLink(this IHypermediaItem context, string name)
        {
            return context.Urls.Api[name];
        }

        public static string WebLink(this IHypermediaItem context, string name)
        {
            return context.Urls.Web[name];
        }
    }
}