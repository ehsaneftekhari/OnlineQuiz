--------------------------------------------------------------------
--Creating Data Base

USE master;
GO

IF DB_ID('OnlineTestDB')>0
BEGIN
	ALTER DATABASE OnlineTestDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE
	DROP DATABASE OnlineTestDB
END
GO

CREATE DATABASE OnlineTestDB
GO

USE OnlineTestDB;
GO

--------------------------------------------------------------------
--Creating Tables

USE OnlineTestDB;
GO


-----------------------------SCHEMA [Users]---------------------------------------
CREATE SCHEMA [Users]


CREATE TABLE [Users].[BaseUser]
(
    [BaseUserId] INT IDENTITY(1,1) PRIMARY KEY,
    [FirstName] NVARCHAR(32),
	[LastName] NVARCHAR(32),
	[Email] VARCHAR(64),
	[PhoneNumber] VARCHAR(11)
)
GO

CREATE TABLE [Users].[User]
(
    [BaseUserId] INT NOT NULL,
    [UserName] VARCHAR(32) NOT NULL,
	[PassWord] NVARCHAR(32) NOT NULL,

	CONSTRAINT FK_User_BaseUser_UserId FOREIGN KEY ([BaseUserId]) REFERENCES [Users].[BaseUser]([BaseUserId]),
	CONSTRAINT PK_User_UserId PRIMARY KEY ([BaseUserId]),
	CONSTRAINT UC_User_UserName UNIQUE ([UserName])
) 
GO

-----------------------------SCHEMA [Tests]---------------------------------------
CREATE SCHEMA [Tests]
GO

CREATE TABLE [Tests].[Test]
(
    [TestId] INT IDENTITY(1,1) PRIMARY KEY,
    [BaseUserId] INT NOT NULL,
    [Title] NVARCHAR(32) NOT NULL,
	[Start] DATETIME,
    [End] DATETIME,
    [Published] BIT DEFAULT 0,
    [RandomizeType] INT NOT NULL,

	CONSTRAINT FK_Test_User_BaseUserId FOREIGN KEY ([BaseUserId]) REFERENCES [Users].[User]([BaseUserId]),
)


-- SCHEMA [Users]
CREATE TABLE [Users].[TestUser]
(
	[BaseUserId] INT NOT NULL,
    [TestUserId] INT IDENTITY(1,1) PRIMARY KEY,
    [TestId] INT REFERENCES [Tests].[Test]([TestId]),
    [TestStartTime] DATETIME,
    [TestEndTime] DATETIME,
    [EarnedScore] float(24),

	CONSTRAINT FK_TestUser_BaseUser_BaseUserId FOREIGN KEY ([BaseUserId]) REFERENCES [Users].[BaseUser]([BaseUserId]),
	CONSTRAINT UC_User_UserId_TestId UNIQUE ([BaseUserId],[TestId]),
)
--


CREATE TABLE [Tests].[Section]
(
    [SectionId] INT IDENTITY(1,1) PRIMARY KEY,
    [TestId] INT NOT NULL,
    [SectionTitle] NVARCHAR(32) NOT NULL,
    [Start] DATETIME,
    [End] DATETIME,
    [Duration] TIME,
    [Order] INT,
    [AttemptLimit] INT DEFAULT 1,
    [RandomizeQuestions] INT DEFAULT 1,
    [DisplayResult] BIT DEFAULT 0,
    [AllowEdit] BIT DEFAULT 0,

	CONSTRAINT FK_Section_Test_TestId FOREIGN KEY ([TestId]) REFERENCES [Tests].[Test]([TestId])
) 


CREATE TABLE [Tests].[Question]
(
    [QuestionId] INT IDENTITY(1,1) PRIMARY KEY,
    [SectionId] INT NOT NULL,
    [Text] NVARCHAR(4000),
    [ImageAddress] NVARCHAR(256),
    [Score] float(24),
    [Duration] TIME,
    [Order] INT,

	CONSTRAINT FK_Question_Section_SectionId FOREIGN KEY ([SectionId]) REFERENCES [Tests].[Section]([SectionId])
) 

