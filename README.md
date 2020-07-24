# _Vendor Order Tracker_
Epicodus Week 9 Independent Project  
Version 1.0 - Date July 24, 2020

## _Project Description_
An exploration of MVC utilizing C# and .NET framework.

## _Contributors_
JohnNils Olson  

## _Usage_
A web application where the user can track bakery orders organized by vendor.

## _Behavior Specifications_
| Behavior | Input | Output |
| User is directed to a splash page. | ---- | Home - Index |
| User is linked to vendor list | Link - "Vendor Index" | Vendor - Index |
| User is linked to a form to input a new vendor to track | Link - "New Vendor" | Vendor - New |
| User enters vendor information into form, vendor is added to list | "Susie's Cafe" | Redirect Vendor - Index |
| User is linked to vendor details | Link - "Vendor Details" | Vendor - Show |
| User is linked to a form to add orders to a vendor | Link - "New Order" | Vender/Order - New |
| User enters order information into form, order is add to list | "Croissant: 10" | Redirect Vendor - Show |

## _Technologies Used_
C#  
.NETCore

## _Installation Instructions_
* Cloning instructions.
  1. Open Git Bash.
  2. Change the current working directory to the location where you would like to clone the repository.
  3. Type "git clone" followed by "(https://github.com/JohnNilsOlson/VendorOrderTracker.Solution)" (without quotes) and hit enter.
  4. Open directory with code editor of choice.
  5. In the terminal, change working directory to ./VendorOrderTracker.
  6. Type "dotnet restore".
  7. Type "dotnet run".

* Download instructions.
  1. Visit "(https://github.com/JohnNilsOlson/VendorOrderTracker.Solution)".
  2. Click the green "code" button and download zip file of project.
  3. Extract zip file to directory of choice.
  4. Open project directory in code editor of choice.

* Instructions to run WebApp
  1. In the terminal, change working directory to ./VendorOrderTracker.
  2. Type "dotnet restore".
  3. Type "dotnet run".

* Instructions to run tests.
  1. In the terminal, change working directory to ./VendorOrderTrackerTests.
  2. Type "dotnet restore".
  3. Type "dotnet test".

## _Bugs_
No known issues.

## _Contact Information_
JohnNils Olson - johnnils@gmail.com  

## _License_
The [MIT] license.
Copyright (c) 2020 JohnNils Olson