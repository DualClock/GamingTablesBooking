# Gaming Tables Booking System

![.NET](https://img.shields.io/badge/.NET-10.0-blue)
![Platform](https://img.shields.io/badge/Platform-Windows%20Forms-green)
![Database](https://img.shields.io/badge/Database-MS%20SQL%20Server-orange)
![Entity Framework](https://img.shields.io/badge/EF%20Core-10.0-purple)

Система бронирования игровых столов - WinForms приложение для учёта и управления бронированиями в игровом клубе.

---

## Возможности

- **Авторизация пользователей** - регистрация, вход, ролевая система (Админ / Клиент)
- **Управление столами** - добавление, редактирование, удаление игровых столов (только админ)
- **Бронирование** - выбор стола, даты и времени, просмотр своих бронирований
- **Статусы столов** - Available (доступен), Maintenance (на обслуживании)
- **Проверка конфликтов** - система не позволяет бронировать занятый стол на пересекающееся время

---

## Стек технологий

| Компонент | Технология |
|-----------|------------|
| Фреймворк | .NET 10.0 Windows Forms |
| База данных | MS SQL Server / LocalDB / Express |
| ORM | Entity Framework Core 10.0 |
| Авторизация | Пароль хранится в открытом виде (демо-проект) |

---

## Быстрый старт

### 1. Предварительные требования

- **.NET 10.0 SDK** - [скачать](https://dotnet.microsoft.com/download/dotnet/10.0)
- **MS SQL Server** или **SQL Server Express** / **LocalDB**

### 2. Настройка базы данных

Откройте SQL Server Management Studio (SSMS) или Azure Data Studio и выполните скрипты **в порядке**:

```sql
-- 1. Сначала создайте базу данных и таблицы
-- Файл: DB_CREATE_SCRIPT.sql

-- 2. Затем заполните тестовыми данными
-- Файл: DB_SEED_DATA.sql
```

Или через командную строку:
```bash
sqlcmd -S localhost -E -i DB_CREATE_SCRIPT.sql
sqlcmd -S localhost -E -i DB_SEED_DATA.sql
```

### 3. Настройка строки подключения

В файле `GamingTablesBookingProject/Data/AppDbContext.cs` проверьте строку подключения:

```csharp
optionsBuilder.UseSqlServer(@"Server=localhost;Database=GamingTablesBooking;Trusted_Connection=True;TrustServerCertificate=True");
```

Замените `localhost` на ваш сервер (например, `(localdb)\MSSQLLocalDb` для LocalDB).

### 4. Запуск

```bash
cd GamingTablesBookingProject
dotnet run
```

---

## Тестовые аккаунты

После выполнения `DB_SEED_DATA.sql`:

| Логин | Пароль | Роль |
|-------|--------|------|
| `admin` | `admin123` | Администратор |
| `ivanov` | `user123` | Клиент |
| `petrova` | `user123` | Клиент |

---

## Структура проекта

```
GamingTablesBookingProject/
├── Data/
│   └── AppDbContext.cs          # Контекст EF Core
├── Models/
│   ├── User.cs                  # Модель пользователя
│   ├── GameTable.cs             # Модель игрового стола
│   └── Booking.cs               # Модель бронирования
├── Forms/
│   ├── LoginForm.cs             # Форма входа
│   ├── RegisterForm.cs          # Форма регистрации
│   ├── AdminForm.cs             # Панель администратора
│   ├── AdminRegisterForm.cs     # Регистрация админа
│   ├── ClientForm.cs            # Панель клиента
│   └── TableEditForm.cs         # Управление столами
├── Utils/
│   └── PasswordHasher.cs        # Хелпер для хеширования паролей
└── Program.cs                   # Точка входа
```

---

## Диаграмма базы данных

```
┌─────────────┐       ┌─────────────┐       ┌─────────────┐
│   Users     │       │   Tables    │       │  Bookings   │
├─────────────┤       ├─────────────┤       ├─────────────┤
│ id (PK)     │       │ id (PK)     │       │ id (PK)     │
│ login       │       │ name        │       │ user_id(FK) │──► Users
│ password    │       │ capacity    │       │ table_id(FK)│──► Tables
│ role        │       │ status      │       │ date        │
│ created_at  │       └─────────────┘       │ time_start  │
└─────────────┘                              │ time_end    │
                                             │ status      │
                                             │ created_at  │
                                             └─────────────┘
```

---

## Статусы столов

| Статус | Описание |
|--------|----------|
| `available` | Стол свободен и готов к бронированию |
| `maintenance` | Стол на обслуживании, недоступен |

## Статусы бронирований

| Статус | Описание |
|--------|----------|
| `Active` | Бронирование активно |
| `Completed` | Бронирование завершено |
| `Cancelled` | Бронирование отменено |

---

## Сборка релиза

```bash
cd GamingTablesBookingProject
dotnet publish -c Release -r win-x64 --self-contained
```

Исполняемый файл будет в `bin/Release/net10.0-windows/win-x64/publish/`

---

## Лицензия

Проект создан в демонстрационных целях.