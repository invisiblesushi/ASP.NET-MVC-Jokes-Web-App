using System.ComponentModel.DataAnnotations;

namespace JokesWebApp.Models
{
    public class Joke
    {
        [Key]
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set;}

        public Joke()
        {
            
        }
    }
}
