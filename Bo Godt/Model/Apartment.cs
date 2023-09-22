using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo_Godt.Model
{
    internal abstract class Apartment
    {
        protected int amountOfRooms;
        protected bool renoFloor;
        protected bool renoKitchen;
        protected bool renoBathRoom;
        protected bool newFrontDoor;
        protected bool newBackDoor;
        protected int newWindowSection;
        protected bool frostedBathRoomWindow;


        // Properties to access and set information about the apartment.
        protected int AmountOfRooms
        {
            get => amountOfRooms;
            set => amountOfRooms = value;
        }
        protected bool RenoKitchen
        {
            get => renoKitchen;
            set => renoKitchen = value;
        }
        protected bool RenoFloor
        {
            get => renoFloor;
            set => renoFloor = value;
        }
        protected bool RenoBathroom
        {
            get => renoBathRoom;
            set => renoBathRoom = value;
        }
        protected bool NewFrontDoor
        {
            get => newFrontDoor;
            set => newFrontDoor = value;
        }
        protected bool NewBackDoor
        {
            get => newBackDoor;
            set => newBackDoor = value;
        }
        protected int NewWindowSection
        {
            get => newWindowSection;
            set => newWindowSection = value;
        }
        protected bool FrostedBathRoomWindow
        {
            get => frostedBathRoomWindow;
            set => frostedBathRoomWindow = value;
        }
        // Constructor to initialize an Animal object with provided properties.
        internal Apartment(int amountOfRooms, bool renoKitchen, bool renoFloor, bool renoBathRoom, bool newFrontDoor, bool newBackDoor, int newWindowSection, bool frostedBathRoomWindow)
        {
            AmountOfRooms = amountOfRooms;
            RenoKitchen = renoKitchen;
            RenoFloor = renoFloor;
            RenoBathroom = renoBathRoom;
            NewFrontDoor = newFrontDoor;
            NewBackDoor = newBackDoor;
            NewWindowSection = newWindowSection;
            FrostedBathRoomWindow = frostedBathRoomWindow;
        }
        public override string ToString()
        {
            // Override of the ToString() method to provide a custom string representation of an Apartment object.
            return ($"AmountOfRooms: {amountOfRooms}" +
                    $"RenoKitchen: {renoKitchen}" +
                    $"RenoFloor: {renoFloor}" +
                    $"RenoBathroom: {renoBathRoom}" +
                    $"NewFrontDoor: {newFrontDoor}" +
                    $"NewBackDoor: {newBackDoor}" +
                    $"NewWindowSection: {newWindowSection}" +
                    $"FrostedBathRoomWindow: {frostedBathRoomWindow}");


        }
    }

}
