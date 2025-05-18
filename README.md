# 📘 Журнали Онлайн

Ин як барномаи ASP.NET Core MVC мебошад, барои идора кардани хонандаҳо, омӯзгорон, синфҳо, фанҳо, баҳогузорӣ, корҳои хонагӣ ва ҳозиршавӣ.

## 🛠 Имконот

- Аутентификатсия ва сабти номи корбарон  
- Идоракунии хонандаҳо, омӯзгорон, синфҳо ва фанҳо  
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
- (Ихтиёрӣ) [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-ssms)

---

### ⚙️ Танзимот (Миграцияи маъмул)

1. **Клони лоиҳа:**
   ```bash
   git clone https://github.com/abdukholiqovhusniddin/online_journal.git
   cd online_journal
   ```

2. **Танзими пойгоҳи додаҳо:**

   Дар файли `appsettings.json`, сатри `DefaultConnection`-ро мувофиқи сервери SQL-и худ нав кунед.

3. **Истифодаи migrations:**

   ```bash
   dotnet ef database update
   ```

4. **Ба кор андохтани барнома:**

   ```bash
   dotnet run
   ```

5. Браузерро кушоед ва ба `https://localhost:5001` гузаред.

---

### 🗄 Импорт аз `.dacpac` (бе migrations)

Агар шумо нахоҳед `dotnet ef` истифода баред, метавонед базаи маълумотро бевосита аз `.dacpac` файл барқарор кунед:

1. SSMS (SQL Server Management Studio)-ро кушоед
2. Ба сервер пайваст шавед
3. Right-click → **Databases** → **Deploy Data-tier Application...**
4. Файли `MyDbJournal.dacpac`-ро интихоб кунед
5. Қадамҳоро анҷом диҳед
6. База пурра бо маълумот импорт мешавад

📥 [Зеркашии MyDbJournal.dacpac](https://github.com/abdukholiqovhusniddin/online_journal/MyDbJournal.dacpac) *(пеш аз ин пайвандро ба GitHub бор кун)*

---

## 📂 Сохтори Лоиҳа

```
online_journal/
│
├── Controllers/         // Контроллерҳои MVC
├── Models/              // Моделҳои Entity
├── Views/               // Razor Views (UI)
├── Data/                // Контексти базаи маълумот
├── wwwroot/             // Файлҳои статикӣ (JS, CSS)
├── appsettings.json     // Танзимот ва пайвастшавӣ
└── Program.cs           // Entry point
```

---

## 📧 Муаллиф

**Абдухолиқов Ҳусниддин**
GitHub: [abdukholiqovhusniddin](https://github.com/abdukholiqovhusniddin)
