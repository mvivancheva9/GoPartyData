namespace GoParty.Api.Controllers
{
    using Services.Data.Contracts;
    using System.Web.Http;
    using System.Linq;
    using System;
    using Services.Data;
    using Data;
    using GoParty.Models;
    using Microsoft.AspNet.Identity;

    [RoutePrefix("api/Parties")]
    public class PartiesController : ApiController
    {
        private readonly IPartiesService Parties;

        public PartiesController()
            : this(new PartiesService(new EfGenericRepository<Party>(new GoPartyDbContext())))
        {
        }

        public PartiesController(IPartiesService PartysService)
        {
            this.Parties = PartysService;
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var result = this
                .Parties
                .GetAll()
                .ToList();

            return this.Ok(result);
        }

        [HttpPost]
        public IHttpActionResult AddParty(Party party)
        {
            var userId = this.User.Identity.GetUserId();
            party.UserId = userId;
            party.startDate = DateTime.Now;
            var result = this
                .Parties
                .Create(party);

            return this.Ok(result);
        }

        [Route("Party/{id}")]
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var result = this
               .Parties
               .GetById(id);
            return this.Ok(result);
        }
    }
}
