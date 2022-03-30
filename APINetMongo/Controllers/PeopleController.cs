using Microsoft.AspNetCore.Mvc;
using APINetMongo.Service;


namespace APINetMongo
{
    [Route("api/People")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleService peopleService;

        public PeopleController(IPeopleService peopleService)
        {
            this.peopleService = peopleService;
        }

        // GET : api/People
        [HttpGet]
        public ActionResult<List<People>> Get(){
            return peopleService.Get();
        }
    }
}
