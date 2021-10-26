using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using APS.DBS.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace APS.Web.MVC.Models
{
    public class PublicationsModel
    {

        /// <summary>
        /// Имя файла.
        /// </summary>
        [Required]
        [Display(Name = "Скачиваемый файл")]
        public string FileName { get; set; }

        /// <summary>
        /// Содержимое файла.
        /// </summary>
        [Display(Name = "Файл")]
        public byte[] FileContent { get; set; }

        /// <summary>
        /// Расширение файла.
        /// </summary>
        [Display(Name = "Расширение файла")]
        public string FileExtension { get; set; }


    }
}
