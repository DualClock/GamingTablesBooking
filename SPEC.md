# Система бронирования игровых столов — Структура проекта

## Модули приложения

### 1. Пользователи и авторизация
**Описание:** Регистрация, вход по логину/паролю, хеширование паролей, ролевая система (client/admin).

**Формы Windows Forms:**
- `LoginForm` — форма входа
- `RegisterForm` — форма регистрации

**EF Core модели:**
- `User` — пользователь (id, login, password_hash, role, created_at)

**Бизнес-правила:**
- Пароль хранится как хеш (BCrypt/PBKDF2)
- Роль: Client или Admin
- При входе — проверка хеша, создание сессии (username, role)

---

### 2. Бронирование столов
**Описание:** Выбор даты/времени, просмотр доступных столов, оформление и отмена бронирований.

**Формы Windows Forms:**
- `BookingForm` — главная форма бронирования
- `TableSelectionControl` — выбор стола (DataGridView)
- `MyBookingsForm` — история бронирований пользователя
- `CancelBookingDialog` — диалог отмены

**EF Core модели:**
- `GameTable` — игровой стол (id, name, capacity, status)
- `Booking` — бронирование (id, user_id, table_id, date, time_start, time_end, status)

**Бизнес-правила:**
- Проверка доступности стола на выбранное время
- Запрет двойного бронирования (один стол + время = конфликт)
- Статусы бронирования: Active, Cancelled, Completed
- Бронирование только для авторизованных

---

### 3. Админ-панель
**Описание:** Управление столами, пользователями, бронированиями, аналитика.

**Формы Windows Forms:**
- `AdminPanelForm` — главная форма админки с TabControl
- `TablesManagementTab` — управление столами
- `UsersManagementTab` — управление пользователями
- `BookingsManagementTab` — просмотр/управление бронированиями
- `AnalyticsTab` — аналитика загрузки

**Бизнес-правила:**
- Доступ только для роли Admin
- CRUD операции над столами и пользователями
- Просмотр всех бронирований с фильтрацией
- Аналитика: загрузка столов по часам/дням

---

### 4. EF Core и база данных
**Описание:** Подключение к существующей БД без миграций.

**EF Core модели:**
```
Models/
├── User.cs           — id, Login, PasswordHash, Role, CreatedAt
├── GameTable.cs      — id, Name, Capacity, Status
└── Booking.cs        — id, UserId, TableId, Date, TimeStart, TimeEnd, Status
```

**DbContext:**
```csharp
AppDbContext.cs — подключение к SQL Server (существующая БД)
```

**Особенности:**
- Без миграций (миграции запрещены)
- ToTable() для маппинга на существующие таблицы
- Fluent API или аттрибуты для маппинга колонок

---

### 5. Интерфейс Windows Forms
**Описание:** Все формы приложения.

**Главные формы:**
- `MainForm` — точка входа после авторизации
- `LoginForm` — вход
- `RegisterForm` — регистрация

**Формы бронирования:**
- `BookingForm` — выбор стола и бронирование
- `MyBookingsForm` — история

**Админ-панель:**
- `AdminPanelForm` — админка с вкладками

---

### 6. Безопасность и производительность
**Описание:** Хеширование, роли, оптимизация запросов.

**Реализация:**
- `PasswordHasher.cs` — хеширование BCrypt/PBKDF2
- Индексы в БД по user_id, table_id, date, time_start
- Быстрые запросы через LINQ с фильтрацией на уровне БД

---

## Структура проекта Visual Studio

```
GamingTablesBooking/
├── GamingTablesBooking.sln
├── src/
│   └── GamingTablesBooking/
│       ├── GamingTablesBooking.csproj
│       ├── Program.cs
│       ├── Models/
│       │   ├── User.cs
│       │   ├── GameTable.cs
│       │   └── Booking.cs
│       ├── Data/
│       │   └── AppDbContext.cs
│       ├── Views/
│       │   ├── LoginForm.cs
│       │   ├── RegisterForm.cs
│       │   ├── MainForm.cs
│       │   ├── BookingForm.cs
│       │   ├── MyBookingsForm.cs
│       │   └── Admin/
│       │       ├── AdminPanelForm.cs
│       │       ├── TablesManagementTab.cs
│       │       ├── UsersManagementTab.cs
│       │       ├── BookingsManagementTab.cs
│       │       └── AnalyticsTab.cs
│       ├── Services/
│       │   ├── AuthService.cs
│       │   ├── BookingService.cs
│       │   └── AdminService.cs
│       └── Utils/
│           └── PasswordHasher.cs
├── DB_CREATE_SCRIPT.sql
└── DB_SEED_DATA.sql
```

