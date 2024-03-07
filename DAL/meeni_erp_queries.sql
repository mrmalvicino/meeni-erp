use meeni_erp_db
go

--------------------
-- LIST CUSTOMERS --
--------------------

select
P.FirstName, P.LastName,
O.OrganizationName, O.OrganizationDescription,
I.ActiveStatus, I.Birth, I.Email,
T.Prefix, T.Number as TaxCodeNumber, T.Suffix,
CO1.CountryName,
PR1.ProvinceName,
CI.CityName, CI.ZipCode,
A.StreetName, A.StreetNumber, A.Flat, A.Details,
CO2.PhoneAreaCode as CountryPhoneAreaCode, PR2.PhoneAreaCode as ProvincePhoneAreaCode, PH.Number as PhoneNumber,
B.PaymentMethod, B.InvoiceCategory,
C.SalesAmount
from Customers C
inner join BusinessPartners B on C.BusinessPartnerId = B.BusinessPartnerId
inner join Individuals I on B.IndividualId = I.IndividualId
left join People P on I.PersonId = P.PersonId
left join Organizations O on I.OrganizationId = O.OrganizationId
left join TaxCodes T on I.TaxCodeId = T.TaxCodeId
left join Adresses A on I.AdressId = A.AdressId
left join Cities CI on A.CityId = CI.CityId
left join Provinces PR1 on CI.ProvinceId = PR1.ProvinceId
left join Countries CO1 on PR1.CountryId = CO1.CountryId
left join Phones PH on I.PhoneId = PH.PhoneId
left join Provinces PR2 on PH.ProvinceId = PR2.ProvinceId
left join Countries CO2 on PR2.CountryId = CO2.CountryId

-----------------
-- READ ADRESS --
-----------------

select A.AdressId, A.StreetName, A.StreetNumber, A.Flat, A.Details, A.CityId, 
CI.CityName, CI.ZipCode, CI.ProvinceId, 
P.ProvinceName, P.CountryId, CO.CountryName 
from Adresses A
inner join Cities CI on A.CityId = CI.CityId
inner join Provinces P on CI.ProvinceId = P.ProvinceId
inner join Countries CO on P.CountryId = CO.CountryId
where AdressId = 6

----------------
-- READ PHONE --
----------------

select PH.Number, PR.PhoneAreaCode as ProvincePhoneAreaCode, C.PhoneAreaCode as CountryPhoneAreaCode
from Phones PH
inner join Provinces PR on PH.ProvinceId = PR.ProvinceId
inner join Countries C on PR.CountryId = C.CountryId
where PhoneId = 2

------------
-- IMAGES --
------------

select I.ImageUrl
from Images I
inner join ImageProductRelations R on I.ImageId = R.ImageId
inner join Products P on R.ProductId = P.ProductId
where P.ProductId = 2

select I.ImageUrl from Images I
inner join People P on P.ImageId = I.ImageId
where P.PersonId = 2

select I.ImageUrl from Images I
inner join Organizations O on O.ImageId = I.ImageId
where O.OrganizationId = 2

------------
-- GET ID --
------------

select ident_current('Individuals') as LastId;

-------------
-- TESTING --
-------------

select * from Customers