using System;
using System.Collections.Generic;
using System.Text;

namespace Properties_OMalley_Lauren
{
    class Car
    {
        // Makes the modle string private
        private string modle;

        // Creates a property for Model using automatic properties
        public string Model { get { return modle; } set { modle = value; } }

        // Creates a property for Make using automatic properties
        public string Make { get; set; }

    }
}
