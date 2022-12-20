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
    internal class MusicService : IService<Music>
    {
        public void Add(Music model)
        {
            Sql.ExecCommand($"INSERT INTO Musics (Name,Duration,CategoryId) VALUES(N'{model.Name}','{model.Duration}' ,'{model.CategoryId}')");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"Delete Musics Where Id = {id}");
        }
        public List<Music> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Musics");
            List<Music> musics = new List<Music>();
            foreach (DataRow dr in dt.Rows)
            {
                musics.Add(new Music { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString(), Duration = TimeSpan.Parse((dr["Duration"].ToString())), CategoryId = Convert.ToInt32(dr["CategoryId"]) });
            }
            return musics;
        }
    }
}
