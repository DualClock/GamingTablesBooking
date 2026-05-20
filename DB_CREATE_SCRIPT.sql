IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'GamingTablesBooking')
BEGIN
    CREATE DATABASE GamingTablesBooking
    COLLATE Cyrillic_General_100_CI_AS_KS_WS_SC;
END
GO

USE GamingTablesBooking;
GO

IF OBJECT_ID('dbo.Users', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Users (
        id          INT IDENTITY(1,1) NOT NULL,
        login       NVARCHAR(100)     NOT NULL,
        password_hash NVARCHAR(256)   NOT NULL,
        role        NVARCHAR(20)     NOT NULL DEFAULT N'Client',
        created_at  DATETIME2         NOT NULL DEFAULT GETDATE(),
        CONSTRAINT PK_Users PRIMARY KEY CLUSTERED (id ASC),
        CONSTRAINT UQ_Users_Login UNIQUE NONCLUSTERED (login)
    );
    CREATE INDEX IX_Users_Role ON dbo.Users(role);
END
GO

IF OBJECT_ID('dbo.Tables', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Tables (
        id       INT IDENTITY(1,1) NOT NULL,
        name     NVARCHAR(100)     NOT NULL,
        capacity INT               NOT NULL,
        status   NVARCHAR(20)      NOT NULL DEFAULT N'Available',
        CONSTRAINT PK_Tables PRIMARY KEY CLUSTERED (id ASC)
    );
    CREATE INDEX IX_Tables_Status ON dbo.Tables(status);
END
GO

IF OBJECT_ID('dbo.Bookings', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Bookings (
        id          INT IDENTITY(1,1) NOT NULL,
        user_id     INT               NOT NULL,
        table_id    INT               NOT NULL,
        date        DATE              NOT NULL,
        time_start  TIME(0)           NOT NULL,
        time_end    TIME(0)           NOT NULL,
        status      NVARCHAR(20)      NOT NULL DEFAULT N'Active',
        created_at  DATETIME2         NOT NULL DEFAULT GETDATE(),
        CONSTRAINT PK_Bookings PRIMARY KEY CLUSTERED (id ASC),
        CONSTRAINT FK_Bookings_Users FOREIGN KEY (user_id) REFERENCES dbo.Users(id) ON DELETE NO ACTION ON UPDATE NO ACTION,
        CONSTRAINT FK_Bookings_Tables FOREIGN KEY (table_id) REFERENCES dbo.Tables(id) ON DELETE NO ACTION ON UPDATE NO ACTION
    );
    CREATE INDEX IX_Bookings_UserId ON dbo.Bookings(user_id ASC);
    CREATE INDEX IX_Bookings_TableId ON dbo.Bookings(table_id ASC);
    CREATE INDEX IX_Bookings_Date ON dbo.Bookings(date ASC);
    CREATE INDEX IX_Bookings_TimeStart ON dbo.Bookings(time_start ASC);
    CREATE INDEX IX_Bookings_TableDateTime ON dbo.Bookings(table_id ASC, date ASC, time_start ASC, time_end ASC) INCLUDE (status);
END
GO

PRINT N'База данных GamingTablesBooking успешно создана!';
GO