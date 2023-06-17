using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataHelper;
using Common;

namespace SALES
{
    public class DataAccess
    {
        public  DataHelper.DataHelper DB = new DataHelper.DataHelper("Data Source=DESKTOP-32D44P8\\SQLEXPRESS01;Initial Catalog=DB_SALES;Integrated Security=True");
    }
}
