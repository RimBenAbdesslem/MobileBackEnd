using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionProduit.Data;
using GestionProduit.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionProduit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SCategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }





        [HttpPost]
        [Route("RegisterSCategories/{id}")]
        public async Task<IActionResult> PostSCategories(SCategorieModel model, int id)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            var Label = new SCategorieModel()
            {
                NomSCatego = model.NomSCatego,

                CategorieId = id,

            };

            var result = await _context.SCategories.AddAsync(Label);
            _context.SaveChanges();
            // var application = await _context.BesoinFormations.FindAsync(applicationUser.Id);
            // _context.Labels.UpdateRange();
            //recuperer l'id de dernier element inseré puiis get cette element 
            return Ok(new { });

        }


        //Get all Domaine
        [HttpGet]
        [Route("GetAllSCategories")]
        public IEnumerable<Object> GetAllSCategories()
        {

            var label = _context.SCategories;
            if (label == null)
            {
                return (null);
            }

            return (label);
        }

        //dellete SCategories
        [HttpDelete]
        [Route("DeleteAllSCategories/{id}")]
        public async Task<ActionResult> DelleteSCategories(int id)
        {

            var Label = await _context.SCategories.FindAsync(id);
            if (Label == null)
            {
                return NotFound();
            }

            _context.SCategories.Remove(Label);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}