# VRC-ASL_Gestures
Gesture Controllers for VRChat 3.0 Avatars to be able to do additional ASL Gestures, depending on the used Controller.

This Repository has different Gesture Controllers that can be used, dependent on the Controller you use:
- Index Controller with ![VRCThumbParams-MOD](https://github.com/benaclejames/VRCThumbParams) <br/>
- Index Controller without any Mods
- Oculus Touch Controllers (or any other controller) Left/Right Hand Dominant versions Available.

### ***Only people who have your avatar shown or Custom animations enabled in Safety-settings are able to see the additional signs.***<br/>
### ***The use of this requires basic unity and VRCSDK3 knowledge to modify and upload a VRChat 3.0 Avatar. The animations used in this Gesture Controller are made with Pandaa's base, but should work with basically any Avatar but might require small adjustments.***

If there are any questions or suggestions about these Gesture Controller, feel free to either create a new issue or text me directly on Discord. **User: I5UCC#6781**<br/>

# Avatar Setup

### 1. Import the provided .unitypackage file to an existing avatar project with VRCSDK3.0. All needed items will be found in your assets folder inside a new folder named VRC-ASL_Gestures. The next steps are dependent on your used Controller:

### 2. Set your Gesture Layer inside your VRC Avatar Descriptor component to the provided controller file.

There are two ways to do this:
- **You dont have a Gesture Layer set in your VRC Avatar Descriptor:**<br/>
Simply take the provided Controller file and put it inside your VRC Avatar Descriptor as shown here:<br/>
![Playable Layers](https://i.imgur.com/b2D9R15.png)
- **You already have a Gesture Layer that is using Layers other then Layers for Hand gestures:**<br/>
You can use ![VRLabs Avatars 3.0 Manager](https://github.com/VRLabs/VRChat-Avatars-3.0) to merge the controller with your existing Gesture Controller. Just make sure you Replace the Right hand and Left Hand Layers to prevent it from interfering with each other.<br/>

#### 3. Set Expression Menu Items and Parameters
Add the following Parameters to your avatars Parameters (**CASE SENSITIVE**): <br/><br/>
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
