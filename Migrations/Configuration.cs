namespace LFApplication.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LFApplication.Models.ItemDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LFApplication.Models.ItemDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            //}

            //    private void SeedAll(ItemDBContext context)
            //{
            //    var Item = new Item
            //    {
            //        Name = "Tocak",
            //        Comment = "Nasao sam tocak. ovo je opis o jednom tocku koji je mnogo velik, pa da vidim moze li stati u ovaj fild",
            //        Tag = "Tockovi",
            //        PersonName = "Meho",
            //        Email = "meho@meho.ba",
            //        Location = "Elidza",
            //        Id = "1",
            //        Phone = "062062062",
            //    };
            //    var Item2 = new Item
            //    {
            //        Name = "Guma",
            //        Comment = "Nasao sam gumu",
            //        Tag = "Tockovi",
            //        PersonName = "Memo",
            //        Email = "memo@meho.ba",
            //        Location = "Elidza",
            //        Id = "2",
            //        Phone = "062062111",
            //    };

            //    var Item3 = new Item
            //    {
            //        Name = "Volan",
            //        Comment = "Nasao sam volan",
            //        Tag = "Voloni",
            //        PersonName = "Kemo",
            //        Email = "kemo@meho.ba",
            //        Location = "Elidza",
            //        Id = "3",
            //        Phone = "0665598",
            //    };

            //    var Item4 = new Item
            //    {
            //        Name = "Volaaaaan",
            //        Comment = "Nasao sam volaaaaaaaaan",
            //        Tag = "Voloni",
            //        PersonName = "Keeeeemo",
            //        Email = "kemo@meho.ba",
            //        Location = "El-Elidza",
            //        Id = "3",
            //        Phone = "0665598",
            //    };

            //    var Item5 = new LostItem
            //    {
            //        Name = "Veeeelaaaaan",
            //        Comment = "Nasao sam voeeeelaaaaaaaaan",
            //        Tag = "Voloni",
            //        PersonName = "Hajro",
            //        Email = "kemo@meho.ba",
            //        Location = "El-Elidza",
            //        Id = "3",
            //        Phone = "0665598",
            //    };


            //    context.Items.AddOrUpdate(Item);
            //    context.Items.AddOrUpdate(Item2);
            //    context.Items.AddOrUpdate(Item3);
            //    context.Items.AddOrUpdate(Item4);

            //    context.LostItems.AddOrUpdate(Item5);
            //    context.SaveChanges();


            context.LostItems.AddOrUpdate(i => i.Name,
            new LostItem
            {
                Name = "Veeeolan",
                Comment = "Nasao sam veeeolan",
                Tag = "Voloni",
                PersonName = "hhaaaamo",
                Email = "kemo@kemo.ba",
                Location = "Elidza",
                Id = "23",
                Phone = "0665598",
            },
            new LostItem
            {
                Name = "Kauc",
                Comment = "Nasao sam kauc",
                Tag = "Voloni",
                PersonName = "hhaaaamo",
                Email = "kemo@meho.ba",
                Location = "Elidza",
                Id = "13",
                Phone = "0665598",
            },
            new LostItem
            {
                Name = "Kljuc",
                Comment = "Nasao sam puno kljucova",
                Tag = "Voloni",
                PersonName = "hhaaaamo",
                Email = "meho@meho.ba",
                Location = "Elidza",
                Id = "12",
                Phone = "0665598",
            }
            );
            

            context.Items.AddOrUpdate(i => i.Name,
                new Item
                {
                    Name = "Tocak",
                    Comment = "Nasao sam tocak. ovo je opis o jednom tocku koji je mnogo velik, pa da vidim moze li stati u ovaj fild",
                    Tag = "Tockovi",
                    PersonName = "Meho",
                    Email = "meho@meho.ba",
                    Location = "Elidza",
                    Id = "1",
                    Phone = "062062062",
                },

                new Item
                {
                    Name = "Guma",
                    Comment = "Nasao sam gumu",
                    Tag = "Tockovi",
                    PersonName = "Memo",
                    Email = "memo@meho.ba",
                    Location = "Elidza",
                    Id = "2",
                    Phone = "062062111",
                },

                new Item
                {
                    Name = "Volan",
                    Comment = "Nasao sam volan",
                    Tag = "Voloni",
                    PersonName = "Kemo",
                    Email = "kemo@meho.ba",
                    Location = "Elidza",
                    Id = "3",
                    Phone = "0665598",
                }


            );

        }
    }

    }