CREATE TABLE [Tests].[Answer]
(
    [TestUserId] INT NOT NULL,
    [QuestionId] INT NOT NULL,
    [Content] NVARCHAR(4000),
    [DateTime] DateTime NOT NULL,
    [EarnedScore] float(24) NOT NULL,

	CONSTRAINT FK_Answer_TestUser_TestUserId FOREIGN KEY ([TestUserId]) REFERENCES [Users].[TestUser]([TestUserId]),
	CONSTRAINT FK_Answer_Question_QuestionId FOREIGN KEY ([QuestionId]) REFERENCES [Tests].[Question]([QuestionId])
) 
GO



-----------------------------SCHEMA [Forms]---------------------------------------
CREATE SCHEMA [Forms]


CREATE TABLE [Forms].[CheckUiType]
(
    [CheckUiTypeId] INT IDENTITY(1,1) PRIMARY KEY,
    [CheckUiTypeName] NVARCHAR(16) NOT NULL
) 
Go

CREATE TABLE [Forms].[CheckField]
(
    [CheckFieldId] INT IDENTITY(1,1) PRIMARY KEY,
    [CheckUiTypeId] INT REFERENCES [Forms].[CheckUiType]([CheckUiTypeId]),
    [QuestionId] INT REFERENCES [Tests].[Question]([QuestionId]),
    [RandomizeOptions] INT DEFAULT 0,
    [MaximumSelections] INT DEFAULT 1
) 
Go

CREATE TABLE [Forms].[Option]
(
    [OptionId] INT IDENTITY(1,1) PRIMARY KEY,
    [CheckFieldId] INT REFERENCES [Forms].[CheckField]([CheckFieldId]),
    [Score] REAL DEFAULT 0,
    [ImageAddress] NVARCHAR(256),
    [Text] NVARCHAR(1024)
) 
Go





CREATE TABLE [Forms].[AllowedFileType]
(
    [AllowedFileTypeId] INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(32),
    [Extention] NVARCHAR(8)
) 
Go

CREATE TABLE [Forms].[FileField]
(
    [FileFieId] INT IDENTITY(1,1) PRIMARY KEY,
    [QuestionId] INT REFERENCES [Tests].[Question]([QuestionId]),
    [MaxSizeKb] INT
) 
Go

CREATE TABLE [Forms].[FileFieldAllowedFileType]
(
    [FileFieId] INT REFERENCES [Forms].[FileField]([FileFieId]),
    [AllowedFileTypeId] INT REFERENCES [Forms].[AllowedFileType]([AllowedFileTypeId]),

    CONSTRAINT UC_FileFieldAllowedFileType UNIQUE ([FileFieId], [AllowedFileTypeId])
) 
GO





CREATE TABLE [Forms].[TextUiType]
(
    [TextUiTypeId] INT IDENTITY(1,1) PRIMARY KEY,
    [TextUiTypeName] NVARCHAR(16) NOT NULL
) 
GO

CREATE TABLE [Forms].[TextField]
(
    [TextFieldId] INT IDENTITY(1,1) PRIMARY KEY,
    [TextUiTypeId] INT REFERENCES [Forms].[TextUiType]([TextUiTypeId]),
    [QuestionId] INT REFERENCES [Tests].[Question]([QuestionId]),
    [AnswerLength] INT DEFAULT 50,
    [RegEx] NVARCHAR(128)
) 
GO


--------------------------------------------------------------------
--Creating Stored Procedures

-----------------------------SCHEMA [Users]---------------------------------------

CREATE OR ALTER PROCEDURE [Users].[Usp_BaseUser_Add]
@FirstName NVARCHAR(32),
@LastName NVARCHAR(32),
@Email VARCHAR(64),
@PhoneNumber VARCHAR(11),
@BaseUserId INT OUTPUT
AS
BEGIN
	INSERT INTO [Users].[BaseUser](FirstName ,LastName ,Email ,PhoneNumber) VALUES (@FirstName ,@LastName ,@Email ,@PhoneNumber)
	SET @BaseUserId = (SELECT SCOPE_IDENTITY())
END
GO



CREATE OR ALTER PROCEDURE [Users].[Usp_User_Verify]
@UserName NVARCHAR(32),
@PassWord NVARCHAR(32)
AS
BEGIN
	SELECT [BaseUserId] FROM [Users].[User] WHERE [UserName] = @UserName AND [PassWord] = @PassWord
