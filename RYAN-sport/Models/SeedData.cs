using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RYAN_sport.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            SportDBContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<SportDBContext>();
            if (context.Database.GetAppliedMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.HeaderImages.Any())
            {
                context.HeaderImages.AddRange(
                    new HeaderImage
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/icon1-hover.png",
                        SportName = "CYCLING",
                    },
                    new HeaderImage
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/icon2-hover.png",
                        SportName = "GOLF",
                    },
                    new HeaderImage
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/icon3-hover.png",
                        SportName = "SWIMMING",
                    },
                    new HeaderImage
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/icon4-hover.png",
                        SportName = "TENNIS",
                    },
                    new HeaderImage
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/running.png",
                        SportName = "TRACK TRAINING",
                    },
                    new HeaderImage
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/weight_lifting.png",
                        SportName = "WEIGHT TRAINING",
                    }
                );
                context.SaveChanges();
            }

            if (!context.exercisePackages.Any())
            {
                context.exercisePackages.AddRange(
                    new exercisePackage
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2016/02/c7.jpg",
                        TitlePackage = "SWIMMING COACH",
                        ContentPackage = "Aenean tempor tincidunt diam ut pretium. Nulla elementum rhoncus ante.",
                        Price = 82,
                        datePackage = "215 Days"
                    },
                    new exercisePackage
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2016/02/c8.jpg",
                        TitlePackage = "TENNIS CHAMPION",
                        ContentPackage = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam a lectus eget orci.",
                        Price = 249.99M,
                        datePackage = "6 Months"
                    },
                    new exercisePackage
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2016/02/c9.jpg",
                        TitlePackage = "TREKKING PRACTICE",
                        ContentPackage = "Nunc at pretium est curabitur commodo leac est venenatis egestas sed aliquet auguevelit.",
                        Price = 69,
                        datePackage = "99 Days"
                    }
                );
                context.SaveChanges();
            }

            if (!context.abouts.Any())
            {
                context.abouts.AddRange(
                    new about
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/team1.jpg",
                        ContentAbout = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi hendrerit elit turpis, a porttitor tellus sollicitudin at. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.",
                    },
                    new about
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/team2.jpg",
                        ContentAbout = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi hendrerit elit turpis, a porttitor tellus sollicitudin at. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.",
                    }
                );
                context.SaveChanges();
            }

            if (!context.galerys.Any())
            {
                context.galerys.AddRange(
                    new galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic1.jpg",
                        SportName = "CYCING",
                    },
                    new galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic2.jpg",
                        SportName = "GOLF",
                    },
                    new galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic3.jpg",
                        SportName = "SWIMMING",
                    },
                    new galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic4.jpg",
                        SportName = "TENNIS",
                    },
                    new galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic5.jpg",
                        SportName = "TRACKS TRAINING",
                    },
                    new galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic6.jpg",
                        SportName = "WEIGHT TRAINING",
                    },
                    new galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2016/01/port9.jpg",
                        SportName = "GALLERY",
                    },
                    new galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2016/01/port10.jpg",
                        SportName = "GALLERY",
                    },
                    new galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2016/01/port11.jpg",
                        SportName = "GALLERY",
                    },
                    new galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2016/01/port6.jpg",
                        SportName = "GALLERY",
                    },
                    new galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2016/01/port7.jpg",
                        SportName = "GALLERY",
                    },
                    new galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2016/01/port8.jpg",
                        SportName = "GALLERY",
                    }


                );
                context.SaveChanges();
            }
        }
    }
}
