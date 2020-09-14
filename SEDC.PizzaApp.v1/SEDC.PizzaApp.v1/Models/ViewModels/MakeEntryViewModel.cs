using SEDC.PizzaApp.v1.Models.Enums;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.v1.Models.ViewModels
{
    public class MakeEntryViewModel
    {
        [Display (Name = "Pizza Name: ")]
        public string PizzaName { get; set; }

        [Display(Name = "Price: ")]
        public double Price { get; set; }

        [Display(Name = "Size: ")]
        public PizzaSize Size { get; set; }

        


        
    }

    
}
