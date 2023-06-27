using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GregslistSharp.Controllers;

    [ApiController]
    [Route("api/houses")]
    public class HousesController : ControllerBase
    {
        private readonly HousesService _housesService;
        public HousesController(HousesService housesService)
        {
            _housesService = housesService;
        }
    

        [HttpGet]
        public ActionResult<List<House>> GetAllHouses()
            {
                try
                {
                    List<House> houses = _housesService.GetAllHouses();
                    return Ok(houses);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }

            [HttpGet("{houseId}")]
            public ActionResult<House> GetById(int houseId)
            {
                try
                {
                    House house = _housesService.GetById(houseId);
                    return Ok(house);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }

            [HttpPost]
            public ActionResult<House> CreateHouse([FromBody] House houseData)
            {
                try
                {
                    House house = _housesService.CreateHouse(houseData);
                    return Ok(house);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }

            [HttpDelete("{houseId}")]
            public ActionResult<string> RemoveHouse(int houseId)
            {
                try
                {
                    string Message = _housesService.RemoveHouse(houseId);
                    return Ok(Message);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }

            [HttpPut("{houseId}")]
            public ActionResult<House> UpdateHouse(int houseId, [FromBody] House updateData)
            {
                try
                {
                    updateData.Id = houseId;
                    House house = _housesService.UpdateHouse(updateData);
                    return Ok(house);
                }
                catch (Exception e)
                {
                    return BadRequest (e.Message);
                }
            }

            
    }
