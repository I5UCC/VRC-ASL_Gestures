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
