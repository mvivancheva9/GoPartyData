namespace GoParty.Models
{
    using System;

    public class Party
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public int Duration { get; set; }

        public DateTime startDate { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
