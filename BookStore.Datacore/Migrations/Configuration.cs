namespace BookStore.Datacore.Migrations
{
    using BookStore.Domain.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookStore.Datacore.Context.BookStoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookStore.Datacore.Context.BookStoreDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //adding mastercategories
            //context.MasterCategories.AddOrUpdate(x => x.Name,
            //    new MasterCategory
            //    {
            //        Name = "Literature"
            //    },
            //    new MasterCategory
            //    {
            //        Name = "Science"
            //    },
            //    new MasterCategory
            //    {
            //        Name = "Religious"
            //    },
            //    new MasterCategory
            //    {
            //        Name = "Fantastic-Adventure"
            //    },
            //    new MasterCategory
            //    {
            //        Name = "Personal Development"
            //    },
            //    new MasterCategory
            //    {
            //        Name = "Research - History"
            //    },
            //    new MasterCategory
            //    {
            //        Name = "Art - Design"
            //    },
            //    new MasterCategory
            //    {
            //        Name = "Philosophy"
            //    },
            //    new MasterCategory
            //    {
            //        Name = "Educational"
            //    },
            //    new MasterCategory
            //    {
            //        Name = "Foreign Languages"
            //    },
            //    new MasterCategory
            //    {
            //        Name = "Children's and Youth"
            //    },
            //    new MasterCategory
            //    {
            //        Name = "Course-Examination"
            //    },
            //    new MasterCategory
            //    {
            //        Name = "Prestige"
            //    },
            //    new MasterCategory
            //    {
            //        Name = "Comics"
            //    },
            //     new MasterCategory
            //     {
            //         Name = "Humor"
            //     },

            //     new MasterCategory
            //     {
            //         Name = "Hobby"
            //     });

            ////add categories
            //context.Categories.AddOrUpdate(x => x.Name,
            //    new Category
            //    {
            //        Name = "Novel",
            //        MasterCategoryId = 1
            //    },
            //    new Category
            //    {
            //        Name = "Poem",
            //        MasterCategoryId = 1
            //    },
            //    new Category
            //    {
            //        Name = "Essay",
            //        MasterCategoryId = 1
            //    },
            //    new Category
            //    {
            //        Name = "Biography",
            //        MasterCategoryId = 1
            //    },
            //    new Category
            //    {
            //        Name = "Narrative",
            //        MasterCategoryId = 1
            //    },
            //    new Category
            //    {
            //        Name = "Turkish Literature",
            //        MasterCategoryId = 1
            //    },
            //    new Category
            //    {
            //        Name = "World Literature",
            //        MasterCategoryId = 1
            //    },
            //    new Category
            //    {
            //        Name = "Engineer",
            //        MasterCategoryId = 2
            //    },
            //    new Category
            //    {
            //        Name = "Archaeology",
            //        MasterCategoryId = 2
            //    },
            //    new Category
            //    {
            //        Name = "Ecology",
            //        MasterCategoryId = 2
            //    },
            //    new Category
            //    {
            //        Name = "Biology",
            //        MasterCategoryId = 2
            //    },
            //    new Category
            //    {
            //        Name = "Chemistry",
            //        MasterCategoryId = 2
            //    },
            //    new Category
            //    {
            //        Name = "Physics",
            //        MasterCategoryId = 2
            //    },
            //    new Category
            //    {
            //        Name = "Geography",
            //        MasterCategoryId = 2
            //    },
            //    new Category
            //    {
            //        Name = "Meteorological",
            //        MasterCategoryId = 2
            //    },
            //    new Category
            //    {
            //        Name = "Zoology",
            //        MasterCategoryId = 2
            //    },
            //    new Category
            //    {
            //        Name = "Astronomy",
            //        MasterCategoryId = 2
            //    },
            //    new Category
            //    {
            //        Name = "Anatomy",
            //        MasterCategoryId = 2
            //    },

            //    new Category
            //    {
            //        Name = "Scientists",
            //        MasterCategoryId = 2
            //    },
            //    new Category
            //    {
            //        Name = "Mathematics",
            //        MasterCategoryId = 2
            //    },
            //    new Category
            //    {
            //        Name = "Islam",
            //        MasterCategoryId = 3
            //    },
            //    new Category
            //    {
            //        Name = "Christianity",
            //        MasterCategoryId = 3
            //    },
            //    new Category
            //    {
            //        Name = "Sufism",
            //        MasterCategoryId = 3
            //    },
            //    new Category
            //    {
            //        Name = "Judaism",
            //        MasterCategoryId = 3
            //    },
            //     new Category
            //     {
            //         Name = "Buudhism",
            //         MasterCategoryId = 3
            //     },
            //     new Category
            //     {
            //         Name = "Clergymen",
            //         MasterCategoryId = 3
            //     },
            //     new Category
            //     {
            //         Name = "Fantastical",
            //         MasterCategoryId = 4
            //     },
            //     new Category
            //     {
            //         Name = "Adventure",
            //         MasterCategoryId = 4
            //     },
            //     new Category
            //     {
            //         Name = "No subcategory :)",
            //         MasterCategoryId = 5
            //     },
            //     new Category
            //     {
            //         Name = "Politics and Current Affairs",
            //         MasterCategoryId = 6
            //     },
            //     new Category
            //     {
            //         Name = "History & Military",
            //         MasterCategoryId = 6
            //     },
            //     new Category
            //     {
            //         Name = "Biography (History)",
            //         MasterCategoryId = 6
            //     },
            //     new Category
            //     {
            //         Name = "History",
            //         MasterCategoryId = 6
            //     },
            //     new Category
            //     {
            //         Name = "Sociology",
            //         MasterCategoryId = 6
            //     },
            //     new Category
            //     {
            //         Name = "Ethnology",
            //         MasterCategoryId = 6
            //     },
            //     new Category
            //     {
            //         Name = "Historical Persons",
            //         MasterCategoryId = 6
            //     },
            //     new Category
            //     {
            //         Name = "Ottoman History",
            //         MasterCategoryId = 6
            //     },
            //     new Category
            //     {
            //         Name = "World History",
            //         MasterCategoryId = 6
            //     },
            //     new Category
            //     {
            //         Name = "Turkish History",
            //         MasterCategoryId = 6
            //     },
            //     new Category
            //     {
            //         Name = "Republic History",
            //         MasterCategoryId = 6
            //     },
            //      new Category
            //     {
            //         Name = "Artists",
            //         MasterCategoryId = 7
            //     },
            //     new Category
            //     {
            //         Name = "Theatre",
            //         MasterCategoryId = 7
            //     },
            //     new Category
            //     {
            //         Name = "Music",
            //         MasterCategoryId = 7
            //     },
            //     new Category
            //     {
            //         Name = "Cinema",
            //         MasterCategoryId = 7
            //     },
            //     new Category
            //     {
            //         Name = "Art History",
            //         MasterCategoryId = 7
            //     },
            //     new Category
            //     {
            //         Name = "Architecture",
            //         MasterCategoryId = 7
            //     },
            //     new Category
            //     {
            //         Name = "Photography",
            //         MasterCategoryId = 7
            //     },
            //     new Category
            //     {
            //         Name = "Painting-Plastic Art",
            //         MasterCategoryId = 7
            //     },
            //     new Category
            //     {
            //         Name = "Philosophical Science",
            //         MasterCategoryId = 8
            //     },
            //     new Category
            //     {
            //         Name = "Wisdom",
            //         MasterCategoryId = 8
            //     },
            //     new Category
            //     {
            //         Name = "Philosophers",
            //         MasterCategoryId = 8
            //     },
            //     new Category
            //     {
            //         Name = "Philosophical Novels",
            //         MasterCategoryId = 8
            //     },
            //     new Category
            //     {
            //         Name = "Philosophical Publications",
            //         MasterCategoryId = 8
            //     },
            //      new Category
            //     {
            //         Name = "Business Economics-Law",
            //         MasterCategoryId = 9
            //     },
            //     new Category
            //     {
            //         Name = "Family-Children",
            //         MasterCategoryId = 9
            //     },
            //     new Category
            //     {
            //         Name = "Psychological Science",
            //         MasterCategoryId = 9
            //     },
            //     new Category
            //     {
            //         Name = "Health",
            //         MasterCategoryId = 9
            //     },
            //     new Category
            //     {
            //         Name = "Linguistics(philology)",
            //         MasterCategoryId = 9
            //     },
            //     new Category
            //     {
            //         Name = "Sightseeing(trip)",
            //         MasterCategoryId = 9
            //     },
            //     new Category
            //     {
            //         Name = "Dictionary",
            //         MasterCategoryId = 9
            //     },
            //     new Category
            //     {
            //         Name = "Encyclopedia",
            //         MasterCategoryId = 9
            //     },
            //      new Category
            //     {
            //         Name = "Language",
            //         MasterCategoryId = 10
            //     },
            //     new Category
            //     {
            //         Name = "Literature and Novel",
            //         MasterCategoryId = 10
            //     },
            //     new Category
            //     {
            //         Name = "Other Languages",
            //         MasterCategoryId = 10
            //     },
            //     new Category
            //     {
            //         Name = "Reference",
            //         MasterCategoryId = 10
            //     },
            //     new Category
            //     {
            //         Name = "Hobby",
            //         MasterCategoryId = 10
            //     },
            //     new Category
            //     {
            //         Name = "History",
            //         MasterCategoryId = 10
            //     },
            //     new Category
            //     {
            //         Name = "Food and Beverage",
            //         MasterCategoryId = 10
            //     },
            //     new Category
            //     {
            //         Name = "Graphic Novel",
            //         MasterCategoryId = 10
            //     },
            //     new Category
            //     {
            //         Name = "School Age 6-10 Years",
            //         MasterCategoryId = 11
            //     },
            //     new Category
            //     {
            //         Name = "Preschool 6 Months - 5 Years",
            //         MasterCategoryId = 11
            //     },
            //     new Category
            //     {
            //         Name = "Youth 10 + Years",
            //         MasterCategoryId = 11
            //     },
            //     new Category
            //     {
            //         Name = "School Books",
            //         MasterCategoryId = 11
            //     },
            //     new Category
            //     {
            //         Name = "Textbooks/Tests (1st.grade-12.grade)",
            //         MasterCategoryId = 12
            //     },
            //     new Category
            //     {
            //         Name = "University Books",
            //         MasterCategoryId = 12
            //     },
            //     new Category
            //     {
            //         Name = "Exam Books",
            //         MasterCategoryId = 12
            //     },
            //     new Category
            //     {
            //         Name = "Art Prestige",
            //         MasterCategoryId = 13
            //     },
            //     new Category
            //     {
            //         Name = "History Prestige",
            //         MasterCategoryId = 13
            //     },
            //     new Category
            //     {
            //         Name = "Photographic Prestige",
            //         MasterCategoryId = 13
            //     },
            //     new Category
            //     {
            //         Name = "Turkey Prestige",
            //         MasterCategoryId = 13
            //     },
            //     new Category
            //     {
            //         Name = "Countries-Cities Prestige",
            //         MasterCategoryId = 13
            //     },
            //     new Category
            //     {
            //         Name = "Nature prestige",
            //         MasterCategoryId = 13
            //     },
            //     new Category
            //     {
            //         Name = "Museums",
            //         MasterCategoryId = 13
            //     },
            //     new Category
            //     {
            //         Name = "Other Prestige",
            //         MasterCategoryId = 13
            //     },
            //     new Category
            //     {
            //         Name = "No subcategory",
            //         MasterCategoryId = 14
            //     },
            //      new Category
            //     {
            //         Name = "Humor Novel-Story",
            //         MasterCategoryId = 15
            //     },
            //     new Category
            //     {
            //         Name = "Cartoon",
            //         MasterCategoryId = 15
            //     },
            //     new Category
            //     {
            //         Name = "Jokes",
            //         MasterCategoryId = 15
            //     },
            //     new Category
            //     {
            //         Name = "Food",
            //         MasterCategoryId = 16
            //     },
            //     new Category
            //     {
            //         Name = "Sports",
            //         MasterCategoryId = 16
            //     },
            //     new Category
            //     {
            //         Name = "General Interests",
            //         MasterCategoryId = 16
            //     },
            //     new Category
            //     {
            //         Name = "Art",
            //         MasterCategoryId = 16
            //     },
            //     new Category
            //     {
            //         Name = "Astronomy",
            //         MasterCategoryId = 16
            //     },
            //     new Category
            //     {
            //         Name = "Crafts",
            //         MasterCategoryId = 16
            //     },
            //     new Category
            //     {
            //         Name = "Puzzles",
            //         MasterCategoryId = 16
            //     },
            //     new Category
            //     {
            //         Name = "Games",
            //         MasterCategoryId = 16
            //     },
            //     new Category
            //     {
            //         Name = "Animal Kingdom",
            //         MasterCategoryId = 16
            //     },
            //     new Category
            //     {
            //         Name = "Fashion",
            //         MasterCategoryId = 16
            //     }
            //    );
            //add spesificcategories
            //context.SpesificCategories.AddOrUpdate(x => x.Name,
            //    new SpesificCategory
            //    {
            //        Name = "Turkish Novel",
            //        CategoryId = 1,
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "World Novel",
            //        CategoryId = 1
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Turkish Classic",
            //        CategoryId = 1
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "World Classic",
            //        CategoryId = 1
            //    },
            //    new SpesificCategory
            //    {
            //        Name = " Romantic",
            //        CategoryId = 1
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Police",
            //        CategoryId = 1
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Fantastic",
            //        CategoryId = 1
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Horror-Thriller",
            //        CategoryId = 1
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Science-Fiction",
            //        CategoryId = 1
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Adventure",
            //        CategoryId = 1
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Turkish Poem",
            //        CategoryId = 2
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "World Poem",
            //        CategoryId = 2
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Turkey Policy",
            //        CategoryId = 29
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "World Policy",
            //        CategoryId = 29
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "International Relations",
            //        CategoryId = 29
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "European Union",
            //        CategoryId = 29
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Non-Governmental Organizations",
            //        CategoryId = 29
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Statesmen",
            //        CategoryId = 29
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Turkish Plays",
            //        CategoryId = 41
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "World Plays",
            //        CategoryId = 41
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Theatre Techniques",
            //        CategoryId = 41
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Law ",
            //        CategoryId = 53
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Management and Business Development",
            //        CategoryId = 53
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Economics",
            //        CategoryId = 53
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Media",
            //        CategoryId = 53
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Finance",
            //        CategoryId = 53
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Communication",
            //        CategoryId = 53
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Human Resources",
            //        CategoryId = 53
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Foreign Trade Techniques",
            //        CategoryId = 53
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Female-Male Relations",
            //        CategoryId = 54
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Pregnancy",
            //        CategoryId = 54
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Sexuality",
            //        CategoryId = 54
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Adolescence",
            //        CategoryId = 54
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Physical Health",
            //        CategoryId = 56
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Nutrition Dietetics",
            //        CategoryId = 56
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Mental Health",
            //        CategoryId = 56
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Guide",
            //        CategoryId = 58
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Turkey",
            //        CategoryId = 58
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "World",
            //        CategoryId = 58
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Graded Reader",
            //        CategoryId = 61
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Phrase Book and Language",
            //        CategoryId = 61
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Grammar and Vocabulary",
            //        CategoryId = 61
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Dictionary",
            //        CategoryId = 61
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Classics",
            //        CategoryId = 62
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Mystery/Crime/Thriller",
            //        CategoryId = 62
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Fantasy",
            //        CategoryId = 62
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Romance",
            //        CategoryId = 62
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Sci-Fi&Fantasy",
            //        CategoryId = 62
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Biography, Autobiography and Memoirs",
            //        CategoryId = 62
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Philosophy Fiction",
            //        CategoryId = 62
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Poems",
            //        CategoryId = 62
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Russian",
            //        CategoryId = 63
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Arabic",
            //        CategoryId = 63
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "German",
            //        CategoryId = 63
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "French",
            //        CategoryId = 63
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Italian",
            //        CategoryId = 63
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "French",
            //        CategoryId = 63
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Chinese",
            //        CategoryId = 63
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Dutch",
            //        CategoryId = 63
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Story",
            //        CategoryId = 69
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Education - Activity",
            //        CategoryId = 69
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Fantastic - Science",
            //        CategoryId = 69
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Comics-Humor",
            //        CategoryId = 69
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Language",
            //        CategoryId = 69
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Fairytale",
            //        CategoryId = 70
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Moving Books",
            //        CategoryId = 70
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Preschool",
            //        CategoryId = 70
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Novel-Story",
            //        CategoryId = 71
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Fantasy - Science Fiction",
            //        CategoryId = 71
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Education - Activity",
            //        CategoryId = 71
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "World Classic",
            //        CategoryId = 71
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Turkish Classic",
            //        CategoryId = 71
            //    },
            //    new SpesificCategory
            //    {
            //        Name = "Poetry",
            //        CategoryId = 71
            //    }


            //);

            //context.ProductImages.AddOrUpdate(x => x.Path,
            //    new ProductImage
            //    {
            //        Path = "/Content/assets/img/ShopPageImages/xyzbook.jpeg",
            //        Product = new Product
            //        {
            //            Title = "X.Y.Z",
            //            Author = "Anna Katharine Green",
            //            Description = "Amazing",
            //            Price = 10.00,
            //            SpesificCategoryId = 10,
            //            PublishingHouse = new PublishingHouse
            //            {
            //                Name = "Tutku"
            //            },

            //        }

            //    },
            //     new ProductImage
            //     {
            //         Path = "/Content/assets/img/ShopPageImages/akiloyunlaribook.jpeg",
            //         Product = new Product
            //         {
            //             Title = "Akýl Oyunlarý",
            //             Author = "Daniel Palmer",
            //             Description = "Amazing",
            //             Price = 20.00,
            //             SpesificCategoryId = 10,
            //             PublishingHouse = new PublishingHouse
            //             {
            //                 Name = "Koridor"
            //             }
            //}
            //});
        }
    }
}
