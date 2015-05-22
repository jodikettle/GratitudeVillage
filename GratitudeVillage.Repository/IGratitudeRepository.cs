using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GratitudeVillage.Repository.Models;

namespace GratitudeVillage.Repository
{
    public interface IGratitudeRepository
    {
        List<Gratitude> GetTop(int count);
    }
}
