=== DB_SEED_DATA.sql ===

-- ================================================
-- Скрипт заполнения базы данных тестовыми данными
-- Система бронирования игровых столов
-- ================================================

USE GamingTablesBooking;
GO

-- ================================================
-- Очистка существующих данных (для повторного запуска)
-- ================================================
DELETE FROM dbo.Bookings;
DELETE FROM dbo.Tables;
DELETE FROM dbo.Users;
DBCC CHECKIDENT ('dbo.Bookings', RESEED, 0);
DBCC CHECKIDENT ('dbo.Tables', RESEED, 0);
DBCC CHECKIDENT ('dbo.Users', RESEED, 0);
GO

-- ================================================
-- Пользователи
-- Пароли в открытом виде:
-- admin / admin123
-- ivanov / user123
-- petrova / user123
-- ================================================

INSERT INTO dbo.Users (login, password_hash, role, created_at)
VALUES
    (N'admin',     N'admin123', N'Admin',  GETDATE()),
    (N'ivanov',    N'user123', N'Client', GETDATE()),
    (N'petrova',   N'user123', N'Client', GETDATE());
GO

-- ================================================
-- Игровые столы
-- ================================================

INSERT INTO dbo.Tables (name, capacity, status)
VALUES
    (N'Стол №1 — VIP',     8,  N'available'),
    (N'Стол №2 — Стандарт', 4, N'available'),
    (N'Стол №3 — Стандарт', 4, N'available'),
    (N'Стол №4 — Маленький', 2, N'maintenance'),
    (N'Стол №5 — Большой',  6, N'available');
GO

-- ================================================
-- Бронирования (примеры)
-- ================================================

INSERT INTO dbo.Bookings (user_id, table_id, date, time_start, time_end, status, created_at)
VALUES
    -- Бронирование Иванова (стол VIP сегодня)
    (2, 1, CAST(GETDATE() AS DATE), CAST(GETDATE() AS TIME), N'14:00:00', N'Active', GETDATE()),

    -- Бронирование Петровой (стол №2 на завтра)
    (3, 2, CAST(DATEADD(DAY, 1, GETDATE()) AS DATE), N'10:00:00', N'12:00:00', N'Active', GETDATE()),

    -- Прошлое бронирование (завершённое)
    (2, 3, CAST(DATEADD(DAY, -2, GETDATE()) AS DATE), N'15:00:00', N'17:00:00', N'Completed', GETDATE());
GO

-- ================================================
-- Проверка данных
-- ================================================

SELECT N'Пользователи:' AS Info;
SELECT * FROM dbo.Users;

SELECT N'Столы:' AS Info;
SELECT * FROM dbo.Tables;

SELECT N'Бронирования:' AS Info;
SELECT * FROM dbo.Bookings;
GO

PRINT N'Тестовые данные успешно добавлены!';
GO