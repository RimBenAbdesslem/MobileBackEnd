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
    public class ProduitController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProduitController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("RegisterProduit")]
        public async Task<IActionResult> PostBesoinFormation(Produit model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            var produit = new Produit()
            {
                Nom = model.Nom,
                Description = model.Description,
                Prix = model.Prix,
                CategorieId = model.CategorieId,
                Categorie = model.Categorie,
                TypeId = model.TypeId,
                Quantite = model.Quantite,
                Image = model.Image,
                Scategorie = model.Scategorie,
                DateDebut = model.DateDebut,
                DateFin = model.DateFin,
                NonFournisseur = model.NonFournisseur,
                Priorite = model.Priorite,
            };

            var result = await _context.Produits.AddAsync(produit);
            _context.SaveChanges();
            return Ok(new { });

        }
        //Get all Produit
        [HttpGet]
        [Route("GetAllProduit")]
        public IEnumerable<Object> GetAllDomaine()
        {

            var produit = _context.Produits;
            if (produit == null)
            {
                return (null);
            }

            return (produit);
        }
        //Remove produit
        [HttpDelete]
        [Route("deleteProduit/{id}")]
        public async Task<ActionResult> DeleteDomaine(int id)
        {
            var produit = await _context.Produits.FindAsync(id);
            if (produit == null)
            {
                return NotFound();
            }

            _context.Produits.Remove(produit);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