END
GO


CREATE OR ALTER PROCEDURE [Users].[Usp_User_ValidateUserName]
@UserName NVARCHAR(32)
AS
BEGIN
	SELECT COUNT([BaseUserId]) AS 'Result' FROM [Users].[User] WHERE [UserName] = @UserName
END
GO


CREATE OR ALTER PROCEDURE [Users].[Usp_User_ValidateEmail]
@Email NVARCHAR(64)
AS
BEGIN
	SELECT COUNT(BU.[BaseUserId]) AS 'Result' FROM [Users].[User] U
	JOIN [Users].[BaseUser] BU ON U.BaseUserId = BU.BaseUserId
	WHERE BU.Email = @Email
END
GO


CREATE OR ALTER PROCEDURE [Users].[Usp_User_ValidatePhoneNumber]
@PhoneNumber NVARCHAR(11)
AS
BEGIN
	SELECT COUNT(BU.[BaseUserId]) AS 'Result' FROM [Users].[User] U
	JOIN [Users].[BaseUser] BU ON U.BaseUserId = BU.BaseUserId
	WHERE BU.PhoneNumber = @PhoneNumber
END
GO


CREATE OR ALTER PROCEDURE [Users].[Usp_User_Add]
@FirstName NVARCHAR(32),
@LastName NVARCHAR(32),
@Email VARCHAR(64),
@PhoneNumber VARCHAR(11),
@UserName NVARCHAR(32),
@PassWord NVARCHAR(32),
@BaseUserId INT OUTPUT
AS
BEGIN
	
    BEGIN TRAN
        BEGIN TRY
            INSERT INTO [Users].[BaseUser](FirstName ,LastName ,Email ,PhoneNumber) VALUES (@FirstName ,@LastName ,@Email ,@PhoneNumber)
			SET @BaseUserId = (SELECT SCOPE_IDENTITY())

			INSERT INTO [Users].[User] ([BaseUserId], [UserName], [PassWord]) VALUES (@BaseUserId , @UserName, @PassWord)

			COMMIT
		END TRY
		BEGIN CATCH
			SET @BaseUserId = 0
			ROLLBACK
		END CATCH
END
GO


-----------------------------SCHEMA [Tests]---------------------------------------

----Test
CREATE OR ALTER PROCEDURE [Tests].[Usp_Test_Add]
@BaseUserId INT,
@Title NVARCHAR(32),
@Start DATETIME,
@End DATETIME,
@Published BIT,
@RandomizeType INT,
@TestId INT OUTPUT
AS
BEGIN
	INSERT INTO [Tests].[Test](BaseUserId ,Title , [Start], [End], Published ,RandomizeType) VALUES (@BaseUserId ,@Title , @Start, @End, @Published, @RandomizeType)
	SET @TestId = (SELECT SCOPE_IDENTITY())
END
GO

CREATE OR ALTER PROCEDURE [Tests].[Usp_Test_GetList]
@BaseUserId INT,
@Title NVARCHAR(32)
AS
BEGIN
	SELECT [TestId], [BaseUserId], [Title], [Start], [End], [Published], [RandomizeType] FROM [Tests].[Test] 
	WHERE [BaseUserId] = @BaseUserId AND [Title] LIKE @Title
END
GO

--EXEC [Tests].[Usp_Test_GetList] 1 ,'%'

CREATE OR ALTER PROCEDURE [Tests].[Usp_Test_Get]
@TestId INT
AS
BEGIN
	SELECT [TestId], [BaseUserId], [Title], [Start], [End], [Published], [RandomizeType] FROM [Tests].[Test] 
	WHERE [TestId] = @TestId
END
GO

CREATE OR ALTER PROCEDURE [Tests].[Usp_Test_Edit]
@TestId INT,
@Title NVARCHAR(32),
@Start DATETIME,
@End DATETIME,
@Published BIT,
@RandomizeType INT
AS
BEGIN
	UPDATE [Tests].[Test] 
	SET Title = @Title, Published = @Published, [Start] = @Start, [End] = @End, RandomizeType = @RandomizeType
	WHERE TestId = @TestId
END
GO

----Section

