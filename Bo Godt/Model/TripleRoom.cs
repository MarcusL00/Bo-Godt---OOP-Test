using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo_Godt.Model
{
    internal class TripleRoom : Apartment, ITriple
    {

        // The TripleRoom class represents a type of apartment that inherits from apartment. 
        protected int size;
        protected int amountOfWindows;


        // Properties to access the TripleRoom size and amount of windows status.
        protected int Size
        {
            set => size = 70;
        }

        protected int AmountOfWindows
        {
            set => amountOfWindows = 13;
        }
        // Constructor to initialize TripleRoom Apartment object.

        internal TripleRoom(int amountOfRooms, bool renoKitchen, bool renoFloor, bool renoBathRoom, bool newFrontDoor, bool newBackDoor, int newWindowSection, bool frostedBathRoomWindow, int size, int amountOfWindows) : base(amountOfRooms, renoKitchen, renoFloor, renoBathRoom, newFrontDoor, newBackDoor, newWindowSection, frostedBathRoomWindow)
        {
            this.Size = size;
            this.AmountOfWindows = amountOfWindows;


        }

        // Override of the ToString() method to provide a custom string representation of a TripleRoom object.
        public override string ToString()
        {
            return $"Size of Apartment: {size},Rooms: {amountOfRooms},New Floor: {renoFloor}, Windows: {amountOfWindows}, Renovation of Kitchen: {renoKitchen}, Renovation of Bathroom: {renoBathRoom}, New front Door: {newFrontDoor}, New back Door: {newFrontDoor}, New Window Section: {newWindowSection}, Has Frosted bathroom window: {frostedBathRoomWindow}";
        }
        public void TripleRenovation() 
        {
            Console.WriteLine("Triple apartment costs of kitchen renovation: 1 apartment: 51.879,94 kr. All triple apartments costs: 8.663.949,98 kr");

        }
    }
}
