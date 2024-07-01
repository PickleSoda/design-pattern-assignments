using System;
using CustomerSupport.Core.Entities;
using CustomerSupport.Core.Interfaces;

namespace CustomerSupport
{
    public class Level3Support : IHandler
    {
        private IHandler _nextHandler;

        public void SetNextHandler(IHandler handler)
        {
            _nextHandler = handler;
        }

        public void HandleRequest(SupportRequest request)
        {
            if (request.Level == 3)
            {
                Console.WriteLine($"Level 3 support handled request: {request.Description}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
}
