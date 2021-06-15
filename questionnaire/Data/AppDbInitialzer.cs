using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using questionnaire.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tele_consult.Data;

namespace questionnaire.Data
{
    public class AppDbInitialzer
    {
        //public static void Seed(IApplicationBuilder appliationBuilder)
        //{
        //    using (var serviceScrope = appliationBuilder.ApplicationServices.CreateScope())
        //    {
        //        var context = serviceScrope.ServiceProvider.GetService<AppDbContext>();
        //        if (!context.questions.Any())
        //        {
        //            context.questions.AddRange(new Questions()
        //            {
        //               Question = "Title",
        //               DateAdd = DateTime.Now, 
        //            },
        //            new Questions()
        //            {
        //                Question = "First Name",
        //                DateAdd = DateTime.Now
        //            },
        //            new Questions()
        //            {
        //                Question = "Last Name",
        //                DateAdd = DateTime.Now
        //            },
        //            new Questions()
        //            {
        //                Question = "Date of birth",
        //                DateAdd = DateTime.Now
        //            },
        //            new Questions()
        //            {
        //                Question = "Country of residence",
        //                DateAdd = DateTime.Now
        //            },
        //            new Questions()
        //            {
        //                Question = "House Address",
        //                DateAdd = DateTime.Now
        //            },
        //            new Questions()
        //            {
        //                Question = "Work Address",
        //                DateAdd = DateTime.Now
        //            },
        //             new Questions()
        //             {
        //                 Question = "Occupation",
        //                 DateAdd = DateTime.Now
        //             },
        //              new Questions()
        //              {
        //                  Question = "Job Title",
        //                  DateAdd = DateTime.Now
        //              },
        //              new Questions()
        //              {
        //                  Question = "Business Type",
        //                  DateAdd = DateTime.Now
        //            });
        //            context.SaveChanges();
        //        }
        //    }
        //}
    }
}
