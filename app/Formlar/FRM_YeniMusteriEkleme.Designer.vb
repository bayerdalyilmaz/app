<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_YeniMusteriEkleme
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GRP_MusteriBilgileri = New GroupBox()
        BTN_YeniMusteriEkleFormuTemizle = New Button()
        BTN_YeniMusteriEkleVazgec = New Button()
        BTN_YeniMusteriEkleOnay = New Button()
        Label6 = New Label()
        TXT_MusteriDurum = New TextBox()
        Label5 = New Label()
        TXT_MusteriEkBilgi = New TextBox()
        Label4 = New Label()
        TXT_MusteriTelefon = New TextBox()
        Label3 = New Label()
        TXT_MusteriSoyadi = New TextBox()
        Label2 = New Label()
        TXT_MusteriAdi = New TextBox()
        Label1 = New Label()
        TXT_MusteriNo = New TextBox()
        Label7 = New Label()
        TXT_MusteriKodu = New TextBox()
        GRP_MusteriBilgileri.SuspendLayout()
        SuspendLayout()
        ' 
        ' GRP_MusteriBilgileri
        ' 
        GRP_MusteriBilgileri.Controls.Add(Label7)
        GRP_MusteriBilgileri.Controls.Add(TXT_MusteriKodu)
        GRP_MusteriBilgileri.Controls.Add(BTN_YeniMusteriEkleFormuTemizle)
        GRP_MusteriBilgileri.Controls.Add(BTN_YeniMusteriEkleVazgec)
        GRP_MusteriBilgileri.Controls.Add(BTN_YeniMusteriEkleOnay)
        GRP_MusteriBilgileri.Controls.Add(Label6)
        GRP_MusteriBilgileri.Controls.Add(TXT_MusteriDurum)
        GRP_MusteriBilgileri.Controls.Add(Label5)
        GRP_MusteriBilgileri.Controls.Add(TXT_MusteriEkBilgi)
        GRP_MusteriBilgileri.Controls.Add(Label4)
        GRP_MusteriBilgileri.Controls.Add(TXT_MusteriTelefon)
        GRP_MusteriBilgileri.Controls.Add(Label3)
        GRP_MusteriBilgileri.Controls.Add(TXT_MusteriSoyadi)
        GRP_MusteriBilgileri.Controls.Add(Label2)
        GRP_MusteriBilgileri.Controls.Add(TXT_MusteriAdi)
        GRP_MusteriBilgileri.Controls.Add(Label1)
        GRP_MusteriBilgileri.Controls.Add(TXT_MusteriNo)
        GRP_MusteriBilgileri.Location = New Point(12, 12)
        GRP_MusteriBilgileri.Name = "GRP_MusteriBilgileri"
        GRP_MusteriBilgileri.Size = New Size(506, 247)
        GRP_MusteriBilgileri.TabIndex = 5
        GRP_MusteriBilgileri.TabStop = False
        GRP_MusteriBilgileri.Text = "Yeni Müşteri Bilgileri"
        ' 
        ' BTN_YeniMusteriEkleFormuTemizle
        ' 
        BTN_YeniMusteriEkleFormuTemizle.Location = New Point(377, 21)
        BTN_YeniMusteriEkleFormuTemizle.Name = "BTN_YeniMusteriEkleFormuTemizle"
        BTN_YeniMusteriEkleFormuTemizle.Size = New Size(103, 44)
        BTN_YeniMusteriEkleFormuTemizle.TabIndex = 15
        BTN_YeniMusteriEkleFormuTemizle.Text = "Formu Temizle"
        BTN_YeniMusteriEkleFormuTemizle.UseVisualStyleBackColor = True
        ' 
        ' BTN_YeniMusteriEkleVazgec
        ' 
        BTN_YeniMusteriEkleVazgec.Location = New Point(377, 71)
        BTN_YeniMusteriEkleVazgec.Name = "BTN_YeniMusteriEkleVazgec"
        BTN_YeniMusteriEkleVazgec.Size = New Size(103, 44)
        BTN_YeniMusteriEkleVazgec.TabIndex = 14
        BTN_YeniMusteriEkleVazgec.Text = "Ekle"
        BTN_YeniMusteriEkleVazgec.UseVisualStyleBackColor = True
        ' 
        ' BTN_YeniMusteriEkleOnay
        ' 
        BTN_YeniMusteriEkleOnay.Location = New Point(377, 121)
        BTN_YeniMusteriEkleOnay.Name = "BTN_YeniMusteriEkleOnay"
        BTN_YeniMusteriEkleOnay.Size = New Size(103, 47)
        BTN_YeniMusteriEkleOnay.TabIndex = 13
        BTN_YeniMusteriEkleOnay.Text = "Vazgeç"
        BTN_YeniMusteriEkleOnay.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 57)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 15)
        Label6.TabIndex = 12
        Label6.Text = "Durum"
        ' 
        ' TXT_MusteriDurum
        ' 
        TXT_MusteriDurum.Location = New Point(102, 54)
        TXT_MusteriDurum.Name = "TXT_MusteriDurum"
        TXT_MusteriDurum.Size = New Size(100, 23)
        TXT_MusteriDurum.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(217, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 9
        Label5.Text = "Ek Bilgi"
        ' 
        ' TXT_MusteriEkBilgi
        ' 
        TXT_MusteriEkBilgi.Location = New Point(268, 25)
        TXT_MusteriEkBilgi.Multiline = True
        TXT_MusteriEkBilgi.Name = "TXT_MusteriEkBilgi"
        TXT_MusteriEkBilgi.Size = New Size(92, 143)
        TXT_MusteriEkBilgi.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 144)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 15)
        Label4.TabIndex = 7
        Label4.Text = "Telefonu"
        ' 
        ' TXT_MusteriTelefon
        ' 
        TXT_MusteriTelefon.Location = New Point(102, 141)
        TXT_MusteriTelefon.Name = "TXT_MusteriTelefon"
        TXT_MusteriTelefon.Size = New Size(100, 23)
        TXT_MusteriTelefon.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 15)
        Label3.TabIndex = 5
        Label3.Text = "Soaydı"
        ' 
        ' TXT_MusteriSoyadi
        ' 
        TXT_MusteriSoyadi.Location = New Point(102, 112)
        TXT_MusteriSoyadi.Name = "TXT_MusteriSoyadi"
        TXT_MusteriSoyadi.Size = New Size(100, 23)
        TXT_MusteriSoyadi.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 15)
        Label2.TabIndex = 3
        Label2.Text = "Adı"
        ' 
        ' TXT_MusteriAdi
        ' 
        TXT_MusteriAdi.Location = New Point(102, 83)
        TXT_MusteriAdi.Name = "TXT_MusteriAdi"
        TXT_MusteriAdi.Size = New Size(100, 23)
        TXT_MusteriAdi.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(23, 15)
        Label1.TabIndex = 1
        Label1.Text = "No"
        ' 
        ' TXT_MusteriNo
        ' 
        TXT_MusteriNo.Location = New Point(102, 25)
        TXT_MusteriNo.Name = "TXT_MusteriNo"
        TXT_MusteriNo.Size = New Size(100, 23)
        TXT_MusteriNo.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 173)
        Label7.Name = "Label7"
        Label7.Size = New Size(35, 15)
        Label7.TabIndex = 17
        Label7.Text = "Kodu"
        ' 
        ' TXT_MusteriKodu
        ' 
        TXT_MusteriKodu.Location = New Point(102, 170)
        TXT_MusteriKodu.Name = "TXT_MusteriKodu"
        TXT_MusteriKodu.Size = New Size(100, 23)
        TXT_MusteriKodu.TabIndex = 16
        ' 
        ' FRM_YeniMusteriEkleme
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(549, 297)
        Controls.Add(GRP_MusteriBilgileri)
        Name = "FRM_YeniMusteriEkleme"
        Text = "YEni Müşteri Ekleme Formu"
        GRP_MusteriBilgileri.ResumeLayout(False)
        GRP_MusteriBilgileri.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GRP_MusteriBilgileri As GroupBox
    Friend WithEvents BTN_YeniMusteriEkleFormuTemizle As Button
    Friend WithEvents BTN_YeniMusteriEkleVazgec As Button
    Friend WithEvents BTN_YeniMusteriEkleOnay As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_MusteriDurum As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_MusteriEkBilgi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_MusteriTelefon As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_MusteriSoyadi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_MusteriAdi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_MusteriNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_MusteriKodu As TextBox
End Class
