# <img src="https://user-images.githubusercontent.com/43730681/176920686-1539fd29-3dad-46a8-9f88-f938d8639b54.png" width="32" height="32">  VRC-ASL_Gestures
Gesture Controllers for VRChat 3.0 Avatars to be able to do more ASL Handshapes. 

This Repository has different gesture controllers that can be used, dependent on the controller you use:
- Index Controller
  - using [ThumbParams](https://github.com/I5UCC/VRC-ASL_Gestures/blob/954e2dc852c1f07d76ef352c9473eb8412aaf3a1/ThumbParamsInfo.md). ***(Recommended)***
  - without any additional programs ***(Left/Right Hand Dominant versions available)***.
- GeneralVR ***(made for Oculus Touch)***
  - using [ThumbParams](https://github.com/I5UCC/VRC-ASL_Gestures/blob/954e2dc852c1f07d76ef352c9473eb8412aaf3a1/ThumbParamsInfo.md). ***(Only Recommended if you use a Controller grip)*** - ALPHA, please report any issues with it. - 
  - without any additional programs ***(Left/Right Hand Dominant versions available)***.

You can find the standard controls for them [here](https://github.com/I5UCC/VRC-ASL_Gestures#controls)

***Currently working on / Known Bugs:***
- Switching back to anystate transitions for both GeneralVR versions (As vrchat doesnt update it correctly sometimes over the network)
- Fixing a multitude of bugs of the General VR Thumbparams version

# ![Download here](https://github.com/I5UCC/VRC-ASL_Gestures/releases/download/v2.0.3/VRC-ASL_Gestures_v2.0.3.unitypackage)

## If there are any questions or suggestions about these Gesture Controller, feel free to create a [DISCUSSION](https://github.com/I5UCC/VRC-ASL_Gestures/discussions) in this repository or text me directly on Discord. **I5UCC#6781**. 

## If there are any issues please read the [FAQ](#faq) and [ISSUES](https://github.com/I5UCC/VRC-ASL_Gestures/issues) first, then create an issue!<br/>

## If you made any alternative animations for different bases that you want to have added, create a pull request for it.

# Avatar Setup

## Automatic Setup

### 1. Import the provided .unitypackage file to an existing avatar project with VRCSDK3.0.

### 2. In unity, click on Tools>VRC-ASL_Gestures
![grafik](https://user-images.githubusercontent.com/43730681/173200345-4e383dd5-a9a2-4069-b28d-23b476ee2cb7.png)

### 3. Drag and drop your avatar into the window
![Unity_bIf8tp1nxi](https://user-images.githubusercontent.com/43730681/177012949-6cc2ac67-7871-4d88-8c53-5a5a6c50a805.gif)


### 4. Choose your settings and click install!
![9yGN74Mosn](https://user-images.githubusercontent.com/43730681/177012951-2dfd2fb6-375a-4108-b5ad-bb1090504c5b.gif)

## Manual Setup

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
Add the following parameters to your avatars parameters (**CASE SENSITIVE**): <br/>

***For index users (WITH VRCThumbParams):*** <br/>

LeftThumb (int) <br/>
RightThumb (int) <br/>
SignsDisabled (bool) <br/>

***For index users (WITHOUT VRCThumbParams):*** <br/>

SignsDisabled (bool) <br/>

***For Oculus users (WITH VRCThumbParams):*** <br/>

RightThumb (Int)<br/>
LeftThumb (Int)<br/>
RightTrigger (Float)<br/>
LeftTrigger (Float)<br/>
SignsDisabled (bool) <br/>

***For Oculus users (WITHOUT VRCThumbParams):*** <br/>

ComboSignIndex (Int)<br/>
SignsDisabled (bool) <br/>

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

# FAQ

- Why cant people see my signs sometimes?
  - Only people who have your avatar shown or Custom animations enabled in Safety-settings are able to see the additional signs, make sure that is the case.
- The animations don't fit my Avatar.
  - The animations used in this Gesture Controller are made with [Pandaabear's base](https://pandaabear.gumroad.com/l/pAxQR). However they should work with basically any Avatar but might require small adjustments for more complex signs like E-Hand or R-Hand. There are some alternative Animations in the 
"Alternative Animations" folder, That you are able to use too. 
- What if my Avatar uses Write Defaults on?
  - Shouldn't be a problem. you can set all of the animations WD on if you use WD in your Gesture Layer, that shouldn't cause problems, I would still recommend having WD off, as VRChat recommends it.
