using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkPlaceOnTour.BACKEND.Entities;

namespace WorkPlaceOnTour.BACKEND.Services
{
    public static class WotContextExtentions
    {

        public static void EnsureSeedDataForContext(this WotContext context)
        {

            // first, clear the database.  This ensures we can always start 
            // fresh with each demo.  Not advised for production environments, obviously :-)


           context.TourDestinations.RemoveRange(context.TourDestinations);
            context.Workplaces.RemoveRange(context.Workplaces);
            context.WokrplaceBookings.RemoveRange(context.WokrplaceBookings);
        

            context.SaveChanges();


            var tourDestinations = WotInMemoryData.GetTourDestinations();

            var workplaces = WotInMemoryData.GetWorkplaces();

           context.AddRange(tourDestinations);
           context.AddRange(workplaces);
     

            context.SaveChanges();



        }

        
    }
}
