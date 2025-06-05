# C# Eğitim Kampı 301 Entity Framework Projesi
NOT: Blank Solution altındaki CSharpEgitimKampi301.EFProject haricindeki kısımlar N katmanlı mimari eğitimiyle ilgilidir. Eğitim devam etmektedir.

# CSharpEgitimKampi301.EFProject
## Ekran Alıntıları
## Formların Ekran Görüntüleri
![resim](https://github.com/user-attachments/assets/ab5ab31f-1499-4111-ae96-ff73ba3a16c2)
![resim](https://github.com/user-attachments/assets/7ea87e41-689c-4097-8630-0b275ee87ee5)
![resim](https://github.com/user-attachments/assets/6dae6b20-024e-4eb5-a867-8d21b9dfa3ec)
## Model1.edmx Ekran Görüntüsü
![resim](https://github.com/user-attachments/assets/32a615a9-59e7-4533-8be0-c88af8a86f0c)



# Açıklama
Bu proje Murat Yücedağ'ın Youtube C# Eğitim Kampı sırasınde geliştirilmiştir. Windows Forms uygulaması altında  Entity Framework kullanılarak veri tabanı işlemleri gerçekleştirilmiştir. Veritabanı Database First yaklaşımı kullanılarak oluşturulmuştur. Proje üç form içerir.

## Kullanılan Teknolojiler
- **C#**
-  **Entity Framework (Database First)**
- **LINQ Sorguları**
- **Windows Forms**

## Formlar

### Form1
Bu form, rehber bilgilerini listeleme, ekleme, silme, güncelleme ve ID'ye göre getirme işlevlerini içerir. CRUD işlemleri Entity Framework kullanılarak gerçekleştirilmiştir.

### FrmLocation
Bu form, lokasyon bilgilerini listeleme, ekleme, silme ve güncelleme işlevlerini içerir. Entity Framework ve LINQ sorguları kullanılmıştır.

### FrmStatistics
Bu form, çeşitli istatistikleri görüntüler. Lokasyon sayısı, toplam kapasite, rehber sayısı, ortalama tur kapasitesi ve fiyatı gibi istatistikler içerir. İstatistiksel veriler LINQ sorguları kullanılarak veritabanından çekilmiştir.

## Özellikler
- **Database First Yaklaşımı:** Veritabanı modeli Entity Framework kullanılarak otomatik olarak oluşturulmuştur. 4 farklı tablo bulunmaktadır: Admin, Guide, Location, Customer.
- **LINQ Sorguları:** Veri tabanıyla etkileşim için LINQ sorguları kullanılmıştır.
- **CRUD İşlemleri:** Kayıt ekleme, silme, güncelleme ve listeleme işlemleri yapılmıştır.
- **İstatistiksel Veriler:** Veritabanından çekilen çeşitli istatistiksel bilgiler formda gösterilmiştir. İstatistiksel veriler LINQ sorguları ile çekilmiştir.
