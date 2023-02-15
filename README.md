# How To Install
Installing synergy modded is straightforward, simply click the green 'Code' button in the top-right corner of the page and select 'Download ZIP'. Once the download is finished, extract the zip and you should be ready to go! Inside the zip, you will find a "Mods" folder, which is the folder you will need to place your mods in (There will already be a mod in there called "IgnoreThis" so you can just delete that).

Once the mods are in place, run the executable file, and you will be able to access and use any mods you have installed. In addition, a Mods menu will appear in the top left of the screen, displaying all the mods you have installed.

With that have fun and good luck! To find mods for the game you can join the unoffical synergy discord [here.](https://discord.gg/578WBFngHd) 
___

# How To Make Mods
In this guide I will be showing you how to make a mod that quits the game when you press Q.

Also before we begin, please note that creating a Synergy mod using Melon Loader requires basic knowledge of C#. If you are new to programming, you might want to start by learning the basics before attempting to create a mod.

With that said, let's get started!

## Step 1: Download and Install Melon Loader

To create a mod with Melon Loader, you first need to download and install it. You can download the latest version of Melon Loader from the official GitHub page (https://github.com/LavaGang/MelonLoader). Once you've downloaded the package, extract it to a location on your computer.

## Step 2: Create a New Visual Studio Project

To create a new mod, you will need to create a new project in Visual Studio (NOT VISUAL STUDIO CODE!). If you don't have Visual Studio installed, you can download it from the official Microsoft website (https://visualstudio.microsoft.com/downloads/).

Once you have Visual Studio installed, open it and create a new project. Select "Class Library (.NET Standard)" as the project type, and give it a name that describes your mod. For example, if you're creating a mod that quits the game when you press the Q key, you could name it "QToQuit".

## Step 3: Add MelonLoader Reference

In order to use MelonLoader in your mod, you need to add a reference to the MelonLoader DLL file. To do this, right-click on References in Visual Studio and select "Add Reference". Navigate to the location where you extracted MelonLoader in Step 1, and select the "MelonLoader.dll" file (Should be located in "SYNERGY-main\MelonLoader" file).

## Step 4: Write Your Mod Code

Now that you have a new project set up and the MelonLoader reference added, it's time to write your mod code.

First, let's rename the default "Class1" to your mod name. In your project, find the file "Class1.cs" and rename it to whatever you want your mod to be called. For example, you could name it "QToQuitClass".

Next, let's add some metadata to your mod. This will allow Melon Loader to display information about your mod in the game's mod menu. To do this, click on the "Properties" folder in your project and open the "AssemblyInfo.cs" file.

In the file, add the following code and fill out the placeholders accordingly:

```cs
using MelonLoader;
using ModeName; // The namespace of your mod class
// ...
[assembly: MelonInfo(typeof(ClassName), "ModName", "version", "ModderName")]
[assembly: MelonGame("DefaultCompany", "SYNERGY")]
```

Make sure to replace the "ClassName" and "ModName" placeholders with the appropriate values for your mod. For example:

```cs
using MelonLoader;
using QToQuit; // The namespace of your mod class
// ...
[assembly: MelonInfo(typeof(QToQuitClass), "QToQuit", "1.0.0", "Loopymtb")]
[assembly: MelonGame("DefaultCompany", "SYNERGY")]
```

This code tells Melon Loader to display your mod's name, version, and author in the mod menu.

Now, let's write the code for your mod. In your class file (e.g. "QToQuitClass.cs"), you will need to override the "OnUpdate" method from the MelonMod base class. This method is called every frame, and is where you will put the code to check if the Q key has been pressed. If it has, you can quit the game using the "Application.Quit()" method.

Here's an example code for a mod that quits the game when the Q key is pressed:

```cs
using MelonLoader;
using UnityEngine;

namespace QToQuit
{
    public class QToQuitClass : MelonMod
    {
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Application.Quit();
            }
        }
    }
}
```

## Step 5: Build and Test Your Mod

Once you've written your mod code, you can build the project by selecting "Build" from the Visual Studio menu. This will create a DLL file in the "bin/Debug" folder of your project.

To use the mod, simply copy the DLL file to the "Mods" folder. Then launch the game, and your mod should be active!

That's it! You've just created your first Synergy mod. You can now experiment with creating more complex mods by adding new features and using the Melon Loader [wiki.](https://melonwiki.xyz/#/modders/quickstart)

I hope this guide was helpful and easy to follow. Good luck with your modding!
