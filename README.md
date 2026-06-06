# Super Mechs 1-to-1 Remake

Rebuilding the original classic Super Mechs turn-based tactical combat engine completely from scratch. This project delivers a faithful 1-to-1 recreation of the original legacy game loops, built around a clean, testable, and type-safe C# core that is decoupled from Godot's scene tree.

---

## 🚀 Project Overview

The goal of this project is to faithfully recreate the tactical depth, math, and logic of the original game within a modern, scalable architecture. By keeping the core backend engine strictly decoupled from Godot's visual node hierarchy, core game math, stat calculations, turn pacing, and state management can be implemented in pure C# and tested outside the editor.

## 🛠️ Tech Stack & Architecture

- Game Engine: Godot v4.6 (Stable)
- Language: C# (.NET)
- Workflow Philosophy: Vibe Coding (clean, decoupled architecture and compile-time safe systems)
- Target Platform: Desktop (`.exe`) for initial test phases

## Requirements

- Godot 4.6 editor
- .NET SDK 7.0 or later
- (Optional) Visual Studio / Visual Studio Code with C# extension

> Make sure Godot is configured to use the installed .NET SDK (Editor → Editor Settings → Mono).

---

## Quickstart — Open & Run in Godot

1. Clone the repo:

   git clone https://github.com/Adeeb-muhammad/new-game-project.git
   cd new-game-project

2. Open `project.godot` with Godot 4.6.
3. Allow Godot to import the project and compile the C# assemblies.
4. Run the main scene from the editor.

---

## Build from CLI

   dotnet restore
   dotnet build "super mech.csproj"

---

## Running Tests

To add unit tests, create a `Tests/` project (xUnit or NUnit) and reference the core library. Run:

   dotnet test ./Tests

---

## Exporting a Standalone Build

1. Install export templates in Godot (Project → Install Export Templates).
2. Configure an Export Preset (Project → Export).
3. Build/export from the editor.

---

## d Next Steps

- Implement core systems in `Scripts/Core/` as pure C# (GameState, EventBus, Constants).
- Add a `Tests/` project with unit tests for combat math and turn resolution.
- Add `CONTRIBUTING.md` and `LICENSE` if needed.

