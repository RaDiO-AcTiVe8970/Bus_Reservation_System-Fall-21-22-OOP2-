using Contents.Define;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contents.Operation
{
    public class OUserRegister:OUserRegisterInterface
    {
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-63QCUO7H;Initial Catalog=BusReservation;Integrated Security=True");
        public int userregister(DUserRegister dur)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into UserRegLat(name,username, gender, city, phone, paddress, perma_address, email, password) values('" + dur.name + "','" + dur.username + "','" + dur.gender + "','" + dur.city + "','" + dur.phone + "','" + dur.address + "','" + dur.paddress + "','" + dur.email + "','" + dur.password + "')", connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            return check;
        }
        public SqlDataAdapter userLogin(DUserRegister dur)
        {
            connection.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("Select COUNT(*) from UserRegLat where email='" + dur.email + "' and password='" + dur.password + "'", connection);
            connection.Close();
            return sqlDA;
        }
        public SqlDataAdapter show(DUserRegister dur)
        {
            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("select * from UserRegLat where username='" + dur.username + "'", connection);
            connection.Close();
            return command;
        }
        public int delete(DUserRegister dur)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM UserRegLat WHERE username= '" + dur.username + "'", connection);
            int cmd = command.ExecuteNonQuery();
            connection.Close();
            return cmd;
        }
        public SqlDataAdapter showAll()
        {
            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("select * from UserRegLat", connection);
            connection.Close();
            return command;
        }
        public int upadateName(DUserRegister dur)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update UserRegLat set name='" + dur.name + "' where username='" + dur.username + "'", connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            return check;
        }

        public int upadatePassword(DUserRegister dur)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update UserRegLat set password='" + dur.password + "' where username='" + dur.username + "'", connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            return check;
        }
        public int upadatEmail(DUserRegister dur)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update UserRegLat set email='" + dur.email + "' where username='" + dur.username + "'", connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            return check;
        }
        public int upadatePhone(DUserRegister dur)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update UserRegLat set phone='" + dur.phone + "' where username='" + dur.username + "'", connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            return check;
        }
        public SqlDataAdapter showByUser(DUserRegister dur)
        {
            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("select * from UserRegLat where username='"+ dur.username+ "'", connection);
            connection.Close();
            return command;
        }
    }
}
