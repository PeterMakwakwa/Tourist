using System.Collections.Generic;
using Tourist.Model;

namespace Tourist.Repository
{
    public class ItemRepository : IItemRepository
    {
        public List<Item> Getitems()
        {
            return new List<Item>
            {
                new Item{Name="map",Weight=90,Value=150},
                new Item{Name="compass",Weight=130,Value=35},
                new Item{Name="water",Weight=1530,Value=200},
                new Item{Name="sandwich",Weight=500,Value=160},
                new Item{Name="glucose",Weight=150,Value=60},
                new Item{Name="tin",Weight=680,Value=45},
                new Item{Name="banana",Weight=270,Value=60},
                new Item{Name="apple",Weight=390,Value=40},
                new Item{Name="cheese",Weight=230,Value=30},
                new Item{Name="beer",Weight=520,Value=10},
                new Item{Name="suntan cream",Weight=110,Value=70},
                new Item{Name="camera",Weight=320,Value=30},
                new Item{Name="T-shirt",Weight=240,Value=15},
                new Item{Name="trousers",Weight=480,Value=10},
            };
        }
    }
}
