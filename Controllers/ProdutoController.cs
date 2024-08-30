using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NunesSports.Data;
using NunesSports.Models;

namespace NunesSports.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly NunesSportsContext _context;

        public ProdutosController(NunesSportsContext context)
        {
            _context = context;
        }

        // GET: /Produtos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Produtos.ToListAsync());
        }

        // GET: /Produtos/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);

            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // GET: /Produtos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Produtos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] Produto produto, IFormFile imagem)
        {
            if (imagem != null)
            {
                var filePath = Path.Combine("wwwroot/images", imagem.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imagem.CopyToAsync(stream);
                }
                produto.ImagemUrl = "/images/" + imagem.FileName;
            }

            if (ModelState.IsValid)
            {
                _context.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(produto);
        }

        // GET: /Produtos/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);

            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: /Produtos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Preco,ImagemUrl")] Produto produto)
        {
            if (id != produto.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Produtos.Any(e => e.Id == id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(produto);
        }

        // GET: /Produtos/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: /Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}