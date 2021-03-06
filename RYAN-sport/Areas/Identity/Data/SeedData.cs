﻿using System;
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
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/12/para-surf.jpg",
                        Group = "Header"
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/12/swim-bg.jpg",
                        Group = "Header"
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/12/rugby.jpg",
                        Group = "Header"
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/icon1-hover.png",
                        SportName = "CYCING",
                        Group = "Icon"
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/icon2-hover.png",
                        SportName = "GOLF",
                        Group = "Icon"
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/icon3-hover.png",
                        SportName = "SWINGMING",
                        Group = "Icon"
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/icon4-hover.png",
                        SportName = "TENNIS",
                        Group = "Icon"
                    }, new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/icon5-hover.png",
                        SportName = "TRACK TRAINING",
                        Group = "Icon"
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/icon6-hover.png",
                        SportName = "WEIGHT TRAINING",
                        Group = "Icon"
                    },

                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic1.jpg",
                        SportName = "CYCING",
                        Group = "Icon"
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic2.jpg",
                        SportName = "GOLF",
                        Group = "Icon"
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic3.jpg",
                        SportName = "SWIMMING",
                        Group = "Icon"
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic4.jpg",
                        SportName = "TENNIS",
                        Group = "Icon"
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic5.jpg",
                        SportName = "TRACKS TRAINING",
                        Group = "Icon"
                    },
                    new Galery
                    {
                        Image = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic6.jpg",
                        SportName = "WEIGHT TRAINING",
                        Group = "Icon"
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

            if (!context.Subjects.Any())
            {
                context.Subjects.AddRange(
                    new Subject
                    {
                        Name = "CYCING",
                        Description = "Your personal cycling coach will design a training program that matches your fitness level, is tailored your cycling goals, and fits around your busy schedule.  ",
                        Price = 100.00M,
                        Time = "9 months",
                        ImgSubject = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic1.jpg",
                        ImgSubjectDetail = "https://raw.githubusercontent.com/nddat1908/T1908A_Sem3/master/ImageSubjectRYAN/cycling.png",
                        Category = "Indoor Sports"
                    },
                    new Subject
                    {
                        Name = "GOLF",
                        Description = "The most common complaint I hear from recreational golfers is that their game simply doesn’t transfer from the lesson tee or the practice range to the golf course. They might experience some success in a lesson environment, hit a couple of great shots in a row with their coach present—or when trying out the latest swing tip they read in one of the instruction magazines—but when it comes time to deliver on the course, the same old swing flaws resurface. The high, 5-yard draw they thought they had mastered on the lesson tee is back to being a weak, stomach curdling 20-yard slice.",
                        Price = 1500.00M,
                        Time = "12 months",
                        ImgSubject = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic2.jpg",
                        ImgSubjectDetail = "https://github.com/nddat1908/T1908A_Sem3/blob/master/ImageSubjectRYAN/golf.png?raw=true",
                        Category = "Outdoor Sports"
                    },
                    new Subject
                    {
                        Name = "SWIMMING",
                        Description = "Becoming a swimming coach is popular across the UK. Nothing quite beats the thrill of a competitive race, and so swimmers often decide to become coaches after calling time on their competitive careers.But it’s not just a former swimmer that ends up becoming a swimming coach; there are plenty of British coaches with no previous experience of competitive swimming.",
                        Price = 75.00M,
                        Time = "6 months",
                        ImgSubject = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic3.jpg",
                        ImgSubjectDetail = "https://github.com/nddat1908/T1908A_Sem3/blob/master/ImageSubjectRYAN/participant_swimming.jpg?raw=true",
                        Category = "Outdoor Sports"
                    },
                    new Subject
                    {
                        Name = "TENNIS",
                        Description = "In tennis, as in any sport, the role of the coach is an important one. A good coach not only can get others interested in playing a sport, but also plays an important role in motivating players and teaching the skills that a player will use for a lifetime. The best coaches also serve as role models and demonstrate the behaviors that players will want to emulate.",
                        Price = 170.00M,
                        Time = "12 months",
                        ImgSubject = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic4.jpg",
                        ImgSubjectDetail = "https://github.com/nddat1908/T1908A_Sem3/blob/master/ImageSubjectRYAN/tennis.png?raw=true",
                        Category = "Outdoor Sports"
                    },
                    new Subject
                    {
                        Name = "TRACKS TRAINING",
                        Description = "A coach at your side during your run will give you direct feedback on form, technique, and pacing. You will also learn numerous warm-up and cool-down drills and routines to incorporate into your daily training.Our personal coaching service gives you an experienced running coach to plan your training and for personal support to talk about race strategy, performance nutrition, injury prevention, stretching, and much more.And best of all, communication is unlimited.The ultimate coaching experience.",
                        Price = 50.00M,
                        Time = "12 months",
                        ImgSubject = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic5.jpg",
                        ImgSubjectDetail = "https://github.com/nddat1908/T1908A_Sem3/blob/master/ImageSubjectRYAN/run.png?raw=true",
                        Category = "Indoor Sports"
                    },
                    new Subject
                    {
                        Name = "WEIGHT TRAINING",
                        Description = "The coaching pathway provides the only qualifications that are recognised for our exclusive coach license scheme and cover the official BWL Technical Models. We have created coach training programmes, that produce world-class weightlifting coaches who help to develop medal winning athletes. The skills learned during BWL coaching courses are invaluable in understanding the sport of weightlifting, but they can also be applied across all types and levels of physical activity to improve strength and conditioning. We work in partnership with Focus Awards (regulated awarding body) to accredit our qualifications.",
                        Price = 90.00M,
                        Time = "9 months",
                        ImgSubject = "https://1bubze2sol6cfove63681xma-wpengine.netdna-ssl.com/wp-content/uploads/2015/11/pic6.jpg",
                        ImgSubjectDetail = "https://github.com/nddat1908/T1908A_Sem3/blob/master/ImageSubjectRYAN/weight.png?raw=true",
                        Category = "Indoor Sports"
                    },
                    new Subject
                    {
                        Name = "FOOTBAll",
                        Description = "My Coach Football allows you to manage and organize the daily operations of your football team, day after day, season after season. Designed to answer amateur and professional coaches’ needs, the platform centralizes all of your squad’s information and allows to gain time and efficiency. In a single click, you can manage players and their personal information, the preparation of training and games, but also individual and collective statistics. Season after season, you keep all those data and hence enjoy an optimum tracking of your team’s progression.",
                        Price = 90.00M,
                        Time = "8 months",
                        ImgSubject = "https://scontent.fhan2-6.fna.fbcdn.net/v/t1.15752-9/p1080x2048/129882239_425010888538704_1132306281933710718_n.jpg?_nc_cat=100&ccb=2&_nc_sid=ae9488&_nc_ohc=-x-cmwLErNsAX-8e0Dd&_nc_ht=scontent.fhan2-6.fna&tp=6&oh=005fd4a56ffca8a8e95438c1d77e1aeb&oe=5FF7CE8E",
                        ImgSubjectDetail = "https://github.com/nddat1908/T1908A_Sem3/blob/master/ImageSubjectRYAN/football1.png?raw=true",
                        Category = "Indoor Sports"
                    },
                    new Subject
                    {
                        Name = "BADMINTON",
                        Description = "At Badminton England, we are proud to support and have a vast network of qualified coaches that can offer coaching to help players learn, improve and master badminton skills whatever their playing experience or level.If you are trying to find a badminton coach for private, group or club coaching sessions then please use the coach search tool below.This lists all members of the Badminton England Coach Accreditation scheme, their qualification, any CPD completed as well as their contact details should they be happy to be contacted directly regarding coaching opportunities.",
                        Price = 90.00M,
                        Time = "8 months",
                        ImgSubject = "https://images.indianexpress.com/2020/04/badminton-bai-bwf-fb.jpg",
                        ImgSubjectDetail = "https://github.com/nddat1908/T1908A_Sem3/blob/master/ImageSubjectRYAN/badminton.png?raw=true",
                        Category = "Indoor Sports"
                    },
                    new Subject
                    {
                        Name = "MUAY Thai",
                        Description = "Muay Thai comes from 'Krabi Krabong', an ancient Siam (SIAM, Old name of Thailand) martial art with the martial arts of royal soldiers with swords in their right hand, the martial art becomes A familiar martial art among the people, is kept as a combat sport, and becomes a pride of the Thai people. The attack method of this martial art includes using the head to hit, biting the mouth, fists, using elbows, knees to hit, hooking eyes as well as kicking, kicking ... Muay Thai is formed from the martial arts mentioned above. Therefore it is also known as The Right of Thai Freedom",
                        Price = 90.00M,
                        Time = "20 months",
                        ImgSubject = "https://images.pexels.com/photos/4651305/pexels-photo-4651305.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                        ImgSubjectDetail = "https://github.com/nddat1908/T1908A_Sem3/blob/master/ImageSubjectRYAN/muay.png?raw=true",
                        Category = "Indoor Sports"
                    },
                    new Subject
                    {
                        Name = "BASEKETBALL",
                        Description = "Basketball coach is the act of directing and strategizing the behavior of a basketball team or individual basketball player. Basketball coaching often involves improving individual and team attack and defense skills, as well as overall physical condition. Coaches are also responsible for improving their team by player development, strategy, and management in the game. Coaches also teach and inspire their team to perform at its best. Coaching is usually done by a single person, often with the help of one or more assistants.",
                        Price = 90.00M,
                        Time = "10 months",
                        ImgSubject = "https://res.cloudinary.com/grohealth/image/upload/f_auto,fl_lossy,q_auto/v1581678662/DCUK/Content/iStock-959080376.jpg",
                        ImgSubjectDetail = "https://raw.githubusercontent.com/nddat1908/T1908A_Sem3/master/ImageSubjectRYAN/basketball.png",
                        Category = "Indoor Sports"
                    },
                    new Subject
                    {
                        Name = "CLIMB THE MOUNTSIN",
                        Description = "Whoever you are, whether you've never climbed the mountain or conquered the toughest peaks, our indoor climbing center, I can provide you with everything you need to hone your climbing skills, hone every movement on the vertical climbing walls. The climbing path is marked with six different colors, based on the Fontainebleau scale. And lots of new climbing tracks are added every week, guaranteeing the best experience possible.",
                        Price = 150.00M,
                        Time = "4 months",
                        ImgSubject = "https://images.pexels.com/photos/4045339/pexels-photo-4045339.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                        ImgSubjectDetail = "https://github.com/nddat1908/T1908A_Sem3/blob/master/ImageSubjectRYAN/leonui.png?raw=true",
                        Category = "Indoor Sports"
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
                    },
                    new SportRoom
                    {
                        Name = "VAnh sports center",
                        Address = " Ha Noi",
                        Hotline = "113855646458"
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
                    },
                    new SubjectSportRoom
                    {
                        SportRoomId = 6,
                        SubjectId = 7
                    },
                    new SubjectSportRoom
                    {
                        SportRoomId = 6,
                        SubjectId = 8
                    },
                    new SubjectSportRoom
                    {
                        SportRoomId = 6,
                        SubjectId = 9
                    },
                    new SubjectSportRoom
                    {
                        SportRoomId = 6,
                        SubjectId = 10
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
                        LevelId = 1,
                    },
                    new Card
                    {
                        NumberCard = "RYAN120046557",
                        LevelId = 1
                    },
                    new Card
                    {
                        NumberCard = "RYAN120046558",
                        LevelId = 1
                    },
                    new Card
                    {
                        NumberCard = "RYAN120046559",
                        LevelId = 1
                    },
                    new Card
                    {
                        NumberCard = "RYAN12004650",
                        LevelId = 1
                    }
                );
                context.SaveChanges();
            }

            if (!context.Subscriptions.Any())
            {
                context.Subscriptions.AddRange(
                    new Subscription
                    {
                        CardId = 1,
                        RegistrationDate = DateTime.Parse("2019-12-22"),
                        EndDate = DateTime.Parse("2020-12-22")
                    },
                    new Subscription
                    {
                        CardId = 2,
                        RegistrationDate = DateTime.Parse("2020-02-25"),
                        EndDate = DateTime.Parse("2021-02-25")
                    }, new Subscription
                    {
                        CardId = 3,
                        RegistrationDate = DateTime.Parse("9-10-2019"),
                        EndDate = DateTime.Parse("9-10-2020")
                    }, new Subscription
                    {
                        CardId = 4,
                        RegistrationDate = DateTime.Parse("11-12-2019"),
                        EndDate = DateTime.Parse("11-12-2021")
                    },
                    new Subscription
                    {
                        CardId = 5,
                        RegistrationDate = DateTime.Parse("9-12-2019"),
                        EndDate = DateTime.Parse("9-12-2020")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
