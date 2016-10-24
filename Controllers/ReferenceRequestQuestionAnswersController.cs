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
	public class ReferenceRequestQuestionAnswersController : Controller
	{
		private readonly ApplicationDbContext _context;

		public ReferenceRequestQuestionAnswersController(ApplicationDbContext context)
		{
			_context = context;
		}


		// GET: ReferenceRequestQuestionAnswers
		public async Task<IActionResult> Index()
		{
			return View(await _context.ReferenceRequestQuestionAnswer.ToListAsync());
		}

		// GET: ReferenceRequestQuestionAnswers/Details/5
		public async Task<IActionResult> Details(Guid? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var referenceRequestQuestionAnswer = await _context.ReferenceRequestQuestionAnswer.SingleOrDefaultAsync(m => m.ID == id);
			if (referenceRequestQuestionAnswer == null)
			{
				return NotFound();
			}

			return View(referenceRequestQuestionAnswer);
		}

		// GET: ReferenceRequestQuestionAnswers/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: ReferenceRequestQuestionAnswers/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("ID,Answer,CreatedDate,Enabled,LastModifiedDate")] ReferenceRequestQuestionAnswer referenceRequestQuestionAnswer)
		{
			if (ModelState.IsValid)
			{
				referenceRequestQuestionAnswer.ID = Guid.NewGuid();
				_context.Add(referenceRequestQuestionAnswer);
				await _context.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			return View(referenceRequestQuestionAnswer);
		}

		// GET: ReferenceRequestQuestionAnswers/Edit/5
		public async Task<IActionResult> Edit(Guid? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var referenceRequestQuestionAnswer = await _context.ReferenceRequestQuestionAnswer.SingleOrDefaultAsync(m => m.ID == id);
			if (referenceRequestQuestionAnswer == null)
			{
				return NotFound();
			}
			return View(referenceRequestQuestionAnswer);
		}

		// POST: ReferenceRequestQuestionAnswers/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(Guid id, [Bind("ID,Answer,CreatedDate,Enabled,LastModifiedDate")] ReferenceRequestQuestionAnswer referenceRequestQuestionAnswer)
		{
			if (id != referenceRequestQuestionAnswer.ID)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(referenceRequestQuestionAnswer);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!ReferenceRequestQuestionAnswerExists(referenceRequestQuestionAnswer.ID))
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
			return View(referenceRequestQuestionAnswer);
		}

		// GET: ReferenceRequestQuestionAnswers/Delete/5
		public async Task<IActionResult> Delete(Guid? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var referenceRequestQuestionAnswer = await _context.ReferenceRequestQuestionAnswer.SingleOrDefaultAsync(m => m.ID == id);
			if (referenceRequestQuestionAnswer == null)
			{
				return NotFound();
			}

			return View(referenceRequestQuestionAnswer);
		}

		// POST: ReferenceRequestQuestionAnswers/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(Guid id)
		{
			var referenceRequestQuestionAnswer = await _context.ReferenceRequestQuestionAnswer.SingleOrDefaultAsync(m => m.ID == id);
			_context.ReferenceRequestQuestionAnswer.Remove(referenceRequestQuestionAnswer);
			await _context.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		private bool ReferenceRequestQuestionAnswerExists(Guid id)
		{
			return _context.ReferenceRequestQuestionAnswer.Any(e => e.ID == id);
		}
	}
}
