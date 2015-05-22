using System.Collections.Generic;
using AutoMapper;
using GratitudeVillage.Models.ViewModels;
using GratitudeVillage.Repository;

namespace GratitudeVillage.Services
{
    public class GratitudeService: IGratitudeService
    {
        private IGratitudeRepository _repository;

        public List<Models.ViewModels.Gratitude> GetTopGratitudes()
        {
            return Mapper.Map<List<Gratitude>>(_repository.GetTop(5));
        }
    }
}