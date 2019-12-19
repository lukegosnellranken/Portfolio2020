using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RecordStoreProject.Models;
using PagedList;

namespace RecordStoreProject.Controllers
{
    public class AlbumsController : Controller
    {
        private RecordStoreDatabaseEntities db = new RecordStoreDatabaseEntities();

        // GET: Albums
        //public ActionResult Index()
        //{
        //    var albums = db.Albums.Include(a => a.Artist).Include(a => a.Genre);
        //    return View(albums.ToList());
        //}

        public ActionResult Index(string sortOrder,string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;

            ViewBag.NameSortParm = sortOrder == "name_desc" ? "name_asc" : "name_desc";
            //ViewBag.NameSortParm = sortOrder == "artist_asc" ? "artist_desc" : "artist_asc";
            //ViewBag.NameSortParm = sortOrder == "genre_asc" ? "genre_desc" : "genre_asc";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var albums = from a in db.Albums
                           select a;
            if (!String.IsNullOrEmpty(searchString))
            {
                albums = albums.Where(a => a.Genre.GenreName.ToString().Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    albums = albums.OrderByDescending(a => a.AlbumName);
                    break;
                case "name_asc":
                    albums = albums.OrderBy(a => a.AlbumName);
                    break;

                //case "artist_desc":
                //    albums = albums.OrderByDescending(a => a.Artist);
                //    break;
                //case "artist_asc":
                //    albums = albums.OrderBy(a => a.Artist);
                //    break;

                //case "genre_desc":
                //    albums = albums.OrderByDescending(a => a.Genre);
                //    break;
                //case "genre_asc":
                //    albums = albums.OrderBy(a => a.Genre);
                //    break;

                default:
                    albums = albums.OrderBy(a => a.AlbumName);
                    break;
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(albums.ToPagedList(pageNumber, pageSize));
        }

        // GET: Albums/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        // GET: Albums/Create
        public ActionResult Create()
        {
            ViewBag.AlbumArtistID = new SelectList(db.Artists, "ArtistID", "ArtistName");
            ViewBag.AlbumGenreID = new SelectList(db.Genres, "GenreID", "GenreName");
            return View();
        }

        // POST: Albums/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AlbumID,AlbumName,AlbumGenreID,AlbumPrice,AlbumArtistID")] Album album)
        {
            if (ModelState.IsValid)
            {
                db.Albums.Add(album);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AlbumArtistID = new SelectList(db.Artists, "ArtistID", "ArtistName", album.AlbumArtistID);
            ViewBag.AlbumGenreID = new SelectList(db.Genres, "GenreID", "GenreName", album.AlbumGenreID);
            return View(album);
        }

        // GET: Albums/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            ViewBag.AlbumArtistID = new SelectList(db.Artists, "ArtistID", "ArtistName", album.AlbumArtistID);
            ViewBag.AlbumGenreID = new SelectList(db.Genres, "GenreID", "GenreName", album.AlbumGenreID);
            return View(album);
        }

        // POST: Albums/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AlbumID,AlbumName,AlbumGenreID,AlbumPrice,AlbumArtistID")] Album album)
        {
            if (ModelState.IsValid)
            {
                db.Entry(album).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AlbumArtistID = new SelectList(db.Artists, "ArtistID", "ArtistName", album.AlbumArtistID);
            ViewBag.AlbumGenreID = new SelectList(db.Genres, "GenreID", "GenreName", album.AlbumGenreID);
            return View(album);
        }

        // GET: Albums/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        // POST: Albums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Album album = db.Albums.Find(id);
            db.Albums.Remove(album);
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
