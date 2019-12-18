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
        //protected SqlConnection _conn = new SqlConnection(@"Data Source=172.105.119.190,2511;Initial Catalog=DataSocial;User ID=guest123;Password=Guest@123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        protected SqlConnection _conn = new SqlConnection(@"Data Source=.\sqldev2017;Initial Catalog=DataSocial;Integrated Security=True");

    }
}
