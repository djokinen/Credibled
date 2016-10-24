using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Credibled.Data;
using Credibled.Models;
using Microsoft.AspNetCore.Authorization;

namespace Credibled.Controllers
{
	[Authorize]
	public class QuestionsController : Controller
	{
		private readonly ApplicationDbContext _context;

		public QuestionsController(ApplicationDbContext context)
		{
			_context = context;
		}

		// GET: Questions
		public async Task<IActionResult> Index()
		{
			return View(await _context.Question.ToListAsync());
		}

		// GET: Questions/Details/5
		public async Task<IActionResult> Details(Guid? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var question = await _context.Question.SingleOrDefaultAsync(m => m.ID == id);
			if (question == null)
			{
				return NotFound();
			}

			return View(question);
		}

		// GET: Questions/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Questions/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("ID,CreatedDate,Enabled,LastModifiedDate,QuestionDataType,QuestionText")] Question question)
		{
			if (ModelState.IsValid)
			{
				question.ID = Guid.NewGuid();
				question.CreatedDate = DateTime.Now;
				question.Enabled = true;
				question.LastModifiedDate = DateTime.Now;

				_context.Add(question);
				await _context.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			return View(question);
		}

		// GET: Questions/Edit/5
		public async Task<IActionResult> Edit(Guid? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var question = await _context.Question.SingleOrDefaultAsync(m => m.ID == id);
			if (question == null)
			{
				return NotFound();
			}
			return View(question);
		}

		// POST: Questions/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(Guid id, [Bind("ID,CreatedDate,Enabled,LastModifiedDate,QuestionDataType,QuestionText")] Question question)
		{
			if (id != question.ID)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					question.LastModifiedDate = DateTime.Now;

					_context.Update(question);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!QuestionExists(question.ID))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction("Index");
			}
			return View(question);
		}

		// GET: Questions/Delete/5
		public async Task<IActionResult> Delete(Guid? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var question = await _context.Question.SingleOrDefaultAsync(m => m.ID == id);
			if (question == null)
			{
				return NotFound();
			}

			return View(question);
		}

		// POST: Questions/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(Guid id)
		{
			var question = await _context.Question.SingleOrDefaultAsync(m => m.ID == id);
			_context.Question.Remove(question);
			await _context.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		private bool QuestionExists(Guid id)
		{
			return _context.Question.Any(e => e.ID == id);
		}
	}
}