using System;
using CustomerSupport.Core.Entities;
using CustomerSupport.Core.Interfaces;

namespace CustomerSupport.Application.Handlers
{
    public class Level1Support : IHandler
    {
        private IHandler _nextHandler;

        public void SetNextHandler(IHandler handler)
        {
            _nextHandler = handler;
        }

        public void HandleRequest(SupportRequest request)
        {
            if (request.Level == 1)
            {
                Console.WriteLine($"Level 1 support handled request: {request.Description}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
}
