# Super Mechs 1-to-1 Remake

Rebuilding the original Super Mechs turn-based tactical combat engine from scratch. This repository contains a pure C# core (decoupled from Godot's scene tree) and Godot project files to run the game.

---

## Project Overview

Core game math, stat calculations, turn pacing, and state management are implemented in pure C# to enable unit testing and deterministic behavior outside the Godot editor.

## Tech Stack

- Godot 4.6
- C# (.NET 7.0+)

---

## Requirements

- Godot 4.6 editor
- .NET SDK 7.0 or later
- Optional: Visual Studio or Visual Studio Code with C# support

---

## Quickstart — Open & Run in Godot

1. Clone the repository:

   git clone https://github.com/Adeeb-muhammad/new-game-project.git
   cd new-game-project

2. Open `project.godot` with Godot 4.6.
3. Allow Godot to import the project and compile the C# assemblies.
4. Run the main scene from the editor play button.

---

## Build from CLI

Restore and build the C# project from the repo root:

   dotnet restore
   dotnet build "super mech.csproj"

Reload the Godot editor or assemblies after building so Godot picks up updated DLLs.

---

## Running Tests

To add automated tests, create a test project (xUnit or NUnit) under `Tests/` and reference the core project. Run tests from the repository root:

   dotnet test ./Tests

---

## Exporting a Standalone Build

1. Install Godot export templates (Project -> Install Export Templates).
2. Configure an Export Preset (Project -> Export) for the target platform.
3. Build/export using the configured preset in the Godot editor.

---

## Recommended Project Tasks

- Implement core systems in `Scripts/Core/` as pure C# libraries (GameState, EventBus, Constants).
- Add a `Tests/` project with unit tests for combat math and turn resolution.
- Add `CONTRIBUTING.md` and an explicit `LICENSE` file.
- Add a CI workflow to build and run tests on push/PRs.

---

## Contributing

Pull requests are accepted. Follow the repository's coding conventions and include tests for new logic.
