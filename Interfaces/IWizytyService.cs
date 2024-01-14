using Stomatologia.Models;
namespace Stomatologia.Interfaces
{
    public interface IWizytyService
    {
    void ZapiszWizyte(UmowWizyteViewModel wizyta);
        void ZapiszWizyte(object wizyta);
    }

}
