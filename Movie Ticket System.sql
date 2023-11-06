CREATE Database movieTicketManagement
USE movieTicketManagement

CREATE Table [User] (
	userAccount varchar(50) PRIMARY KEY,
	password varchar(16),
	userType varchar(10)
)

CREATE Table Customer (
	Id_Customer int PRIMARY KEY,
	lastName_Cus varchar(50),
	firstName_Cus varchar(50),
	phoneNum int,
	userAccount varchar(50),	
	gender varchar(10)
)

CREATE Table Cashier (
	Id_Cashier int PRIMARY KEY,
	lastName_Cas varchar(50),
	firstName_Cas varchar(50),
	phoneNum int,
	userAccount varchar(50),
	gender varchar(10)
)

CREATE Table [Admin] (
	Id_Admin int PRIMARY KEY,
	lastName_Adm varchar(50),
	firstName_Adm varchar(50),
	phoneNum int,
	userAccount varchar(50),
	gender varchar(10)
)

CREATE Table Movies (
	Id_Movie int PRIMARY KEY,
	movieName varchar(50),
	movieGenre varchar(15),
	movieTime time,
	movieCost decimal(4, 2)
)

CREATE Table [BookMovie](
	Id_Order int PRIMARY KEY,
	Id_Customer int,
	Id_Movie int,
	Id_Cashier int,
	quantity int,
	totalPayment decimal(9,2)
)

CREATE PROCEDURE addAccount @userAccount varchar(50), @password varchar(16), @userType varchar(10) AS 
INSERT INTO [User] VALUES(@userAccount, @password, @userType)

CREATE PROCEDURE inputCustInfo 
@Id_Customer int, @lastName_Cus varchar(50), @firstName_Cus varchar(50), @phoneNum int, @userAccount varchar(50), @gender varchar(10) AS 
INSERT INTO Customer VALUES(@Id_Customer, @lastName_Cus, @firstName_Cus, @phoneNum, @userAccount, @gender)


CREATE PROCEDURE inputCasInfo 
@Id_Cashier int, @lastName_Cas varchar(50), @firstName_Cas varchar(50), @phoneNum int, @userAccount varchar(50), @gender varchar(10) AS 
INSERT INTO Customer VALUES(@Id_Cashier, @lastName_Cas, @firstName_Cas, @phoneNum, @userAccount, @gender)

--CREATE VIEW viewCusInfo
--CREATE VIEW viewCasInfo
--CREATE VIEW viewAccounts
--CREATE VIEW viewReceipt

