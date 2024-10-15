# Car Manufacturing Program

This program is a console application that allows users to manufacture cars. The produced cars are added to a list, and when the program ends, this list is displayed on the screen.

## Features

- The user is asked if they want to manufacture a car.
- Cars are produced with an automatically assigned production date.
- Information such as the number of doors is validated when entered by the user.
- The produced cars are listed with their serial number, brand, model, color, number of doors, and production date.

## Usage

1. When the program starts, the user is asked whether they want to manufacture a car (Y/N).
   - If `Y` is selected, the user is prompted to enter car information (serial number, brand, model, color, number of doors).
   - If `N` is selected, the program terminates and displays the list of produced cars.
   
2. User input, such as the number of doors, is validated to ensure it's numeric. In case of incorrect input, an error message is shown, and the user is prompted to re-enter the information.

3. When the program ends, the information of all produced cars is printed to the screen.

## Code Explanation

- **`Car` Class**: Represents a car object. The production date is automatically assigned.
- **`Program` Class**: Manages the main functionality of the program, gathers user input, manufactures cars, and prints the list of cars.
- **`GetAllCars` Method**: Displays the information of all produced cars.

## Setup

1. Copy this code into a C# project.
2. Ensure you have a C# development environment (e.g., Visual Studio).
3. Run the program and start manufacturing cars.

## License

This project is licensed under the MIT License.

## Contact

For any questions or support, please email (ahmet.sulu1993@gmail.com)
