<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()

        Me.cmbitem = New System.Windows.Forms.ComboBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.btnsubtotal = New System.Windows.Forms.Button()
        Me.txtdiskon = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.txtkembali = New System.Windows.Forms.TextBox()

        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()

        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()

        Me.btntotal = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()

        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()

        '================ PANEL HEADER =================
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(928, 160)

        '================ LABEL HEADER =================
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 50)
        Me.Label3.Size = New System.Drawing.Size(350, 27)
        Me.Label3.Text = "APLIKASI E-TRACKING BUS"

        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 85)
        Me.Label4.Size = New System.Drawing.Size(280, 27)
        Me.Label4.Text = "UNIVERSITAS SIBER ASIA"

        '================ PANEL ETA =================
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(580, 45)
        Me.Panel2.Size = New System.Drawing.Size(320, 75)

        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Text = "ETA:"

        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(100, 20)
        Me.Label2.Text = "0"

        '================ FIELD LABEL =================
        Me.Label5.Location = New System.Drawing.Point(50, 210)
        Me.Label5.Text = "ID BUS"

        Me.Label6.Location = New System.Drawing.Point(50, 260)
        Me.Label6.Text = "RUTE"

        Me.Label7.Location = New System.Drawing.Point(50, 310)
        Me.Label7.Text = "HALTE TERAKHIR"

        Me.Label8.Location = New System.Drawing.Point(50, 360)
        Me.Label8.Text = "ETA (MENIT)"

        Me.Label9.Location = New System.Drawing.Point(50, 470)
        Me.Label9.Text = "STATUS"

        Me.Label10.Location = New System.Drawing.Point(50, 520)
        Me.Label10.Text = "KETERANGAN"

        Me.Label11.Location = New System.Drawing.Point(520, 470)
        Me.Label11.Text = "INFO"

        Me.Label12.Location = New System.Drawing.Point(520, 520)
        Me.Label12.Text = "JUMLAH DATA"

        Me.Label13.Location = New System.Drawing.Point(700, 190)
        Me.Label13.Text = "FILTER STATUS"

        '================ INPUT CONTROLS =================
        Me.cmbitem.Location = New System.Drawing.Point(241, 210)
        Me.cmbitem.Size = New System.Drawing.Size(200, 35)

        Me.txtharga.Location = New System.Drawing.Point(241, 260)
        Me.txtharga.Size = New System.Drawing.Size(250, 34)

        Me.txtjumlah.Location = New System.Drawing.Point(241, 310)
        Me.txtjumlah.Size = New System.Drawing.Size(250, 34)

        Me.txtsubtotal.Location = New System.Drawing.Point(241, 360)
        Me.txtsubtotal.Size = New System.Drawing.Size(150, 34)

        Me.txtdiskon.Location = New System.Drawing.Point(241, 470)
        Me.txtdiskon.Size = New System.Drawing.Size(150, 34)

        Me.txttotal.Location = New System.Drawing.Point(241, 520)
        Me.txttotal.Size = New System.Drawing.Size(250, 34)

        Me.txtbayar.Location = New System.Drawing.Point(676, 470)
        Me.txtbayar.Size = New System.Drawing.Size(200, 34)

        Me.txtkembali.Location = New System.Drawing.Point(676, 520)
        Me.txtkembali.Size = New System.Drawing.Size(200, 34)

        '================ BUTTONS =================
        Me.btnsubtotal.Location = New System.Drawing.Point(241, 420)
        Me.btnsubtotal.Size = New System.Drawing.Size(150, 40)
        Me.btnsubtotal.Text = "Load CSV"

        Me.btntotal.Location = New System.Drawing.Point(410, 420)
        Me.btntotal.Size = New System.Drawing.Size(150, 40)
        Me.btntotal.Text = "Tampilkan"

        Me.btnreset.Location = New System.Drawing.Point(241, 590)
        Me.btnreset.Size = New System.Drawing.Size(150, 40)
        Me.btnreset.Text = "Reset"

        Me.btnclose.Location = New System.Drawing.Point(410, 590)
        Me.btnclose.Size = New System.Drawing.Size(150, 40)
        Me.btnclose.Text = "Close"

        '================ RADIO BUTTON FILTER =================
        Me.RadioButton1.Location = New System.Drawing.Point(676, 230)
        Me.RadioButton1.Text = "ON_ROUTE"

        Me.RadioButton2.Location = New System.Drawing.Point(676, 270)
        Me.RadioButton2.Text = "DELAY"

        Me.RadioButton3.Location = New System.Drawing.Point(676, 310)
        Me.RadioButton3.Text = "ARRIVED"

        Me.RadioButton4.Location = New System.Drawing.Point(676, 350)
        Me.RadioButton4.Text = "ALL"

        Me.RadioButton5.Location = New System.Drawing.Point(676, 390)
        Me.RadioButton5.Text = "RESET FILTER"

        '================ FORM =================
        Me.ClientSize = New System.Drawing.Size(928, 700)
        Me.Controls.Add(Me.Panel1)

        Me.Controls.Add(Me.cmbitem)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.txtdiskon)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtbayar)
        Me.Controls.Add(Me.txtkembali)

        Me.Controls.Add(Me.btnsubtotal)
        Me.Controls.Add(Me.btntotal)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnclose)

        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton5)

        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)

        Me.Text = "E-Tracking Bus"

        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

    Friend WithEvents cmbitem As ComboBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents btnsubtotal As Button
    Friend WithEvents txtdiskon As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtbayar As TextBox
    Friend WithEvents txtkembali As TextBox

    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton

    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label

    Friend WithEvents btntotal As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents btnclose As Button

End Class
