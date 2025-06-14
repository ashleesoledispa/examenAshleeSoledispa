﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using examenAshleeSoledispa.Data;
using examenAshleeSoledispa.Models;

namespace examenAshleeSoledispa.Controllers
{
    public class PlanRecompensasController : Controller
    {
        private readonly examenAshleeSoledispaContext _context;

        public PlanRecompensasController(examenAshleeSoledispaContext context)
        {
            _context = context;
        }

        // GET: PlanRecompensas
        public async Task<IActionResult> Index()
        {
            return View(await _context.PlanRecompensa.ToListAsync());
        }

        // GET: PlanRecompensas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planRecompensa = await _context.PlanRecompensa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planRecompensa == null)
            {
                return NotFound();
            }

            return View(planRecompensa);
        }

        // GET: PlanRecompensas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlanRecompensas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,FechaInicio,PuntosAcumulados")] PlanRecompensa planRecompensa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planRecompensa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(planRecompensa);
        }

        // GET: PlanRecompensas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planRecompensa = await _context.PlanRecompensa.FindAsync(id);
            if (planRecompensa == null)
            {
                return NotFound();
            }
            return View(planRecompensa);
        }

        // POST: PlanRecompensas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,FechaInicio,PuntosAcumulados")] PlanRecompensa planRecompensa)
        {
            if (id != planRecompensa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planRecompensa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanRecompensaExists(planRecompensa.Id))
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
            return View(planRecompensa);
        }

        // GET: PlanRecompensas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planRecompensa = await _context.PlanRecompensa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planRecompensa == null)
            {
                return NotFound();
            }

            return View(planRecompensa);
        }

        // POST: PlanRecompensas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planRecompensa = await _context.PlanRecompensa.FindAsync(id);
            if (planRecompensa != null)
            {
                _context.PlanRecompensa.Remove(planRecompensa);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanRecompensaExists(int id)
        {
            return _context.PlanRecompensa.Any(e => e.Id == id);
        }
    }
}
