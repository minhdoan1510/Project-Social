using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ConnectToDTB
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=172.105.119.190,1433;Initial Catalog=DataSocial;User ID=minhtien123;Password=Minhtien@123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}
