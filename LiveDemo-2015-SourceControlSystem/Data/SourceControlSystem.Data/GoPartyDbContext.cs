namespace GoParty.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Data.Entity;

    public class GoPartyDbContext : IdentityDbContext<User>, IGoPartyDbContext
    {
        public GoPartyDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Party> Parties { get; set; }

        public static GoPartyDbContext Create()
        {
            return new GoPartyDbContext();
        }
    }
}
