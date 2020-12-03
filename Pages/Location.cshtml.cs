﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageMovie.Pages
{
    public class LocationModel : PageModel
    {
        private readonly ILogger<LocationModel> _logger;

        public LocationModel(ILogger<LocationModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
