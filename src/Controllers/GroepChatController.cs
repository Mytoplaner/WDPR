// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Security.Claims;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.Logging;
// using src.Models;

// namespace src.Controllers
// {
//     [Authorize(Roles = "Client, Hulpverlener")]
//     public class ChatController : Controller
//     {
//         private readonly ILogger<HomeController> _logger;
//         private readonly DatabaseContext _context;

//         private readonly IHttpContextAccessor _httpContextAccessor;

//         private readonly UserManager<ApplicatieGebruiker> _userManager;
//         public ChatController(ILogger<HomeController> logger, DatabaseContext context, IHttpContextAccessor httpContextAccessor, UserManager<ApplicatieGebruiker> userManager)
//         {
//             _logger = logger;
//             _context = context;
//             _httpContextAccessor = httpContextAccessor;
//             _userManager = userManager;
//         }

//         public IActionResult Index()
//         {
//                 var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
//                 ViewBag.uId = userId;
//                 var client = _context.Clienten.Any(x => x.User.Id == userId);
//                 if(client){
//                     _context.Clienten.Include(x => x.User);
//                     var c1 = _context.Clienten.Where(x => x.User.Id == userId).FirstOrDefault();
//                     ViewBag.UserName = c1.Voornaam;
//                      ViewBag.accountid = c1.Id;
//                 }
//                 else {
//                     _context.Hulpverleners.Include(x => x.User);
//                     var h1 = _context.Hulpverleners.Where(x => x.User.Id == userId).FirstOrDefault();
//                     ViewBag.UserName = h1.Voornaam;
//                     ViewBag.accountid = h1.Id;
//                 }
//                 return View();
//         }
//     }
// }