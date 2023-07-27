using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly BestRestaurantsContext _db;
        public RestaurantsController(BestRestaurantsContext db)
        {
            _db = db;
        }







    }
}