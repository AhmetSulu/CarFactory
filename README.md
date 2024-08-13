# Araba Üretim Programı

Bu program, kullanıcıların arabalar üretmesini sağlayan bir konsol uygulamasıdır. Üretilen arabalar bir listeye eklenir ve program sonlandığında bu liste ekrana yazdırılır.

## Özellikler

- Kullanıcıdan araba üretmek isteyip istemediği sorulur.
- Üretim tarihini otomatik olarak atayan arabalar üretilir.
- Kapı sayısı gibi kullanıcıdan alınan bilgiler doğrulama yapılır.
- Üretilen arabalar, seri numarası, marka, model, renk, kapı sayısı ve üretim tarihi bilgileriyle birlikte listelenir.

## Kullanım

1. Program çalıştırıldığında, kullanıcıya bir araba üretmek isteyip istemediği sorulur. (E/H)
   - `E` seçeneği seçilirse, kullanıcıdan araba bilgileri (seri numarası, marka, model, renk, kapı sayısı) alınır.
   - `H` seçeneği seçilirse, program sonlandırılır ve üretilen arabaların listesi ekrana yazdırılır.

2. Kapı sayısı gibi kullanıcıdan alınan bilgilerin sayısal olup olmadığı kontrol edilir. Hatalı girişlerde uyarı mesajı gösterilir ve tekrar giriş yapılması istenir.

3. Üretilen tüm arabaların bilgileri program sonlandığında ekrana yazdırılır.

## Kod Açıklamaları

- **`Car` Sınıfı**: Araba nesnesini temsil eder. Üretim tarihi otomatik olarak atanır.
- **`Program` Sınıfı**: Programın ana işleyişini sağlar. Kullanıcıdan bilgi alır, araba üretir ve listeyi ekrana yazdırır.
- **`GetAllCars` Metodu**: Üretilen tüm arabaların bilgilerini ekrana yazdırır.

## Kurulum

1. Bu kodu bir C# projesine kopyalayın.
2. Projeyi çalıştırmak için bir C# geliştirme ortamına (örneğin, Visual Studio) sahip olun.
3. Programı çalıştırarak arabalar üretmeye başlayın.
