using Contents.Define;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contents.Operation
{
    public class OTicket:OTicketInterface
    {
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-63QCUO7H;Initial Catalog=BusReservation;Integrated Security=True");

        public int addTicket(DTicket dt)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Ticket(name, phone, email, btype, departure, bname, seat, route) values('" + dt.name + "','" + dt.phone + "','" + dt.email + "','" + dt.btype + "','" + dt.departure + "','" + dt.bname + "','" + dt.seat+ "','" + dt.destination + "')", connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            return check;
        }

        public SqlDataAdapter show(DTicket dt)
        {
            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("select * from Ticket where name='" + dt.name + "'", connection);
            connection.Close();
            return command;
        }

        public SqlDataAdapter showSchedule(DTicket dt)
        {
            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("select * from Bus where name='" + dt.name + "'", connection);
            connection.Close();
            return command;
        }

        public SqlDataAdapter validate(DTicket dt)
        {
            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("select (bname) from bus where departure='"+ dt.departure +"' and btype='"+ dt.btype +"' and route='"+ dt.destination +"'", connection);
            connection.Close();
            return command;
        }
    }
}
