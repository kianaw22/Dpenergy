using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.User
{
    public class ExternalLettersViewModel
    {

        public int LetterID { get; set; }

        [Display(Name = "موضوع نامه")]
        [Required(ErrorMessage = "This field is reqiured")]
        public string LetterSubject { get; set; }

        [Display(Name = "شرکت")]
        [Required(ErrorMessage = "This field is reqiured")]
        public string Company { get; set; }

        [Display(Name = "شخص")]
        [Required(ErrorMessage = "This field is reqiured")]
        public string Person { get; set; }

        [Display(Name = "سمت")]
        [Required(ErrorMessage = "This field is reqiured")]
        public string Position { get; set; }

        [Display(Name = "محتوای نامه")]
        [Required(ErrorMessage = "This field is reqiured")]
        public string LetterContent { get; set; }

        public string UserID { get; set; }
        //public string? UserID { get; set; }

        [Display(Name = "تاریخ نامه")]
        public DateTime LetterCreateDate { get; set; }

        public IList<string> Recipent { get; set; }

        public IEnumerable<IFormFile>Attachment { get; set; }




    }
}
