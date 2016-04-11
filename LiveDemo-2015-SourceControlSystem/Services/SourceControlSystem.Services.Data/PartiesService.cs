namespace GoParty.Services.Data
{
    using System.Linq;
    using Models;
    using GoParty.Services.Data.Contracts;
    using GoParty.Data;
    using System;

    public class PartiesService : IPartiesService
    {
        private readonly IRepository<Party> Parties;

        public PartiesService(IRepository<Party> PartiesRepository)
        {
            this.Parties = PartiesRepository;
        }

        public Party Create(Party party)
        {
            this.Parties.Add(party);

            this.Parties.SaveChanges();

            return party;
        }

        public void DeleteById(int id)
        {
            this.Parties.Delete(id);

            this.Parties.SaveChanges();
        }

        public IQueryable<Party> GetAll()
        {
            return this.Parties.All();
        }

        public Party GetById(int id)
        {
            return this.Parties.GetById(id);
        }

        public Party UpdateById(Party party)
        {
            var partyToUpdate = this.Parties.GetById(party.Id);

            partyToUpdate.Title = party.Title;
            partyToUpdate.Latitude = party.Latitude;
            partyToUpdate.Longitude = party.Longitude;
            partyToUpdate.Duration = party.Duration;
            partyToUpdate.startDate = party.startDate;

            this.Parties.SaveChanges();

            return partyToUpdate;
        }
    }
}
