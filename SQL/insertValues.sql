use NumberIncrement

insert into Numbers (CurrentNumber, LastUpdateDate, DateFromFront)
values
(5, GETDATE(), GETDATE()),
(10, GETDATE(), GETDATE())