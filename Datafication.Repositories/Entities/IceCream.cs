using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datafication.Repositories.Entities
{
    public class IceCream
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ManufacturerId {  get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        


    }
}
