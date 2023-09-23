# Common

This solution contains important settings to be used by both Macabre2D.Framework and Macabre2D.Project.Gameplay. There are several files this project that can be edited, but should not be deleted.

## Layers

Layers are a core component of Macabre2D. Both the rendering and physics of Macabre2D use bitwise operations on the Layers enum. This enum is serialized as a numeric value, so feel free to rename the layers per project. 

Do not delete the Layers enum.

## InputAction

Input actions define the various actions a user can perform when using an input device. These will generically tie an action to an input, allowing gameplay code to be input agnostic.

Do not delete the InputAction enum.