# VRC-ASL_Gestures
Gesture Controllers for VRChat 3.0 Avatars to be able to do additional ASL Gestures, depending on the used controller.

This Repository has different gesture controllers that can be used, dependent on the controller you use:
- Index Controller
  - using [VRCThumbParamsOSC](https://github.com/I5UCC/VRCThumbParamsOSC) running in the background.
    - *(OR [VRCThumbParams](https://github.com/I5UCC/VRC-ASL_Gestures/releases/download/v1.3.4/ThumbParams.dll) by [benaclejames](https://github.com/benaclejames) **DISCLAIMER**: any modification to VRChat's Client or SDK can lead to a ban or other punishment, I will not be held responsible for any punishments that you may be given for using this mod.)*
  - without any additional programs ***(Left/Right Hand Dominant versions available)***.
- GeneralVR ***(made for Oculus Touch)***
  - using [VRCThumbParamsOSC](https://github.com/I5UCC/VRCThumbParamsOSC) running in the background. ***(Only Recommended if you use a Controller grip)***
  - without any additional programs ***(Left/Right Hand Dominant versions available)***.

If there are any questions or suggestions about these Gesture Controller, feel free to create a discussion in this repository or text me directly on Discord. **User: I5UCC#6781**. 

***If there are any issues please read the [FAQ](https://github.com/I5UCC/VRC-ASL_Gestures#faq) first, then create an issue!<br/>***

### ![Download here](https://github.com/I5UCC/VRC-ASL_Gestures/releases/latest)

## Future Updates:
- [ ] Optimizing the controllers to not use Any State transitions for better performance. ([v2.0-Alpha1 Release](https://github.com/I5UCC/VRC-ASL_Gestures/releases/tag/v2.0-Alpha2))
  - [x] Index_Thumbparams 
  - [x] Index_NoMod
  - [ ] GeneralVR_Thumbparams
  - [x] GeneralVR_NoMod 
- [ ] Making an install script

# Avatar Setup

### 1. Import the provided .unitypackage file to an existing avatar project with VRCSDK3.0. All needed items will be found in your assets folder inside a new folder named VRC-ASL_Gestures. The next steps are dependent on your used Controller.

![image](https://user-images.githubusercontent.com/43730681/165518981-482d3ced-3fa0-45e8-af09-f0ac24583443.png)

### 2. Set your Gesture Layer inside your VRC Avatar Descriptor component to the provided controller file.

There are two ways to do this:
- **You dont have a gesture layer set in your VRC Avatar Descriptor:**<br/>
Simply take the provided .controller file and put it inside your VRC Avatar Descriptor as shown here:<br/>
![Playable Layers](https://i.imgur.com/b2D9R15.png)
  - ***File for Index users (WITH VRCThumbParams):*** <br/>
    - VRC-ASL_Gestures/IndexVR/ThumbParams/ASLGestures_Index_Thumbparams.controller <br/>
  - ***File for Index users (WITHOUT VRCThumbParams):*** <br/>
    - VRC-ASL_Gestures/IndexVR/Without/ASLGestures_Index_NoMod_RightHandDominant.controller
    - VRC-ASL_Gestures/IndexVR/Without/ASLGestures_Index_NoMod_LeftHandDominant.controller <br/>
  - ***File for Oculus users (WITH VRCThumbParams):*** <br/>
    - VRC-ASL_Gestures/GeneralVR/ThumbParams/ASLGestures_GeneralVR_Thumbparams.controller <br/>
  - ***File for Oculus users (WITHOUT VRCThumbParams):*** <br/>
    - VRC-ASL_Gestures/GeneralVR/Without/ASLGestures_GeneralVR_LeftHandDominant.controller
    - VRC-ASL_Gestures/GeneralVR/Without/ASLGestures_GeneralVR_RightHandDominant.controller

- **You already have a gesture layer that is using layers other then layers for hand gestures:**<br/>
You can use ![VRLabs Avatars 3.0 Manager](https://github.com/VRLabs/Avatars-3.0-Manager) to merge the controller with your existing gesture controller. Just make sure you replace the right hand and left Hand layers to prevent it from interfering with each other.<br/>

#### 3. Set Expression Menu Items and Parameters
Add the following parameters to your avatars parameters (**CASE SENSITIVE**): <br/><br/>

***For index users (WITH VRCThumbParams):*** <br/>
![Parameters](https://i.imgur.com/bSZOaXb.png)<br/><br/>
LeftThumb (int) <br/>
RightThumb (int) <br/>
SignsDisabled (bool) <br/><br/>

***For index users (WITHOUT VRCThumbParams):*** <br/>
![Parameters](https://user-images.githubusercontent.com/43730681/145733626-67525125-6fb3-4c14-9921-012d5bfa8892.png)<br/><br/>
SignsDisabled (bool) <br/>
SignIndex (int) <br/><br/>

***For Oculus users (WITH VRCThumbParams):*** <br/>
![image](https://user-images.githubusercontent.com/43730681/165517573-d065f543-563c-4080-970d-185abbe1ec9f.png)<br/><br/>
RightThumb (Int)<br/>
LeftThumb (Int)<br/>
RightTrigger (Float)<br/>
LeftTrigger (Float)<br/>
SignsDisabled (bool) <br/><br/>

***For Oculus users (WITHOUT VRCThumbParams):*** <br/>

![Parameters](https://user-images.githubusercontent.com/43730681/145126521-0de7f8fd-56a4-4f6f-91da-6fddc51549dc.png)<br/><br/>
ComboSignIndex (Int)<br/>
ComboSignDisabled (Bool)<br/><br/>

# Controls

### For index users (WITH VRCThumbParams): <br/>

| Base | Thumb Position | Result |
| --- | --- | --- |
| Neutral | A Button | C Hand |
| Neutral | B Button | Claw Hand |
| Neutral | Trackpad | *[None/Addable]* |
| Neutral | Thumbstick | *[None/Addable]* |
| Fist | A Button | Trigger(S-Hand->E-Hand) |
| Fist | B Button | Trigger(Flat_O-Hand->Flat_B-Hand(Bent)) |
| Fist | Trackpad | Trigger(A-Hand->T-Hand) |
| Fist | Thumbstick | Trigger(N-Hand->M-Hand) |
| Fingerpoint | A Button | G-Hand |
| Fingerpoint | B Button | X-Hand |
| Fingerpoint | Trackpad | *[None/Addable]* |
| Fingerpoint | Thumbstick | K-Hand |
| Victory | A Button | R-Hand |
| Victory | B Button | V-Hand |
| Victory | TrackPad | *[None/Addable]* |
| Victory | Thumbstick | Bent-V-Hand |
| RockNRoll | A Button | IRLY-Hand |
| RockNRoll | B Button | W-Hand |
| RockNRoll | TrackPad | *[None/Addable]* |
| RockNRoll | Thumbstick | *[None/Addable]* |

### For index users (WITHOUT VRCThumbParams): <br/>

| Combination | Result |
| --- | --- |
| OffHandClosedFist+Fist | Trigger(Flat_O-Hand->Flat_B-Hand) |
| OffHandClosedFist+ThumbsUp | E-Hand |
| OffHandClosedFist+Victory | R-Hand |
| OffHandClosedFist+Gun | G-Hand |
| OffHandClosedFist+Neutral | Claw Hand |
| OffHandClosedFist+RnR | IRLY Hand |

### For Oculus users (WITH VRCThumbParams): <br/>

| Base | Thumb Position | Result |
| --- | --- | --- |
| Neutral | Not Touching | C Hand |
| Neutral | A Button | Open-8-Hand |
| Neutral | B Button | Rested-Hand |
| Neutral | Thumbstick | Claw Hand |
| Fist | A Button | Trigger(Flat_O-Hand->Flat_B-Hand(Bent)) |
| Fist | B Button | Trigger(S-Hand->E-Hand) |
| Fist | Thumbstick | Trigger(I-Hand->RnR-Hand) |
| Fingerpoint | A Button | X-Hand |
| Fingerpoint | B Button | D-Hand |
| Fingerpoint | Thumbstick | K-Hand |
| Victory | A Button | R-Hand |
| Victory | B Button | V-Hand |
| Victory | Thumbstick | U-Hand |
| RockNRoll | A Button | W-Hand |
| RockNRoll | B Button | Y-Hand |
| RockNRoll | Thumbstick | F-Hand |
| ThumbsUp | Not touching | Trigger(G-Hand) |

### For Oculus users (WITHOUT VRCThumbParams):

Basically, you make a gesture on your dominant hand and do a "RockNRoll"(Y-Hand here) on your support hand, it locks a specific gesture to your dominant hand and replaces the Y Hand animation with the new one. Additionally you can close your fist(TRIGGER NEEDS TO BE PUSHED IN COMPLETELY) to give it another animation.

VRC Gesture Alias | Base <br/>(Gesture on Dominant Hand) | Combo1 <br/>(Base/Combo2+Support-Y-Hand) | Combo2 <br/>(Combo1+Support-ClosedFist) |
| --- | --- | --- | --- |
| Neutral | Neutral | Claw-Hand | Flat-B(Bent) |
| Fist | S-Hand | Flat_O-Hand | K-Hand |
| HandOpen | 5-Hand | Open-8-Hand | Open-8-Hand |
| fingerpoint | D-Hand | X Hand | G-Hand |
| Victory | V-Hand | R Hand | U-Hand |
| RockNRoll | Y-Hand | Y Hand | RockNRoll |
| HandGun | L-Hand | F Hand | W-Hand |
| ThumbsUp | Open-A-Hand| I Hand | E-Hand |

# Modifying/Adding Gestures

### First open your avatar's ASL Gesture controller, ***then for both Left and Right hands***:

#### 1. Click on the hand position you wish to modify the gesture for (in this case Neutral_ThumbStick).

![gesture](https://user-images.githubusercontent.com/7873528/166107617-3680388e-4e3c-4d44-b8ca-652e003d3ab8.png)

#### 2. In the inspector, change the "Motion" parameter by clicking on the little circle to the right of it. In the window that appears, search for "hand", then select the hand animation you desire for that gesture (in this case B Hand).

![motion](https://user-images.githubusercontent.com/7873528/166107753-7be8f3d7-8ce9-43b6-89c5-fad2d43e63a0.png)

#### 3. Make sure the transition to the gesture isn't muted, the arrow connecting to it should be white, if not: click on the arrow, and in the inspector window, untick "Mute".

![mute](https://user-images.githubusercontent.com/7873528/166108164-e24e07fb-9aea-429d-ac55-261df6183005.png)
![mute2](https://user-images.githubusercontent.com/7873528/166108312-70a410ab-94a6-4221-a971-2b20672344b8.png)

# FAQ

- Why can't people see my signs sometimes?
  - Only people who have your avatar shown or Custom animations enabled in Safety-settings are able to see the additional signs, make sure that is the case.
- The animations don't fit my Avatar.
  - The animations used in this Gesture Controller are made with [Pandaabear's base](https://pandaabear.gumroad.com/l/pAxQR). However they should work with basically any Avatar but might require small adjustments for more complex signs like E-Hand or R-Hand.
