# 🎉 Event Attendee Manager

## 🧩 Objective
A simple **C# console application** to manage event attendees using a `HashSet<string>` to prevent duplicate registrations.

---

## 🚀 Features
- ✅ Add attendees (no duplicates allowed)
- 🗑️ Remove attendees
- 📋 Display all registered attendees
- 🔁 Simple menu-driven interface

---

## ⚙️ How to Run
1. Open **Visual Studio** or **VS Code**.
2. Create a new **Console App** project named `EventAttendeeManagerApp`.
3. Replace the default `Program.cs` with the files provided.
4. Run the project (Ctrl + F5).

---

## 🧠 Explanation
- The `EventManager` class uses a `HashSet<string>` to store names.
- `AddAttendee()` checks for duplicates automatically.
- `RemoveAttendee()` deletes entries if they exist.
- `DisplayAllAttendees()` lists all registered names neatly.

---

## 🔒 Example Output
