using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeviceMonitorServiceApiUsingController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //Service
    public class DeviceStatusController : ControllerBase
    {
        //Actions
        [HttpGet]
        public int Get()
        {
            DeviceStatusMonitorLib.DeviceMonitor _monitorRef = new DeviceStatusMonitorLib.DeviceMonitor();
            return _monitorRef.GetDeviceStatusCode();
        }
        [HttpGet("GetbyName/{name}")]
        public int GetAllbyName()
        {
            
        }
        
        [HttpPut("Put")]

        public IActionResult Put([FromBody] UserRequest request)
        {
            Countries country = new Countries();
            

            try
            {
                _countryContext.countries.Add(country);
                _countryContext.SaveChanges();

            }
            catch(Exception ex)
            {
                return StatusCode(500, "An error has occured");
            }
            
            return Ok();

        }
        
    }
}
