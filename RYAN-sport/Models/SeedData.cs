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

            if (!context.subscriptions.Any())
            {
                context.subscriptions.AddRange(
                    new Subscription
                    {
                        RegistrationDate = "22-12-2019",
                        EndDate = "22-12-2020"
                    },
                    new Subscription
                    {
                        RegistrationDate = "25-2-2020",
                        EndDate = "25-02-2021"
                    }, new Subscription
                    {
                        RegistrationDate = "9-10-2019",
                        EndDate = "9-10-2020"
                    }, new Subscription
                    {
                        RegistrationDate = "11-12-2019",
                        EndDate = "11-12-2021"
                    },
                    new Subscription
                    {
                        RegistrationDate = "9-12-2019",
                        EndDate = "9-12-2020"
                    }
                );
                context.SaveChanges();
            }

            if (!context.Subjects.Any())
            {
                context.Subjects.AddRange(
                    new Subjects
                    {
                        Name = "CYCING",
                        Description = "updating",
                        Price = 100.00M,
                        Time = "9 months"
                    },
                    new Subjects
                    {
                        Name = "GOLF",
                        Description = "updating",
                        Price = 1500.00M,
                        Time = "12 months"
                    },
                    new Subjects
                    {
                        Name = "SWIMMING",
                        Description = "updating",
                        Price = 75.00M,
                        Time = "6 months"
                    },
                    new Subjects
                    {
                        Name = "TENNIS",
                        Description = "updating",
                        Price = 170.00M,
                        Time = "12 months"
                    },
                    new Subjects
                    {
                        Name = "TRACKS TRAINING",
                        Description = "updating",
                        Price = 50.00M,
                        Time = "12 months"
                    },
                    new Subjects
                    {
                        Name = "WEIGHT TRAINING",
                        Description = "updating",
                        Price = 90.00M,
                        Time = "9 months"
                    }
                );
                context.SaveChanges();
            }

            if (!context.SportRooms.Any())
            {
                context.SportRooms.AddRange(
                    new SportRoom
                    {
                        Name = "Bicycle gym in the Binh Minh house",
                        Address = "8, Ton That Thuyet, My Dinh 2",
                        Hotline = "113"
                    },
                    new SportRoom
                    {
                        Name = "FLC golf course",
                        Address = "Tu NIem, Ha Noi",
                        Hotline = "19008198"
                    },
                    new SportRoom
                    {
                        Name = "Pool Chet Duoi",
                        Address = "119 Thanh Xuan, HA Noi",
                        Hotline = "16322000"
                    },
                    new SportRoom
                    {
                        Name = "Tiger Woods tennis court.",
                        Address = "Long BIen, Ha Noi",
                        Hotline = "9886546"
                    },
                    new SportRoom
                    {
                        Name = "Blue Gym",
                        Address = "Dai Tu, Ha Noi",
                        Hotline = "1138556468"
                    }
                );
                context.SaveChanges();
            }

            if (!context.Levels.Any())
            {
                context.Levels.AddRange(
                    new Level
                    {
                        Category = "Vip",
                        SportRoomID = 1,
                        SubjectsID = 1                        
                    },
                    new Level
                    {
                        Category = "SVip",
                        SportRoomID = 2,
                        SubjectsID = 2
                    },
                    new Level
                    {
                        Category = "VVip",
                        SportRoomID = 3,
                        SubjectsID = 3
                    },
                    new Level
                    {
                        Category = "Vip",
                        SportRoomID = 4,
                        SubjectsID = 4
                    },
                    new Level
                    {
                        Category = "Vip",
                        SportRoomID = 5,
                        SubjectsID = 5
                    },
                    new Level
                    {
                        Category = "VVip",
                        SportRoomID = 5,
                        SubjectsID = 6
                    }
                );
                context.SaveChanges();
            }

            if (!context.Cards.Any())
            {
                context.Cards.AddRange(
                    new Card
                    {
                        NumberCard = "RYAN120046556",
                        SubscriptionID = 1,
                        LevelID = 1,
                        AplicationtUserID = 1
                    },
                    new Card
                    {
                        NumberCard = "RYAN120046557",
                        SubscriptionID = 2,
                        LevelID = 2,
                        AplicationtUserID = 1
                    },
                    new Card
                    {
                        NumberCard = "RYAN120046558",
                        SubscriptionID = 3,
                        LevelID = 3,
                        AplicationtUserID = 1
                    },
                    new Card
                    {
                        NumberCard = "RYAN120046559",
                        SubscriptionID = 4,
                        LevelID = 4,
                        AplicationtUserID = 1
                    },
                    new Card
                    {
                        NumberCard = "RYAN12004650",
                        SubscriptionID = 5,
                        LevelID = 5,
                        AplicationtUserID = 1
                    }
                );
                context.SaveChanges();
            }


        }
    }
}
