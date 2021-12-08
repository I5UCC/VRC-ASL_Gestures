# VRC-ASL_Gestures
Gesture Controllers for VRChat 3.0 Avatars to be able to do additional ASL Gestures, depending on the used controller.

This Repository has different gesture controllers that can be used, dependent on the controller you use:
- Index Controller with ![VRCThumbParams-MOD](https://github.com/benaclejames/VRCThumbParams) (Might need to build the dll yourself, or use the dll provided by me in the ![releases section](https://github.com/I5UCC/VRC-ASL_Gestures/releases) (May be outdated))<br/>
- Index Controller without any mods (Left/Right Hand Dominant versions available) (early state/figuring things out).
- Oculus Touch Controllers (Left/Right Hand Dominant versions available).

### ***Only people who have your avatar shown or Custom animations enabled in Safety-settings are able to see the additional signs.***<br/>
### ***The use of this requires basic unity and VRCSDK3 knowledge to modify and upload a VRChat 3.0 Avatar. The animations used in this Gesture Controller are made with Pandaa's base, but should work with basically any Avatar but might require small adjustments.***

If there are any questions or suggestions about these Gesture Controller, feel free to create a discussion in this repository or text me directly on Discord. **User: I5UCC#6781**. If there are any issues please create an issue!<br/>

### ***If you use this package for a public avatar world or a sold avatar, please be sure to credit me with I5UCC#6781***

### ![Download here](https://github.com/I5UCC/VRC-ASL_Gestures/releases)

# Avatar Setup

### 1. Import the provided .unitypackage file to an existing avatar project with VRCSDK3.0. All needed items will be found in your assets folder inside a new folder named VRC-ASL_Gestures. The next steps are dependent on your used Controller.

### 2. Set your Gesture Layer inside your VRC Avatar Descriptor component to the provided controller file.

There are two ways to do this:
- **You dont have a gesture layer set in your VRC Avatar Descriptor:**<br/>
Simply take the provided .controller file and put it inside your VRC Avatar Descriptor as shown here:<br/>
![Playable Layers](https://i.imgur.com/b2D9R15.png)
- **You already have a gesture layer that is using layers other then layers for hand gestures:**<br/>
You can use ![VRLabs Avatars 3.0 Manager](https://github.com/VRLabs/VRChat-Avatars-3.0) to merge the controller with your existing gesture controller. Just make sure you replace the right hand and left Hand layers to prevent it from interfering with each other.<br/>

#### 3. Set Expression Menu Items and Parameters
Add the following parameters to your avatars parameters (**CASE SENSITIVE**): <br/><br/>

***For index users (WITH THE MOD):*** <br/>
![Index_Parameters](https://i.imgur.com/bSZOaXb.png)<br/><br/>
LeftThumb (int) <br/>
RightThumb (int) <br/>
SignsDisabled (bool) <br/><br/>

***For index users (WITHOUT THE MOD):*** <br/>
![Index_Parameters](https://i.imgur.com/JId1s05.png)<br/><br/>
SignsDisabled (bool) <br/><br/>
***For Oculus users:*** <br/>
![Parameters](https://i.imgur.com/bSZOaXb.png)<br/><br/>
ComboSignIndex (Int)<br/>
ComboSignDisabled (Bool)<br/><br/>

# Controls

***For index users (WITH THE MOD):*** <br/>

| Base | Thumb Position | Result |
| --- | --- | --- |
| Peace | A Button | R-Hand |
| Peace | B Button | V-Hand |
| Peace | Thumbstick | Bent-V-Hand |
| Fist | A Button | Trigger_Blendtree(S-Hand->E-Hand) |
| Fist | B Button | Trigger_Blendtree(Flat_O-Hand->Flat_B-Hand) |
| Fist | Trackpad | Trigger_Blendtree(A-Hand->T-Hand) |
| Fist | Thumbstick | Trigger_Blendtree(N-Hand->M-Hand) |
| RockNRoll | A Button | IRLY-Hand |
| RockNRoll | Thumbstick | Claw-Hand |
| Point | A Button | G-Hand |

***For index users (WITHOUT THE MOD):*** <br/>

| Combination | Result |
| --- | --- |
| Fist | Trigger_Blendtree(Flat_O-Hand->Flat_B-Hand) |
| OffHandClosedFist+ThumbsUp | E-Hand |
| OffHandClosedFist+Victory | R-Hand |
| OffHandClosedFist+Gun | G-Hand |

***For Oculus users:*** <br/>

Basically, you make a gesture on your dominant hand and do a "RockNRoll"(Y-Hand here) on your support hand, it locks a specific gesture to your dominant hand and replaces the Y Hand animation with the new one. Additionally you can close your fist(TRIGGER NEEDS TO BE PUSHED IN COMPLETELY) to give it another animation.

VRC Gesture Alias | Base <br/>(Gesture on Dominant Hand) | Combo1 <br/>(Base/Combo2+Support-Y-Hand) | Combo2 <br/>(Combo1+Support-ClosedFist) |
| --- | --- | --- | --- |
| Fist | S-Hand | Flat_O-Hand | K-Hand |
| HandOpen | 5-Hand | 25-Hand | 25-Hand |
| fingerpoint | D-Hand | X Hand | G-Hand |
| Victory | V-Hand | R Hand | U-Hand |
| RockNRoll | Y-Hand | Y Hand | RockNRoll |
| HandGun | L-Hand | F Hand | W-Hand |
| ThumbsUp | VR-A-Hand | I Hand | E-Hand |

# DISCLAIMER
If you are using a gesture controller that is requiring the ![VRCThumbParams-MOD](https://github.com/benaclejames/VRCThumbParams): <br/>
As with all mods, any modification to VRChat's Client or SDK can lead to a ban or other punishment.
I will not be held responsible for any punishments that you may be given for using mods.
***USE IT AT YOUR OWN RISK***
