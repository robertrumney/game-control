# Global Static Class for Unity

In Unity, it's common to have variables that need to be accessed from multiple scripts throughout your project. One way to do this is by creating a global static class that contains those variables, which can be accessed from anywhere in your project without needing to create a GameObject to hold the script.

## Why Use a Global Static Class?

There are several benefits to using a global static class for your Unity project:

- **Easy to access:** Because the variables are declared as static, you can access them directly from the class name without needing to create an instance of the class. This makes it easy to use the variables from any script in your project.
- **Persistent data:** Because the variables are stored in a global static class, they will persist across scenes and GameObjects. This means you can access the same data from multiple scripts in different parts of your project without needing to pass data between them.
- **Avoids GameObject clutter:** Because you don't need to create a GameObject to hold the script, you can avoid cluttering your project with unnecessary GameObjects. This can make it easier to navigate and organize your project.

## How to Use a Global Static Class

Here's an example of how you can create a global static class in Unity:

```csharp
using UnityEngine;

public static class GameControl : object 
{
    public static bool paused=false;
    public static int score=0;
    // ...add any other global variables here...
}
```
In this example, we've created a global static class called GameControl that contains two global variables: paused and score. To access these variables from another script, you can simply use the class name followed by the variable name:
```csharp
if (GameControl.paused)
{
    // ...do something when the game is paused...
}
```

```csharp
GameControl.score += 10;
```
