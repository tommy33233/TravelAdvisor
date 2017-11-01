if COL_LENGTH('Countries','Info') is null
begin
alter table Countries add Info nvarchar(max)
end

if COL_LENGTH('Countries','ImageName') is null
begin
alter table Countries add ImageName nvarchar(100)
end

update Countries set Info = 'The most captivating places of interest in Belarus include surprising castles and family manors, magnificent temples and monasteries, unique nooks of pristine nature, ancient engineering constructions, interesting museums and ethnographic villages, birthplaces of famous painters, writers, and scientists.',ImageName = 'CollageBelarus'  where CountryId=20


update Countries set Info = 'One of the most visited countries in the world, England offers travellers endless possibilities when it comes to fun things to see and do. Part of the beautiful British Isles, this small but influential country is simply bursting with fascinating history, exciting cities and rich cultural traditions. Historic sites are found at every turn, from old castles dotting the picturesque countryside and colleges dating back to the Middle Ages to ancient Roman sites and centuries old royal palaces.

England is also extremely easy to get around, and whether you choose to tour the country by car or public transport, you are guaranteed an unforgettable experience.', ImageName='CollageUK' where CountryId = 230