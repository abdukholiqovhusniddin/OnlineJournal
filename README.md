# Журнали Онлайн

Ин як барномаи ASP.NET Core MVC мебошад, барои идора кардани хонандахо, омӯзгорон, синфҳо, фанҳо, баҳогузорӣ, корҳои хонагӣ ва ҳозиршавӣ.

## 🛠 Имконот

- Аутентификатсия ва сабти номи корбарон  
- Идоракунии хонандахо, омӯзгорон, синфҳо ва фанҳо  
- Сабт ва намоиши баҳоҳо ва ҳозиршавӣ  
- Супоридани ва пайгирии корҳои хонагӣ  

## 💻 Технологияҳо

- .NET 9  
- ASP.NET Core MVC  
- Entity Framework Core (SQL Server)  
- C# 13  
- Bootstrap (барои интерфейси корбар)  
- JavaScript & CSS  

## 🚀 Оғози кор

### 📋 Пешшароитҳо

- [SDK-и .NET 9](https://dotnet.microsoft.com/download)  
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)  

### ⚙️ Танзимот

1. **Клони лоиҳа:**
   ```bash
   git clone https://github.com/abdukholiqovhusniddin/online_journal.git
   cd online_journal
   ```

2. **Танзими пойгоҳи додаҳо:**

   * Дар файли `appsettings.json`, сатри `DefaultConnectionString`-ро бо маълумоти пайвасти SQL Server-и худ навсозӣ кунед.

3. **Истифодаи migrations:**

   ```bash
   dotnet ef database update
   ```

4. **Ба кор андохтани барнома:**

   ```bash
   dotnet run
   ```

5. Браузери худро кушоед ва ба `https://localhost:5001` (ё URL, ки дар консол нишон дода мешавад) гузаред.

## 📂 Сохтори Лоиҳа

* `Controllers/` - Контроллерҳои MVC барои коркарди дархостҳо
* `Models/` - Моделҳои Entity
* `Views/` - Намудҳои Razor барои UI
* `Data/` - Контексти базаи маълумот
* `wwwroot/` - Файлҳои статикӣ (JS, CSS ва ғайра)
