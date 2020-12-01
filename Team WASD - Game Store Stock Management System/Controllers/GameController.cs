﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Team_WASD___Game_Store_Stock_Management_System.Models;

namespace Team_WASD___Game_Store_Stock_Management_System.Controllers
{
    public class GameController : Controller
    {
        private GameStoreDBContext db = new GameStoreDBContext();
        // GET: Game
        public ActionResult Index()
        {
            var games = db.Games.Include(g => g.Publisher)
                .Include(g => g.Platform)
                .Include(g => g.Genre);
            
            return View(games.ToList());
        }

        // GET: Game/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var games = db.Games.Include(g => g.Publisher)
                .Include(g => g.Platform)
                .Include(g => g.Genre);
            Game game = null;
            foreach(Game g in games)
            {
                if(g.Id == id)
                {
                    game = g;
                }
            }

            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // GET: Game/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Game/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,GameTitle,Publisher,ReleaseDate,Platform,Genre,Description,InStockAmount,Price")] Game game)
        {
            if (ModelState.IsValid)
            {
                db.Games.Add(game);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(game);
        }

        // GET: Game/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var games = db.Games.Include(g => g.Publisher)
                .Include(g => g.Platform)
                .Include(g => g.Genre);
            Game game = null;
            foreach (Game g in games)
            {
                if (g.Id == id)
                {
                    game = g;
                }
            }
            if (game == null)
            {
                return HttpNotFound();
            }

            ViewData["Publishers"] = db.Publishers;
            ViewData["Platforms"] = db.Platforms;
            ViewData["Genres"] = db.Genres;
            return View(game);
        }

        // POST: Game/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,GameTitle,Publisher,ReleaseDate,Platform,Genre,Description,InStockAmount,Price")] Game game)
        {
            if (ModelState.IsValid)
            {
                db.Entry(game).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(game);
        }

        // GET: Game/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var games = db.Games.Include(g => g.Publisher)
                .Include(g => g.Platform)
                .Include(g => g.Genre);
            Game game = null;
            foreach (Game g in games)
            {
                if (g.Id == id)
                {
                    game = g;
                }
            }
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Game/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Game game = db.Games.Find(id);
            db.Games.Remove(game);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
