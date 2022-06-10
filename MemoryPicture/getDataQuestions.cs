using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

using System.Threading.Tasks;

namespace MemoryPicture
{
    class getDataQuestions
    {
        public string path = @"..\..\database\memorypic.accdb";
        public getDataQuestions()
        {

            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path;
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand("SELECT * from  question WHERE idpicture='@1'", connection);
                command.Parameters.AddWithValue("@1", numberQ);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Lquestion.Add(new question(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString()));
                }
            }
        }
    }
}
