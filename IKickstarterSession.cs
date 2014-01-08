using System.Threading.Tasks;

namespace Kickstarter.Api
{
    public interface IKickstarterSession
    {
        Task<TResult> Get<TResult>(string path);
        Task<TResult> Post<TResult>(string path, object parameters);
    }
}