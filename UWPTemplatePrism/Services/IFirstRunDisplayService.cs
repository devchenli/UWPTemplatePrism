using System.Threading.Tasks;

namespace UWPTemplatePrism.Services
{
    public interface IFirstRunDisplayService
    {
        Task ShowIfAppropriateAsync();
    }
}
