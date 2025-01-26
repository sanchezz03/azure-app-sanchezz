﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using azure_app_sanchezz.Data;

namespace azure_app_sanchezz.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly azure_app_sanchezz.Data.AppDbContext _context;

        public IndexModel(azure_app_sanchezz.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
