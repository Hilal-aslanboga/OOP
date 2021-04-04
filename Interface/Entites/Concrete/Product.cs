using Interface.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entites.Concrete
{
    public class Product : BaseEntity<int>
    {
        public override int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public short UnitPrice { get; set; }
        public decimal UnitInStocck { get; set; }
    }
}
