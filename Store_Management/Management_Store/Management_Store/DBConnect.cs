using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Store
{
    internal class DBConnect
    {
        private string con;
        public string myConnection()
        {
            con = @"Data Source=SERBAN\SQLEXPRESS;Initial Catalog=SERBAN;Integrated Security=True";
            return con;

    }
}
