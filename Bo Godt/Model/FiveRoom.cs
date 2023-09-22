using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo_Godt.Model
{
    internal class FiveRoom : Apartment, IFive 
    {

        // The FiveRoom class represents a type of apartment that inherits from apartment. 
        protected int size;
        protected int amountOfWindows;


        // Properties to access the FiveRoom size and amount of windows status.
        protected int Size
        {
            set => size = 110;
        }

        protected int AmountOfWindows
        {
            set => amountOfWindows = 20;
        }
        // Constructor to initialize FiveRoom Apartment object.

        internal FiveRoom(int amountOfRooms, bool renoKitchen, bool renoFloor, bool renoBathRoom, bool newFrontDoor, bool newBackDoor, int newWindowSection, bool frostedBathRoomWindow, int size, int amountOfWindows) : base(amountOfRooms, renoKitchen, renoFloor, renoBathRoom, newFrontDoor, newBackDoor, newWindowSection, frostedBathRoomWindow)
        {
            this.Size = size;
            this.AmountOfWindows = amountOfWindows;
        }
        // Override of the ToString() method to provide a custom string representation of a FiveRoom object.
        public override string ToString()
        {
            return $"Size of Apartment: {size},Rooms: {amountOfRooms},New Floor: {renoFloor}, Windows: {amountOfWindows}, Renovation of Kitchen: {renoKitchen}, Renovation of Bathroom: {renoBathRoom}, New front Door: {newFrontDoor}, New back Door: {newFrontDoor}, New Window Section: {newWindowSection}, Has Frosted bathroom window: {frostedBathRoomWindow}";
        }
        public void FiveRenovation()
        {
            Console.WriteLine("Five apartment costs of kitchen renovation: 1 apartment: 71.018,43 kr. All five apartments costs: 3.337.866,60 kr");

        }
    }
}
