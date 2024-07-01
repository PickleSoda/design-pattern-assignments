using System;
using CustomerSupport.Core.Entities;
using CustomerSupport.Core.Interfaces;

namespace CustomerSupport
{
    public class Level2Support : IHandler
    {
        private IHandler _nextHandler;

        public void SetNextHandler(IHandler handler)
        {
            _nextHandler = handler;
        }

        public void HandleRequest(SupportRequest request)
        {
            if (request.Level == 2)
            {
                Console.WriteLine($"Level 2 support handled request: {request.Description}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
}
