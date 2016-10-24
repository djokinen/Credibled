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
	public class ReferenceRequestsController : Controller
	{
		private readonly ApplicationDbContext _context;

		public ReferenceRequestsController(ApplicationDbContext context)
		{
			_context = context;
		}

		// GET: ReferenceRequests
		public async Task<IActionResult> Index()
		{
			return View(await _context.ReferenceRequest.ToListAsync());
		}

		// GET: ReferenceRequests/Details/5
		public async Task<IActionResult> Details(Guid? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var referenceRequest = await _context.ReferenceRequest.SingleOrDefaultAsync(m => m.ID == id);
			if (referenceRequest == null)
			{
				return NotFound();
			}

			return View(referenceRequest);
		}

		// GET: ReferenceRequests/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: ReferenceRequests/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("ID,CandidateEndDate,CandidateId,CandidateJobDuties,CandidateStartDate,CreatedDate,Enabled,LastModifiedDate,RefereeId")] ReferenceRequest referenceRequest)
		{
			if (ModelState.IsValid)
			{
				referenceRequest.ID = Guid.NewGuid();
				_context.Add(referenceRequest);
				await _context.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			return View(referenceRequest);
		}

		// GET: ReferenceRequests/Edit/5
		public async Task<IActionResult> Edit(Guid? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var referenceRequest = await _context.ReferenceRequest.SingleOrDefaultAsync(m => m.ID == id);
			if (referenceRequest == null)
			{
				return NotFound();
			}
			return View(referenceRequest);
		}

		// POST: ReferenceRequests/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(Guid id, [Bind("ID,CandidateEndDate,CandidateId,CandidateJobDuties,CandidateStartDate,CreatedDate,Enabled,LastModifiedDate,RefereeId")] ReferenceRequest referenceRequest)
		{
			if (id != referenceRequest.ID)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(referenceRequest);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!ReferenceRequestExists(referenceRequest.ID))
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
			return View(referenceRequest);
		}

		// GET: ReferenceRequests/Delete/5
		public async Task<IActionResult> Delete(Guid? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var referenceRequest = await _context.ReferenceRequest.SingleOrDefaultAsync(m => m.ID == id);
			if (referenceRequest == null)
			{
				return NotFound();
			}

			return View(referenceRequest);
		}

		// POST: ReferenceRequests/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(Guid id)
		{
			var referenceRequest = await _context.ReferenceRequest.SingleOrDefaultAsync(m => m.ID == id);
			_context.ReferenceRequest.Remove(referenceRequest);
			await _context.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		private bool ReferenceRequestExists(Guid id)
		{
			return _context.ReferenceRequest.Any(e => e.ID == id);
		}
	}
}