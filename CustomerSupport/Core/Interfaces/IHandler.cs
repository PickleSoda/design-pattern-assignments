using CustomerSupport.Core.Entities;
namespace CustomerSupport.Core.Interfaces
{
    public interface IHandler
    {
        void SetNextHandler(IHandler handler);
        void HandleRequest(SupportRequest request);
    }
}
