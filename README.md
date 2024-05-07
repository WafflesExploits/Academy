
<h1 align="center">
  <img alt="Academy" title="Academy" src="https://user-images.githubusercontent.com/15943431/195387627-725db6ee-60e3-4a4b-bcf9-ffc441f30438.png" />
</h1>

<h3 align="center">
  > Academy is a fitness app prototype built on VisualStudio using C# and .NET Framework with SQLite Database
</h3>


## Table of Contents
* [General Info](#general-information)
* [Technologies Used](#technologies-used)
* [Features](#features)
* [Screenshots](#screenshots)
* [Setup](#setup)
* [Usage](#usage)
* [Project Status](#project-status)
* [Room for Improvement](#room-for-improvement)
* [Note](#note)
* [Contact](#contact)
<!-- * [License](#license) -->


## General Information
- Academy helps with every bodybuilder needs, workout planning, macros calculation, meal planning and more. 
- This project was made with the intent of polishing my C# and SQLite Skills and, at the same time, creating a useful project to be used daily by myself and anyone
  who wants a fitness app to organize their life for free.


## Technologies Used
- .NET Framework - version 4.7.2
- Visual Studio 2022 - Community Edition
- C#
- SQLite


## Features
- Home Page (Unfinished)
- Workout Planner
- Calendar:
  - Workout Schedules
  - Assynchronous and Synchronous Workout Plans
  - Events Reminder (e.g. Mr. Olympia)
- Analytics:
  - Meal Planner: (2-6 Meals/Day)
    - Ingredients Editor
  - Macros Calculator:
    - Calories Calculator
    - Types of Fat Calculator
    - Gym Goals:
      - Bulking
      - Recomp/Maingain
      - Cutting
    - Weight Target Table
  - Physique: 
    - BMI Calculator
    - Ideal Weight Calculator
 - Settings (Unfinished)
 - Credits

## Screenshots
<details>
  <summary>Login Screen:</summary>
  <img height="250" alt="Login Screen" src="https://user-images.githubusercontent.com/15943431/212474231-19cb2d64-0797-4492-8f66-5e45f8969081.png">
</details>
<details>
  <summary>Workout Planner:</summary>
  <img height="250" alt="Workout Planner" src="https://user-images.githubusercontent.com/15943431/212475233-c075216e-5e1f-4bdd-8b12-9298dceff416.png">
</details>
<details>
  <summary>Calendar:</summary>
  <img height="250" alt="Calendar" src="https://user-images.githubusercontent.com/15943431/212476167-2f68cc6b-ff45-4370-9a30-e7521ce7665b.png">
  <details>
    <summary>Synchronous Workout Plans:</summary> 
    <img height="250" alt="Sync Calendar" src="https://user-images.githubusercontent.com/15943431/212476203-21a668c0-55cb-4bc5-9f68-19e5d1238413.png"> 
    <img height="250" alt="Sync Calendar" src="https://user-images.githubusercontent.com/15943431/212476206-0b0645a2-ce73-48b5-a189-eff534f1116f.png"> 
  </details>
   <details>
    <summary>Assynchronous Workout Plans:</summary> 
    <img height="250" alt="Async Calendar" src="https://user-images.githubusercontent.com/15943431/212476269-325ce4dd-8a7b-4197-acb6-61fd61c320fc.png"> 
    <img height="250" alt="Async Calendar" src="https://user-images.githubusercontent.com/15943431/212476273-f330a416-0220-4fba-9667-ecf6f8249e13.png"> 
  </details>
  <details>
    <summary>Events Editor Plans:</summary> 
    <img height="250" alt="Event Add" src="https://user-images.githubusercontent.com/15943431/212476326-cd977652-708a-41dc-97d3-9c02a05ddfb8.png"> 
    <img height="250" alt="Event Editor" src="https://user-images.githubusercontent.com/15943431/212476321-76b3101d-3af5-4dd9-b4b2-f3382a39c794.png"> 
  </details>
</details>
<details>
  <summary>Analytics:</summary>
  <img height="250" alt="Meal Planner" src="https://user-images.githubusercontent.com/15943431/212477291-b14b8624-7a42-450c-9723-c4691e9e1b2a.png">
</details>

## Setup
- Build the project on Visual Studio and run Academy yourself.
- Due to an error of the SQLite Library on Visual Studio, Academy may only be open through the Visual Studio Project.
- Download the project <a href="https://github.com/WafflesExploit/Academy/releases/tag/Release">here</a>.
## Usage
- Academy can be used to assist you in your gym goals.
- Be it macros and calories, workouts or even planning your day, Academy is there **for you**.

## Project Status
 <h3 align="center"><strong>
   Finished</strong>
</h3>

# Conclusion
<center>
There are many things I think I would have done differently if I were to start over. 
First, I wouldn't try to pursue such an ambitious idea in VS 22 (Visual Studio). The Program is great for small projects and learning C++/C#, but everytime I would try to fix a bug, another one would appear just because of trying to open the project in VS 22. So, when you start to have more than 10000 Lines of code it becomes practically impossible to fix every bug, if they just keep appearing. 
Thus, I will not fix or upgrade this project anymore since it has every main feature I imagined in my head, so I'm happy with how it ended. Even if it could be better.
</center>

## Room for Improvement
- Overall design -> The design at the start was more aesthetically pleasant but it evolved to a more efficient one to consume less time.
- Round buttons -> Was unable to add round buttons on the project without crashing it.
- Fixed Resolution -> Didn't take to account multiple resolutions that could be used while running academy.
- SQLite -> Couldn't find dlls for SQLite.Interop, so the programm doesn't run without being in Visual Studio, this being the reason the project will remain unfinished.

## Note
- Calories are calculted via TDEE formula:
    ```  
    TDEE = BMR*BMRM 
       Mifflin St. Jeor BMR Formula:
         Men:   BMR = 10*Weight + 6.25*Height - 5*Age + 5
         Women: BMR = 10*Weight + 6.25*Height - 5*Age - 161
       BMR Multipliers (BMRM):
          BMR X 1.2: Sedentary: little to no exercise
          BMR X 1.375: Slightly Active: exercise 1-3 days/week
          BMR X 1.465: Moderate Active: exercise 3-4 days/week
          BMR X 1.55: Active: Intense exercise 4-5 days/week
          BMR X 1.725: Very Active: intense exercise 6-7 days/week
          BMR X 1.9: Extra Active: Very hard daily exercise or physical job
    ```
## Contact
Created by [@WafflesExploit](https://github.com/WafflesExploit) - feel free to contact me!


