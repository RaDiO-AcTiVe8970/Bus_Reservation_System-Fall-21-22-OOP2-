using Contents.Define;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contents.Operation
{
    interface OBusInterface
    {
        int addbus(DBus bus);
        int addtime(DBus bus);
        SqlDataAdapter show(DBus bus);
        SqlDataAdapter showAdmin(DBus bus);
        SqlDataAdapter showUser(DBus bus);
        SqlDataAdapter showAll();
        SqlDataAdapter showSchedule(DBus bus);
        int updateName(DBus dar);
    }
}
