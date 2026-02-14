Imports System.IO
Imports System.Linq

Public Class Form1

    ' ================== DATA ==================
    Private dataBus As New List(Of BusTracking)
    Private filteredBus As New List(Of BusTracking)

    ' ================== FORM LOAD ==================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupUI()
        ResetForm()
    End Sub

    ' ================== PROCEDURE: SETUP UI ==================
    Private Sub SetupUI()
        Label3.Text = "APLIKASI E-TRACKING BUS"
        Label4.Text = "UNIVERSITAS SIBER ASIA"

        Label5.Text = "ID BUS"
        Label6.Text = "RUTE"
        Label7.Text = "HALTE TERAKHIR"
        Label8.Text = "ETA (MENIT)"
        Label9.Text = "STATUS"
        Label10.Text = "KETERANGAN"

        Label11.Text = "INFO"
        Label12.Text = "JUMLAH DATA"
        Label13.Text = "FILTER STATUS"

        Label1.Text = "ETA: "

        btnsubtotal.Text = "Load CSV"
        btntotal.Text = "Tampilkan"
        btnreset.Text = "Reset"
        btnclose.Text = "Close"

        ' Viewer style
        txtharga.ReadOnly = True
        txtjumlah.ReadOnly = True
        txtsubtotal.ReadOnly = True
        txtdiskon.ReadOnly = True
        txttotal.ReadOnly = True

        txtbayar.ReadOnly = True
        txtkembali.ReadOnly = True

        ' Filter text
        RadioButton1.Text = "ON_ROUTE"
        RadioButton2.Text = "DELAY"
        RadioButton3.Text = "ARRIVED"
        RadioButton4.Text = "ALL"
        RadioButton5.Text = "RESET FILTER"

        cmbitem.Items.Clear()
    End Sub

    ' ================== BUTTON: LOAD CSV ==================
    Private Sub btnsubtotal_Click(sender As Object, e As EventArgs) Handles btnsubtotal.Click
        Dim filePath As String = ""

        Dim defaultPath = Path.Combine(Application.StartupPath, "bus_tracking.csv")
        If File.Exists(defaultPath) Then
            filePath = defaultPath
        Else
            Dim ofd As New OpenFileDialog()
            ofd.Filter = "CSV (*.csv)|*.csv|Text (*.txt)|*.txt|All files (*.*)|*.*"
            If ofd.ShowDialog() = DialogResult.OK Then
                filePath = ofd.FileName
            Else
                Return
            End If
        End If

        LoadDataFromFile(filePath)

        cmbitem.Items.Clear()
        For Each b In dataBus
            cmbitem.Items.Add(b.IDBus)
        Next

        filteredBus = New List(Of BusTracking)(dataBus)
        UpdateInfoPanel()

        If cmbitem.Items.Count > 0 Then
            cmbitem.SelectedIndex = 0
        End If

        MessageBox.Show("File berhasil dibaca!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' ================== PROCEDURE: BACA FILE + LOOP ==================
    Private Sub LoadDataFromFile(pathFile As String)
        dataBus.Clear()

        Dim lines() As String = File.ReadAllLines(pathFile)

        For i As Integer = 0 To lines.Length - 1
            Dim line = lines(i).Trim()
            If String.IsNullOrWhiteSpace(line) Then Continue For

            If i = 0 AndAlso line.StartsWith("IDBus", StringComparison.OrdinalIgnoreCase) Then
                Continue For
            End If

            Dim parts() As String = line.Split(","c)
            If parts.Length < 5 Then Continue For

            Dim idBus = parts(0).Trim()
            Dim rute = parts(1).Trim()
            Dim halte = parts(2).Trim()

            Dim eta As Integer
            If Not Integer.TryParse(parts(3).Trim(), eta) Then eta = 0

            Dim status = parts(4).Trim().ToUpper()
            Dim ket As String = GetKeterangan(status, eta)

            dataBus.Add(New BusTracking With {
                .IDBus = idBus,
                .Rute = rute,
                .HalteTerakhir = halte,
                .ETAmenit = eta,
                .Status = status,
                .Keterangan = ket
            })
        Next
    End Sub

    ' ================== FUNCTION: KETERANGAN (PERCABANGAN) ==================
    Private Function GetKeterangan(status As String, eta As Integer) As String
        If status = "ARRIVED" Then
            Return "Sudah sampai tujuan"
        ElseIf status = "DELAY" Then
            If eta >= 15 Then
                Return "Terlambat parah - kemungkinan macet"
            Else
                Return "Terlambat - cek kondisi jalan"
            End If
        ElseIf status = "ON_ROUTE" Then
            If eta <= 5 Then
                Return "Akan tiba sebentar lagi"
            Else
                Return "Dalam perjalanan"
            End If
        Else
            Return "Status tidak dikenal"
        End If
    End Function

    ' ================== COMBO ID BUS CHANGED ==================
    Private Sub cmbitem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbitem.SelectedIndexChanged
        If cmbitem.SelectedItem Is Nothing Then Return
        TampilkanDetailBus(cmbitem.SelectedItem.ToString())
    End Sub

    ' ================== BUTTON: TAMPILKAN ==================
    Private Sub btntotal_Click(sender As Object, e As EventArgs) Handles btntotal.Click
        If cmbitem.SelectedItem Is Nothing Then
            MessageBox.Show("Pilih ID Bus dulu ya.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        TampilkanDetailBus(cmbitem.SelectedItem.ToString())
    End Sub

    ' ================== PROCEDURE: TAMPILKAN DETAIL BUS ==================
    Private Sub TampilkanDetailBus(idBus As String)
        Dim bus = filteredBus.FirstOrDefault(Function(x) x.IDBus = idBus)

        If bus Is Nothing Then
            ClearDetail()
            txtbayar.Text = "Bus tidak ada di filter saat ini."
            txtkembali.Text = ""
            Label2.Text = "0"
            Return
        End If

        txtharga.Text = bus.Rute
        txtjumlah.Text = bus.HalteTerakhir
        txtsubtotal.Text = bus.ETAmenit.ToString()
        txtdiskon.Text = bus.Status
        txttotal.Text = bus.Keterangan

        If bus.Status = "ARRIVED" OrElse bus.ETAmenit = 0 Then
            Label2.Text = "ARRIVED"
        Else
            Label2.Text = bus.ETAmenit.ToString()
        End If

        UpdateInfoPanel()
    End Sub

    ' ================== PROCEDURE: UPDATE INFO ==================
    Private Sub UpdateInfoPanel()
        Dim totalData As Integer = dataBus.Count
        Dim shownData As Integer = filteredBus.Count

        Dim onRoute As Integer = 0
        Dim delay As Integer = 0
        Dim arrived As Integer = 0

        For Each b In filteredBus
            If b.Status = "ON_ROUTE" Then
                onRoute += 1
            ElseIf b.Status = "DELAY" Then
                delay += 1
            ElseIf b.Status = "ARRIVED" Then
                arrived += 1
            End If
        Next

        txtbayar.Text =
            "Filter Aktif: " & GetFilterAktif() & vbCrLf &
            "ON_ROUTE: " & onRoute & vbCrLf &
            "DELAY: " & delay & vbCrLf &
            "ARRIVED: " & arrived

        txtkembali.Text =
            "Total Data File: " & totalData & vbCrLf &
            "Ditampilkan: " & shownData
    End Sub

    ' ================== FILTER via RADIO BUTTON ==================
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then ApplyFilter("ON_ROUTE")
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then ApplyFilter("DELAY")
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then ApplyFilter("ARRIVED")
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then ApplyFilter("ALL")
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ApplyFilter("ALL")
        End If
    End Sub

    ' ================== PROCEDURE: APPLY FILTER ==================
    Private Sub ApplyFilter(filter As String)
        If dataBus.Count = 0 Then
            MessageBox.Show("Load file dulu ya.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        filter = filter.ToUpper()

        If filter = "ALL" Then
            filteredBus = New List(Of BusTracking)(dataBus)
        Else
            filteredBus = New List(Of BusTracking)
            For Each b In dataBus
                If b.Status = filter Then
                    filteredBus.Add(b)
                End If
            Next
        End If

        cmbitem.Items.Clear()
        For Each b In filteredBus
            cmbitem.Items.Add(b.IDBus)
        Next

        UpdateInfoPanel()

        If cmbitem.Items.Count > 0 Then
            cmbitem.SelectedIndex = 0
        Else
            ClearDetail()
            Label2.Text = "0"
            txtbayar.Text = "Tidak ada bus sesuai filter."
            txtkembali.Text = ""
        End If
    End Sub

    Private Function GetFilterAktif() As String
        If RadioButton1.Checked Then Return "ON_ROUTE"
        If RadioButton2.Checked Then Return "DELAY"
        If RadioButton3.Checked Then Return "ARRIVED"
        If RadioButton4.Checked Then Return "ALL"
        Return "ALL"
    End Function

    ' ================== RESET ==================
    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        ResetForm()
    End Sub

    Private Sub ResetForm()
        cmbitem.Text = ""
        cmbitem.Items.Clear()

        ClearDetail()

        txtbayar.Text = ""
        txtkembali.Text = ""

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = True
        RadioButton5.Checked = False

        Label2.Text = "0"
    End Sub

    Private Sub ClearDetail()
        txtharga.Text = ""
        txtjumlah.Text = ""
        txtsubtotal.Text = ""
        txtdiskon.Text = ""
        txttotal.Text = ""
    End Sub

    ' ================== CLOSE ==================
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

End Class

' ================== MODEL DATA ==================
Public Class BusTracking
    Public Property IDBus As String
    Public Property Rute As String
    Public Property HalteTerakhir As String
    Public Property ETAmenit As Integer
    Public Property Status As String
    Public Property Keterangan As String
End Class
