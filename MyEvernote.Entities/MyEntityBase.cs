using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvernote.Entities
{
    public class MyEntityBase
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)] //primary key ve otomatik artan kolon olmasini sagladik.
        public int Id { get; set; }

        [Required]  //Bos gecilemez demektir.
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime ModifiedOn { get; set; }

        [Required,StringLength(30)] //kullanici adini 30 karakterler sinirladik.
        public string ModifiedUsername { get; set; }
    }
}
