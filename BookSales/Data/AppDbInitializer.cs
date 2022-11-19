using BookSales.Data.Enums;
using BookSales.Models;

namespace BookSales.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            Name = "J.K.Rowling",
                            PictureUrl = "https://media-cldnry.s-nbcnews.com/image/upload/newscms/2020_26/3155921/191219-j-k-rowling-2018-ac-845p.jpg",
                            Bio = "Joanne Rowling CH OBE FRSL, also known by her pen name J. K. Rowling, is a British author and philanthropist. She wrote Harry Potter, a seven-volume children's fantasy series published from 1997 to 2007."
                        },
                        new Author()
                        {
                            Name = "A.C.Doyle",
                            PictureUrl = "https://victorianweb.org/painting/portraits/arthurconandoyle.jpg",
                            Bio = "Sir Arthur Ignatius Conan Doyle KStJ DL (22 May 1859 – 7 July 1930) was a British writer and physician. He created the character Sherlock Holmes in 1887 for A Study in Scarlet, the first of four novels and fifty-six short stories about Holmes and Dr. Watson. The Sherlock Holmes stories are milestones in the field of crime fiction."
                        },
                        new Author()
                        {
                            Name = "Ray Bradbury",
                            PictureUrl = "https://upload.wikimedia.org/wikipedia/commons/6/69/Ray_Bradbury_%281975%29_-cropped-.jpg",
                            Bio = "Ray Douglas Bradbury was an American author and screenwriter. One of the most celebrated 20th-century American writers, he worked in a variety of modes, including fantasy, science fiction, horror, mystery, and realistic fiction."
                        },
                        new Author()
                        {
                            Name = "George Orwell",
                            PictureUrl = "https://www.biography.com/.image/ar_1:1%2Cc_fill%2Ccs_srgb%2Cfl_progressive%2Cq_auto:good%2Cw_1200/MTgwNzU5NDU4MjAzMzEzNTEy/george-orwell.jpg",
                            Bio = "Eric Arthur Blair, better known by his pen name George Orwell, was an English novelist, essayist, journalist, and critic. His work is characterised by lucid prose, social criticism, opposition to totalitarianism, and support of democratic socialism."
                        }
                    });
                }

                if (!context.Translators.Any())
                {
                    context.Translators.AddRange(new List<Translator>()
                    {
                        new Translator()
                        {
                            Name = "Elizabeth",
                            PictureUrl = "https://atlasls.com/wp-content/uploads/2021/06/Reliable-Translation-Services-AdobeStock_439069626-1024x683.jpeg",
                            Bio = ""
                        },
                        new Translator()
                        {
                            Name = "Lisa",
                            PictureUrl = "https://static01.nyt.com/images/2022/03/07/books/00Ukraine1/merlin_203352840_8b19dc00-cde6-4b35-af78-f0816594a747-articleLarge.jpg?quality=75&auto=webp&disable=upscale",
                            Bio = ""
                        },
                        new Translator()
                        {
                            Name = "Adams",
                            PictureUrl = "https://algorithmwatch.org/en/wp-content/uploads/2021/03/wp-AW_icons8-team-m0oSTE_MjsI-unsplash.jpg",
                            Bio = ""
                        },
                        new Translator()
                        {
                            Name = "Alice",
                            PictureUrl = "https://vmentoring.com/wp-content/uploads/2020/11/Fully-Booked-Translator-Formula.jpg",
                            Bio = ""
                        }
                    });
                }

                if (!context.PrintHouses.Any())
                {
                    context.PrintHouses.AddRange(new List<PrintHouse>()
                    {
                        new PrintHouse()
                        {
                            Name = "Qanun publishing house",
                            PictureUrl = "https://alsan.az/image/cache/catalog/Marka%20Logo/Qanun%20Nesriyyati%20Logo-200x200h.jpg",
                            About = "Qanun nəşriyyatı bütün sahələrdə: bədii ədəbiyyat, fəlsəfə, tarix, iqtisadiyyat, tibb, coğrafiya, elmi-fantastika, uşaq ədəbiyyatı, din, mətbəx və sağlamlıqla bağlı kitablar nəşr etməklə fəaliyyətini ilbəil genişləndirir. “Qanun” nəşriyyatının gənclərlə bağlı başladığı “birinci kitab” və “ən yeni ədəbiyyat” seriyası cəmiyyətdə populyarlıq qazanmışdır."
                        },
                        new PrintHouse()
                        {
                            Name = "Teaspress publishing house",
                            PictureUrl = "https://cdn.trend.az/2018/04/16/teas_logo_160418.jpg",
                            About = "Azərbaycanın müasir nəşriyyat sferasında ən qabaqcıl nəşriyyat evinə çevrilən və özünəməxsus dəst-xətti olan \"TEAS Press\" Nəşriyyat Evi Azərbaycanda kitabçılıq işinə dəstək vermək, xarici dillərdən akademik və müxtəlif nəşrlərin Azərbaycan dilinə yüksək keyfiyyətlə tərcüməsi və nəşri, həmçinin Azərbaycanın xaricdə tanıdılmasına töhfə vermək məqsədilə Avropa Azərbaycan Cəmiyyəti tərəfindən 2014-cü ildən təsis edilmişdir."
                        },
                        new PrintHouse()
                        {
                            Name = "Parlaq imzalar publishing house",
                            PictureUrl = "https://yt3.ggpht.com/ytc/AMLnZu8ziOyJ4l1v_sm13NKT8w4U9a1toKkHhGRHrnU8VA=s900-c-k-c0x00ffffff-no-rj",
                            About = "Cəmiyyətimizin xilasının, parlaq gələcəyimizin yalnız kitabla mümkün olduğunu dərk edərək, kitab qoxusu ilə məst olan bir kollektivlə, elə də asan olmayacağını anladığımız bu məsuliyyətli işə başladıq.\r\nMəqsədimiz kitabın bir dəyər olduğunu çatdırmaq, kitabsız bir insanın ruhsuz bədən olduğunu anlatmaq, ölkə kitabçılığına yeni bir nəfəs gətirməkdir."
                        },
                        new PrintHouse()
                        {
                            Name = "Ali Nino publishing house",
                            PictureUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRr6RvMPnHwJ2PgiaYhFup9VbbagcryNNwKKQ&usqp=CAU",
                            About = "Musiqi ilə istirahət etməyi sevənlərin, ruhunu əsl musiqi ilə dincəltmək istəyənlərin sevimli əşyalarından biri də klassik dövrdən bu günədək hələ də öz aktuallığını qoruyub saxlayan qrammofonlardır."
                        },
                    });

                    if (!context.Books.Any())
                    {
                        context.Books.AddRange(new List<Book>()
                        {
                            new Book()
                            {
                                Name = "1984",
                                PictureUrl = "https://upload.wikimedia.org/wikipedia/az/thumb/a/a5/Corc_Oruell._1984.jpg/250px-Corc_Oruell._1984.jpg",
                                Description = "Nineteen Eighty-Four is a dystopian social science fiction novel and cautionary tale written by the English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.",
                                PageNumber = 394,
                                Price = 10,
                                BookCategory = BookCategory.Fantasy,
                                AuthorId = 4,
                                TranslatorId = 4,
                                PrintHouseId = 1
                            },
                            new Book()
                            {
                                Name = "Harry Potter and the Philosopher's stone",
                                PictureUrl = "https://tr.web.img2.acsta.net/pictures/bzp/01/29276.jpg",
                                Description = "Harry Potter and the Philosopher's Stone is a 2001 fantasy film directed by Chris Columbus and distributed by Warner Bros. Pictures, based on J. K. Rowling's 1997 novel of the same name. Produced by David Heyman and written by Steve Kloves, it is the first instalment of the Harry Potter film series.",
                                PageNumber = 274,
                                Price = 15,
                                BookCategory = BookCategory.Fantasy,
                                AuthorId = 1,
                                TranslatorId = 1,
                                PrintHouseId = 1
                            }
                        });
                    }
                }
            }
        }
    }
}
