using CarService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarService.Controllers
{
    [Route("api/car")]
    public class CarController : ControllerBase
    {
        [HttpPost("add")]
        public void AddCar([FromBody] AddCarModel model)
        {
            //....
        }

        // localhost:5000/api/car/history/1
        [HttpGet("history/{id}")]
        public void GetCarHistory(int id)
        {
            
        }

        [HttpPost("history")]
        public void AddCarServicingHistory([FromBody] AddCarServicingHistoryModel model)
        {
            
        }
    }
}