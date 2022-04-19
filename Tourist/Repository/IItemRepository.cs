using System.Collections.Generic;
using Tourist.Model;

namespace Tourist.Repository
{
    public interface IItemRepository
    {
        List<Item> Getitems();
    }
}
