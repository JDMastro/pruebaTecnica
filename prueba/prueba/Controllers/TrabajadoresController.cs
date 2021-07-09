using Microsoft.AspNetCore.Mvc;
using prueba.Models;
using prueba.Models.ViewModels;
using prueba.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Controllers
{
    public class TrabajadoresController : Controller
    {
        private readonly IAreas areasRepository;
        private readonly ITrabajos trabajosRepository;
        private readonly IEmpresas empresasRepository;
        public TrabajadoresController(IAreas areas, ITrabajos trabajos, IEmpresas empresas) 
        { 
            areasRepository = areas;
            trabajosRepository = trabajos;
            empresasRepository = empresas;
        }
        public async Task<IActionResult> IndexJefes()
        {
            
            var areas = await areasRepository.ObtenerAreasporSp() ;
            var empresas = await empresasRepository.ObtenerEmpresasporSp();
            var trabajadores = await trabajosRepository.ObtenerTrabajadoresporSp();

            TrabajadoresViewModels vmTrabajadores = new TrabajadoresViewModels
            {
                Areas = areas,
                Empresas = empresas,
                Trabajadores = trabajadores
            };

            return View(vmTrabajadores);
        }

        //Vista de crear jefes

        public async Task<ActionResult> CreateJefes()
        {
            var areas = await areasRepository.ObtenerAreasporSp();
            var empresas = await empresasRepository.ObtenerEmpresasporSp();

            TrabajadoresViewModels vmTrabajadores = new TrabajadoresViewModels
            {
                Areas = areas.Where(a => a.TrabajadoresId == 0 ).ToList(),
                Empresas = empresas,
                Trabajador = new Trabajadores()
            };

            return View(vmTrabajadores);
        }

        //Insertar jefe
        [HttpPost]
        public async Task<IActionResult> CreateJefes(TrabajadoresViewModels t)
        {
            /* TrabajadoresViewModels vmTrabajadores = new TrabajadoresViewModels
             {
                 Trabajador = t.Trabajador
             };*/

            var areas = await areasRepository.ObtenerAreasporSp();
            var empresas = await empresasRepository.ObtenerEmpresasporSp();

            TrabajadoresViewModels vmTrabajadores = new TrabajadoresViewModels
            {
                Areas = areas.Where(a => a.TrabajadoresId == 0).ToList(),
                Empresas = empresas,
                Trabajador = new Trabajadores()
            };

            if (ModelState.IsValid)
            {

                await trabajosRepository.IngresarTrabajadoresJefeporSp(t.Trabajador);
                TempData["mensaje"] = "El trabajador jefe se ha guardado correctamente";
                return RedirectToAction("IndexJefes");
            }
            return View(vmTrabajadores);
        }



        //Vista Edit
        public async Task<ActionResult> Edit(int? id)
        {
            var empresas = await empresasRepository.ObtenerEmpresasporSp();
            var trabajador = await trabajosRepository.ObtenerTrabajadoresporSp();

            TrabajadoresViewModels vmTrabajadores = new TrabajadoresViewModels
            {
                Empresas = empresas,
                Trabajador = trabajador.FirstOrDefault(t => t.Id == id)
            };

            return View(vmTrabajadores);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(TrabajadoresViewModels t)
        {
            
            if (ModelState.IsValid)
            {
                await trabajosRepository.ActualizarTrabajadoresJefeporSp(t.Trabajador);
                TempData["mensaje"] = "El trabajador jefe se ha actualizado correctamente";
                return RedirectToAction("IndexJefes");
            }
            return View();
        }


    }
}
