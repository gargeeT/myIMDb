using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using myIMDb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myIMDb.Data
{
    public class AppDbInitializer
    {


        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Actor.Any())
                {
                    context.Actor.AddRange(new Actor()
                    {
                        Name = "Actor1",
                        Sex = "Male",
                        DOB = DateTime.Now,
                        Bio = "aaaaaaaaaa",
                        
                    },
                    new Actor()
                    {
                        Name = "Actor2",
                        Sex = "Male",
                        DOB = DateTime.Now,
                        Bio = "bbbbbbbbb",
                    });

                    context.SaveChanges();
                }
                if (!context.Producer.Any())
                {
                    context.Producer.AddRange(new Producer()
                    {
                        Name = "Producer1",
                        Sex = "Male",
                        DOB = DateTime.Now,
                        Bio = "aaaaaaaaa",
                    },
                    new Producer()
                    {
                        Name = "Producer2",
                        Sex = "Male",
                        DOB = DateTime.Now,
                        Bio = "bbbbbbbbb",
                    });

                    context.SaveChanges();
                }

                if (!context.Movie.Any())
                {
                    context.Movie.AddRange(new Movie()
                    {
                        Name = "Batman",
                        YearOfRelease = DateTime.Now,
                        Plot = "aaaaaaaaaaa",
                        Poster = "http1....",
                        ProducerId = 1
                    },
                    new Movie()
                    {
                        Name = "SuperMan",
                        YearOfRelease = DateTime.Now,
                        Plot = "bbbbbbbbb",
                        Poster = "http2....",
                        ProducerId = 1
                    });

                    context.SaveChanges();

                   
                    }
                }
            }
        }

    }

       /* public static async Task SeedRoles(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));

                if (!await roleManager.RoleExistsAsync(UserRoles.Publisher))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Publisher));

                if (!await roleManager.RoleExistsAsync(UserRoles.Author))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Author));

                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
            }
        }*/

