if COL_LENGTH('Attractions','ImageName') is null
begin
alter table Attractions add ImageName nvarchar(100)
end


 update Attractions set ImageName = 'mirCastle.jpg' where AttractionId=1
 update Attractions set ImageName = 'Troitskoe_Predmeste.jpg' where AttractionId=2
 update Attractions set ImageName = 'stadiumDinamo.jpeg' where AttractionId=3