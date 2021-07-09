using Microsoft.AspNetCore.Mvc;
using prueba.Models;
using prueba.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Controllers
{
    public class AreasController : Controller
    {
        private readonly IAreas areasRepository;
        public AreasController(IAreas areas) => areasRepository = areas;

        //Get Vista
        public async Task<ActionResult> Index()
        {
            var list = await areasRepository.ObtenerAreasporSp();
            return View(list);
        }

        //Vista de Insertar area
        public ActionResult Create() 
        {
            return View();
        }

        //Vista de Editar area
        public async Task<ActionResult> Edit(int? id)
        {
            if(id == 0 || id == null)
            {
                return NotFound();
            }

            var list = await areasRepository.ObtenerAreasporIdSp(id);

            if(list == null)
            {
                return NotFound();
            }

            return View(list.First());
        }

        //Insertar area
        [HttpPost]
        public async Task<ActionResult> Create(Areas a)
        {
            if (ModelState.IsValid)
            {

                await areasRepository.InsertarAreasporSp(a);
                TempData["mensaje"] = "El area se ha guardado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        //Actualizar area
        [HttpPost]
        public async Task<ActionResult> Edit(Areas a)
        {
            if (ModelState.IsValid)
            {

                await areasRepository.ActualizarAreasSp(a);
                TempData["mensaje"] = "El area se ha actualizado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
