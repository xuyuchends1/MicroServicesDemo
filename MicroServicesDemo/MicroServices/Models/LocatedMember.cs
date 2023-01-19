using System;

namespace MicroServices.Models
{    
    public class LocatedMember : Member 
    {
        public LocationRecord LastLocation {get; set;}
    }        
}
