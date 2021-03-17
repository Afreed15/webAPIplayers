using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApimodelbase.Models;

namespace WebApimodelbase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        static List<Players> listplayers = new List<Players>
        {
            new Players{PId=1,PName="rohit",PDob=DateTime.Parse("12/2/1992"),PTeam="MI"},
            new Players{PId=2,PName="Polard",PDob=DateTime.Parse("12/2/1989"),PTeam="MI"},
            new Players{PId=3,PName="Hardik",PDob=DateTime.Parse("12/11/1993"),PTeam="MI"}
        };
        [HttpGet]
        public IEnumerable<Players> Get()
        {
            return listplayers.ToList();
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var player = listplayers.FirstOrDefault(x => x.PId == id);
            if(player==null)
            {
                return NotFound();
            }
            return Ok(player);
        }
        [HttpPost]
        public ActionResult Post([FromBody] Players obj)
        {
            Players player = new Players();
            player.PId = obj.PId;
            player.PName = obj.PName;
            player.PTeam = obj.PTeam;
            player.PDob = obj.PDob;
            listplayers.Add(obj);
            return NoContent();
        }
        [HttpPut("{id}")]
        public ActionResult Put(int id,[FromBody] Players obj)
        {
            var player = listplayers.FirstOrDefault(x => x.PId == id);
            if(player==null)
            {
                return NotFound();
            }
            else
            {
               
                player.PName = obj.PName;
                player.PTeam = obj.PTeam;
                player.PDob = obj.PDob;
               

            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var player = listplayers.FirstOrDefault(x => x.PId == id);
            if(player==null)
            {
                return NotFound();
            }else
            {
                listplayers.RemoveAt(id);
            }
            return NoContent();


        }
        
    }
}
