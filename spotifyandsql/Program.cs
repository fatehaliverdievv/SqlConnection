using spotifyandsql.Models;
using spotifyandsql.Services;

namespace spotifyandsql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArtistService artistService = new ArtistService();
            //----------------------------------------------------ADD
            //Artist epi = new Artist {StageName = "Epi", Name = "Ekber", Surname = "Novruzlu", Birthday = new DateTime(1990,11,12), Gender = "Male"};
            //artistService.Add(epi);
            //----------------------------------------------------GETALL
            //foreach (var item in artistService.GetAll())
            //{
            //    Console.WriteLine(item.Id + "." + item.StageName + " " + item.Name + " " + item.Surname + " " + item.Gender + " " + item.Birthday);
            //}
            //_____________________________________________________DELETE
            //artistService.Delete(25);

            MusicService musicService = new MusicService();
            //----------------------------------------------------ADD
            //Music theindependent = new Music { Name = "The Indepentent", Duration = new TimeSpan(1,1,30), CategoryId = 5};
            //musicService.Add(theindependent);
            //----------------------------------------------------GETALL
            //foreach (var item in musicService.GetAll())
            //{
            //    Console.WriteLine(item.Id + "." + item.Name + " " + item.Duration + " " + item.CategoryId);
            //}
            //____________________________________________________DELETE
            //musicService.Delete(2);

        }
    }
}