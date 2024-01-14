﻿using Stomatologia.Data;
using Stomatologia.Interfaces;
using Stomatologia.Models;

namespace Stomatologia.Services
{
    public class WizytyService : IWizytyService
    {
        private readonly ApplicationDbContext _context;

        public WizytyService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void ZapiszWizyte(UmowWizyteViewModel wizyta)
        {
            _context.Wizyty.Add(wizyta);
            _context.SaveChanges();
        }

        void IWizytyService.ZapiszWizyte(UmowWizyteViewModel wizyta)
        {
            throw new NotImplementedException();
        }

        void IWizytyService.ZapiszWizyte(object wizyta)
        {
            throw new NotImplementedException();
        }
    }
}
