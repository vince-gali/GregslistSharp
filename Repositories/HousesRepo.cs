using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GregslistSharp.Repositories;

    public class HousesRepo
    {
        private readonly IDbConnection _db;
        public HousesRepo(IDbConnection db)
        {
            _db = db;
        }

        internal List<House> GetAllHouses()
        {
            string sql = "SELECT * FROM houses ORDER BY createdAt DESC;";
            List<House> houses = _db.Query<House>(sql).ToList();
            return houses;
        }

        internal House GetById(int houseId)
        {
            string sql = "SELECT * FROM houses WHERE id = @houseId;";
            House house = _db.Query<House>(sql, new {houseId}).FirstOrDefault();
            return house;
        }

        internal House CreateHouse(House houseData)
        {
            string sql = @"
            INSERT INTO houses
            (year,price,address,bedrooms,bathrooms,description)
            VALUES(@year,@price,@address,@bedrooms,@bathrooms,@description);";
            House house = _db.Query<House>(sql, houseData).FirstOrDefault();
            return house;
        }

        internal int RemoveHouse(int houseId)
        {
            string sql = "DELETE FROM houses WHERE id = @houseId LIMIT 1";
            int rows = _db.Execute(sql, new{houseId});
            return rows;
        }

        internal void UpdateHouse(House houseData)
        {
            string sql = @"
            UPDATE houses SET
            year = @year,
            price = @price,
            address = @address,
            bedrooms = @bedrooms,
            bathrooms = @bathrooms,
            description = @description
            WHERE id = @id;";
            _db.Execute(sql, houseData);
        }



    }