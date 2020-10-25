using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;

namespace FormUI
{
    public class DataAccess
    {
        public List<Session> GetSessions(string date_S)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConVal("SampleDB")))
            {
                var output = connection.Query<Session>("dbo.spSessions_GetByDate_1 @Date_S", new { Date_S = date_S }).ToList();
                return output;
            }
        }

        public void Yoga_Insert(DateTime date_S, string s_1_1, string s_1_2, string s_1_3, string s_2_1, string s_2_2, string s_2_3)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConVal("SampleDB")))
            {
                List<Session> session = new List<Session>();
                session.Add(new Session { Date_S = date_S , S_1_1 = Convert.ToBoolean(s_1_1), S_1_2 = Convert.ToBoolean(s_1_2), 
                    S_1_3 = Convert.ToBoolean(s_1_3), S_2_1 = Convert.ToBoolean(s_2_1), S_2_2 = Convert.ToBoolean(s_2_2), 
                    S_2_3 = Convert.ToBoolean(s_2_3) });
                connection.Execute("dbo.spSessions_Insert  @Date_S, @S_1_1, @S_1_2, @S_1_3, @S_2_1, @S_2_2, @S_2_3", session);
            }
        }
    }
}
