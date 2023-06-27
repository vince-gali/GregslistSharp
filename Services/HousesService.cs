using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GregslistSharp.Services;
    public class HousesService
    {

        private readonly HousesRepo _repo;
        public HousesService(HousesRepo repo)
        {
            _repo = repo;
        }
        internal List<House> GetAllHouses()
        {
            List<House> houses = _repo.GetAllHouses();
            return houses;
        }

        internal House GetById(int houseId)
        {
            House house = _repo.GetById(houseId);
            if(house == null) throw new Exception($"no house found at id: {houseId}");
            return house;
        }

        internal House CreateHouse(House houseData)
        {
            House house = _repo.CreateHouse(houseData);
            return house;
        }

        internal string RemoveHouse(int houseId)
        {
            House house = GetById(houseId);
            int rows = _repo.RemoveHouse(houseId);
            if (rows > 1 ) throw new Exception("Tried to delete more than one listing");
            return $"House listing at id: {houseId} was removed";
        }

        internal House UpdateHouse(House updateData)
        {
            House original = GetById(updateData.Id);
            //check if you are authorized to do this
            // original.Year = updateData.Year != null ? updateData.Year : original.Year;
            original.Price = updateData.Price != null ? updateData.Price : original.Price;
            // original.Address = updateData.Address != null ? updateData.Address : original.Address;
            // original.Bedrooms = updateData.Bedrooms != null ? updateData.Bedrooms : original.Bedrooms;
            // original.Bathrooms = updateData.Bathrooms != null ? updateData.Bathrooms : original.Bathrooms;
            original.Description = updateData.Description != null ? updateData.Description : original.Description;
            _repo.UpdateHouse(original);
            return original;
        }


    }