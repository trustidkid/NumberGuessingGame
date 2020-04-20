using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
    
            /*
                PROBLEM
                User is able to guess numbers against a number set by your program
                If user enters anything other than number, user should be told
                There are 3 levels, easy, medium and hard
                At easy, Users get a chance to guess the number between 1 - 10, and the user gets 6 guesses
                Medium, the users is required to guess the number between 1 - 20, and the user gets 4 guesses
                Hard, users are required to guess between 1 - 50, and they only get 3 guesses
                User should be able to set the level they want to play
                Users should see how many guesses they have left after each guess
                If user guesses right, user should be told "You got it right!"
                If the user guesses wrong, user should be told "That was wrong"
                If users uses all available guessing power and still unable to guess right, user should be told "Game over!"
            */

            //get the user name
            Console.WriteLine("Hey! Before we proceed, your name please");
            string name = Console.ReadLine();
            //welcome message
            Console.WriteLine("You are welcome (" + name+")");

            //set game levels
            Console.WriteLine("There are 3 levels in this game. 1 => Easy, 2 => Medium, 3 => Hard");
            Console.WriteLine("Please enter the numerical value corresponding to your level");
            //get the level selected
            var userSelection = Console.ReadLine();
            int userSelectedLevel = int.Parse(userSelection);
            
            /**
                Start!
                check if user enters anything other than number
            */
                int userchoice;
                bool checkValue = int.TryParse(userSelection, out userchoice);
                if(!checkValue){
                    Console.WriteLine(name + " that wasn't a number now!!!***");
                    return;
                }
            /**
                End!
            */


            /*
                Generate random number between two values
                inclusive of the upper bound number
             */
             int RandomNumber(int min, int max){
                
                Random random = new Random();
                return random.Next(min,max+1);
            }

            /*
                Generate random number for easy level
             */
            int minValue = 1; int maxValue = 10;
            int randomNumberEasy = RandomNumber(minValue,maxValue);
           
             /*
                Generate random number for Medium level
             */
            int minValueMed = 1; int maxValueMed = 20;
            int randomNumberMedium = RandomNumber(minValueMed,maxValueMed);

             /*
                Generate random number for Hard level
             */
            int minValueHard = 1; int maxValueHard = 50;
            int randomNumberHard = RandomNumber(minValueHard,maxValueHard);

            //check user selection
            /*
                *****EASY LEVEL********
                Users get a chance to guess the number between 1 - 10, 
                and the user gets 6 guesses
             */
            if(userSelectedLevel == 1){
                //user has six time to try
                Console.WriteLine("***EASY LEVEL NUMBER GUESSING GAME***");
                Console.WriteLine("***YOU HAVE 6 CHANCES TO GUESS***");
                Console.WriteLine("***INSTRUCTION: PICK A NUMBER BETWEEN 1 AND 10 ***");
                int trial = 5;

                for(int i = 0; i <= trial; i++){

                    if(i > 0){
                        Console.WriteLine("Don't worry, let's go again! Enter a number...");
                    }else
                    Console.WriteLine("Oya let's go there! Enter a number...");
                    //read user guesss
                    /**
                        Start!
                        check if user enters anything other than number
                     */
                    var userInput = Console.ReadLine();
                    int value;
                    bool checkInt = int.TryParse(userInput, out value);
                    if(!checkInt){
                        Console.WriteLine(name + " that wasn't a number now!!!***");
                        return;
                    }
                    /**
                        End!
                     */
                    int guessValue = int.Parse(userInput);
                    if(guessValue < 1 || guessValue > 10){
                        Console.WriteLine("Please read instruction again. You can't pick number above 10 or less than 1");
                    }
                    if(guessValue == randomNumberEasy){
                        Console.WriteLine("Whaoo! You guess right!");
                        if(i < 3){
                            Console.WriteLine("Baba Ijebu needs you, You can try Medium Level");
                        }
                        return;
                    }
                    if(i == trial && guessValue != randomNumberEasy){
                        Console.WriteLine("You have come to the end of the Game!");
                        Console.WriteLine("***GAME OVER***");
                        Console.WriteLine("THE NUMBER IS = ***" + randomNumberHard+"***" );
                        return;
                    }
                    Console.WriteLine("Oh Sorry, that was wrong Mr./Mrs. " + name );
                    Console.WriteLine("You have "+ (trial - i) + " more trial(s) to go.");
                }
            }

            /*
                *****MEDIUM LEVEL********
                The users is required to guess the number between 
                1 - 20, and the user gets 4 guesses
             */
            if(userSelectedLevel == 2){
                //user has six time to try
                Console.WriteLine("***MEDIUM LEVEL NUMBER GUESSING GAME***");
                Console.WriteLine("***YOU HAVE 4 CHANCES TO GUESS***");
                Console.WriteLine("***INSTRUCTION: PICK A NUMBER BETWEEN 1 AND 20 ***");
                int trial = 3;
                
                for(int i = 0; i <= trial; i++){


                    if(i > 0){
                        Console.WriteLine("Don't worry, let's go again! Enter a number...");
                    }else
                    Console.WriteLine("Oya let's go there! Enter a number...");

                    /**
                        Start!
                        check if user enters anything other than number
                     */
                    var userInput = Console.ReadLine();
                    int value;
                    bool checkInt = int.TryParse(userInput, out value);
                    if(!checkInt){
                        Console.WriteLine(name + " that wasn't a number now!!!***");
                        return;
                    }
                    /**
                        End!
                     */

                    //read user guesss
                    int guessValue = int.Parse(userInput);
                    if(guessValue < 1 || guessValue > 20){
                        Console.WriteLine("Please read instruction again. You can't pick a number above 20 or less than 1");
                    }
                    if(guessValue == randomNumberMedium){
                        Console.WriteLine("Whaoo! You guess right!");
                        if(i < 2){
                            Console.WriteLine("Baba Ijebu needs you, You can try Hard Level");
                        }
                        return;
                    }
                    if(i == trial && guessValue != randomNumberMedium){
                        Console.WriteLine("You have come to the end of the Game!");
                        Console.WriteLine("***GAME OVER***");
                        Console.WriteLine("THE NUMBER IS = ***" + randomNumberHard+"***" );
                        return;
                    }
                    Console.WriteLine("Oh Sorry, that was wrong Mr./Mrs. " + name );
                    Console.WriteLine("You have "+ (trial - i) + " more trial(s) to go.");
                }
            }

            /*
                *****HARD LEVEL********
                Users are required to guess between 1 - 50, and they only get 3 guesses
             */
            if(userSelectedLevel == 3){
                //user has 3 times to try
                Console.WriteLine("***HARD LEVEL NUMBER GUESSING GAME***");
                Console.WriteLine("***YOU HAVE 3 CHANCES TO TRY***");
                Console.WriteLine("***INSTRUCTION: PICK A NUMBER BETWEEN 1 AND 50***");
                int trial = 2;
                
                for(int i = 0; i <= trial; i++){
                    
                    if(i > 0){
                        Console.WriteLine("Don't worry, let's go again! Enter a number...");
                    }else
                    Console.WriteLine("Oya let's go there! Enter a number...");
                    /**
                        Start!
                        check if user enters anything other than number
                     */
                    var userInput = Console.ReadLine();
                    int value;
                    bool checkInt = int.TryParse(userInput, out value);
                    if(!checkInt){
                        Console.WriteLine(name + " that wasn't a number now!!!***");
                        return;
                    }
                    /**
                        End!
                     */

                    //read user guesss
                    int guessValue = int.Parse(userInput);
                    
                    //check user chosen number not outside the range
                    if(guessValue < 1 || guessValue > 50){
                        Console.WriteLine("Please read instruction again. You can't pick a number above 50 or less than 1");
                        //return;
                    }
                    //check if user guess right
                    if(guessValue == randomNumberHard){
                        Console.WriteLine("Whaoo! You guess right!");
                        if(i == 1 ){
                            Console.WriteLine("Baba Ijebu needs you, You can try Medium Level");
                        }
                        return;
                    }
                    //user fails after all tries
                    if(i == trial && guessValue != randomNumberHard){
                        Console.WriteLine("You have come to the end of the Game!");
                        Console.WriteLine("***GAME OVER***");
                        Console.WriteLine("THE NUMBER IS ***" + randomNumberHard+"***" );
                        return;
                    }
                    
                    Console.WriteLine("Oh Sorry, that was wrong Mr./Mrs. " + name );
                    Console.WriteLine("You have "+ (trial - i) + " more trial(s) to go.");
                }
                
            }

        }
    }
}
