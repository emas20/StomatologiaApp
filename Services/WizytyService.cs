using Stomatologia.Data;
using Stomatologia.Interfaces;
using Stomatologia.Models;
using Stomatologia.Controllers;

namespace Stomatologia.Services
{
    public class WizytyService : IWizytyService
    {
        private readonly ApplicationDbContext _context;

        public WizytyService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void ZapiszWizyte(Wizyta wizyta)
        {
            Console.WriteLine("Próba zapisu wizyty do bazy danych...");
            Console.WriteLine($"Dane wizyty: StomatologId={wizyta.WybranyStomatologId}, Data={wizyta.WybranaData}, Godzina={wizyta.WybranaGodzina}");
            _context.Wizyty.Add(wizyta);
            Console.WriteLine($"Dane wizyty: StomatologId={wizyta.WybranyStomatologId}, Data={wizyta.WybranaData}, Godzina={wizyta.WybranaGodzina}");
            _context.SaveChanges();
            Console.WriteLine("Wizyta została zapisana do bazy danych.");
        }       
    }
}
