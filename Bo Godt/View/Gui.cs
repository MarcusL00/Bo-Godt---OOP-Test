using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo_Godt.View
{
    internal class Gui
    {
        // WriteApartments method displays information about Apartments in the console.
        // It takes an array of Model.Apartment objects as parameters and iterates through them,
        // calling the ToString method for each apartment and printing the details to the console.
        // After displaying the information, it waits for a key press to allow the user to read the output
        public static void WriteApartments(params Model.Apartment[]apartments)
        {
        foreach (var apartment in apartments) 
            {
                Console.WriteLine(apartment.ToString());
            }
        Console.ReadKey();
        
        }
    }
}
