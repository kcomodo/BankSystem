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
            else {
                return BadRequest();
            }
        } catch (Exception e)
        {
            return StatusCode(500, "Internal Server Error");
        }
    }
    [HttpGet("/Logins")]
    public IActionResult getLogins()
    {
        try
        {
            IEnumerable<InfoModel> list = _bankServices.ReturnLogin();
            if (list != null)
            {
                return Ok(list);
            }
            else
            {
                return BadRequest();
            }
        } catch (Exception e)
        {
            return StatusCode(500, "Internal Server Error");
        }
    }
    [HttpGet("{username}")]
    public IActionResult getUserInfo(string username)
    {
        try
        {
            IEnumerable<InfoModel> list = _bankServices.userInformation(username);
            if (list != null)
            {
                return Ok(list);
            }
            else
            {
                return BadRequest();
            }

        } catch (Exception e)
        {
            return StatusCode(500, "Internal Server Error");
        }
    }
    [HttpPost]
    public IActionResult InsertBankInfo(InfoModel info) {
        InfoModel returnInfo = _bankServices.InsertBankInfo(info);
        return StatusCode(500);
        
    }
    [HttpPut]
    public IActionResult UpdateBankInfo(string name, InfoModel info)
    {
        _bankServices.UpdateUserInfo(name, info);
        return NoContent();
    }
        
    [HttpDelete("{username}")]
    public IActionResult DeleteUserInfo(string username) {
        _bankServices.DeleteUserInfo(username);
        return NoContent();
        
    }
  
}
