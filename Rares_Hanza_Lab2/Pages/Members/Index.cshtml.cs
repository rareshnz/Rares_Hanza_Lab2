using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rares_Hanza_Lab2.Data;
using Rares_Hanza_Lab2.Models;

namespace Rares_Hanza_Lab2.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly Rares_Hanza_Lab2.Data.Rares_Hanza_Lab2Context _context;

        public IndexModel(Rares_Hanza_Lab2.Data.Rares_Hanza_Lab2Context context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Member != null)
            {
                Member = await _context.Member.ToListAsync();
            }
        }
    }
}
