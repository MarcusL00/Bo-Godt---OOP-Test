using Bo_Godt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo_Godt.Controller
{
    internal class Controller
    {


        public void Ctrl()
        {
            
            // Creating instances of different Apartment types and storing them in variables
            // of a common base class or interface (Polymorphism).
            SingleRoom singleRoom = new SingleRoom(1,false,false,false,false,false,0,false,0,0);
            DualRoom dualRoom = new DualRoom(2,false,false,false,false,false,0,false,0,0);
            TripleRoom tripleRoom = new TripleRoom(3,false,false,false,false,false,0,false,0,0);
            QuadRoom quadRoom = new QuadRoom(4,false,false,false,false,false,0,false,0,0);
            FiveRoom fiveRoom = new FiveRoom(5,false,false,false,false,false,0,false,0,0);


            // Calling the different method on different Apartment objects
            // that implement various Apartment interfaces.
            singleRoom.SingleRenovation();
            dualRoom.DualRenovation();
            tripleRoom.TripleRenovation();
            quadRoom.QuadRenovation();
            fiveRoom.FiveRenovation();



            // Writing the details of different types of Apartments to the GUI.
            View.Gui.WriteApartments(singleRoom, dualRoom, tripleRoom, quadRoom, fiveRoom);
        }
    }
}
