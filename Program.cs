using System;
//using System.IO;



namespace c__Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //option 1
            Console.WriteLine("Please enter your filename:");
            // get user input and store in local variable
             string fileName = Console.ReadLine();

             //option 2
             // if file is not valid show error message and return user to main menu - Techie Delight
            /*
            bool fileNameExist = FileName.Exists()
            if (fileNameExist)
            {
                Console.WriteLine ( "filename exists" );
            } 
            else
            {
                Console.WriteLine ( " the filename is not exist, please try again ");
                 // change user input to blank space or take user to option 1
            */

            int i = 0;
            while (i < 4)
            {
                Console.WriteLine( "Please enter your filename: " )
                string rawInput = Console.ReadLine();
                string stringInput;
                if (!string.TryParse(rawInput, out stringInput))
            }
            }
           
            


        }
    }
}
