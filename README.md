# 🧾 Task Tracker CLI

A simple and efficient command-line tool to manage your daily tasks using a JSON file for storage.

---

## 🚀 Features

* Add new tasks
* Update existing tasks
* Delete tasks
* Mark tasks as:

  * `todo`
  * `in-progress`
  * `done`
* List:

  * All tasks
  * Only `done` tasks
  * Only `todo` tasks
  * Only `in-progress` tasks

---

## 🛠 Tech Stack

* .NET Console Application
* C#
* JSON file storage (no external libraries)

---

## 📂 Project Structure

```bash
TaskTrackerCLI
│
├── Program.cs
├── Commands/
│   ├── Add.cs
│   ├── Update.cs
│   ├── Delete.cs
│   ├── ListOf.cs
│   ├── MarkDone.cs
│   └── MarkProgressTask.cs
│
├── TaskProperties/
│   ├── TaskItem.cs
│   └── FileHelper.cs
│
└── Task.json
```

---

## ⚙️ How It Works

* The application reads commands from the command line.
* Tasks are stored in a local `Task.json` file.
* If the file does not exist, it will be created automatically.
* Each operation updates the file immediately.

---

## 📌 Task Model

Each task contains:

* `Id` → Unique identifier
* `Description` → Task details
* `Status` → (`todo`, `in-progress`, `done`)
* `CreatedAt` → Creation timestamp
* `UpdatedAt` → Last update timestamp

---

## 🧪 Usage

Run commands using:

```bash
dotnet run <command> [arguments]
```

---

### ➕ Add Task

```bash
dotnet run add "Buy groceries"
```

---

### ✏️ Update Task

```bash
dotnet run update 1 "Buy groceries and cook dinner"
```

---

### ❌ Delete Task

```bash
dotnet run delete 1
```

---

### 🔄 Mark Task

```bash
dotnet run mark-in-progress 1
dotnet run mark-done 1
```

---

### 📋 List Tasks

```bash
dotnet run list
```

Filter by status:

```bash
dotnet run list done
dotnet run list todo
dotnet run list in-progress
```

---

## ⚠️ Notes

* Task IDs are generated automatically and incremented based on existing data.
* Descriptions can include multiple words (no strict need for quotes).
* Invalid commands or inputs are handled gracefully.

---

## 🧠 Design Decisions

* Kept the architecture simple (no over-engineering)
* Avoided external libraries for learning purposes
* Centralized file handling in a single helper (`FileHelper`)
* Used modular command classes to separate responsibilities

---

## 📈 Possible Improvements

* Add search functionality
* Add sorting (by date or status)
* Improve CLI UX (colors, formatting)
* Add help command
* Convert to full CLI tool (global command)

---

## 👨‍💻 Author

Built as a hands-on backend exercise to strengthen:

* File handling
* CLI parsing
* Clean code practices

---

## 📄 License

This project is open-source and free to use.