CREATE OR ALTER PROCEDURE [Tests].[Usp_Section_Add]
@TestId INT,
@SectionTitle NVARCHAR(32),
@Start DATETIME,
@End DATETIME,
@Duration TIME,
@Order INT,
@AttemptLimit INT,
@RandomizeQuestions INT,
@DisplayResult BIT,
@AllowEdit BIT,
@SectionId INT OUTPUT
AS
BEGIN
	INSERT INTO [Tests].[Section] ([TestId], [SectionTitle], [Start], [End], [Duration], [Order], [AttemptLimit], [RandomizeQuestions], [DisplayResult], [AllowEdit])
	VALUES (@TestId, @SectionTitle, @Start, @End, @Duration, @Order, @AttemptLimit, @RandomizeQuestions, @DisplayResult, @AllowEdit)
	SET @SectionId = (SELECT SCOPE_IDENTITY())
END
GO

CREATE OR ALTER PROCEDURE [Tests].[Usp_Section_GetList]
@TestId INT
AS
BEGIN
	SELECT [TestId],[SectionId],[SectionTitle],[Start],[End],[Duration],[Order],[AttemptLimit],[RandomizeQuestions],[DisplayResult],[AllowEdit] FROM [Tests].[Section] 
	WHERE [TestId] = @TestId
END
GO

CREATE OR ALTER PROCEDURE [Tests].[Usp_Section_Get]
@SectionId INT
AS
BEGIN
	SELECT [TestId],[SectionId],[SectionTitle],[Start],[End],[Duration],[Order],[AttemptLimit],[RandomizeQuestions],[DisplayResult],[AllowEdit] FROM [Tests].[Section] 
	WHERE [SectionId] = @SectionId
END
GO

CREATE OR ALTER PROCEDURE [Tests].[Usp_Section_Edit]
@SectionTitle NVARCHAR(32),
@Start DATETIME,
@End DATETIME,
@Duration TIME,
@Order INT,
@AttemptLimit INT,
@RandomizeQuestions INT,
@DisplayResult BIT,
@AllowEdit BIT,
@SectionId INT OUTPUT
AS
BEGIN
	UPDATE [Tests].[Section] 
	SET
	[SectionTitle] = @SectionTitle,
	[Start] = @Start,
	[End] = @End,
	[Duration] = @Duration,
	[Order] = @Order,
	[AttemptLimit] = @AttemptLimit,
	[RandomizeQuestions] = @RandomizeQuestions,
	[DisplayResult] = @DisplayResult,
	[AllowEdit] = @AllowEdit
	WHERE [SectionId] = @SectionId
	
END
GO

CREATE OR ALTER PROCEDURE [Tests].[Usp_Section_Delete]
@SectionId INT OUTPUT
AS
BEGIN
	DELETE [Tests].[Section] 
	WHERE [SectionId] = @SectionId
END
GO

--insert into [Tests].[Section]([TestId], [SectionTitle]) values
--(1, 'Section1_1'),
--(1, 'Section1_2'),
--(1, 'Section1_3'),
--(1, 'Section1_4'),
--(1, 'Section1_5'),
--(2, 'Section2_1'),
--(2, 'Section2_2'),
--(2, 'Section2_3'),
--(2, 'Section2_4'),
--(2, 'Section2_5'),
--(3, 'Section3_1'),
--(3, 'Section3_2'),
--(3, 'Section3_3'),
--(3, 'Section3_4'),
--(3, 'Section3_5')

CREATE OR ALTER PROCEDURE [Tests].[Usp_Question_GetList]
@SectionId INT
AS
BEGIN
	SELECT [QuestionId],[SectionId],[Text],[ImageAddress],[Score],[Duration],[Order] FROM [Tests].[Question]
	WHERE [SectionId] = @SectionId
END
GO

--insert into [Tests].[Question]([SectionId], [Text]) values
--(1, 'Question1_1'),
--(1, 'Question1_2'),
--(1, 'Question1_3'),
--(1, 'Question1_4'),
--(1, 'Question1_5'),
--(2, 'Question2_1'),
--(2, 'Question2_2'),
--(2, 'Question2_3'),
--(2, 'Question2_4'),
--(2, 'Question2_5'),
--(3, 'Question3_1'),
--(3, 'Question3_2'),
--(3, 'Question3_3'),
--(3, 'Question3_4'),
--(3, 'Question3_5')
