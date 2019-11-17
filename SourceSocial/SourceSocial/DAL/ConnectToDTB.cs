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
        protected SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-6ENCE12\SQLEXPRESS;Initial Catalog=DataSocial;Integrated Security=True");
    }
}
