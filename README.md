<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/253856911/20.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T878107)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# WinForms Diagram Control - Create a Custom Toolbox

This example demonstrates how to create a custom toolbox ([GridControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl) in this example) and display it in the [DiagramControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramControl). The [DrawDetachedItem](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.Extensions.XtraDiagramExtensions.DrawDetachedItem(DiagramControl--DiagramItem--GraphicsCache)) method allows you to draw this toolbox outside the [canvas area](https://docs.devexpress.com/WindowsForms/116876/controls-and-libraries/diagrams/diagram-control/canvas).

![image](https://user-images.githubusercontent.com/65009440/226934248-d8b0a8c2-d521-4240-aefd-bdcc5eb63bcd.png)

Call the **StartDragTool** command when a user clicks a grid row to start the drag operation. Use the [TranslateTransform](https://docs.devexpress.com/WindowsForms/DevExpress.Utils.Drawing.GraphicsCache.TranslateTransform(System.Single-System.Single-System.Drawing.Drawing2D.MatrixOrder)) method to draw a diagram item at a specific position.

## Files to Review

* [Form1.cs](./CS/CustomDiagramToolboxExample/Form1.cs) (VB: [Form1.vb](./VB/CustomDiagramToolboxExample/Form1.vb))

## Documentation

* [Shapes Panel](https://docs.devexpress.com/WindowsForms/116881/controls-and-libraries/diagrams/diagram-control/shapes-panel)
* [Shapes](https://docs.devexpress.com/WindowsForms/116882/controls-and-libraries/diagrams/diagram-items/shapes)
* [DrawDetachedItem](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.Extensions.XtraDiagramExtensions.DrawDetachedItem(DiagramControl--DiagramItem--GraphicsCache))

## More Examples

* [Create custom diagram containers and register them in the toolbox and ribbon gallery](https://github.com/DevExpress-Examples/how-to-create-custom-diagram-containers-and-register-them-in-the-toolbox-and-ribbon-gallery-t466447)
* [Diagram Control for WinForms - Create Custom Shapes with Connection Points](https://github.com/DevExpress-Examples/winforms-diagram-create-custom-shapes-with-connection-points)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-diagram-create-custom-toolbox&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-diagram-create-custom-toolbox&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
