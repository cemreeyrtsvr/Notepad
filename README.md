#  NotePad (C# Windows Forms)

Bu proje, C# programlama dili ve Windows Forms (.NET Framework) kullanılarak geliştirilmiş temel bir Not Defteri (Notepad) uygulamasıdır. 
##  Proje Durumu ve Teknolojiler

| Badge | Açıklama |
| :--- | :--- |
| ![C#](https://img.shields.io/badge/Language-C%23-blue.svg?style=for-the-badge&logo=c-sharp) | Proje C# ile yazılmıştır. |
| ![Platform](https://img.shields.io/badge/Platform-Windows%20Forms-4CAF50?style=for-the-badge&logo=windows) | Kullanıcı arayüzü Windows Forms kullanılarak geliştirilmiştir. |
| ![Framework](https://img.shields.io/badge/.NET%20Framework-.NET%20Framework-512BD4?style=for-the-badge&logo=dotnet) | .NET Framework üzerinde çalışır. |


---

##  Özellikler

Uygulamanın temel ve ek özellikleri:

### Dosya Yönetimi
* **Yeni:** Yeni, boş bir belge başlatma.
* **Aç:** Mevcut bir metin dosyasını (`.txt`) açma.
* **Kaydet & Farklı Kaydet:** Kaydedilmemiş dosyaları kaydetme ve kayıtlı dosyaları yeni bir isimle kaydetme (`Kaydet` ve `Farklı Kaydet` mantığı ayrılmıştır).
* **Çıkış:** Uygulamadan çıkarken **kayıt uyarısı** sunma.

### Düzenleme ve İşlevsellik
* **Kes / Kopyala / Yapıştır:** Temel metin düzenleme işlevleri.
* **Tarih/Saat Ekleme:** İmlecin bulunduğu yere anlık tarih ve saati ekleme.


### Biçimlendirme ve Görünüm
* **Yazı Tipi:** Belgenin yazı tipini, boyutunu ve stilini ayarlama.
* **Metin Rengi:** Seçili metnin rengini değiştirme.
* **Arka Plan Rengi:** Metin düzenleyicinin arka plan rengini değiştirme.


---

##  Kurulum ve Çalıştırma

1.  **Visual Studio Kurulumu:** C# ve .NET masaüstü geliştirme iş yükünün yüklü olduğu bir Visual Studio sürümüne ihtiyacınız var.
2.  **Projeyi Açma:** Bu kod dosyalarını (.cs) bir **Windows Forms Uygulaması** projesine ekleyin veya projeyi doğrudan Visual Studio'da açın.
3.  **Tasarım Kontrolü:** `Form1.cs [Design]` ekranında aşağıdaki bileşenlerin ve menü öğelerinin doğru `Name` özellikleriyle bağlandığından emin olun (Örneğin, `richTextBox1`, `kaydetToolStripMenuItem`, `kalinToolStripMenuItem`, vb.).
4.  **Derleme:** Visual Studio'da `Başlat` (F5) tuşuna basarak projeyi derleyin ve çalıştırın.

---

## Kullanılan Namespace

Projenin temel `namespace` adı aşağıdaki gibidir:

```csharp
namespace NotePad
