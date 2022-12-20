using spotifyandsql.Abstraction;
using spotifyandsql.Helper;
using spotifyandsql.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace spotifyandsql.Services
{
    internal class ArtistService : IService<Artist>
    {
        
        public void Add(Artist model)
        {
            Sql.ExecCommand($"INSERT INTO Artists (StageName,Name,Surname,Birthday,Gender) VALUES (N'{model.StageName}',N'{model.Name}',N'{model.Surname}','{model.Birthday}',N'{model.Gender}')");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE Artists WHERE Id ={id}");
        }
        public List<Artist> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Artists");
            List<Artist> artists = new List<Artist>();
            foreach (DataRow dr in dt.Rows)
            {
                artists.Add(new Artist { Id = Convert.ToInt32(dr["Id"]), StageName = dr["StageName"].ToString(), Name = dr["Name"].ToString(), Surname = dr["Surname"].ToString(), Birthday = Convert.ToDateTime(dr["Birthday"]), Gender = dr["Gender"].ToString() });
            }
            return artists;
        }
    }
}
