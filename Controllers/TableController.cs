using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using BlackjackAttack.Models;
using BlackjackAttack.DataLayer;

namespace BlackjackAttack.Controllers
{
    [Route("api/table")]
    public class TableController : Controller
    {
        private readonly ITableRepository _tableRepository;

        public TableController(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

        [HttpGet]
        public IEnumerable<Table> GetAll()
        {
            return _tableRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetTable")]
        public IActionResult GetById(Guid id)
        {
            var item = _tableRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Table item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            item.CurrentShoe = new Shoe(item.DecksInShoe);

            _tableRepository.Add(item);

            return CreatedAtRoute("GetTable", new { id = item.Key }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] Table item)
        {
            if (item == null || item.Key != id)
            {
                return BadRequest();
            }

            var table = _tableRepository.Find(id);
            if (table == null)
            {
                return NotFound();
            }

            table.Name = item.Name;

            _tableRepository.Update(table);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var table = _tableRepository.Find(id);
            if (table == null)
            {
                return NotFound();
            }

            _tableRepository.Remove(id);
            return new NoContentResult();
        }
    }
}