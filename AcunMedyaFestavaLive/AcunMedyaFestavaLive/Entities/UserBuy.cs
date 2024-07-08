using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaFestavaLive.Entities
{
    public class UserBuy
    {
        public int UserBuyId { get; set; }
        
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        
        public int Number { get; set; }
        // Foreign Key

        public int TicketId { get; set; }

        // Navigation property
        public Ticket Ticket { get; set; }
    }
}
