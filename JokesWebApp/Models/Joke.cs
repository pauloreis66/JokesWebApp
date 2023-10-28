namespace JokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokePergunta { get; set; }
        public string JokeResposta{ get; set; }
        public Joke()
        {
            Id =0;
            JokePergunta = string.Empty;
            JokeResposta = string.Empty;
        }
    }
}
