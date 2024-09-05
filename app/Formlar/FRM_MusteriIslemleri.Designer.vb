<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MusteriIslemleri
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
        BTN_Giris = New Button()
        GRP_MusteriArama = New GroupBox()
        TXT_MusteriAra = New TextBox()
        BTN_MusteriAra = New Button()
        GRP_Musteriler = New GroupBox()
        DGV_Musteriler = New DataGridView()
        GRP_MusteriBilgileri = New GroupBox()
        Label7 = New Label()
        TXT_MusteriKodu = New TextBox()
        Button4 = New Button()
        Button2 = New Button()
        Button3 = New Button()
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
        GRP_MusteriIslemleri = New GroupBox()
        BTN_MusteriOdemeleri = New Button()
        BTN_MusteriIslemleri = New Button()
        BTN_YeniMusteriEklemeFormuAc = New Button()
        GRP_MusteriArama.SuspendLayout()
        GRP_Musteriler.SuspendLayout()
        CType(DGV_Musteriler, ComponentModel.ISupportInitialize).BeginInit()
        GRP_MusteriBilgileri.SuspendLayout()
        GRP_MusteriIslemleri.SuspendLayout()
        SuspendLayout()
        ' 
        ' BTN_Giris
        ' 
        BTN_Giris.ForeColor = SystemColors.ActiveCaptionText
        BTN_Giris.Location = New Point(953, 12)
        BTN_Giris.Name = "BTN_Giris"
        BTN_Giris.Size = New Size(141, 64)
        BTN_Giris.TabIndex = 0
        BTN_Giris.Text = "Giriş Ekranına Dön"
        BTN_Giris.UseVisualStyleBackColor = True
        ' 
        ' GRP_MusteriArama
        ' 
        GRP_MusteriArama.Controls.Add(TXT_MusteriAra)
        GRP_MusteriArama.Controls.Add(BTN_MusteriAra)
        GRP_MusteriArama.Location = New Point(12, 12)
        GRP_MusteriArama.Name = "GRP_MusteriArama"
        GRP_MusteriArama.Size = New Size(322, 64)
        GRP_MusteriArama.TabIndex = 2
        GRP_MusteriArama.TabStop = False
        GRP_MusteriArama.Text = "Müşteri Arama"
        ' 
        ' TXT_MusteriAra
        ' 
        TXT_MusteriAra.Location = New Point(6, 22)
        TXT_MusteriAra.Name = "TXT_MusteriAra"
        TXT_MusteriAra.Size = New Size(198, 23)
        TXT_MusteriAra.TabIndex = 1
        ' 
        ' BTN_MusteriAra
        ' 
        BTN_MusteriAra.Location = New Point(219, 22)
        BTN_MusteriAra.Name = "BTN_MusteriAra"
        BTN_MusteriAra.Size = New Size(97, 23)
        BTN_MusteriAra.TabIndex = 0
        BTN_MusteriAra.Text = "Müşteri Ara"
        BTN_MusteriAra.UseVisualStyleBackColor = True
        ' 
        ' GRP_Musteriler
        ' 
        GRP_Musteriler.Controls.Add(DGV_Musteriler)
        GRP_Musteriler.Location = New Point(12, 299)
        GRP_Musteriler.Name = "GRP_Musteriler"
        GRP_Musteriler.Size = New Size(1037, 418)
        GRP_Musteriler.TabIndex = 3
        GRP_Musteriler.TabStop = False
        GRP_Musteriler.Text = "Müşteriler"
        ' 
        ' DGV_Musteriler
        ' 
        DGV_Musteriler.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DGV_Musteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_Musteriler.Location = New Point(6, 22)
        DGV_Musteriler.Name = "DGV_Musteriler"
        DGV_Musteriler.Size = New Size(1025, 379)
        DGV_Musteriler.TabIndex = 0
        ' 
        ' GRP_MusteriBilgileri
        ' 
        GRP_MusteriBilgileri.Controls.Add(Label7)
        GRP_MusteriBilgileri.Controls.Add(TXT_MusteriKodu)
        GRP_MusteriBilgileri.Controls.Add(Button4)
        GRP_MusteriBilgileri.Controls.Add(Button2)
        GRP_MusteriBilgileri.Controls.Add(Button3)
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
        GRP_MusteriBilgileri.Location = New Point(14, 85)
        GRP_MusteriBilgileri.Name = "GRP_MusteriBilgileri"
        GRP_MusteriBilgileri.Size = New Size(472, 208)
        GRP_MusteriBilgileri.TabIndex = 4
        GRP_MusteriBilgileri.TabStop = False
        GRP_MusteriBilgileri.Text = "Seçili Müşteri Bilgileri"
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
        ' Button4
        ' 
        Button4.Location = New Point(379, 86)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 15
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(379, 57)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 14
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(379, 25)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 13
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
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
        ' GRP_MusteriIslemleri
        ' 
        GRP_MusteriIslemleri.Controls.Add(BTN_MusteriOdemeleri)
        GRP_MusteriIslemleri.Controls.Add(BTN_MusteriIslemleri)
        GRP_MusteriIslemleri.Location = New Point(492, 85)
        GRP_MusteriIslemleri.Name = "GRP_MusteriIslemleri"
        GRP_MusteriIslemleri.Size = New Size(163, 170)
        GRP_MusteriIslemleri.TabIndex = 5
        GRP_MusteriIslemleri.TabStop = False
        GRP_MusteriIslemleri.Text = "Seçili Müşteri İşlemleri"
        ' 
        ' BTN_MusteriOdemeleri
        ' 
        BTN_MusteriOdemeleri.Location = New Point(6, 65)
        BTN_MusteriOdemeleri.Name = "BTN_MusteriOdemeleri"
        BTN_MusteriOdemeleri.Size = New Size(151, 41)
        BTN_MusteriOdemeleri.TabIndex = 1
        BTN_MusteriOdemeleri.Text = "Müşteri Ödemeleri"
        BTN_MusteriOdemeleri.UseVisualStyleBackColor = True
        ' 
        ' BTN_MusteriIslemleri
        ' 
        BTN_MusteriIslemleri.Location = New Point(6, 22)
        BTN_MusteriIslemleri.Name = "BTN_MusteriIslemleri"
        BTN_MusteriIslemleri.Size = New Size(151, 41)
        BTN_MusteriIslemleri.TabIndex = 0
        BTN_MusteriIslemleri.Text = "Müşteri İşlemleri"
        BTN_MusteriIslemleri.UseVisualStyleBackColor = True
        ' 
        ' BTN_YeniMusteriEklemeFormuAc
        ' 
        BTN_YeniMusteriEklemeFormuAc.ForeColor = SystemColors.ActiveCaptionText
        BTN_YeniMusteriEklemeFormuAc.ImageAlign = ContentAlignment.TopCenter
        BTN_YeniMusteriEklemeFormuAc.Location = New Point(806, 13)
        BTN_YeniMusteriEklemeFormuAc.Name = "BTN_YeniMusteriEklemeFormuAc"
        BTN_YeniMusteriEklemeFormuAc.Size = New Size(141, 64)
        BTN_YeniMusteriEklemeFormuAc.TabIndex = 6
        BTN_YeniMusteriEklemeFormuAc.Text = "Yeni Müşteri Ekle"
        BTN_YeniMusteriEklemeFormuAc.UseVisualStyleBackColor = True
        ' 
        ' FRM_MusteriIslemleri
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1106, 751)
        Controls.Add(BTN_YeniMusteriEklemeFormuAc)
        Controls.Add(GRP_MusteriIslemleri)
        Controls.Add(GRP_MusteriBilgileri)
        Controls.Add(GRP_Musteriler)
        Controls.Add(GRP_MusteriArama)
        Controls.Add(BTN_Giris)
        Name = "FRM_MusteriIslemleri"
        Text = "Müşteri İşlemleri Ekranı"
        GRP_MusteriArama.ResumeLayout(False)
        GRP_MusteriArama.PerformLayout()
        GRP_Musteriler.ResumeLayout(False)
        CType(DGV_Musteriler, ComponentModel.ISupportInitialize).EndInit()
        GRP_MusteriBilgileri.ResumeLayout(False)
        GRP_MusteriBilgileri.PerformLayout()
        GRP_MusteriIslemleri.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents BTN_Giris As Button
    Friend WithEvents GRP_MusteriArama As GroupBox
    Friend WithEvents TXT_MusteriAra As TextBox
    Friend WithEvents BTN_MusteriAra As Button
    Friend WithEvents GRP_Musteriler As GroupBox
    Friend WithEvents DGV_Musteriler As DataGridView
    Friend WithEvents GRP_MusteriBilgileri As GroupBox
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
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_MusteriDurum As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GRP_MusteriIslemleri As GroupBox
    Friend WithEvents BTN_MusteriOdemeleri As Button
    Friend WithEvents BTN_MusteriIslemleri As Button
    Friend WithEvents BTN_YeniMusteriEklemeFormuAc As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_MusteriKodu As TextBox
End Class
