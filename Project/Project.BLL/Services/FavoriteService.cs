﻿using AutoMapper;
using Project.BLL.BusinessModels;
using Project.BLL.DTO;
using Project.BLL.Infrastructure;
using Project.BLL.Interfaces;
using Project.DAL.Entities;
using Project.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Services
{
    public class FavoriteService /*: IFavoriteService
    {
        IUnitOfWork Database { get; set; }

        public FavoriteService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void ChooseFavorite(FavoriteDTO favoriteDto)
        {
           Favorite favorite = Database.Favorites.Get(favoriteDto.userid);

            // валидация
            if (favorite == null)
                throw new ValidationException("Not Found", "");
            Favorite nfavorite = new Favorite
            {
              //створення...
            };
            Database.Favorites.Create(nfavorite);
            Database.SaveAsync();
        }

        public IEnumerable<FavoriteDTO> GetFavorites()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Favorite, FavoriteDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Favorite>, List<FavoriteDTO>>(Database.Favorites.GetAll());
        }

        public FavoriteDTO GetFavorite(int? id)
        {
            if (id == null)
                throw new ValidationException("Not Found", "");
            var favorite = Database.Favorites.Get(id.Value);
            if (favorite == null)
                throw new ValidationException("Null", "");

            return new FavoriteDTO {  };
        }

        public void Dispose()
        {
            Database.Dispose();
        }

        FavoriteDTO IFavoriteService.GetFavorite(int? id)
        {
            if (id == null)
                throw new ValidationException("Not Found", "");
            var favorite = Database.Users.Get(id.Value);
            if (favorite == null)
                throw new ValidationException("Null", "");

            return new FavoriteDTO { };
        }*/
    { 
    }
}
