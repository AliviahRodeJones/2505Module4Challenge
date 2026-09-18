using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module4Challenge.Pages

{
    public class BasePageModel : PageModel
    {
        public string[] dadJokes { get; set; } = new string[12]
        {
            "When does a joke become a dad joke. When it becomes apparent.",
            "What do you call a well-balanced horse? Stable.",
            "I was wondering why the baseball was getting closer and closer. And then it hit me.",
            "Where do polar bears keep their money? In a snowbank.",
            "Joke5",
            "Joke6",
            "Joke7",
            "Joke8",
            "Joke9",
            "Joke10",
            "Joke11",
            "Joke12"
        };

        public int numberOfJokesToShow { get; set; } = 2;
        public string[] jokesToShow { get; set; } = new string[2];


    public void OnGet()
        {
             
            Random rnd = new Random();
            for (int x = 0; x < numberOfJokesToShow; x++)
            {
                int currentJoke = rnd.Next(0,12);
                while (string.IsNullOrEmpty(dadJokes[currentJoke]))
                {
                    currentJoke = rnd.Next(1,13);
                }
                jokesToShow[x] = dadJokes[currentJoke];
                dadJokes[currentJoke] = "";
            }
        }

    public void OnPost()
        {

            Random rnd = new Random();
            for (int x = 0; x < jokesToShow.Length; x++)
            {
                int currentJoke = rnd.Next(1,13);
                while (string.IsNullOrEmpty(dadJokes[currentJoke]))
                {
                    currentJoke = rnd.Next(1,13);
                }
                jokesToShow[x] = dadJokes[currentJoke];
                dadJokes[currentJoke] = "";
            }

        }

    }

}