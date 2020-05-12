Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.Linq
Imports System.Xml.Linq
Imports System.Text
Imports System.Globalization





Public NotInheritable Class CFrmRoot
    Public Sub New()
        InitializeComponent()
    End Sub


    Private Shared Sub ppResetWindowPosition(tfrm As Form)
        Dim tcs As Screen = Screen.FromPoint(Cursor.Position)
        Dim tsb As Rectangle = tcs.Bounds
        Dim tlp As Point = New Point(tsb.Right, tsb.Bottom)
        Dim tws As Size = tfrm.Size
        tlp.Offset(-(tws.Width + 40), -(tws.Height + 40))
        tfrm.Location = tlp
    End Sub


    Private Const _strVer As String = "v1.00"

    Protected Overrides Sub OnLoad(tea As EventArgs)
        MyBase.OnLoad(tea)

        Me.Text = String.Format("{0}  {1}", Me.GetType().Namespace, _strVer)
        ppResetWindowPosition(Me)

        pp_btn2_Click(Nothing, Nothing)
    End Sub







    ''' <summary>
    ''' ▼▼▼ Reset (CTRL+R)
    ''' </summary>
    ''' <param name="tsd"></param>
    ''' <param name="tea"></param>
    ''' <remarks></remarks>
    Private Sub pp_btn2_Click(tsd As Object, tea As EventArgs) Handles _btn2.Click
        Try
            _txb1.Text = "yyyy-MM-dd/HH:mm:ss/fff"
            Me.Focus()
        Catch
        End Try
    End Sub



    ''' <summary>
    ''' ▼▼▼ Stamp and Copy to Clipboard (CTRL+E)
    ''' </summary>
    ''' <param name="tsd"></param>
    ''' <param name="tea"></param>
    ''' <remarks></remarks>
    Private Sub pp_btn1_Click(tsd As Object, tea As EventArgs) Handles _btn1.Click
        Try
            Dim tis As String = _txb1.Text
            If Not String.IsNullOrEmpty(tis) Then
                'Dim tos As String = DateTime.Now.ToString("yyyy-MM-dd/HH:mm:ss/fff", CultureInfo.InvariantCulture)
                Dim tos As String = DateTime.Now.ToString(tis, CultureInfo.InvariantCulture)
                _lbl1.Text = tos
                Clipboard.SetText(tos)
                Me.Focus()
            End If
        Catch
            MsgBox("Wrong format")
        End Try
    End Sub




    ''' <summary>
    ''' Shortcuts
    ''' </summary>
    ''' <param name="tmsg"></param>
    ''' <param name="tkd"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Overrides Function ProcessCmdKey(ByRef tmsg As Message, tkd As Keys) As Boolean
        If (tkd = (Keys.Control Or Keys.R)) Then
            pp_btn2_Click(Nothing, Nothing)
            Return True
        ElseIf (tkd = (Keys.Control Or Keys.E)) Then
            pp_btn1_Click(Nothing, Nothing)
            Return True
        End If
        Return MyBase.ProcessCmdKey(tmsg, tkd)
    End Function


End Class
