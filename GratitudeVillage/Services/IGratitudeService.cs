
using System.Collections.Generic;
using GratitudeVillage.Models.ViewModels;

namespace GratitudeVillage.Services
{
    public interface IGratitudeService
    {
        List<Gratitude> GetTopGratitudes();
    }
}
