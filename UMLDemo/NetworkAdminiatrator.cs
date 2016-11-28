using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UMLDemo
{
    public class NetworkAdminiatrator : Profession, IHardwareFixer
    {
        public void FixHardware()
        {
            throw new NotImplementedException();
        }
    }
}