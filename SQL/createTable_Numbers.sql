use NumberIncrement

create table Numbers
(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	CurrentNumber INT not null,
	LastUpdateDate DATETIME not null,
	DateFromFront DATETIME
)