<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoverDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MoverDashboard))
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        SearchBtn = New Button()
        Label1 = New Label()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        UserName = New DataGridViewTextBoxColumn()
        PhoneNumber = New DataGridViewTextBoxColumn()
        email = New DataGridViewTextBoxColumn()
        DataGridView2 = New DataGridView()
        User = New DataGridViewTextBoxColumn()
        status = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(251), CByte(205), CByte(88))
        Panel1.Controls.Add(SearchBtn)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(0, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(744, 52)
        Panel1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(247, 14)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(196, 23)
        TextBox1.TabIndex = 0
        ' 
        ' SearchBtn
        ' 
        SearchBtn.ForeColor = Color.White
        SearchBtn.Image = My.Resources.Resources.search_13_16
        SearchBtn.Location = New Point(405, 14)
        SearchBtn.Name = "SearchBtn"
        SearchBtn.Size = New Size(38, 24)
        SearchBtn.TabIndex = 1
        SearchBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(168), CByte(100), CByte(62))
        Label1.Location = New Point(29, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 25)
        Label1.TabIndex = 1
        Label1.Text = "User Request"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(168), CByte(100), CByte(62))
        Label2.Location = New Point(519, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 25)
        Label2.TabIndex = 2
        Label2.Text = "Accepted Users"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {UserName, PhoneNumber, email})
        DataGridView1.Location = New Point(17, 136)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(426, 241)
        DataGridView1.TabIndex = 3
        ' 
        ' Name
        ' 
        UserName.HeaderText = "Name"
        UserName.Name = "Name"
        UserName.Width = 150
        ' 
        ' PhoneNumber
        ' 
        PhoneNumber.HeaderText = "Phone Number"
        PhoneNumber.Name = "PhoneNumber"
        PhoneNumber.Width = 120
        ' 
        ' email
        ' 
        email.HeaderText = "E-mail"
        email.Name = "email"
        email.Width = 120
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {User, status})
        DataGridView2.Location = New Point(495, 136)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(236, 222)
        DataGridView2.TabIndex = 4
        ' 
        ' User
        ' 
        User.HeaderText = "Name"
        User.Name = "User"
        ' 
        ' status
        ' 
        status.HeaderText = "Status"
        status.Name = "status"
        ' 
        ' MoverDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(743, 449)
        Controls.Add(DataGridView2)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        UserName = "MoverDashboard"
        Text = "MoverDashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SearchBtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UserName As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents User As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
End Class
