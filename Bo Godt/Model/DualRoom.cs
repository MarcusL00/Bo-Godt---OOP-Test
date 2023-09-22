using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo_Godt.Model
{
    internal class DualRoom : Apartment, IDual
    {

        // The DualRoom class represents a type of apartment that inherits from apartment. 
        protected int size;
        protected int amountOfWindows;


        // Properties to access the DualRoom size and amount of windows status.
        protected  int Size
        {

            set => size = 55;
        }

        protected int AmountOfWindows
        {
            set => amountOfWindows = 5;
        }
        // Constructor to initialize DualRoom Apartment object.

        internal DualRoom(int amountOfRooms, bool renoKitchen,bool renoFloor, bool renoBathRoom, bool newFrontDoor, bool newBackDoor, int newWindowSection, bool frostedBathRoomWindow, int size, int amountOfWindows) : base(amountOfRooms, renoKitchen, renoFloor, renoBathRoom, newFrontDoor, newBackDoor, newWindowSection, frostedBathRoomWindow)
        {
            this.Size = size;
            this.AmountOfWindows = amountOfWindows;
        }
        // Override of the ToString() method to provide a custom string representation of a DualRoom object.
        public override string ToString()
        {
            return $"Size of Apartment: {size},Rooms: {amountOfRooms},New Floor: {renoFloor}, Windows: {amountOfWindows}, Renovation of Kitchen: {renoKitchen}, Renovation of Bathroom: {renoBathRoom}, New front Door: {newFrontDoor}, New back Door: {newFrontDoor}, New Window Section: {newWindowSection}, Has Frosted bathroom window: {frostedBathRoomWindow}";
        }
        public void DualRenovation()
        {
            Console.WriteLine("Dual apartment costs of kitchen renovation: 1 apartment: 44.341,83 kr. All single apartments costs: 10.420.330,05 kr");
        }
    }
}
