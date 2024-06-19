<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
    Button1 = New Button()
    Button2 = New Button()
    PictureBox1 = New PictureBox()
    TextBox1 = New TextBox()
    TextBox2 = New TextBox()
    Label1 = New Label()
    Label2 = New Label()
    Label3 = New Label()
    CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
    SuspendLayout()
    ' 
    ' Button1
    ' 
    Button1.BackColor = Color.Lime
    Button1.Font = New Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point)
    Button1.Location = New Point(12, 12)
    Button1.Name = "Button1"
    Button1.Size = New Size(173, 58)
    Button1.TabIndex = 0
    Button1.Text = "AKCE"
    Button1.UseVisualStyleBackColor = False
    ' 
    ' Button2
    ' 
    Button2.BackColor = Color.Red
    Button2.Font = New Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point)
    Button2.ForeColor = Color.White
    Button2.Location = New Point(12, 76)
    Button2.Name = "Button2"
    Button2.Size = New Size(173, 58)
    Button2.TabIndex = 1
    Button2.Text = "KONEC"
    Button2.UseVisualStyleBackColor = False
    ' 
    ' PictureBox1
    ' 
    PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
    PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
    PictureBox1.Location = New Point(39, 161)
    PictureBox1.Name = "PictureBox1"
    PictureBox1.Size = New Size(162, 199)
    PictureBox1.TabIndex = 2
    PictureBox1.TabStop = False
    ' 
    ' TextBox1
    ' 
    TextBox1.Location = New Point(281, 34)
    TextBox1.Name = "TextBox1"
    TextBox1.Size = New Size(125, 27)
    TextBox1.TabIndex = 3
    ' 
    ' TextBox2
    ' 
    TextBox2.Location = New Point(281, 67)
    TextBox2.Name = "TextBox2"
    TextBox2.Size = New Size(125, 27)
    TextBox2.TabIndex = 4
    ' 
    ' Label1
    ' 
    Label1.AutoSize = True
    Label1.Location = New Point(244, 37)
    Label1.Name = "Label1"
    Label1.Size = New Size(31, 20)
    Label1.TabIndex = 5
    Label1.Text = "a ="
    ' 
    ' Label2
    ' 
    Label2.AutoSize = True
    Label2.Location = New Point(243, 70)
    Label2.Name = "Label2"
    Label2.Size = New Size(32, 20)
    Label2.TabIndex = 6
    Label2.Text = "b ="
    ' 
    ' Label3
    ' 
    Label3.AutoSize = True
    Label3.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
    Label3.Location = New Point(318, 187)
    Label3.Name = "Label3"
    Label3.Size = New Size(0, 46)
    Label3.TabIndex = 7
    ' 
    ' Form1
    ' 
    AutoScaleDimensions = New SizeF(8F, 20F)
    AutoScaleMode = AutoScaleMode.Font
    ClientSize = New Size(821, 418)
    Controls.Add(Label3)
    Controls.Add(Label2)
    Controls.Add(Label1)
    Controls.Add(TextBox2)
    Controls.Add(TextBox1)
    Controls.Add(PictureBox1)
    Controls.Add(Button2)
    Controls.Add(Button1)
    Name = "Form1"
    Text = "Form1"
    CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
    ResumeLayout(False)
    PerformLayout()
  End Sub

  Friend WithEvents Button1 As Button
  Friend WithEvents Button2 As Button
  Friend WithEvents PictureBox1 As PictureBox
  Friend WithEvents TextBox1 As TextBox
  Friend WithEvents TextBox2 As TextBox
  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label

End Class
