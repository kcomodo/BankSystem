using Microsoft.AspNetCore.Mvc;
using BankSystemDataControl.Models;
using BankSystemDataControl.Services;
using BankSystemDataControl.Repository;
using System.ServiceProcess;

namespace BankSystemDataControl.Controllers;

[ApiController]
[Route("[Controller]")]
public class BankSystemController : ControllerBase
{
    public IBankServices _bankServices;
    public iInfoRepository _infoRepository;
    public BankSystemController(IBankServices bankServices)
    {
        _bankServices = bankServices;
    }

    [HttpGet] // do /BankSystem to get all info
    public IActionResult getAllInfo()
    {
        try
        {
            IEnumerable<InfoModel> list = _bankServices.ReturnAll();
            if (list != null)
            {
                return Ok(list);
            }
            else{
                return BadRequest();
            }
        }catch(Exception e)
        {
            return StatusCode(500, "Internal Server Errror");
        }
    }

  
}
