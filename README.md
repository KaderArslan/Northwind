# Northwind Database ile N-Katmanlı Mimari

## Senaryo
Microsoft'un sağladığı Northwind Database ile .Net5 ile N Katmanlı Mimari Yapısını kurmak ve Jwt Token ile Token oluşturmak.

### Her bir Model'e ait;
1. N-Katmanlı Mimaride Entity katmanında bulunan Model klasörü altındaki class'ların Dto class'larını oluşturmak ve MappingProfile yapısını eklemek,
1. Interface katmanına Servis'lerin tanımlanması,
1. Dal (Data Access Layer) katmanına Interface'lerin (IRepository) ve Class'ların (Repository) tanımlanması,
1. Bll (Business Logic Layer - İş Katmanı) katmanına Manager sınıflarının tanımlanması,
1. WebApi katmanında Controller yapılarını oluşturmak.
---

**Northwind Database:** Sql'e yeni başlayanların ya da kendilerini geliştirmek için sorgu örneklerini detaylı bir şekilde kullanabilecekleri Microsoft'un sağlamış olduğu ücretsiz bir database örneğidir.

---

## Uygulama Görselleri
### User Login
![UserLogin](https://github.com/KaderArslan/Northwind/blob/master/screenshots/user.png)
---
### Category
![Category](https://github.com/KaderArslan/Northwind/blob/master/screenshots/category.png)
---
### Customer
![Customer](https://github.com/KaderArslan/Northwind/blob/master/screenshots/customer.png)
---
### Employee
![Employee](https://github.com/KaderArslan/Northwind/blob/master/screenshots/employee.png)
---
### Invoice
![Invoice](https://github.com/KaderArslan/Northwind/blob/master/screenshots/invoice.png)
---
### Order
![Order](https://github.com/KaderArslan/Northwind/blob/master/screenshots/order.png)
---
### Product
![Product](https://github.com/KaderArslan/Northwind/blob/master/screenshots/product.png)
---
### Region
![Region](https://github.com/KaderArslan/Northwind/blob/master/screenshots/region.png)
---
### Supplier
![Supplier](https://github.com/KaderArslan/Northwind/blob/master/screenshots/supplier.png)
---
### Territory
![Territory](https://github.com/KaderArslan/Northwind/blob/master/screenshots/territory.png)
