# Garbage Collection WPF Demo (C#)

This project demonstrates how to interact with the .NET Garbage Collection (GC) 
mechanism using a simple WPF (Windows Presentation Foundation) application. 
It visualizes memory usage by displaying the collected memory after garbage collection events.

## Features

* Displays total memory collected by the Garbage Collector.
* Uses WPF to build a minimalist user interface.
* Uses .NET’s `GC.GetTotalMemory` method to fetch memory statistics.

## Prerequisites

Before running this project, ensure you have the following installed:

* **.NET 6.0 or later** (for compatibility with C# WPF projects)
* **Visual Studio** or another C# IDE (with WPF support)

## Getting Started

### Clone the repository

You can clone the project to your local machine using the following Git command:

```bash
git clone https://github.com/HChristopherNaoyuki/garbage-collection-wpf-demo-cs.git
```

### Open the project in Visual Studio

1. Open Visual Studio.
2. Select **File > Open > Project/Solution**.
3. Navigate to the folder where you cloned the repository and open `garbage-collection-wpf-demo-cs.sln`.

### Build and Run

1. Once the project is open, click **Build > Build Solution** (or press `Ctrl + Shift + B`).
2. Press **F5** or click **Start Debugging** to run the application.
3. The window will display the total memory collected by the Garbage Collector.

## Features and Design

* **Memory Display**: The application will show the memory collected by the .NET Garbage Collector in kilobytes (KB).
* **Minimalist UI**: The window is fixed at a size of 400x200 pixels with a centered `TextBlock` showing the memory details.
* **Non-Resizable Window**: The window is non-resizable for a consistent user experience.

## Example Output

Upon running the application, you will see a window with the following output:

```
Memory Collected: 1234 KB
```

This shows the amount of memory freed by the garbage collector.

## Contributing

If you'd like to contribute, feel free to fork the repository and submit a pull request. Here's a basic flow:

1. Fork the repository.
2. Clone your fork.
3. Create a new branch for your changes.
4. Commit your changes.
5. Push the changes and create a pull request.

## DISCLAIMER

UNDER NO CIRCUMSTANCES SHOULD IMAGES OR EMOJIS BE INCLUDED DIRECTLY 
IN THE README FILE. ALL VISUAL MEDIA, INCLUDING SCREENSHOTS AND IMAGES 
OF THE APPLICATION, MUST BE STORED IN A DEDICATED FOLDER WITHIN THE 
PROJECT DIRECTORY. THIS FOLDER SHOULD BE CLEARLY STRUCTURED AND NAMED 
ACCORDINGLY TO INDICATE THAT IT CONTAINS ALL VISUAL CONTENT RELATED TO 
THE APPLICATION (FOR EXAMPLE, A FOLDER NAMED IMAGES, SCREENSHOTS, OR MEDIA).

I AM NOT LIABLE OR RESPONSIBLE FOR ANY MALFUNCTIONS, DEFECTS, OR ISSUES 
THAT MAY OCCUR AS A RESULT OF COPYING, MODIFYING, OR USING THIS SOFTWARE. 
IF YOU ENCOUNTER ANY PROBLEMS OR ERRORS, PLEASE DO NOT ATTEMPT TO FIX THEM 
SILENTLY OR OUTSIDE THE PROJECT. INSTEAD, KINDLY SUBMIT A PULL REQUEST 
OR OPEN AN ISSUE ON THE CORRESPONDING GITHUB REPOSITORY, SO THAT IT CAN 
BE ADDRESSED APPROPRIATELY BY THE MAINTAINERS OR CONTRIBUTORS.

---
