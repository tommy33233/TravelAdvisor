if object_id('Cities', 'U') is null
begin
create table Cities(
CityId int identity(1,1) primary key,
CityName nvarchar(100) not null,
CountryId int not null,
Population int not null,
 CONSTRAINT FK_Cities_Countries FOREIGN KEY (CountryId)
   REFERENCES Countries(CountryId),
)
end

if not exists (select * from Cities)
begin
insert into Cities (CityName, CountryId, Population) values
('Brest', 20, 328681),
('Vitebsk', 20, 362466),
('Gomel', 20, 508839),
('Grodno',20, 354521),
('Mogilev',20, 368765),
('Minsk', 20, 1911000),
('Novogrudok',20,29336);
end