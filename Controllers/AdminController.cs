using eshop.api.Data;
using eshop.api.Entities;
using eshop.api.ViewModels;
using eshop.api.ViewModels.Address;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eshop.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AdminController(IUnitOfWork unitOfWork) : ControllerBase
{
    private readonly IUnitOfWork _unitofwork = unitOfWork;
    
}