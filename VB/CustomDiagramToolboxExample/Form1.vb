Imports DevExpress.Diagram.Core
Imports DevExpress.XtraDiagram
Imports DevExpress.XtraDiagram.Extensions
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace CustomDiagramToolboxExample

    Public Partial Class Form1
        Inherits System.Windows.Forms.Form

        Public Sub New()
            Me.InitializeComponent()
            Dim toolboxItems = New System.Collections.ObjectModel.ObservableCollection(Of DevExpress.XtraDiagram.DiagramShape)()
            For Each shape In DevExpress.Diagram.Core.BasicShapes.Stencil.Shapes
                toolboxItems.Add(New DevExpress.XtraDiagram.DiagramShape() With {.Shape = shape})
            Next

            Me.gridControl1.DataSource = toolboxItems
        End Sub

        Private shapeTextOffset As Integer = 60

        Private mouseDownLocation As System.Drawing.Point

        Private gridHitInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo

        Private Sub GridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)
            Dim shapeItem As DevExpress.XtraDiagram.DiagramShape = TryCast(Me.gridView1.GetRow(e.RowHandle), DevExpress.XtraDiagram.DiagramShape)
            If shapeItem Is Nothing Then Return
            Dim transState As System.Drawing.Drawing2D.GraphicsState = e.Graphics.Save()
            Try
                e.Appearance.DrawString(e.Cache, e.DisplayText, New System.Drawing.Rectangle(e.Bounds.X + Me.shapeTextOffset, e.Bounds.Y, e.Bounds.Width - Me.shapeTextOffset, e.Bounds.Height))
                e.Cache.TranslateTransform(e.Bounds.X, e.Bounds.Y)
                shapeItem.Width = 40
                shapeItem.Height = e.Bounds.Height
                Me.diagramControl1.DrawDetachedItem(shapeItem, e.Cache)
                e.Handled = True
            Finally
                e.Graphics.Restore(transState)
            End Try
        End Sub

        Private Sub gridControl1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            Me.gridHitInfo = Me.gridView1.CalcHitInfo(e.Location)
            Me.mouseDownLocation = e.Location
        End Sub

        Private Sub gridControl1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If e.Button = System.Windows.Forms.MouseButtons.Left AndAlso Me.CanStartDragDrop(e.Location) Then
                Me.StartDragDrop()
            End If
        End Sub

        Private Sub gridControl1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If Me.gridHitInfo IsNot Nothing Then Me.gridHitInfo.View.ResetCursor()
            Me.gridHitInfo = Nothing
        End Sub

        Private Function CanStartDragDrop(ByVal location As System.Drawing.Point) As Boolean
            Return Me.gridHitInfo.InDataRow AndAlso (System.Math.Abs(location.X - Me.mouseDownLocation.X) > 2 OrElse System.Math.Abs(location.Y - Me.mouseDownLocation.Y) > 2)
        End Function

        Public Sub StartDragDrop()
            Dim draggedItem = CType(Me.gridHitInfo.View.GetRow(Me.gridHitInfo.RowHandle), DevExpress.XtraDiagram.DiagramShape)
            Dim tool = New DevExpress.Diagram.Core.FactoryItemTool("", Function() "", Function(diagram) New DevExpress.XtraDiagram.DiagramShape(draggedItem.Shape), New System.Windows.Size(150, 100))
            Me.diagramControl1.Commands.Execute(DevExpress.Diagram.Core.DiagramCommandsBase.StartDragToolCommand, tool, Nothing)
        End Sub
    End Class
End Namespace
