using System;

namespace Homework0013
{
    class Program
    {
        static void Main(string[] args)
        {
            public void ExecuteSQL(String query)
            {
                using (var cn = new SqlConnection(this.ConnectionString))
                {
                    var cm = new SqlCommand();
                    cm.CommandText = query;

                    cn.Open();
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                }
            }
        }
    }
}
