using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo_Godt.Model
{
    internal class SingleRoom : Apartment, ISingle
    {
        // The SingleRoom class represents a type of apartment that inherits from apartment. 
        protected int size;
        protected int amountOfWindows;


        // Properties to access the SingleRoom size and amount of windows status.
        protected int Size
        {
            set => size = 40;
        }

        protected int AmountOfWindows
        {
            set => amountOfWindows = 3;
        }
        // Constructor to initialize SingleRoom Apartment object.

        internal SingleRoom(int amountOfRooms, bool renoKitchen, bool renoFloor, bool renoBathRoom, bool newFrontDoor, bool newBackDoor, int newWindowSection, bool frostedBathRoomWindow, int size, int amountOfWindows) : base(amountOfRooms,renoFloor, renoKitchen, renoBathRoom, newFrontDoor, newBackDoor, newWindowSection, frostedBathRoomWindow)
        {
            this.Size = size;
            this.AmountOfWindows = amountOfWindows;
        }
        // Override of the ToString() method to provide a custom string representation of a SingeRoom object.
        public override string ToString()
        {
            return $"Size of Apartment: {size},Rooms: {amountOfRooms},New Floor: {renoFloor}, Windows: {amountOfWindows}, Renovation of Kitchen: {renoKitchen}, Renovation of Bathroom: {renoBathRoom}, New front Door: {newFrontDoor}, New back Door: {newFrontDoor}, New Window Section: {newWindowSection}, Has Frosted bathroom window: {frostedBathRoomWindow}";
        }
        public void SingleRenovation() 
        {
            Console.WriteLine("Single apartment costs of kitchen renovation: 1 apartment: 37.899,00 kr. All single apartments costs: 13.946.832,00 kr");
        }
    }
}
