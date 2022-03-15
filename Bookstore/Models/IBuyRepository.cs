using System;
using System.Linq;

namespace Bookstore.Models
{
    public interface IBuyRepository
    {
        IQueryable<Buy> Buys { get; }

        public void SaveBuy(Buy buy);
    }
}