---

## Список задач для разработчика

### Фаза 1: Проект и модели
1. Создать solution и WinForms проект
2. Добавить NuGet пакеты: Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.SqlServer
3. Создать модель `User`
4. Создать модель `GameTable`
5. Создать модель `Booking`
6. Создать `AppDbContext` с подключением к SQL Server

### Фаза 2: Авторизация
7. Создать `PasswordHasher` (BCrypt)
8. Создать `LoginForm`
9. Создать `RegisterForm`
10. Создать `AuthService`

### Фаза 3: Бронирование
11. Создать `BookingForm`
12. Создать метод проверки доступности стола
13. Создать `MyBookingsForm`
14. Реализовать отмену бронирования

### Фаза 4: Админ-панель
15. Создать `AdminPanelForm` с TabControl
16. Реализовать `TablesManagementTab` (CRUD столов)
17. Реализовать `UsersManagementTab` (просмотр пользователей)
18. Реализовать `BookingsManagementTab` (просмотр всех бронирований)
19. Реализовать `AnalyticsTab` (загрузка столов)

### Фаза 5: Безопасность и тестирование
20. Настроить проверку ролей (Client/Admin)
21. Запустить SQL-скрипты вручную
22. Протестировать весь функционал

---

## Подключение EF Core к существующей БД

### Важно: без миграций!

**Строка подключения (LocalDB):**
```
Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name="GamingTablesBooking";Command Timeout=30
```

**В C# код (AppDbContext.cs):**

```csharp
public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<GameTable> GameTables { get; set; }
    public DbSet<Booking> Bookings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Маппинг на существующие таблицы
        modelBuilder.Entity<User>().ToTable("Users");
        modelBuilder.Entity<GameTable>().ToTable("Tables");
        modelBuilder.Entity<Booking>().ToTable("Bookings");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=""GamingTablesBooking"";Command Timeout=30";
        optionsBuilder.UseSqlServer(connectionString);
    }
}
```

**В App.config (connectionStrings):**

```xml
<configuration>
  <connectionStrings>
    <add name="GamingTablesBooking"
         connectionString="Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=&quot;GamingTablesBooking&quot;;Command Timeout=30"
         providerName="System.Data.SqlClient"/>
  </connectionStrings>
</configuration>
```

**Через DI (Program.cs):**

```csharp
var connectionString = ConfigurationManager.ConnectionStrings["GamingTablesBooking"].ConnectionString;
services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
```

**Или просто создание контекста:**

```csharp
using var context = new AppDbContext();
var users = context.Users.ToList();
```

---

### Порядок подключения

1. Запустить `DB_CREATE_SCRIPT.sql` в SSMS → создаётся БД `GamingTablesBooking`
2. Запустить `DB_SEED_DATA.sql` → заполняется тестовыми данными
3. В проекте указать connection string → EF Core подключится к существующей БД
4. Миграции НЕ используются — EF Core только читает/пишет в существующую схему

---

## Бизнес-правила бронирования

1. **Проверка доступности:**
   ```
   SELECT * FROM Bookings
   WHERE table_id = @tableId
   AND date = @date
   AND status = 'Active'
   AND (time_start < @timeEnd AND time_end > @timeStart)
   ```

2. **Запрет двойного бронирования:**
   - Если запрос выше возвращает строки → стол занят

3. **Статусы столов:**
   - Available — свободен
   - Occupied — занят
   - Maintenance — на обслуживании

4. **Статусы бронирований:**
   - Active — активно
   - Cancelled — отменено
   - Completed — завершено

---

## Аналитика (доп. функционал)

### Загрузка столов по времени
```sql
SELECT
    t.name,
    DATEPART(HOUR, time_start) as Hour,
    COUNT(*) as BookingCount
FROM Bookings b
JOIN Tables t ON b.table_id = t.id
WHERE b.status = 'Active'
GROUP BY t.name, DATEPART(HOUR, time_start)
ORDER BY t.name, Hour
```