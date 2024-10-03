using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Bookcase
{
    internal class ACCESSConneciton
    {
        public OleDbConnection connection()
        { 
           OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Courses\C# Project\Bookcase\DB_Books.mdb");
            conn.Open();
            return conn;
        }
    }
}
