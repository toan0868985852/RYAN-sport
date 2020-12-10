using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RYAN_sport.Data;
using RYAN_sport.Models;
using RYAN_sport.Areas.Identity.Data;

namespace RYAN_sport.Areas.Identity.Data
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            RYAN_sportDBContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<RYAN_sportDBContext>();
            if (context.Database.GetAppliedMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Galeries.Any())
            {
                context.Galeries.AddRange(
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic1.jpg",
                        SportName = "CYCING",
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic2.jpg",
                        SportName = "GOLF",
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic3.jpg",
                        SportName = "SWIMMING",
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic4.jpg",
                        SportName = "TENNIS",
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic5.jpg",
                        SportName = "TRACKS TRAINING",
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic6.jpg",
                        SportName = "WEIGHT TRAINING",
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2016/01/port9.jpg",
                        SportName = "GALLERY",
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2016/01/port10.jpg",
                        SportName = "GALLERY",
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2016/01/port11.jpg",
                        SportName = "GALLERY",
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2016/01/port6.jpg",
                        SportName = "GALLERY",
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2016/01/port7.jpg",
                        SportName = "GALLERY",
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2016/01/port8.jpg",
                        SportName = "GALLERY",
                    }


                );
                context.SaveChanges();
            }

            if (!context.Subscriptions.Any())
            {
                context.Subscriptions.AddRange(
                    new Subscription
                    {
                        RegistrationDate = DateTime.Parse("2019-12-22"),
                        EndDate = DateTime.Parse("2020-12-22")
                    },
                    new Subscription
                    {
                        RegistrationDate = DateTime.Parse("2020-02-25"),
                        EndDate = DateTime.Parse("2021-02-25")
                    }, new Subscription
                    {
                        RegistrationDate = DateTime.Parse("9-10-2019"),
                        EndDate = DateTime.Parse("9-10-2020")
                    }, new Subscription
                    {
                        RegistrationDate = DateTime.Parse("11-12-2019"),
                        EndDate = DateTime.Parse("11-12-2021")
                    },
                    new Subscription
                    {
                        RegistrationDate = DateTime.Parse("9-12-2019"),
                        EndDate = DateTime.Parse("9-12-2020")
                    }
                );
                context.SaveChanges();
            }

            if (!context.Subjects.Any())
            {
                context.Subjects.AddRange(
                    new Subject
                    {
                        Name = "CYCING",
                        Description = "updating",
                        Price = 100.00M,
                        Time = "9 months"
                    },
                    new Subject
                    {
                        Name = "GOLF",
                        Description = "updating",
                        Price = 1500.00M,
                        Time = "12 months"
                    },
                    new Subject
                    {
                        Name = "SWIMMING",
                        Description = "updating",
                        Price = 75.00M,
                        Time = "6 months"
                    },
                    new Subject
                    {
                        Name = "TENNIS",
                        Description = "updating",
                        Price = 170.00M,
                        Time = "12 months"
                    },
                    new Subject
                    {
                        Name = "TRACKS TRAINING",
                        Description = "updating",
                        Price = 50.00M,
                        Time = "12 months"
                    },
                    new Subject
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

            if (!context.SubjectSportRooms.Any())
            {
                context.SubjectSportRooms.AddRange(
                    new SubjectSportRoom
                    {
                        SportRoomId = 1,
                        SubjectId = 1
                    },
                    new SubjectSportRoom
                    {
                        SportRoomId = 2,
                        SubjectId = 2
                    },
                    new SubjectSportRoom
                    {
                        SportRoomId = 3,
                        SubjectId = 3
                    },
                    new SubjectSportRoom
                    {
                        SportRoomId = 4,
                        SubjectId = 4
                    },
                    new SubjectSportRoom
                    {
                        SportRoomId = 5,
                        SubjectId = 5
                    },
                    new SubjectSportRoom
                    {
                        SportRoomId = 5,
                        SubjectId = 6
                    }
                );
                context.SaveChanges();
            }

            if (!context.Levels.Any())
            {
                context.Levels.AddRange(
                    new Level
                    {
                        Name = "Vip",
                        
                    },
                    new Level
                    {
                        Name = "SVip",
                        
                    },
                    new Level
                    {
                        Name = "VVip",
                        
                    }
                   
                );
                context.SaveChanges();
            }

            if (!context.LevelSubjects.Any())
            {
                context.LevelSubjects.AddRange(
                    new LevelSubject
                    {
                        LevelId = 1,
                        SubjectId = 1

                    },
                    new LevelSubject
                    {
                        LevelId = 2,
                        SubjectId = 1

                    },
                    new LevelSubject
                    {
                        LevelId = 1,
                        SubjectId = 2

                    },
                    new LevelSubject
                    {
                        LevelId = 1,
                        SubjectId = 3

                    },
                    new LevelSubject
                    {
                        LevelId = 1,
                        SubjectId = 4

                    },
                    new LevelSubject
                    {
                        LevelId = 1,
                        SubjectId = 6

                    }
                ); ;
                context.SaveChanges();
            }

            if (!context.Cards.Any())
            {
                context.Cards.AddRange(
                    new Card
                    {
                        NumberCard = "RYAN120046556",
                        UserId = "",
                        LevelId = 1
                        
                    },
                    new Card
                    {
                        NumberCard = "RYAN120046557",
                        UserId = "",
                        LevelId = 2
                    },
                    new Card
                    {
                        NumberCard = "RYAN120046558",
                        UserId = "",
                        LevelId = 1
                    },
                    new Card
                    {
                        NumberCard = "RYAN120046559",
                        UserId = "",
                        LevelId = 1
                    },
                    new Card
                    {
                        NumberCard = "RYAN12004650",
                        UserId = "",
                        LevelId = 3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
