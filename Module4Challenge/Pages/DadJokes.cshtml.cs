using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module4Challenge.Pages

{
    public class BasePageModel : PageModel
    {
        public string[] dadJokes { get; set; } = new string[12]
        {
            "Joke1", //"When does a joke become a dad joke. When it becomes apparent.",
            "Joke2", //"What do you call a well-balanced horse? Stable.",
            "Joke3",//"I was wondering why the baseball was getting closer and closer. And then it hit me.",
            "Joke4",//"Where do polar bears keep their money? In a snowbank.",
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
        public string[] newJokeList { get; set; } = new string[2];



    public void OnGet()
        {
             
            Random rnd = new Random();
            // Creates a new random object. 
            int randomJokeNumber = rnd.Next(0,12);
            // Generates a new randomJokeNumber between 0 and 11. 

            for (int x = 0; x < numberOfJokesToShow; x++)
            // Loops for numberOfJokesToShow. x represents the current joke in newJokeList.
            {
                
                string currentJoke = dadJokes[randomJokeNumber]; 
                // currentJoke is set to the value in dadJokes that the int randomJokeNumber is. This sets the r

                for(int c = 0; c < jokesToShow.Length; c++){
                    // Loops over jokesToShow. c represents the current joke in jokesToShow. 
                    if(jokesToShow[c] == currentJoke)
                    {
                        randomJokeNumber = rnd.Next(0,12);
                        currentJoke = dadJokes[randomJokeNumber];
                        // Sets the randomJokeNumber to an new random value and sets the currentJoke to a new random string in dadJokes. 
                        x = 0;
                        // Sets x to 0 so that the jokesToShow list is looped over again.
                        continue;
                    }

                
                }
                
                newJokeList[x] = currentJoke;
                // The end of the x for-loop. After the c for-loop is done checking the joke is original, this line set the 
                // x jokesToShow value as the currentJoke. 

                randomJokeNumber = rnd.Next(0,12);
                // Sets randomJokeNumber to a new random number.
                for (int y = 0; y < newJokeList.Length; y++)
                {
                    if(dadJokes[randomJokeNumber] == newJokeList[y])
                    {
                        randomJokeNumber = rnd.Next(0,12);
                        y = 0;
                        continue;
                    }

                }
                // This block of code checks if the joke that matches with the new randomly generated number 
                // matches a joke in the newJokeList. if so, a new random number is generated. 
                 
            }

            Array.Copy(newJokeList, jokesToShow, newJokeList.Length);
            // Copies the values in newJokesList to jokesToShow.
        }

    public void OnPost()
        {
             
            Random rnd = new Random();
            // Creates a new random object. 
            int randomJokeNumber = rnd.Next(0,12);
            // Generates a new randomJokeNumber between 0 and 11. 
            
            for (int x = 0; x < numberOfJokesToShow; x++)
            // Loops the total number of times for the number of jokes to show. x is the current chosen joke in newJokeList.
            {
                
                string currentJoke = dadJokes[randomJokeNumber]; 

                for(int c = 0; c < jokesToShow.Length; c++){
                    // Loops over jokesToShow. c represents the current joke in jokesToShow
                    if(jokesToShow[c] == currentJoke)
                    // If the current value in jokesToShow matches the currentJoke
                    {
                        randomJokeNumber = rnd.Next(0,12);
                        x = 0;
                        continue;
                    }

                
                }
                
                newJokeList[x] = currentJoke;
                // The end of the x for-loop. After the c for-loop is done checking the joke is original, this line set the 
                // x jokesToShow value as the currentJoke. 
                randomJokeNumber = rnd.Next(0,12);
                for (int y = 0; y < newJokeList.Length; y++)
                {
                    if(dadJokes[randomJokeNumber] == newJokeList[y])
                    {
                        randomJokeNumber = rnd.Next(0,12);
                        y = 0;
                        continue;
                    }

                }
                // This block of code checks if the joke that matches with the new randomly generated number 
                // matches a joke in the newJokeList. if so, a new random number is generated. 
                 
            }

            Array.Copy(newJokeList, jokesToShow, newJokeList.Length);
            // Copies the values in newJokesList to jokesToShow.
        }

    }

}