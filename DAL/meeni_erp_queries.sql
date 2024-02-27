use meeni_erp_db
go

--------------------
-- CUSTOMERS LIST --
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

select TaxCodeId, Prefix, Number, Suffix from taxCodes where TaxCodeId = 2