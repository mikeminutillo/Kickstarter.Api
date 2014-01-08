using System.Threading.Tasks;

namespace Kickstarter.Api
{
    public interface IQuery<TResult>
    {
        Task<TResult> ApplyTo(IKickstarterSession session);
    }
}