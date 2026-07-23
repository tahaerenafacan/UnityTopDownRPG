# Unity Top Down RPG

Solo geliştirici olarak, **öğrenme amaçlı** geliştirdiğim bir top-down RPG prototipi. Ticari bir ürün değildir. Projeye ilk olarak Unity 2020 versiyonunda başladım; daha sonra Unity 6.3'e upgrade ettim. Bu yüzden proje içinde hem eski dönem kararlarımın (ör. Built-in Render Pipeline, eski Input System) izlerini bulabilirsiniz.

## 📖 Proje Hakkında

Bu proje, Unity öğrenme sürecimin erken bir aşamasında başladı ve zamanla üzerine eklemeler yaptım. Kod yapısı, o dönemki deneyim seviyemi yansıtıyor; yani mimari açıdan en temiz veya en "best practice" hâliyle övünen bir proje değil. Yine de temel bir top-down RPG'nin işleyen bir prototipini ortaya koyuyor ve bugüne kadarki gelişimimi gösteren bir kilometre taşı olarak portfolyomda yer alıyor.

## ✨ Özellikler

- Top-down karakter kontrolü ve kamera sistemi
- Deneyim / seviye atlama mekaniği
- Karakter için kendi yazdığım diyalog sistemi ve editör aracı
- Basit kaydetme (save) sistemi ve save encryption strategies (Json, Xor, Xor 64)
- Built-in Render Pipeline (BRP)

## 🎮 Kontroller

| Tuş | İşlev |
| --- | --- |
| `S` | Oyunu kaydeder (Save Game) |
| `E` | 1000 EXP kazandırır (test/debug amaçlı) |

## 🛠️ Kullanılan Teknolojiler

- **Unity 6.3** (proje 2020'de başlayıp bu sürüme upgrade edildi)
- **C#** — oyun mantığı ve sistemler
- **Built-in Render Pipeline (BRP)**
- Unity'nin **eski (Input Manager) Input System**'i

## 📦 Kurulum

1. Bu repoyu klonlayın:
   ```bash
   git clone https://github.com/tahaerenafacan/UnityTopDownRPG.git
   ```
2. Unity Hub üzerinden projeyi Unity 6 (veya üzeri uyumlu bir sürüm) ile açın.
3. Gerekli paketlerin Package Manager üzerinden otomatik olarak yüklendiğinden emin olun.
4. Bir sahneyi açıp Play moduna geçerek projeyi deneyimleyebilirsiniz.

Hazır bir derlenmiş sürümü denemek isterseniz, [Releases](https://github.com/tahaerenafacan/UnityTopDownRPG/releases) sekmesinden Windows derlemesine ulaşabilirsiniz.

## 🚧 Proje Durumu

Bu proje, öğrenme sürecimin bir parçası olarak tamamlanmış bir prototip niteliğindedir. Kod kalitesi güncel standartlarımı yansıtmıyor olabilir; yine de nereden başladığımı gösteren bir referans olarak burada duruyor.

## 📄 Lisans

Bu proje ticari bir ürün değildir; yalnızca eğitim ve portfolyo amacıyla paylaşılmıştır.

**Taha Eren Afacan**
GitHub: [@tahaerenafacan](https://github.com/tahaerenafacan)
