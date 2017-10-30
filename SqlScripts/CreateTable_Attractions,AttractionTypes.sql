if object_id('AttractionTypes', 'U') is null
begin
create table AttractionTypes(
AttractionTypeId int not null identity(1,1) primary key,
Name nvarchar(20) not null
)
end

if object_id('Attractions', 'U') is null
begin
create table Attractions(
AttractionId int identity(1,1) primary key,
AttractionName nvarchar(100) not null,
CountryId int not null,
CityId int  null,
AttractionType int null,
description nvarchar(max) null

 CONSTRAINT FK_Attractions_Countries FOREIGN KEY (CountryId)
   REFERENCES Countries(CountryId),
    CONSTRAINT FK_Attractions_Cities FOREIGN KEY (CityId)
   REFERENCES Cities(CityId),
   CONSTRAINT FK_Attractions_AttractionTypes FOREIGN KEY (AttractionType)
   REFERENCES AttractionTypes(AttractionTypeId),
)
end

if not exists (select * from AttractionTypes)
begin
insert into AttractionTypes(Name) values
('Historical'), ('Culture'), ('Nature'), ('Sport'),('Night Life'), ('Extreme')
end

if not exists (select * from Attractions)
begin
insert into Attractions(AttractionName, CountryId, CityId, AttractionType) values
('Mirsky castle',20,null,2),
 ('Niamiha',20,6,1),
 ('Dinamo stadium',20,6,5);
 end