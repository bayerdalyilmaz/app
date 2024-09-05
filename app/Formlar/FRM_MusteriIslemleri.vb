Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class FRM_MusteriIslemleri
    Public connectionString As String
    Dim FRM_Giris As FRM_Giris
    'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\00_CalismaAlani\VB\app\app\app\Kaynaklar\kaynaklar.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES;"""

    Public Sub New(ByVal FRM_Giris As FRM_Giris)
        InitializeComponent()
        FRM_Giris = FRM_Giris
    End Sub
    Private Sub FRM_MusteriIslemleri_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim excelDosyaAdresi As String = FRM_Giris.TXT_ExcelDosyaAdresi.Text
        connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & excelDosyaAdresi & ";Extended Properties=""Excel 12.0 Xml;HDR=YES;"""

        Dim connection As New OleDbConnection(connectionString)
        Dim sql As String
        GRP_Musteriler.Text = "Tüm Müşteriler"
        Try
            connection.Open()
            sql = "SELECT * FROM [MUSTERILER$] ORDER BY MUSTERI_NO DESC"
            Dim musterilerDataSet As New DataSet()
            Dim musterilerDataAdapter As New OleDbDataAdapter(sql, connection)
            musterilerDataAdapter.Fill(musterilerDataSet)
            DGV_Musteriler.DataSource = musterilerDataSet.Tables(0).DefaultView()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub BTN_Giris_Click(sender As Object, e As EventArgs) Handles BTN_Giris.Click
        FRM_Giris.Visible = True
        Me.Visible = False
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connection As New OleDbConnection(connectionString)
        Dim sql As String
        Try
            connection.Open()
            sql = "SELECT count(*)+1 AS MUSTERI_NO FROM [MUSTERILER$]"
            Dim commandSelect As New OleDbCommand(sql, connection)
            Dim reader = commandSelect.ExecuteReader
            Dim musteriNo As String
            While reader.Read
                musteriNo = reader("MUSTERI_NO")
            End While
            Dim musteriDurum = TXT_MusteriDurum.Text
            Dim musteriAdi = TXT_MusteriAdi.Text
            Dim musteriSoyadi = TXT_MusteriSoyadi.Text
            Dim musteriTelefon = TXT_MusteriTelefon.Text
            Dim musteriEkBilgi = TXT_MusteriEkBilgi.Text
            'MsgBox("" & musteriNo & "','" & musteriDurum & "','" & musteriAdi & "','" & musteriSoyadi & "','" & musteriTelefon & "','" & musteriEkBilgi)
            sql = "INSERT INTO [MUSTERILER$] (MUSTERI_NO,MUSTERI_DURUM,MUSTERI_ADI,MUSTERI_SOYADI,MUSTERI_TELEFON,MUSTERI_EK_BILGI) VALUES ('" & musteriNo & "','" & musteriDurum & "','" & musteriAdi & "','" & musteriSoyadi & "','" & musteriTelefon & "','" & musteriEkBilgi & "')"
            Dim commandInsert As New OleDbCommand(sql, connection)
            commandInsert.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim musterilerDataSet As New DataSet()
        Dim connection As New OleDbConnection(connectionString)
        Dim musterilerDataAdapter As New OleDbDataAdapter("SELECT * FROM [MUSTERILER$]", connection)
        connection.Open()

        musterilerDataAdapter.Fill(musterilerDataSet)
        DGV_Musteriler.DataSource = musterilerDataSet.Tables(0).DefaultView()
        connection.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Musteriler.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DGV_Musteriler.Rows(e.RowIndex)
            TXT_MusteriNo.Text = selectedRow.Cells(0).Value.ToString()
            TXT_MusteriDurum.Text = selectedRow.Cells(1).Value.ToString()
            TXT_MusteriAdi.Text = selectedRow.Cells(2).Value.ToString()
            TXT_MusteriSoyadi.Text = selectedRow.Cells(3).Value.ToString()
            TXT_MusteriTelefon.Text = selectedRow.Cells(4).Value.ToString()
            TXT_MusteriKodu.Text = selectedRow.Cells(5).Value.ToString()
            TXT_MusteriEkBilgi.Text = selectedRow.Cells(6).Value.ToString()
        End If
    End Sub

    Private Sub Button2_DoubleClick(sender As Object, e As EventArgs) Handles Button2.DoubleClick
        Dim connection As New OleDbConnection(connectionString)
        Dim command As New OleDbCommand("SELECT * FROM [MUSTERILER$]", connection)
        Try
            connection.Open()
            Dim reader = command.ExecuteReader
            While reader.Read
                'ListBox1.Items.Add(reader("MUSTERI_NO") & " - " & reader("MUSTERI_ADI"))
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connection As New SqlConnection
        connection.ConnectionString = connectionString
        connection.Open()
        Dim musterilerDataTable As New DataTable()
        'Dim musterilerDataTableAdapter As New TableAdapter()
        ' ("SELECT * FROM [MUSTERILER$]", connection)
        'musterilerDataAdapter.Fill(musterilerDataSet)
        'DataGridView1.DataSource = musterilerDataSet.Tables(0).DefaultView()
        connection.Close()
    End Sub



    Private Sub BTN_MusteriAra_Click(sender As Object, e As EventArgs) Handles BTN_MusteriAra.Click
        Dim connection As New OleDbConnection(connectionString)
        Dim sql As String
        Dim arananMetin = TXT_MusteriAra.Text
        If arananMetin <> "" Then

            Try
                connection.Open()
                sql = $"SELECT * FROM [MUSTERILER$] WHERE MUSTERI_NO LIKE '%{arananMetin}%' OR MUSTERI_DURUM LIKE '%{arananMetin}%' OR MUSTERI_ADI LIKE '%{arananMetin}%' OR MUSTERI_SOYADI LIKE '%{arananMetin}%' OR MUSTERI_TELEFON LIKE '%{arananMetin}%' OR MUSTERI_EK_BILGI LIKE '%{arananMetin}%' ORDER BY MUSTERI_NO DESC"
                Dim musterilerDataSet As New DataSet()
                Dim musterilerDataAdapter As New OleDbDataAdapter(sql, connection)
                musterilerDataAdapter.Fill(musterilerDataSet)
                GRP_Musteriler.Text = "Aranan: [" & arananMetin & "] için bulunan tüm müşteriler"
                DGV_Musteriler.DataSource = musterilerDataSet.Tables(0).DefaultView()
            Catch ex As Exception
                MessageBox.Show("Hata oluştu: " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            MsgBox("Aranan değer boş olamaz")
            Me.Controls.Clear()
            InitializeComponent()
            FRM_MusteriIslemleri_Load(e, e)
        End If

    End Sub

    Private Sub BTN_YeniMusteriEklemeFormuAc_Click(sender As Object, e As EventArgs) Handles BTN_YeniMusteriEklemeFormuAc.Click
        FRM_YeniMusteriEkleme.Visible = True
        Me.Visible = False
    End Sub
End Class