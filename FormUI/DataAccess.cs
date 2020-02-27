using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FormUI.Properties.Settings.MLBConnectionString")))
            {
                return connection.Query<Person>($"select * from People where lastName = '{ lastName }'").ToList();

            }
        }
    }
}
