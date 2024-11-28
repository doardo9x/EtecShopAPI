using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EtecShopAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EtecShopAPI.Controllers;

    [ApiController]
    [Route("api/categorias")]
    public class CategoriasController(AppDbContext db) : ControllerBase
    {
        private readonly AppDbContext _db = db;

        public CategoriasController(ILogger<CategoriasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
