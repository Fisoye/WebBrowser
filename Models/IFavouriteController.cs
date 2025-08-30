using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Models
{
    public interface IFavouriteController
    {
        void AddFavourite(string filePath, FavouriteModel favourite);
        void DeleteFavourite(int id);
        void EditFavourite(FavouriteModel favourite);
        IList<FavouriteModel> GetFavourites(string filePath);
        FavouriteModel? GetFavourite(string filePath, int id);

    }
}
