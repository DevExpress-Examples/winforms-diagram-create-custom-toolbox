# How to create a custom toolbox for WinForms DiagramControl

DiagramControl provides the DrawDetachedItem method to draw diagram items outside of the canvas area. This allows you to use any suitable control as a diagram toolbox. In this example, we use GridControl.

To start dragging an item when a user clicks a grid row, call the StartDragTool command. To draw a diagram item at a specific position, use the TranslateTransform method.



