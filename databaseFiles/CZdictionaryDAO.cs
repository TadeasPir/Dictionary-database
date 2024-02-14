using DatabazeMineraly;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_database.databaseFiles
{public class CZdictionaryDAO  : IRepozitory<CZdictionary>
    {
        public void Delete(CZdictionary element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CZdictionary> GetAll()
        {
            SqlConnection conn = DatabaseSingleton.GetInstance();

            using (SqlCommand command = new SqlCommand("SELECT * FROM Effects", conn))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CZdictionary cZdictionary = new CZdictionary
                    {
                        ID = Convert.ToInt32(reader[0].ToString()),
                        Slovo = reader[1].ToString()
                    };
                    yield return cZdictionary;
                }
                reader.Close();
            }

        }

        public CZdictionary GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(ENdictionary element)
        {
            throw new NotImplementedException();
        }

        public void Save(CZdictionary element)
        {
            throw new NotImplementedException();
        }

        CZdictionary IRepozitory<CZdictionary>.GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }


}
