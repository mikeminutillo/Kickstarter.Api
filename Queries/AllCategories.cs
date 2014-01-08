using System.Threading.Tasks;
using Kickstarter.Api.Model;

namespace Kickstarter.Api.Queries
{
    public class AllCategories : IQuery<CategoryList>
    {
        public Task<CategoryList> ApplyTo(IKickstarterSession session)
        {
            return session.Get<CategoryList>("v1/categories");
        }
    }
}