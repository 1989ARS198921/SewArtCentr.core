using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SewArtCentr.Models
{
    public class SampleData
    {
        public static void Initialize(FashionContext context)
        {
            if (!context.FashionColls.Any())
            {
                context.FashionColls.AddRange(
                    new FashionColl
                    {
                        Name = "Осенняя",
                        Year = "2000",
                        Price = 1500
                    },
                    new FashionColl
                    {
                        Name = "Летняя",
                        Year = "1979",
                        Price = 3000

                    }
                    );
            context.SaveChanges();



            

            }
        }
    }
}
