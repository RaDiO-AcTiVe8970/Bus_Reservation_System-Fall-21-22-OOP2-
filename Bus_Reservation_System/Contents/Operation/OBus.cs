using Contents.Define;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contents.Operation
{
    public class OBus:OBusInterface
    {
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-63QCUO7H;Initial Catalog=BusReservation;Integrated Security=True");

        public int addbus(DBus bus)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Bus(bname, btype, route, totalbus, price, cname) values('" + bus.bname + "','" + bus.btype + "','" + bus.route + "','" + bus.totalbus + "','" + bus.price + "','" + bus.cname + "')", connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            return check;
        }

        public int addtime(DBus bus)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update Bus set departure='" + bus.departure + "', date='" + bus.date + "' where bname='" + bus.bname + "'", connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            return check;
        }

        public SqlDataAdapter show(DBus bus)
        {
            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("select * from Bus where bname='" + bus.bname + "'", connection);
            connection.Close();
            return command;
        }
        public SqlDataAdapter showAdmin(DBus bus)
        {

            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("select * from Bus where bname='" + bus.bname + "' and cname='" + bus.cname + "'", connection);
            connection.Close();
            return command;
        }
        public SqlDataAdapter showUser(DBus bus)
        {
            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("select * from Bus where bname='" + bus.bname + "'", connection);
            connection.Close();
            return command;
        }
        public SqlDataAdapter showAll()
        {
            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("select * from Bus", connection);
            connection.Close();
            return command;
        }
        public SqlDataAdapter showSchedule(DBus bus)
        {
            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("select * from Bus where departure='" + bus.departure + "' and date='" + bus.date + "'", connection);
            connection.Close();
            return command;
        }
        public int updateName(DBus db)
        {
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("update Bus set cname='" + db.newCname + "' where cname='" + db.cname + "'", connection);
            int check2 = cmd2.ExecuteNonQuery();
            connection.Close();
            return check2;
        }
    }
}
