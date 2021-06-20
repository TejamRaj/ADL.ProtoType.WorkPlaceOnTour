using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkPlaceOnTour.BACKEND.Entities;

namespace WorkPlaceOnTour.BACKEND.Services
{
    public class WorkplaceRepository : IWorkplaceRepository
    {
        private readonly WotContext context;

        public WorkplaceRepository(WotContext context)
        {
            this.context = context;
        }


        public async Task<IEnumerable<Workplace>> GetWorkPlacesByTourId(Guid tourId)
        {
            return await context.Workplaces.Where(t => t.TourId.Equals(tourId.ToString())).ToListAsync();
        }

        public async Task AddWorkplace(Workplace workplace)
        {
            await context.Workplaces.AddAsync(workplace);
        }
    }
}
