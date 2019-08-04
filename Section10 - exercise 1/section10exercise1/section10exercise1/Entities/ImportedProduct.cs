using System;
using System.Collections.Generic;
using System.Text;

namespace section10exercise1.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        
        public ImportedProduct()
        {
            
        }
        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }
        public override string PriceTag()
        {
            return base.PriceTag() + $" (Customs fee: $ {CustomsFee})";
        }
    }
}
