using Contents.Define;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contents.Operation
{
    public class OAgentRegister: OAgentRegisterInterface
    {
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-63QCUO7H;Initial Catalog=BusReservation;Integrated Security=True");
        public int agentregister(DAgentRegister dar)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into AgentReg(cname, email, password) values('" + dar.cname + "','" + dar.email + "','" + dar.pass + "')", connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            return check;
        }

        public int updateName(DAgentRegister dar)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update AgentReg set cname='"+ dar.cname +"' where email='"+ dar.email +"'",connection);
            int check = cmd.ExecuteNonQuery();
            connection.Close();
            return check;
        }

        public int updatePass(DAgentRegister dar)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update AgentReg set password='" + dar.pass + "' where email='" + dar.email + "'", connection);
            int check = cmd.ExecuteNonQuery();
            connection.Close();
            return check;
        }

        public int deleteagent(DAgentRegister dar)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM AgentReg WHERE email= '" + dar.email + "'", connection);
            int cmd = command.ExecuteNonQuery();
            connection.Close();
            return cmd;
        }

        public SqlDataAdapter agentLogin(DAgentRegister dar)
        {
            connection.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("Select COUNT(*) from AgentReg where email='" + dar.email + "' and password='" + dar.pass + "'", connection);
            connection.Close();
            return sqlDA;
        }

        public SqlDataAdapter show(DAgentRegister dar)
        {
            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("select * from AgentReg where cname='" + dar.cname + "'", connection);
            connection.Close();
            return command;
        }
        public int delete(DAgentRegister dar)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM AgentReg WHERE cname= '" + dar.cname + "'", connection);
            int cmd = command.ExecuteNonQuery();
            connection.Close();
            return cmd;
        }
        public SqlDataAdapter showAll()
        {
            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("select * from AgentReg ", connection);
            connection.Close();
            return command;
        }
        public SqlDataAdapter showViaEmail(DAgentRegister dar)
        {
            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("select * from AgentReg where email='" + dar.email + "'", connection);
            connection.Close();
            return command;
        }
    }
}
