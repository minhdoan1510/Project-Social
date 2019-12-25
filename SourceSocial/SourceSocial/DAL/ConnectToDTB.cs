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
        protected string connectionSTR = @"Data Source=172.105.119.190,2511;Initial Catalog=DataSocial;Persist Security Info=True;User ID=guest123;Password=Guest@123";
        protected SqlConnection _conn = new SqlConnection(@"Data Source=172.105.119.190,2511;Initial Catalog=DataSocial;Persist Security Info=True;User ID=guest123;Password=Guest@123");
    }
}