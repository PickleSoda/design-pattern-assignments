using System;
using CustomerSupport;
using CustomerSupport.Core.Entities;
using CustomerSupport.Core.Interfaces;
using CustomerSupport.Application.Handlers;

class Program
{
    static void Main()
    {
        // Create handlers
        IHandler level1Support = new Level1Support();
        IHandler level2Support = new Level2Support();
        IHandler level3Support = new Level3Support();

        // Set up chain of responsibility
        level1Support.SetNextHandler(level2Support);
        level2Support.SetNextHandler(level3Support);

        // Create support requests
        SupportRequest request1 = new SupportRequest(1, "Basic issue");
        SupportRequest request2 = new SupportRequest(2, "Intermediate issue");
        SupportRequest request3 = new SupportRequest(3, "Advanced issue");

        // Process requests
        level1Support.HandleRequest(request1);
        level1Support.HandleRequest(request2);
        level1Support.HandleRequest(request3);
    }
}
