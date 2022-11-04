using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Data;
using HouseRentingSystem.Core.Models.Home;
using HouseRentingSystem.Core.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Core.Services
{
    public class HouseService : IHouseService
    {
        private readonly IRepository repo;

        public HouseService(IRepository _repo)
        {
            repo = _repo;
        }

        public IEnumerable<HouseIndexServiceModel> LastThreeHouses()
        {
            var lastThree = repo.AllReadonly<House>()
                .OrderByDescending(x => x.Id)
                .Select(x => new HouseIndexServiceModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    ImageUrl = x.ImageUrl
                })
                .Take(3)
                .ToList();

            return lastThree;
        }
    }
}
