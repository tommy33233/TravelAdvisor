if object_id('RegionNominations') is null
begin 
 create table RegionNominations(
 RegionNominationId int identity(1,1) primary key,
 Nomination nvarchar(100) not null
 )
end


if object_id('Regions', 'U') is null
begin
 create table  Regions (
  RegionId int identity(1,1) primary key,
  CountryId int not null,
  RegionNumber int not null,
  RegionNominationId int not null,
  Name nvarchar(150) not null, 
   CONSTRAINT FK_Regions_RegionNominations FOREIGN KEY (RegionNominationId)
   REFERENCES RegionNominations(RegionNominationId),
   CONSTRAINT FK_Regions_Countries FOREIGN KEY (CountryId)
   REFERENCES Countries(CountryId),
) 
end

if not exists (select * from RegionNominations)
begin
insert into RegionNominations(Nomination) values
 ('Oblast'),
 ('State'),
 ('Department'); 
end


if not exists(select * from Regions)
begin
insert into Regions(CountryId,RegionNominationId, RegionNumber,Name) values
(20,1,1,'Brestskaya'),
(20,1,2,'Vitebskaya'),
(20,1,3,'Gomelskaya'),
(20,1,4,'Grodnenskaya'),
(20,1,5,'Minskaya'),
(20,1,6,'Mogilevskaya');
end