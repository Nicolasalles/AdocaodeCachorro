using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using adocaodecachorro.Models;

namespace adocaodecachorro.Controllers
{
    public class CachorroController : Controller
    {
        static IList<CachorroModel> DogList = new List<CachorroModel>{
                new CachorroModel() { DogID=1, Nome = "Rodolfo", Raca = "Vira-Lata", Idade = 6, Castracao = true, Sexo = 'M' },
                new CachorroModel() { DogID=2, Nome = "Haru", Raca = "Fox Paulista", Idade = 3, Castracao = false, Sexo = 'F' },

        };
        // GET: Aluno
        public ActionResult Index()
        {
            return View(DogList.OrderBy(s=> s.DogID).ToList());
        }


        // GET: Aluno/Edit/5
        public ActionResult Edit(int id)
        {
            var dog = DogList.Where(s =>s.DogID == id).FirstOrDefault();
            return View(dog);
        }
        
        // POST: Aluno/Edit/5
        [HttpPost]
        public ActionResult Edit(CachorroModel dog)
        {
            var cachorro = DogList.Where(s=>s.DogID==dog.DogID).FirstOrDefault();
            DogList.Remove(cachorro);
            DogList.Add(dog);

            return RedirectToAction("Index");
        }
        // GET: Aluno/Details/5
        public ActionResult Details(int id)
        {
            return View(CachorroModel.CriarLista()[id]);
        }

        // GET: Aluno/Delete/5
        public ActionResult Delete(int id)
        {
            return View(CachorroModel.CriarLista()[id]);
        }

        // GET: Aluno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cachorro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    



        // POST: Aluno/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}