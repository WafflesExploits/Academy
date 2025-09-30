<h1 align="center">
  <img alt="Academy" title="Academy" src="https://user-images.githubusercontent.com/15943431/195387627-725db6ee-60e3-4a4b-bcf9-ffc441f30438.png" />
</h1>

<h3 align="center">
  A comprehensive fitness app built with C# and .NET Framework
</h3>

## Overview

Academy is a desktop fitness management application designed to help bodybuilders and fitness enthusiasts organize every aspect of their fitness journey. From workout planning to macro calculations and meal scheduling, Academy provides a complete suite of tools for managing your fitness goals.

This project was developed to polish C# and SQLite skills while creating a practical, free tool for daily fitness & nutrition management.

## Project Status

**Status:** Completed

## Technology Stack

- **.NET Framework** - version 4.7.2
- **Visual Studio 2022** - Community Edition
- **C#** - Core programming language
- **SQLite** - Database management

## Features

### Core Functionality

**Workout Planning**
- Custom workout routine builder
- Exercise library and management
- Rep and set tracking

**Calendar System**
- Workout schedule management
- Synchronous workout plans (fixed weekly schedules)
- Asynchronous workout plans (flexible scheduling)
- Event reminders (competitions, important dates)

**Analytics Suite**

*Meal Planning*
- 2-6 meals per day configuration
- Custom ingredients editor
- Nutritional tracking

*Macros Calculator*
- TDEE-based calorie calculations
- Fat type breakdown
- Goal-specific planning:
  - Bulking protocols
  - Recomposition/Maingain
  - Cutting strategies
- Weight target progression tables

*Physique Tracking*
- BMI calculator
- Ideal weight calculator
- Progress monitoring

**Additional Features**
- User authentication system
- Settings configuration
- Credits and attribution

## Screenshots

### Login Interface
- <img height="250" alt="Login Screen" src="https://user-images.githubusercontent.com/15943431/212474231-19cb2d64-0797-4492-8f66-5e45f8969081.png">

### Workout Planner
- <img height="250" alt="Workout Planner" src="https://user-images.githubusercontent.com/15943431/212475233-c075216e-5e1f-4bdd-8b12-9298dceff416.png">

### Calendar Views

**Main Calendar**
- <img height="250" alt="Calendar" src="https://user-images.githubusercontent.com/15943431/212476167-2f68cc6b-ff45-4370-9a30-e7521ce7665b.png">

**Synchronous Plans**
- <img height="250" alt="Sync Calendar" src="https://user-images.githubusercontent.com/15943431/212476203-21a668c0-55cb-4bc5-9f68-19e5d1238413.png">
- <img height="250" alt="Sync Calendar" src="https://user-images.githubusercontent.com/15943431/212476206-0b0645a2-ce73-48b5-a189-eff534f1116f.png">

**Asynchronous Plans**
- <img height="250" alt="Async Calendar" src="https://user-images.githubusercontent.com/15943431/212476269-325ce4dd-8a7b-4197-acb6-61fd61c320fc.png">
- <img height="250" alt="Async Calendar" src="https://user-images.githubusercontent.com/15943431/212476273-f330a416-0220-4fba-9667-ecf6f8249e13.png">

**Event Management**
- <img height="250" alt="Event Add" src="https://user-images.githubusercontent.com/15943431/212476326-cd977652-708a-41dc-97d3-9c02a05ddfb8.png">
- <img height="250" alt="Event Editor" src="https://user-images.githubusercontent.com/15943431/212476321-76b3101d-3af5-4dd9-b4b2-f3382a39c794.png">

### Analytics Dashboard
- <img height="250" alt="Meal Planner" src="https://user-images.githubusercontent.com/15943431/212477291-b14b8624-7a42-450c-9723-c4691e9e1b2a.png">

## Installation & Setup

**Download:** [Latest Release](https://github.com/WafflesExploits/Academy/releases/tag/Release)

### Building from Source

1. Clone the repository
2. Open the project in Visual Studio 2022
3. Build and run the solution

**Important Note:** Due to SQLite library limitations in Visual Studio, Academy currently requires the Visual Studio environment to run properly. The standalone executable may not function correctly due to missing SQLite.Interop DLLs.

## Usage

Academy assists with:
- **Macro and calorie tracking** - Precise nutritional planning based on your goals
- **Workout organization** - Structured training programs
- **Daily planning** - Schedule management and reminders
- **Progress tracking** - Monitor your fitness journey

## Calorie Calculation Methodology

Academy uses the Mifflin St. Jeor equation for BMR calculation:

```
TDEE = BMR × Activity Multiplier

BMR Formulas:
  Men:   BMR = 10×Weight + 6.25×Height - 5×Age + 5
  Women: BMR = 10×Weight + 6.25×Height - 5×Age - 161

Activity Multipliers:
  1.2   - Sedentary (little to no exercise)
  1.375 - Lightly Active (exercise 1-3 days/week)
  1.465 - Moderately Active (exercise 3-4 days/week)
  1.55  - Active (intense exercise 4-5 days/week)
  1.725 - Very Active (intense exercise 6-7 days/week)
  1.9   - Extra Active (very hard daily exercise or physical job)
```


## Project Reflection

While Visual Studio is excellent for learning, scaling to 10,000+ lines revealed significant IDE-specific challenges and bug persistence. Despite these limitations, Academy successfully achieved all envisioned core features and serves its intended purpose as a comprehensive fitness management tool.

### Known Limitations

**Technical Constraints:**
- SQLite dependencies prevent standalone execution outside Visual Studio
- Fixed resolution UI design
- Requires Visual Studio environment to run

**Design Trade-offs:**
- UI evolved from aesthetic focus to efficiency-driven design
- Some components (rounded buttons) couldn't be implemented due to stability issues

### Key Takeaways

- Choose development environments that scale with project complexity
- Resolve library dependencies early for standalone distribution
- Balance aesthetic goals with practical implementation constraints
- Define realistic feature boundaries from the start

**Note:** This project is complete and won't receive further updates. Future iterations would benefit from responsive UI design, proper dependency packaging, modern frameworks (WPF, Avalonia), and cross-platform compatibility.

## Contact
Created by [@AndreCrafts](https://github.com/andrecrafts)

Feel free to explore the codebase and reach out with questions or feedback!
