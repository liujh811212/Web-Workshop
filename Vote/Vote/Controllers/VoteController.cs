using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Vote.Controllers
{
    public class VoteController : Controller
    {
        //
        // GET: /Test/

//        public ActionResult Index()
//        {
//            return View();
//        }
        [HttpPost]
        public HttpResponseMessage<int> Vote(Vote movieToCreate)
        {
            // Add movieToCreate to the database and update primary key
//            movieToCreate.Id = 23;

            // Build a response that contains the location of the new movie
            var response = new HttpResponseMessage<int>(12, HttpStatusCode.Created);
//            var relativePath = "/api/movie/" + movieToCreate.Id;
//            response.Headers.Location = new Uri(Request.RequestUri, relativePath);
            return response;
        }

    }

    public class Vote
    {
        private string Hiking { get; set; }
    }
}
