using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace LFApplication.Models
{
    public class Item
    {
        //[Display(Name = "Release Date")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        [Required(ErrorMessage = "ID is required")]
        public string Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Tag is required")]
        public string Tag { get; set; }
        public byte[] Image { get; set; }

        public string Comment { get; set; }
        private int CommentCut = 20;
        [Display(Name = "Comment")]
        public string CommentCutOut
        {
            get
            {
                if (this.Comment.Length > this.CommentCut)
                    return this.Comment.Substring(0, this.CommentCut) + " ...";
                else
                    return this.Comment;
            }
        }

        [Required(ErrorMessage = "Contact name is required")]
        public string PersonName { get; set; }
        [Required(ErrorMessage = "Contact email is required")]
        public string Email { get; set; }
        public string Phone { get; set; }


        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime DateCreated { get; set; }
    }

    public class LostItem
    {
        //[Display(Name = "Release Date")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        [Required(ErrorMessage = "ID is required")]
        public string Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Tag is required")]
        public string Tag { get; set; }
        public byte[] Image { get; set; }

        public string Comment { get; set; }
        private int CommentCut = 20;
        [Display(Name = "Comment")]
        public string CommentCutOut
        {
            get
            {
                if (this.Comment.Length > this.CommentCut)
                    return this.Comment.Substring(0, this.CommentCut) + " ...";
                else
                    return this.Comment;
            }
        }

        [Required(ErrorMessage = "Contact name is required")]
        public string PersonName { get; set; }
        [Required(ErrorMessage = "Contact email is required")]
        public string Email { get; set; }
        public string Phone { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime DateCreated { get; set; }
    }


    public class ItemDBContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<LostItem> LostItems { get; set; }
    }
}