using Feeds.Models;
using System.Web.Http;
using StructureMap;
using Feeds.Repository;

namespace Feeds.REST.Controllers
{
    [RoutePrefix("feeds")]
    public class FeedsController : ApiController
    {
        private readonly IFeedsImpl _feedImpl;

        public FeedsController(IFeedsImpl feedImpl)
        {
            _feedImpl = feedImpl;
        }

        [HttpGet]
        [Route("getFeed")]
        public Feed GetFeed()
        {
            var result = _feedImpl.GetFeeds();
            return result;
        }
    }
}
