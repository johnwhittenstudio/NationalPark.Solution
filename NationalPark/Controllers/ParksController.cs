using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NationalPark.Models;

namespace NationalPark.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly NationalParkContext _db;

    public ParksController(NationalParkContext db)
    {
      _db = db;
    }

    /// <summary>
    /// Gets all animals or animals based off search query
    /// </summary>
    /// <param name="name"></param>
    /// <param name="state"></param>
    /// <param name="coordinates"></param>
    /// <param name="established"></param>
    /// <param name="area"></param>
    /// <param name="description"></param>
    /// <returns>List of animals</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     GET/api/Parks
    ///     {
    ///       "ParkId": "1",
    ///       "Name": "Acadia",
    ///       "State": "Maine",
    ///       "Coordinates": "44°21′N 68°13′W / 44.35°N 68.21°W",
    ///       "Established": "26-Feb-19",
    ///       "Area": "47,389.67 acres (191.8†km2)",
    ///       "Description = "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes. There are freshwater, estuary, forest, and intertidal habitats.",
    ///     }
    /// </remarks>
    /// <response code="200">Returns an array of entries. If no entries returns an empty array</response>
    /// <response code="400">Returns Not Found</response>

    // GET api/animals
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string name, string state, string coordinates, string established, string area, string description)
    {
      var query = _db.Parks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (state != null)
      {
        query = query.Where(entry => entry.State == state);
      }

      if (coordinates != null)
      {
        query = query.Where(entry => entry.Coordinates == coordinates);
      }

      if (established != null)
      {
        query = query.Where(entry => entry.Established == established);
      }

      if (area != null)
      {
        query = query.Where(entry => entry.Area == area);
      }

      if (description != null)
      {
        query = query.Where(entry => entry.Description == description);
      }

      return await query.ToListAsync();
    }

    /// <summary>
    /// Gets specific park based off id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Park object that matches id</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     GET/api/Parks{id}
    ///     {
    ///       "ParkId": "1",
    ///       "Name": "Acadia",
    ///       "State": "Maine",
    ///       "Coordinates": "44°21′N 68°13′W / 44.35°N 68.21°W",
    ///       "Established": "26-Feb-19",
    ///       "Area": "47,389.67 acres (191.8†km2)",
    ///       "Description = "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes. There are freshwater, estuary, forest, and intertidal habitats.",
    ///     }
    /// </remarks>
    /// <response code="200">Returns Ok (Success)</response>
    /// <response code="404">Returns Not Found</response>

    // GET: api/Parks/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      var park = await _db.Parks.FindAsync(id);

      if (park == null)
      {
        return NotFound();
      }

      return park;
    }

    /// <summary>
    /// Edits properties of entries in database
    /// </summary>
    ///<param name="id"></param>
    /// <param name="park"></param>
    /// <returns>Status code 204: successful </returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     PUT/api/Parks{id}
    ///     {
    ///       "ParkId": "1",
    ///       "Name": "Acadia",
    ///       "State": "Maine",
    ///       "Coordinates": "44°21′N 68°13′W / 44.35°N 68.21°W",
    ///       "Established": "26-Feb-19",
    ///       "Area": "47,389.67 acres (191.8†km2)",
    ///       "Description = "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes. There are freshwater, estuary, forest, and intertidal habitats.",
    ///     }
    /// </remarks>
    /// <response code="204">Successfully posted park</response>
    /// <response code="404">Returns Not Found</response>

    // PUT: api/Parks/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Entry(park).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    /// <summary>
    /// Posts a new park
    /// </summary>
    /// <param name="park"></param>
    /// <returns>Status code 204: successful </returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST/api/Parks
    ///     {
    ///       "ParkId": "1",
    ///       "Name": "Acadia",
    ///       "State": "Maine",
    ///       "Coordinates": "44°21′N 68°13′W / 44.35°N 68.21°W",
    ///       "Established": "26-Feb-19",
    ///       "Area": "47,389.67 acres (191.8†km2)",
    ///       "Description = "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes. There are freshwater, estuary, forest, and intertidal habitats.",
    ///     }
    /// </remarks>
    /// <response code="204">Successfully posted park</response>
    /// <response code="404">Returns Not Found</response>

    // POST api/animals
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    /// <summary>
    /// Deletes park entry
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Status code 204: successful </returns>
    /// <response code="404">Returns Not Found</response>

    // DELETE: api/Parks/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      var park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }
  }
}