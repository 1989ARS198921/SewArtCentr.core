using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SewArtCentr.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string User { get; set; }//Имя Фамилия покупателя
        public string Address { get; set; }// Адресс покупателя
        public string ConactPhone { get; set; }

        public int FashionID { get; set; }//ссылка на связанную модель Fashion
        public FashionColl FashionColl { get; set; }

    }
}
