using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_1.Models.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int? CategoryID { get; set; } //Foreign key'i kendiniz vermek istiyorsanız bunu otomatik tanıtmak icin uygulamanız gerekne isim standartı ilişkisel property ismi sonuna ID takısının gelmesidir...

        //Relatinonal Properties
        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }



    }
}
