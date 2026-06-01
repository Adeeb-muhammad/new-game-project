# Super Mechs 1-to-1 Remake

Rebuilding the original classic Super Mechs turn-based tactical combat engine completely from scratch. This project delivers a faithful 1-to-1 recreation of the original legacy game loops, built around a clean, testable, and type-safe C# core that is decoupled from Godot's scene tree.

---

## 🚀 Project Overview

The goal of this project is to faithfully recreate the tactical depth, math, and logic of the original game within a modern, scalable architecture. Core game math, stat calculations, turn pacing, and state management live entirely in pure C# so they can be unit-tested outside of Godot.

## 🛠️ Tech Stack

- Game Engine: Godot 4.6
- Language: C# (.NET)
- Project layout: Godot project files at repo root, C# source under `Scripts/`

---

## Requirements

- Godot 4.6 (editor)
- .NET SDK 7.0 or later (install from https://dotnet.microsoft.com/)
- (Optional) Visual Studio / Visual Studio Code with C# extension for development

> Note: Make sure Godot is configured to use the installed .NET SDK. In Godot editor: Editor -> Editor Settings -> Mono -> Editor -> External Editor and related Mono settings.

---

## Quickstart — Open & Run in Godot

1. Clone the repo:

   git clone https://github.com/Adeeb-muhammad/new-game-project.git
   cd new-game-project

2. Open the `project.godot` file with Godot 4.6 (File -> Open)

3. Wait for Godot to import the project and compile the C# assemblies. If Godot prompts to install or locate the .NET SDK, point it to your .NET SDK installation.

4. Select the main scene (configured in `project.godot`) and press Play to run the game.

---

## Build from CLI (compile C# assemblies)

From the repository root you can build the C# assemblies using the dotnet CLI:

   dotnet restore
   dotnet build "super mech.csproj"

After building, re-open Godot (or reload assemblies in the editor) so Godot picks up the latest DLLs.

---

## Running Tests

This repository is structured so that core game logic can be unit-tested outside Godot. To add tests:

1. Create a `Tests/` project (xUnit or NUnit) and reference the core class library project.
2. Add test files to `Tests/` and run:

   dotnet test

I can add a test project skeleton for you if you'd like.

---

## Exporting a Standalone Build

To export a standalone executable (.exe) you must have Godot export templates installed and configured. Steps:

1. In Godot: Project -> Install Export Templates (if not already installed).
2. Configure an Export Preset (Project -> Export) for your target platform (Windows, Linux, etc.).
3. Build/export from the Godot Editor using the configured preset.

Note: Godot handles packaging the C# assemblies into the export; you do not normally use `dotnet publish` for the exported game bundle.

---

## Recommended Next Steps

- Convert core systems in `Scripts/Core/` to pure C# class libraries (GameState, EventBus, Constants) so they are easily testable.
- Add a `Tests/` project and a couple of unit tests for the game math/stat calculations.
- Add a `README.md` (this file) and a `CONTRIBUTING.md` for contributors.
- Add a `LICENSE` (MIT is a common choice for game projects).
- Add a GitHub Actions workflow that runs `dotnet test` on push/PR.

---

## How I can help

I can:
- Add a LICENSE file
- Create a `Tests/` project with a sample test
- Add GitHub Actions workflow to build & test
- Create skeleton files for GameState and EventBus

Reply with which items you'd like me to add and I'll create them.
