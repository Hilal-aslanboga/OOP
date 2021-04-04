using Abstract.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Entities.Concrete
{
    //Category sınıfına oluşturmuş olduğumuz BaseEntity sınıfı kalıtım verdi.
    //BaseEntity sınıfının namespace verdikten sonra Category Sınıfı altı kızarır. 
    //Çünkü BaseEntity sınıfında abstract olarak işaretlediğimiz bir üye bulunmakta o üye burda override edildi. 
    // Id üyesine kuralı bozmadan istediğim yetenekleri atayabilirim.
    public class Category : BaseEntity
    {
        public override Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
