
<h1 align="center">
  <img alt="Academy" title="Academy" src="https://user-images.githubusercontent.com/15943431/195387627-725db6ee-60e3-4a4b-bcf9-ffc441f30438.png" />
</h1>

<h3 align="center">
  > Academy is a fitness app prototype built on VisualStudio with C# and .NET Framework with SQLite Database
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
  <img width="992" alt="Login Screen" src="https://user-images.githubusercontent.com/15943431/212474231-19cb2d64-0797-4492-8f66-5e45f8969081.png">
</details>
<details>
  <summary>Login Screen:</summary>
  <img width="992" alt="Login Screen" src="https://user-images.githubusercontent.com/15943431/212474231-19cb2d64-0797-4492-8f66-5e45f8969081.png">
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
> There are many things I think I would have done differently if I were to start over, or even just fix.
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


