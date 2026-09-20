using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module4Challenge.Pages

{
    public class BasePageModel : PageModel
    {
        public string[] dadJokes { get; set; } = new string[12]
        {
            "When does a joke become a dad joke. When it becomes apparent.", //"",
            "What do you call a well-balanced horse? Stable.", //"",
            "I was wondering why the baseball was getting closer and closer. And then it hit me.",//"",
            "Where do polar bears keep their money? In a snowbank.",//"",
            "Why did the scarecrow win an award? Because he was outstanding in his field.",  
            "What do you call a boomerang that won't fly back? A stick.", 
            "Why did the guy get fired from the calendar factory? Because he took a few days off.",
            "Did you hear about the cheese factory that exploded in France? Apparently, da brie is everywhere.",
            "What do you call someone who raises hens? A chicken tender.",
            "Why did the Gym close down? Because it didn't work out.",
            "What's worse than raining cats and dogs. Hailing taxis.",
            "What did the beach say when the tide came in. Long time no sea!"
        };
        // This global array holds a list of 12 different jokes. 

        public int numberOfJokesToShow { get; set; } = 2;
        // This global variable holds the number of jokes that are shown on the page at a time. 
        public string[] jokesToShow { get; set; } = new string[2];
        // This global array holds the current list of jokes that are shown on the page. 
        //public string[] newJokeList { get; set; } = new string[2];
        // This global array holds the list of jokes that will be shown on the page next. 



    public void OnGet()
        {
             
            Random rnd = new Random();
            // Creates a new random object. 
            int randomJokeNumber = rnd.Next(0,12);
            // Generates a new randomJokeNumber between 0 and 11. 

            for (int x = 0; x < numberOfJokesToShow; x++)
            // Loops for numberOfJokesToShow. x represents the current joke in jokesToShow(newJokeList.
            {
                
                string currentJoke = dadJokes[randomJokeNumber]; 
                // currentJoke is set to the value in dadJokes that the int randomJokeNumber is. This sets the r

                for(int c = 0; c < jokesToShow.Length; c++){
                    // Loops over jokesToShow. c represents the current joke in jokesToShow. 
                    if(jokesToShow[c] == currentJoke)
                    // If the current joke in jokesToShow is the same as currentJoke
                    {
                        randomJokeNumber = rnd.Next(0,12);
                        currentJoke = dadJokes[randomJokeNumber];
                        // Sets the randomJokeNumber to an new random value and sets the currentJoke to a new random string in dadJokes. 
                        x = 0;
                        // Sets x to 0 so that the jokesToShow list is looped over again.
                        continue;
                        // Goes back to the top of the loop.
                    }

                
                }
                
                jokesToShow[x] = currentJoke;
                // The end of the x for-loop. After the c for-loop is done checking the joke is original, 
                // this line sets the x jokesToShow value as the currentJoke. 

                randomJokeNumber = rnd.Next(0,12);
                // Sets randomJokeNumber to a new random number.
                
            }
                               
            }

        

    public void OnPost()
        {
             
              
            Random rnd = new Random();
            // Creates a new random object. 
            int randomJokeNumber = rnd.Next(0,12);
            // Generates a new randomJokeNumber between 0 and 11. 

            for (int x = 0; x < numberOfJokesToShow; x++)
            // Loops for numberOfJokesToShow. x represents the current joke in jokesToShow(newJokeList.
            {
                
                string currentJoke = dadJokes[randomJokeNumber]; 
                // currentJoke is set to the value in dadJokes that the int randomJokeNumber is. This sets the r

                for(int c = 0; c < jokesToShow.Length; c++){
                    // Loops over jokesToShow. c represents the current joke in jokesToShow. 
                    if(jokesToShow[c] == currentJoke)
                    // If the current joke in jokesToShow is the same as currentJoke
                    {
                        randomJokeNumber = rnd.Next(0,12);
                        currentJoke = dadJokes[randomJokeNumber];
                        // Sets the randomJokeNumber to an new random value and sets the currentJoke to a new random string in dadJokes. 
                        x = 0;
                        // Sets x to -1 so that the jokesToShow list is looped over again.
                        continue;
                        // Goes back to the top of the loop.
                    }

                
                }
                
                jokesToShow[x] = currentJoke;
                // The end of the x for-loop. After the c for-loop is done checking the joke is original, 
                // this line sets the x jokesToShow value as the currentJoke. 

                randomJokeNumber = rnd.Next(0,12);
                // Sets randomJokeNumber to a new random number.
                
            }
              
        }

    }

}