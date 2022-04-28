# Northwind Database ile N-Katmanlı Mimari

### Senaryo
---
Her bir Model Class'ın Dto Class'larını Oluşturmak

1. N-Katmanlı Mimaride Entity katmanında bulunan Model klasörü altındaki class'ların Dto class'larını oluşturmak ve MappingProfile yapısını eklemek.

Her bir Model'e ait;

1. Interface katmanına Servis'lerin tanımlanması
1. Bll (Business Logic Layer - İş Katmanı) katmanına Manager sınıflarının tanımlanması
1. Dal (Data Access Layer) katmanına Interface'lerin (IRepository) ve Class'ların (Repository) tanımlanması.

### Amaç
---
1. N-Katmanlı Mimaride Model ve DtoModel yapısını anlamak ve kullananabilmek.
1. Interface katmanında bulunan Servis'lerin Manager'a Kalıtım verir.
1. IRepository -> Repository yapısına kalıtım verir.


**Northwind Database:** Sql'e yeni başlayanların ya da kendilerini geliştirmek için sorgu örneklerini detaylı bir şekilde kullanabilecekleri Microsoft'un sağlamış olduğu ücretsiz bir database örneğidir.
