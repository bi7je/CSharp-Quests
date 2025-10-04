# ☕ Design Scroll — Quest 01: The Dungeon Doors

> *“Three doors stand before you, Apprentice. Code them wisely, for each line you write is a key that might open freedom—or unleash bugs untold.”*

---

## 📜 The Story & Purpose

You find yourself deep beneath the mountain of logic and syntax, standing before three colossal Dungeon Doors.  
Each is bound by ancient runes and responds only to code of precise intent.  
To leave this place, you must breathe life into your creations—teaching your program to understand what it means to open, close, and inspect a door.

The purpose of this quest is to build a small C# console application that models **interactive doors** using **classes and objects**.  
Through this, you’ll learn to bind data and behavior together—the essence of **encapsulation**—and to manage **state** within an object’s lifecycle.

---

## ⚙️ The Tools of Design

### 🧩 The Main Actors

1. **Door (Class)**  
   The heart of the quest. A Door remembers its nature and reacts to commands.
   - **Properties:**  
     - `bool IsOpen` — determines whether the door currently stands open or closed.  
     - `string Material` — describes the door’s construction (oak, iron, obsidian...).  
     - `string RuneCode` — the magical code required to open rune-locked doors.  

   - **Methods:**  
     - `Open()` — attempts to open the door. May require a rune code.  
     - `Close()` — closes the door if it is open.  
     - `Inspect()` — reveals details about the door (material, state, perhaps a faint shimmer of runes).  

2. **The Player / Console Menu**  
   A humble interface that allows interaction with the doors.
   - Presents choices: Open, Close, Inspect, Exit.  
   - Reads input and calls the correct `Door` methods.  
   - Loops until the player chooses to quit.

---

## 🔄 The Flow of the Program

1. Display a greeting and brief story introduction.  
2. Initialize several `Door` objects with different materials and rune codes.  
3. Enter a loop presenting menu options.  
4. Process player input.  
5. Execute actions (`Open()`, `Close()`, or `Inspect()`).  
6. Display resulting messages.  
7. Repeat until the player quits.  

---

## 🧠 Edge Cases & Considerations

- What if a player tries to open a door that’s already open?  
  → Respond with a gentle reminder (“The door is already open, apprentice.”)  

- What if the rune code entered is incorrect?  
  → The door should remain closed and display a warning.  

- Should each door behave differently?  
  → Optional flavor! An iron door may creak, while a stone door grinds ominously.  

- How will input be validated?  
  → Use simple `if` or `switch` statements. Guard against empty input.  

---

## 🧰 Development Phases

1. **Phase 1: Skeleton Crafting**  
   - Create the `Door` class with its properties and method stubs.  
   - Write a minimal `Main()` to test object creation.

2. **Phase 2: Behavior Binding**  
   - Implement each method with logic.  
   - Test manually by calling them directly.

3. **Phase 3: Console Interface**  
   - Add the menu loop for player interaction.  
   - Let the user choose which door to interact with.

4. **Phase 4: Rune Lock (Bonus)**  
   - Add code entry to unlock doors.  
   - Handle both success and failure messages gracefully.

5. **Phase 5: Flavor & Final Polish**  
   - Add creative flavor text.  
   - Refactor repetitive logic into helper methods if needed.

---

## 🪶 Mentor’s Commentary

> *“You have done well to plan before coding, Apprentice. Remember—clarity is your torch in the dark.  
> Each class should represent a single concept, each method a clear action.  
> Don’t chase perfection in one swing of the hammer. Forge, test, refine. That is the way of the Brewer.”*

> *“And one more thing—never underestimate the power of narrative. Code that tells a story will always be remembered.”*

---

### 📦 Next Steps

1. Review this scroll.  
2. Create your `Door.cs` and `Program.cs` files following this plan.  
3. Test and iterate in small steps.  
4. When complete, push your progress to GitHub and summon me for review.

---

> *“Go now, Novice Brewer. The Dungeon Doors await.”*
