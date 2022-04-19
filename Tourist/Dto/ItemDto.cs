using System.Collections.Generic;
using Tourist.Model;

namespace Tourist.Dto
{
    public class ItemDto
    {
        public List<Item> Items { get; set; }
        public double TotalWeightKG { get; set; }
        public int TotalValue { get; set; }
        
    }
}
