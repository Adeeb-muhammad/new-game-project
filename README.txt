# Super Mechs 1-to-1 Remake

Rebuilding the original classic Super Mechs turn-based tactical combat engine completely from scratch. This project delivers a flawless 1-to-1 recreation of the original legacy game loops, built natively using Godot 4.6 and C#. The entire codebase features a decoupled, modular architecture designed to easily support future update expansions.

---

## 🚀 Project Overview

The goal of this project is to faithfully recreate the tactical depth, math, and logic of the original game within a modern, scalable architecture. By keeping the core backend engine strictly decoupled from the frontend visuals, the project remains highly optimized for desktop execution while staying fully prepared for future content updates and mechanics.

## 🛠️ Tech Stack & Architecture

* **Game Engine:** Godot v4.6 (Stable)
* **Language:** C# (.NET)
* **Workflow Philosophy:** Vibe Coding (Strict focus on clean, decoupled architecture, modular data schemas, and compile-time safe systems)
* **Target Platform:** Desktop (`.exe`) for initial test phases, with architecture ready for future expansion.

## ⚙️ Core Implementation Rules

1. **Strict Logic Isolation:** Game math, stat calculations, turn pacing, and state management live entirely in pure C# scripts, independent of Godot's visual node hierarchy.
2. **Type-Safe Event Handling:** Built using Godot 4.6's modern Roslyn Source Generators (`public partial class` structures) and native C# events (`+=` syntax) rather than loose string-based signal connections.
3. **Scalable Tuning:** Balancing numbers (energy costs, ranges, delays) are routed to a centralized constants file to allow instant game-economy updates.

---
*Developed from the ground up to keep the spirit of the classic alive.*