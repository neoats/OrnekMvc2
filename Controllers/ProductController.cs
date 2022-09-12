using Microsoft.AspNetCore.Mvc;
using ÖrnekProje2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ÖrnekProje2.Controllers
{
    public class ProductController : Controller
    {
       
        public string Email1 { get; set; }
        
     
        
        public IActionResult Index()
        {
            return View();
        }
     
        public IActionResult Validation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Validation(Productz model)
        {/* 
         
            Validation kurallarını if else switch ile yapma kod uzuyor
        */

        /*  if (!string.IsNullOrEmpty(model.ProductName) && model.ProductName.Length <= 100 && bool.Equals(model.Email,Email1))
            {
        
            }
        */
        //modelstate: mvc de bir type ın data annotationslarının durumunu kontrol eden ve geriye sonuç dönen bir prop
        //modelstate de values de gözüküyor valid invalid olanlar
        if(!ModelState.IsValid)
            {   //log
                //işlem exeküt
                //tercümesi hata alan kodun  hata kısmına data annotion errormesaj ını bind edip viewbagda yazdırıyoruz
                /* ViewBag.HataMesaj = ModelState.Values.FirstOrDefault(x =>x.ValidationState ==Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid).Errors[0].ErrorMessage;*/
                var message = ModelState.ToList();

                return View(model);
            }
            return View();
        }
    }
}
