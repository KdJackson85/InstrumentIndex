using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise
{
    class Brass : Instruments
    {
        
        private int numberOfValves;
        private int pipeLength;
        private string pitch;
        

        //***Properties***


    //***Constructors***

        public Brass(string pitch, int numberOfValves, int pipeLength) : base("French Horn","gold", "brass", 999.99,25)
        {
            
            this.numberOfValves = numberOfValves;
            this.pipeLength = pipeLength;
            this.pitch = pitch;


        }
        
    }
}
