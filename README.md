# Centralised UI
The Centralised UI package allows you to modify the colours, images or animations of your selectable UI elements in a centralised way.

## Getting Started
You can add the Component to your different GameObjects through the Editor and you will see that it already has 3 default ScriptableObjects, one for each type of Selectable transition.

Once you click the "Apply Skin" button or press Play in the Unity Editor the UI Data will be applied to the Selectable.
<br>
And to modify the Selectable Data you only have to change the data of the associated ScriptableObject instead of going element by element.

You can also directly create a GameObject with the associated Component from the Unity Editor. You will see that inside UI there is a new folder called "ProgramadorCastellano" and inside it "CentralisedUI". Here you can see that you can create all of Unity's default selectables with the component added.

## Creation of Scriptable Objects for the Component
To create the ScriptableObjects associated to the components you must:

1. Right-click on a directory
2. Go to "Create" and search for "ProgramadorCastellano"
3. Click on "CentralisedUI" and select 1 of the 3 centralised transition types (ColorTint, SpriteSwap or Animation).

Once you have created the ScriptableObject you can set the values you prefer and associate it to as many Selectables with the Component as you want.

## Component Explanation
When you associate the component you will see that it has:

- **Transition Mode**: This is the same enum that the selectable transitions have, you can adjust it to decide how to apply the centralised data to the selected selectable.

- **Color Tint SO**: Here you can put the ColorTintSO you have created for this Selectable to have its ColorBlock.

- **Sprite Swap SO**: Here you can put the SpriteSwapSO you have created for this Selectable to have its SpriteState.

- **Animation SO**: Here you can put the AnimationSO you have created for this Selectable to have its Animation Triggers.

- **Apply Skin**: This button once pressed will set Selectable to the transition mode chosen in **Transition Mode** and depending on the mode selected will update the ColorBlock, SpriteState or AnimationTriggers of it, or nothing if you choose None.