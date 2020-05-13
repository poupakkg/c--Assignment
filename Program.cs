using System;
using System.IO;
using System.Linq;

namespace c__Assignment
{
    class Program
    { 
        
        static void Main(string[] args) 
        {
            Console.WriteLine("Make a choice!");
            Console.WriteLine("Option 1: Enter a filename");
            Console.WriteLine("Option 2: Parser");
            Console.WriteLine("Option 3: Quit Program");
            Console.ReadLine();

            bool exitRequest = true;
            string fileName = "";
            int option = 3;
            while (!exitRequest){
                Console.WriteLine("Make a choice!");
                string makeChoice = Console.ReadLine();
            }
            switch(option){                            
            //option 1
            case 1:
            Console.WriteLine("Please Enter a filename: ");
            // get user input and store in local variable
            fileName = Console.ReadLine();
            // bool fileNameExist = FileNames.Exists();
            if (!File.Exists(fileName))
             { // if file does not exist show error message
                 Console.WriteLine("File name does not exist. Please try again.");
             }
             break;
            //option 2
            case 2:
            Console.WriteLine("Please enter a string: ");
            string stringToReplace = Console.ReadLine();
            if (File.Exists(fileName))
            {
                string readText = File.ReadAllText("fileName");  // Read the contents of the file
               // Console.WriteLine(readText);  // Output the content
                string[] splitText = readText.Split( stringToReplace );
            
            foreach (string element in splitText){
                Console.WriteLine(element); //print out our sorted array of names
            }
            break;
            }
            //option 3
             case 3:
             exitRequest = true;
             Console.WriteLine("Exit");
             break;

            }
        }
    }
}

    
            

             // if file is not valid show error message and return user to main menu - Techie Delight
            /*
           
            {
                Console.WriteLine ( "filename exists" );
            } 
            else
            {
                Console.WriteLine ( " the filename is not exist, please try again ");
                 // change user input to blank space or take user to option 1
            */
            /*int i = 0;
            int attemptInput = 0;
            while (i < 4)
            {
                Console.WriteLine( "Please enter your filename: " )
                string rawInput = Console.ReadLine();
                int attemptInput;
                if (!string.TryParse(rawInput, out attemptInput))
                {
                    Console.WriteLine ( "the filename is not exist, please try agai" );
                    continue;
                }
                attemptInput < 4;
                
            }
            }*/
           
            


        }
    }
}
