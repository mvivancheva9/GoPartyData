namespace GoParty.Services.Data.Contracts
{
    using GoParty.Models;
    using System.Linq;

    public interface IPartiesService
    {
        IQueryable<Party> GetAll();

        Party UpdateById(Party party);

        void DeleteById(int id);

        Party Create(Party party);

        Party GetById(int id);
    }
}
