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
        [Display(Name = "Имя файла")]
        public string FileName { get; set; }

        /// <summary>
        /// Признак публичной доступности файла.
        /// </summary>
        [Display(Name = "Общедоступный файл?")]
        public bool IsPublic { get; set; }

        /// <summary>
        /// Загружаемый файл.
        /// </summary>
        [Display(Name = "Загружаемый файл")]
        public IFormFile UploadFile { get; set; }


    }
}
