﻿using WebApplication4.Models;

namespace WebApplication4.Data
{
    public class AppRepository : IAppRepository
    {
        public void Add<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public List<City> GetCities()
        {
            throw new NotImplementedException();
        }

        public City GetCityById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Photo> GetPhotoByCity(int id)
        {
            throw new NotImplementedException();
        }

        public Photo GetPhotoById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveAll()
        {
            throw new NotImplementedException();
        }
    }
}
