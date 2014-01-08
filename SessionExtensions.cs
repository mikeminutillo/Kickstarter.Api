using System.Threading.Tasks;

namespace Kickstarter.Api
{
    public static class SessionExtensions
    {
        public static Task<TResult> Query<TResult>(this IKickstarterSession session, IQuery<TResult> results)
        {
            return results.ApplyTo(session);
        }
    }
}