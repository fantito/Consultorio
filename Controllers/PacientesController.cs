using Consultorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Consultorio.Controllers
{
    public class PacientesController : Controller
    {
        ConsultorioContext db = new ConsultorioContext();
        // GET: Pacientes
        public ActionResult Index()
        {
            var pacientes = db.Pacientes.ToList();
            return View(pacientes);
        }

        // GET: Pacientes/Details/5
        public ActionResult Details(int id)
        {
            var paciente = db.Pacientes.Find(id);
            return View(paciente);
        }

        // GET: Pacientes/Create
        public ActionResult Create()
        {
            var documentosTipos = db.DocumentoTipos.ToList();
            ViewBag.DocumentoTipos = new SelectList(db.DocumentoTipos.ToList(), "Id", "Descripcion");
            return View();
        }

        // POST: Pacientes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
              
                db.PacienteCreate(collection.Get("Codigo"), 
                    collection.Get("Nombre"),
                    collection.Get("Apellido"), 
                    collection.Get("DocumentoNro"),
                    Convert.ToInt32( collection.Get("DocumentoTipo")),
                    DateTime.Now,
                    collection.Get("Domicilio"),
                    collection.Get("Mail"));

                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
              //  return View();
            }
        }

        // GET: Pacientes/Edit/5
        public ActionResult Edit(int id)
        {
            var paciente = db.Pacientes.Find(id);
            return View(paciente);
        }

        // POST: Pacientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pacientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pacientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
