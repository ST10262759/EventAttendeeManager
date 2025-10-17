using System;
using System.Collections.Generic;

namespace EventAttendeeManagerApp
{
    public class EventManager
    {
        private HashSet<string> attendees = new HashSet<string>();

        public void AddAttendee(string name)
        {
            if (attendees.Add(name))
            {
                Console.WriteLine($"✅ \"{name}\" has been registered successfully.\n");
            }
            else
            {
                Console.WriteLine($"⚠️ \"{name}\" is already registered.\n");
            }
        }

        public void RemoveAttendee(string name)
        {
            if (attendees.Remove(name))
            {
                Console.WriteLine($"🗑️ \"{name}\" has been removed.\n");
            }
            else
            {
                Console.WriteLine($"❌ \"{name}\" was not found in the registration list.\n");
            }
        }

        public void DisplayAllAttendees()
        {
            Console.WriteLine("\n--- Registered Attendees ---");
            if (attendees.Count == 0)
            {
                Console.WriteLine("No one is registered yet.\n");
            }
            else
            {
                foreach (var name in attendees)
                {
                    Console.WriteLine($"- {name}");
                }
                Console.WriteLine();
            }
        }
    }
}
