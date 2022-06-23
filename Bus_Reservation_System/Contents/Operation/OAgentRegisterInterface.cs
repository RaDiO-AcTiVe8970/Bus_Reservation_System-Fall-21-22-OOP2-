using Contents.Define;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contents.Operation
{
    interface OAgentRegisterInterface
    {
        int agentregister(DAgentRegister dar);
        int deleteagent(DAgentRegister dar);
        SqlDataAdapter agentLogin(DAgentRegister dar);
        SqlDataAdapter show(DAgentRegister dar);
        int delete(DAgentRegister dar);
        SqlDataAdapter showAll();
        SqlDataAdapter showViaEmail(DAgentRegister dar);
        int updatePass(DAgentRegister dar);
        int updateName(DAgentRegister dar);
    }
}
