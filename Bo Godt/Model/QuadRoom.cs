using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo_Godt.Model
{
    internal class QuadRoom : Apartment, IQuad
    {

        // The QuadRoom class represents a type of apartment that inherits from apartment. 
        protected int size;
        protected int amountOfWindows;


        // Properties to access the QuadRoom size and amount of windows status.
        protected int Size
        {
            set => size = 85;
        }

        protected int AmountOfWindows
        {
            set => amountOfWindows = 15;
        }
        // Constructor to initialize QuadRoom Apartment object.

        internal QuadRoom(int amountOfRooms, bool renoKitchen, bool renoFloor, bool renoBathRoom, bool newFrontDoor, bool newBackDoor, int newWindowSection, bool frostedBathRoomWindow, int size, int amountOfWindows) : base(amountOfRooms, renoKitchen, renoFloor, renoBathRoom, newFrontDoor, newBackDoor, newWindowSection, frostedBathRoomWindow)
        {
            this.Size = size;
            this.AmountOfWindows = amountOfWindows;
        }
        // Override of the ToString() method to provide a custom string representation of a QuadRoom object.
        public override string ToString()
        {
            return $"Size of Apartment: {size},Rooms: {amountOfRooms},New Floor: {renoFloor}, Windows: {amountOfWindows}, Renovation of Kitchen: {renoKitchen}, Renovation of Bathroom: {renoBathRoom}, New front Door: {newFrontDoor}, New back Door: {newFrontDoor}, New Window Section: {newWindowSection}, Has Frosted bathroom window: {frostedBathRoomWindow}";
        }
        public void QuadRenovation()
        {
            Console.WriteLine("Quad apartment costs of kitchen renovation: 1 apartment: 60.699,52 kr. All Quad apartments costs: 5.887.854,39 kr");

        }
    }
}
