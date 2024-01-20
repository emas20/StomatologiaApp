using System.ComponentModel.DataAnnotations.Schema;

namespace Stomatologia.Models
{
    public class Wizyta
    {
            public int Id { get; set; }
            public DateTime WybranaData { get; set; }
            public string WybranaGodzina { get; set; }
       
        [Column("WybranyStomatologId")]
        public string WybranyStomatologId { get; set; }
        //public Stomatolog? Stomatolog { get; set; }
    }
    }

