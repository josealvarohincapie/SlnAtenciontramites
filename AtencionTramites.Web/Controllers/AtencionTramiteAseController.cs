﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Ultimus.Interfaces.UltimusForm;
using Ultimus.Utilitarios;

namespace AtencionTramites.Controllers
{
    public class AtencionTramiteAseController : BaseController
    {
        UltimusLogs UltimusLogs = new UltimusLogs("AtencionTramiteAseController");

        public ActionResult Radicado()
        {
            InitControllers();

            return View();
        }

        public ActionResult Seguimiento()
        {
            InitControllers();

            return View();
        }

        public ActionResult GenerarDocumento()
        {
            InitControllers();

            return View();
        }

        public ActionResult RevisionVistoBueno()
        {
            InitControllers();

            return View();
        }

        public ActionResult Aprobar()
        {
            InitControllers();

            return View();
        }

        public ActionResult Verificar()
        {
            InitControllers();

            return View();
        }

        public ActionResult Archivar()
        {
            InitControllers();

            return View();
        }
    }
}