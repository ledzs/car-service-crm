using JetBrains.Annotations;

namespace CarService.Models
{
    [PublicAPI]
    public class AddCarModel
    {
        public string Brand { get; set; }
        
        public string Model { get; set; }
        
        public OwnerModel Owner { get; set; }
        
        public class OwnerModel
        {
            public string OwnerName { get; set; }
            
            public string PhoneNumber { get; set; }
        }
    }
}