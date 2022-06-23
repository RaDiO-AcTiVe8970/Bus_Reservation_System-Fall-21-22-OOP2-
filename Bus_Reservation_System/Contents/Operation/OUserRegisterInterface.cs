using Contents.Define;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contents.Operation
{
    interface OUserRegisterInterface
    {
        int userregister(DUserRegister dur);
        SqlDataAdapter userLogin(DUserRegister dur);
        SqlDataAdapter show(DUserRegister dur);
        int delete(DUserRegister dur);
        SqlDataAdapter showAll();
        int upadateName(DUserRegister dur);
        int upadatePassword(DUserRegister dur);
        int upadatEmail(DUserRegister dur);
        int upadatePhone(DUserRegister dur);
        SqlDataAdapter showByUser(DUserRegister dur);
    }
}
