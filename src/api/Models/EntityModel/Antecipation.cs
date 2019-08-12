using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Antecipation
    {
        public long AntecipationId { get; set; }
        public DateTime SolicitedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public decimal AmountRequested { get; set; }
        public decimal AmountApproved { get; set; }

    }
}
