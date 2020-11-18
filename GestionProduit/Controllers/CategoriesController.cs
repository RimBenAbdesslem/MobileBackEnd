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
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("RegisterCategorie")]
        public async Task<IActionResult> PostCategorie(CategorieModel model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            var categorie = new CategorieModel()
            {
                NomCategorie = model.NomCategorie,

            };

            var result = await _context.Categories.AddAsync(categorie);
            _context.SaveChanges();
            return Ok(new { });

        }



        [HttpPost]
        [Route("ModifierCategorie/{id}")]
        public async Task<IActionResult> ModifierCtegorie(int id, CategorieModel model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            var domaine = await _context.Categories.FindAsync(id);


            domaine.NomCategorie = model.NomCategorie;

            _context.Update(domaine);

            //  var result = await _context.Domaines.Update(DomaineId);
            _context.SaveChanges();
            return Ok(new { });

        }

        //Get all Domaine
        [HttpGet]
        [Route("GetAllCategorie")]
        public IEnumerable<Object> GetAllDomaine()
        {

            var domaine = _context.Categories;
            if (domaine == null)
            {
                return (null);
            }

            return (domaine);
        }



        [HttpDelete]
        [Route("deleteDomaine/{id}")]
        public async Task<ActionResult> DeleteCategorie(int id)
        {
            var domaine = await _context.Categories.FindAsync(id);
            if (domaine == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(domaine);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}