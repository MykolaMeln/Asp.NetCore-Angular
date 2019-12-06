using Project.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Interfaces
{
    interface IFavoriteService
    {
        void ChooseFavorite(FavoriteDTO favoriteDto);
        FavoriteDTO GetFavorite(int? id);
        IEnumerable<FavoriteDTO> GetFavorites();
        void Dispose();
    }
}
