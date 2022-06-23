using Contents.Define;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contents.Operation
{
    interface OTicketInterface
    {
        int addTicket(DTicket dt);
        SqlDataAdapter show(DTicket dt);
        SqlDataAdapter showSchedule(DTicket dt);
        SqlDataAdapter validate(DTicket dt);
    }
}
