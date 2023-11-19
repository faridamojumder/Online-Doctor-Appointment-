Drop DataBase DoctorAppointment
Create database DoctorAppointment
use DoctorAppointment
create Table Specialist
(
	SpecialistID int identity(1,1) primary key,
	SpecialistName Varchar(50)
);

create Table Doctor
(
	DoctorID int identity(1,1) primary key,
	DoctorName Varchar(50),
	Email Varchar(50),
	Fee int,
	ServiceType Varchar(50),
	ScheduleDate datetime,
	Prescription Nvarchar(500),
	SpecialistID int references Specialist(SpecialistID)
);

create Table Schedule
(
	ScheduleID int identity(1,1) primary key,
	ScheduleDate datetime,
	SerialNo int,
	Gender varchar(50),
	DoctorID int references Doctor(DoctorID)
);

CREATE TABLE Role
(
	RoleId int IDENTITY(1,1) primary key NOT NULL,
	RoleName varchar(50) NULL
);
CREATE TABLE [User]
	(
	UserId int IDENTITY(1,1) primary key NOT NULL,
	Username varchar(20) NULL,
	Password varchar(20) NULL,
	RoleId  int references Role(RoleId) NULL
	);
CREATE TABLE RolePermission
(
	RolePermissionId bigint IDENTITY(1,1) primary key NOT NULL,
	RoleId int references Role(RoleId) NULL,
	UserId int references [User](UserId) NULL,
	MenuName varchar(50) NULL,
	IsSelect bit NULL,
	IsInsert bit NULL,
	IsUpdate bit NULL,
	IsDelete bit NULL
);
	
Select * From Specialist
Select * From Doctor
Select * From Schedule
Select * From [User]
Select * From Role
Select * From RolePermission
