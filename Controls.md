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
| Neutral | Not Touching | Trigger(C Hand->Claw Hand) |
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
| Victory | B Button | U-Hand |
| Victory | Thumbstick | V-Hand |
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
