using handMadeShop.Application.System.Roles;
using handMadeShop.Data.EF;
using handMadeShop.Data.Entities;
using handMadeShop.ViewModels.System.Roles;
using handMadeShop.ViewModels.Utilities.Slides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handMadeShop.Application.Utilities.Slides
{
    public class SlideService : ISlideService
    {
        private readonly handMadeDBContext _context;

        public SlideService(handMadeDBContext context)
        {
            _context = context;
        }

        public async Task<List<SlideVm>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder)
                .Select(x => new SlideVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Url = x.Url,
                    Image = x.Image
                }).ToListAsync();

            return slides;
        }
    }
}