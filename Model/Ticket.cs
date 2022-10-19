using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket
    {
        int Id { get; set; }
        string TicketedBy { get; set; }
        string ReportedBy { get; set; }
        string Subject { get; set; }
        DateTime date { get; set; }
        string TicketType { get; set; }
        string Priority { get; set; }
        string Deadline { get; set; }
        string Description { get; set; }
    }
}
