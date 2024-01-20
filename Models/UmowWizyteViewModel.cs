using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stomatologia.Models
{
    public class UmowWizyteViewModel
    {
        public string? Id { get; set; }
        public IEnumerable<Stomatolog>? DostepniStomatolodzy { get; set; }

        [Required(ErrorMessage = "Wybierz datę.")]
        public DateTime WybranaData { get; set; }

        [Required(ErrorMessage = "Wybierz godzinę.")]
        public string? WybranaGodzina { get; set; }
        
        [Required(ErrorMessage = "Wybierz stomatologa.")]
        [Column("WybranyStomatologId")]
        public string? WybranyStomatologId { get; set; }

        //public IEnumerable<string>? DostepneGodziny { get; set; }
        public Stomatolog? Stomatolog { get; set; }
    }
}
