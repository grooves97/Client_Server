using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ClientServerPart.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDBContent context = app.ApplicationServices
                .GetRequiredService<ApplicationDBContent>();
            context.Database.Migrate();

            if (!context.CleverItems.Any())
            {
                context.CleverItems.AddRange(
                    new CleverItem
                    {
                        ItemType = "Lamp",
                        ItemName = "Lamp in the hall",
                        OverallStatus = true,
                        CurrentStatus = false

                    },
                    new CleverItem
                    {
                        ItemType = "Lamp",
                        ItemName = "Lamp in the kitchen",
                        OverallStatus = false,
                        CurrentStatus = false
                    },
                    new CleverItem
                    {
                        ItemType = "Television",
                        ItemName = "Television in the guestroom",
                        OverallStatus = true,
                        CurrentStatus = false
                    },
                     new CleverItem
                     {
                         ItemType = "Television",
                         ItemName = "Television in the guestroom",
                         OverallStatus = true,
                         CurrentStatus = false
                     },
                      new CleverItem
                      {
                          ItemType = "Television",
                          ItemName = "Television in the guestroom",
                          OverallStatus = true,
                          CurrentStatus = false
                      }

                );
                context.SaveChanges();
            }
        }
    }
}
