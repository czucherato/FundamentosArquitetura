﻿using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DemoDI.Controllers
{
    public class MultiplasClassesController : Controller
    {
        public MultiplasClassesController(Func<string, IService> serviceAccessor)
        {
            _serviceAccessor = serviceAccessor;
        }

        private readonly Func<string, IService> _serviceAccessor;

        public string Index()
        {
            return _serviceAccessor("A").Retorno();
            //return _serviceAccessor("B").Retorno();
            //return _serviceAccessor("C").Retorno();
        }
    }
}
