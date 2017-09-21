using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace App.Controllers
{
    public class ScoreController : ApiController
    {
        private ScoreEntities db = new ScoreEntities();

        // GET: api/scores
        public IQueryable<score> GetScores()
        {
            return db.scores; 
        }
    }
}
