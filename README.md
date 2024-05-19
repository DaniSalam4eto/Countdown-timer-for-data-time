# Countdown Timer

The Countdown Timer script for Unity allows you to create a countdown timer that displays the remaining days, hours, and minutes. The timer's state is saved to a file so that it persists across application sessions.

## Features

- **Customizable initial countdown time** (days, hours, minutes).
- **Displays the remaining time** in a `TextMeshProUGUI` element.
- **Saves and loads the countdown state** to/from a file.
- **Handles application pause, quit, and focus events** to ensure accurate time tracking.

## Setup

### Add the Script to a GameObject

1. Attach the `Countdown` script to a GameObject in your Unity scene.

### Assign UI Elements

1. Create a `TextMeshProUGUI` element in your scene to display the countdown timer.
2. Assign this `TextMeshProUGUI` element to the `countdownText` field in the script.

### Set Initial Time

1. In the Inspector, set the `daysLeft`, `hoursLeft`, and `minutesLeft` fields to define the initial countdown duration.

## Usage

### Running the Scene

- When you run the scene, the countdown will start from the specified time.
- The remaining time will be displayed in the format: `Time Left: 00d 00h 00m`.
- When the countdown reaches zero, it will display `Time's Up!`.

### Persistence

- The countdown state is saved to a file located at `Application.persistentDataPath + "/countdown.txt"`.
- The timer state is saved when the application is paused, loses focus, or quits.
- On restarting the application, the countdown will resume from the last saved state.

## Notes

- Ensure that the TextMeshPro package is installed in your Unity project.
- Customize the display format or behavior as needed by modifying the script.

## Example

Here’s a basic setup example:

1. Create a new GameObject in the scene and name it `CountdownTimer`.
2. Attach the `Countdown` script to the `CountdownTimer` GameObject.
3. Create a UI Text element using TextMeshPro and assign it to the `countdownText` field of the script.
4. Set the initial time values (e.g., `daysLeft = 1`, `hoursLeft = 2`, `minutesLeft = 30`).

## License

This project is licensed under the Creative Commons Attribution 4.0 International Public License. You are free to use, distribute, remix, adapt, and build upon this work, even commercially, as long as you credit the original creator.

## Credits

This script was developed by Daniel Chakarov/Sleeping Impulse.
