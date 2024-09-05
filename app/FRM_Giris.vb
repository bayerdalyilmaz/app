Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class FRM_Giris
    Private Sub BTN_MusteriIslemleri_Click(sender As Object, e As EventArgs) Handles BTN_MusteriIslemleri.Click
        FRM_MusteriIslemleri.Visible = True
        Me.Visible = False
    End Sub

    Private Sub BTN_ExceleBaglan_Click(sender As Object, e As EventArgs) Handles BTN_ExceleBaglan.Click
        Dim excelDosyaAdresi As String = TXT_ExcelDosyaAdresi.Text
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & excelDosyaAdresi & ";Extended Properties=""Excel 12.0 Xml;HDR=YES;"""
        Dim connection As New OleDbConnection(connectionString)
        Dim sql As String
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
End Class
