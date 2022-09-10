using Microsoft.AspNetCore.Mvc;
using ÖrnekProje2.Models.ModelMetaDataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Twilio.TwiML.Voice;

namespace ÖrnekProje2.Models
{
    [ModelMetadataType(typeof(ProductMMDT))]
    public class Productz
    { /*
       VIEWMODEL
       ENTITY
       PRODUCTZ NESNESİ
       entity kısmında validation önerilmez
        entity validasyondan arındırılıp daha temiz hala getirilmekte
        metadatype değil model metadata olucak modelden çekicek
      */
        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public string Email { get; set; }

        public int KeyN { get; set; }


    }
}
