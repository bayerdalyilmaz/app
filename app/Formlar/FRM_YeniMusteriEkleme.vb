Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class FRM_YeniMusteriEkleme
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\00_CalismaAlani\VB\app\app\app\Kaynaklar\kaynaklar.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES;"""
    Dim connection As New OleDbConnection(connectionString)
    Dim sql As String
    Private Sub FRM_YeniMusteriEkleme_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TXT_MusteriNo.Text = ""
        TXT_MusteriDurum.Text = ""
        TXT_MusteriAdi.Text = ""
        TXT_MusteriSoyadi.Text = ""
        TXT_MusteriTelefon.Text = ""
        TXT_MusteriKodu.Text = ""
        TXT_MusteriEkBilgi.Text = ""
        Try
            connection.Open()
            sql = "SELECT count(*)+1 AS MUSTERI_NO FROM [MUSTERILER$]"
            Dim commandSelect As New OleDbCommand(sql, connection)
            Dim reader = commandSelect.ExecuteReader
            Dim musteriNo As String
            While reader.Read
                musteriNo = reader("MUSTERI_NO")
            End While
            TXT_MusteriNo.Text = musteriNo
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub BTN_YeniMusteriEkleFormuTemizle_Click(sender As Object, e As EventArgs) Handles BTN_YeniMusteriEkleFormuTemizle.Click
        'TXT_MusteriNo.Text = ""
        TXT_MusteriDurum.Text = ""
        TXT_MusteriAdi.Text = ""
        TXT_MusteriSoyadi.Text = ""
        TXT_MusteriTelefon.Text = ""
        TXT_MusteriKodu.Text = ""
        TXT_MusteriEkBilgi.Text = ""
    End Sub

    Private Sub BTN_YeniMusteriEkleVazgec_Click(sender As Object, e As EventArgs) Handles BTN_YeniMusteriEkleOnay.Click
        'FRM_MusteriIslemleri.Visible = True
        Me.Visible = False
    End Sub

    Private Sub BTN_YeniMusteriEkleOnay_Click(sender As Object, e As EventArgs) Handles BTN_YeniMusteriEkleVazgec.Click
        Try
            connection.Open()
            Dim musteriNo = TXT_MusteriNo.Text
            Dim musteriDurum = TXT_MusteriDurum.Text
            Dim musteriAdi = TXT_MusteriAdi.Text
            Dim musteriSoyadi = TXT_MusteriSoyadi.Text
            Dim musteriTelefon = TXT_MusteriTelefon.Text
            Dim musteriKodu = TXT_MusteriKodu.Text
            Dim musteriEkBilgi = TXT_MusteriEkBilgi.Text
            'MsgBox("" & musteriNo & "','" & musteriDurum & "','" & musteriAdi & "','" & musteriSoyadi & "','" & musteriTelefon & "','" & musteriEkBilgi)
            sql = "INSERT INTO [MUSTERILER$] (MUSTERI_NO,MUSTERI_DURUM,MUSTERI_ADI,MUSTERI_SOYADI,MUSTERI_TELEFON,MUSTERI_KODU,MUSTERI_EK_BILGI) VALUES ('" & musteriNo & "','" & musteriDurum & "','" & musteriAdi & "','" & musteriSoyadi & "','" & musteriTelefon & "','" & musteriKodu & "','" & musteriEkBilgi & "')"
            Dim commandInsert As New OleDbCommand(sql, connection)
            commandInsert.ExecuteNonQuery()
            MessageBox.Show("Yeni Müşteri Eklendi, [Müşteriler] Formuna dönülüyor.")
            'FRM_MusteriIslemleri.Visible = True
            Me.Visible = False
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
End Class