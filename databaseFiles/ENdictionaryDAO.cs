using DatabazeMineraly;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_database.databaseFiles
{
    public class ENdictionaryDAO : IRepozitory<ENdictionary>
    {
        public void Delete(ENdictionary element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ENdictionary> GetAll()
        {
            SqlConnection conn = DatabaseSingleton.GetInstance();

            using (SqlCommand command = new SqlCommand("SELECT * FROM Effects", conn))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ENdictionary eNdictionary = new ENdictionary
                    {
                        ID = Convert.ToInt32(reader[0].ToString()),
                        Slovo = reader[1].ToString()
                    };
                    yield return eNdictionary;
                }
                reader.Close();
            }

        }

        public ENdictionary GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(ENdictionary element)
        {
            throw new NotImplementedException();
        }
    }

}
