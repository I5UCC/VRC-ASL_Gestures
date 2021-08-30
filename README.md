# VRC-ASL_Gestures
Gesture Controllers for VRChat 3.0 Avatars to be able to do additional ASL Gestures, depending on the used controller.

This Repository has different gesture controllers that can be used, dependent on the controller you use:
- Index Controller with ![VRCThumbParams-MOD](https://github.com/benaclejames/VRCThumbParams) <br/>
- Index Controller without any mods
- Oculus Touch Controllers (or any other controller) Left/Right Hand Dominant versions Available.
- A combined Controller for both index and Oculus Controllers (Nice for Public avatars) (Does still require the ![VRCThumbParams-MOD](https://github.com/benaclejames/VRCThumbParams))

### ***Only people who have your avatar shown or Custom animations enabled in Safety-settings are able to see the additional signs.***<br/>
### ***The use of this requires basic unity and VRCSDK3 knowledge to modify and upload a VRChat 3.0 Avatar. The animations used in this Gesture Controller are made with Pandaa's base, but should work with basically any Avatar but might require small adjustments.***

If there are any questions or suggestions about these Gesture Controller, feel free to either create a new issue or text me directly on Discord. **User: I5UCC#6781**<br/>

### Download here: ![VRC-ASL_Gestures_v1.1.unitypackage](https://github.com/I5UCC/VRC-ASL_Gestures/releases/download/v1.1/VRC-ASL_Gestures_v1.1.unitypackage)

# Avatar Setup

### 1. Import the provided .unitypackage file to an existing avatar project with VRCSDK3.0. All needed items will be found in your assets folder inside a new folder named VRC-ASL_Gestures. The next steps are dependent on your used Controller.

### 2. Set your Gesture Layer inside your VRC Avatar Descriptor component to the provided controller file.

There are two ways to do this:
- **You dont have a gesture layer set in your VRC Avatar Descriptor:**<br/>
Simply take the provided .controller file and put it inside your VRC Avatar Descriptor as shown here:<br/>
![Playable Layers](https://i.imgur.com/b2D9R15.png)
- **You already have a gesture layer that is using layers other then layers for hand gestures:**<br/>
You can use ![VRLabs Avatars 3.0 Manager](https://github.com/VRLabs/VRChat-Avatars-3.0) to merge the controller with your existing Gesture Controller. Just make sure you Replace the Right hand and Left Hand Layers to prevent it from interfering with each other.<br/>

#### 3. Set Expression Menu Items and Parameters
Add the following parameters to your avatars parameters (**CASE SENSITIVE**): <br/><br/>

***For index users (WITH THE MOD):*** <br/>
![Index_Parameters](https://i.imgur.com/bSZOaXb.png)<br/><br/>
LeftThumb(int) <br/>
RightThumb(int) <br/>
SignsDisabled(bool) <br/><br/>

***For index users (WITHOUT THE MOD):*** <br/>
![Index_Parameters](https://i.imgur.com/JId1s05.png)<br/><br/>
SignsDisabled(bool) <br/><br/>
***For Oculus users:*** <br/>
![Parameters](https://i.imgur.com/bSZOaXb.png)<br/><br/>
ComboSignIndex(Int)<br/>
ComboSignDisabled(Bool)<br/><br/>

***Using the combined Controller***<br/>
![Parameters](https://i.imgur.com/GXd4RTL.png)<br/><br/>
LeftThumb(int) <br/>
RightThumb(int) <br/>
ComboSignIndex(Int)<br/>
SignsDisabled(bool) <br/><br/>

# Controls

***For index users (WITH THE MOD):*** <br/>

| Base | Thumb Position | Result |
| --- | --- | --- |
| Fist | A Button | R-Hand |
| Fist | B Button | V-Hand |
| Fist | Thumbstick | K-Hand |
| Peace | A Button | Flat_O-Hand |
| Peace | B Button | V-Hand |
| Peace | Thumbstick | S-Hand |

***For index users (WITHOUT THE MOD):*** <br/>

Make a fist with your hand. Pushing down the trigger makes a ***S-Hand***, completely pushing down the Trigger makes a ***Flat_O-Hand***

***For Oculus users:*** <br/>

Basically, you make a gesture on your dominant hand and do a "RockNRoll"(Y-Hand here) or close your fist(TRIGGER NEEDS TO BE PUSHED IN COMPLETELY) on your support hand, it locks a specific gesture to your dominant hand and replaces the Y Hand animation with the new one.

| Base <br/>(Gesture on Dominant Hand) | Combo1 <br/>(Base/Combo2+Support-Y-Hand) | Combo2 <br/>(Base/Combo1+Support-ClosedFist) |
| --- | --- | --- |
| Fist | Flat_O | - |
| Open | MiddleDown | - |
| Point | X Hand | K-Hand |
| Victory | R Hand | U-Hand |
| Handgun | F Hand | W-Hand |
| ThumbsUp | I Hand | E-Hand |
| Y Hand | - | RockNRoll |

# DISCLAIMER
If you are using a gesture controller that is requiring the ![VRCThumbParams-MOD](https://github.com/benaclejames/VRCThumbParams): <br/>
As with all mods, any modification to VRChat's Client or SDK can lead to a ban or other punishment.
I will not be held responsible for any punishments that you may be given for using mods.
***USE IT AT YOUR OWN RISK***
