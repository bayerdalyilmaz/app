<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_Giris
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
        BTN_MusteriIslemleri = New Button()
        BTN_ExceleBaglan = New Button()
        TXT_ExcelDosyaAdresi = New TextBox()
        DGV_Musteriler = New DataGridView()
        CType(DGV_Musteriler, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BTN_MusteriIslemleri
        ' 
        BTN_MusteriIslemleri.Location = New Point(347, 415)
        BTN_MusteriIslemleri.Name = "BTN_MusteriIslemleri"
        BTN_MusteriIslemleri.Size = New Size(161, 91)
        BTN_MusteriIslemleri.TabIndex = 3
        BTN_MusteriIslemleri.Text = "Müşteri İşlemleri"
        BTN_MusteriIslemleri.UseVisualStyleBackColor = True
        BTN_MusteriIslemleri.Visible = False
        ' 
        ' BTN_ExceleBaglan
        ' 
        BTN_ExceleBaglan.Location = New Point(347, 67)
        BTN_ExceleBaglan.Name = "BTN_ExceleBaglan"
        BTN_ExceleBaglan.Size = New Size(161, 37)
        BTN_ExceleBaglan.TabIndex = 2
        BTN_ExceleBaglan.Text = "Excel'e Bağlan"
        BTN_ExceleBaglan.UseVisualStyleBackColor = True
        ' 
        ' TXT_ExcelDosyaAdresi
        ' 
        TXT_ExcelDosyaAdresi.Location = New Point(268, 29)
        TXT_ExcelDosyaAdresi.Name = "TXT_ExcelDosyaAdresi"
        TXT_ExcelDosyaAdresi.Size = New Size(341, 23)
        TXT_ExcelDosyaAdresi.TabIndex = 1
        ' 
        ' DGV_Musteriler
        ' 
        DGV_Musteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_Musteriler.Location = New Point(12, 135)
        DGV_Musteriler.Name = "DGV_Musteriler"
        DGV_Musteriler.Size = New Size(837, 262)
        DGV_Musteriler.TabIndex = 4
        ' 
        ' FRM_Giris
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(861, 553)
        Controls.Add(DGV_Musteriler)
        Controls.Add(TXT_ExcelDosyaAdresi)
        Controls.Add(BTN_ExceleBaglan)
        Controls.Add(BTN_MusteriIslemleri)
        Name = "FRM_Giris"
        Text = "Giris Ekranı"
        CType(DGV_Musteriler, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BTN_MusteriIslemleri As Button
    Friend WithEvents BTN_ExceleBaglan As Button
    Friend WithEvents DGV_Musteriler As DataGridView
    Public WithEvents TXT_ExcelDosyaAdresi As TextBox

End Class
