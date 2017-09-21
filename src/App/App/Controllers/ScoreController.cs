using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace App.Controllers
{
    public class ScoreController : ApiController
    {
        private ScoreEntities db = new ScoreEntities();

        // GET: api/scores
        [ResponseType(typeof(List<score>))]
        public IHttpActionResult GetScores()
        {
            return Ok(db.scores); 
        }

        // GET: api/scores/(int) id
        [ResponseType(typeof(score))]
        public IHttpActionResult GetScore(int id)
        {
            score score = db.scores.Find(id);

            if (score == null)
                return NotFound();  

            return Ok(score);
        }

        // Get: api/scores/average
        [HttpGet]
        [Route("api/scores/average")]
        [ResponseType(typeof(List<score>))]
        public IHttpActionResult GetAverage()
        {
            return Ok(db.SelectAverageScore());
        }
       


    }
}
