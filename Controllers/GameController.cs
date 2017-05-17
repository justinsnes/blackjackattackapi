using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

using BlackjackAttack.Models;
using BlackjackAttack.DataLayer;

namespace BlackjackAttack.Controllers
{
    [Route("api/game")]
    public class GameController : Controller
    {
        private readonly ITableRepository _tableRepository;

        public GameController(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

        [HttpGet("/drawcard/{tableId}", Name = "DrawCard")]
        public IActionResult DrawCard(Guid tableId)
        {
            var table = _tableRepository.Find(tableId);
            if (table == null)
            {
                return NotFound();
            }

            var yourCard = table.CurrentShoe.Cards.First();
            table.CurrentShoe.Cards.Remove(yourCard);
            _tableRepository.Update(table);

            return new ObjectResult(yourCard);
        }
    }
}