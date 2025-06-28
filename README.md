### ⚙️ Installation & Setup

Um dieses Projekt lokal auszuführen, folge den folgenden Schritten:  
**WICHTIG:** Es ist nur auf Windows-Systemen möglich!

### 1️⃣ **Repository klonen**  
Öffne eine Konsole und navigiere zu dem Verzeichnis, in dem du das Projekt speichern möchtest. Führe dann diesen Befehl aus, um das Repository zu klonen:

```sh
git clone https://github.com/TimoNegel/CRM.git
cd .\CRM\CRM\
````

### 2️⃣ **EF Tools**

Überprüfen Sie, ob die Entity Framework Core-Tools installiert sind:

```sh
dotnet tool list -g
```

Wenn sie nicht installiert sind, installieren Sie sie:

```sh
dotnet tool install --global dotnet-ef
```

### 3️⃣ **Local DB**

Überprüfen Sie, ob die MSSQLLocalDB installiert ist:

```sh
sqllocaldb i
```

Wenn sie nicht installiert ist, installieren Sie sie:
👉 [SqlLocalDB.msi (SQL Server 2019)](https://download.microsoft.com/download/7/c/1/7c14e92e-bdcb-4f89-b7cf-93543e7112d1/SqlLocalDB.msi)

🔧 So installierst du es:

* Lade die Datei über den obigen Link herunter.
* Doppelklicke auf die Datei `SqlLocalDB.msi`, um die Installation zu starten.
* Folge dem Installationsassistenten – es ist eine sehr einfache, schnelle Installation ohne viele Optionen.

### 4️⃣ **Abhängigkeiten installieren**

Das Projekt verwendet **NuGet-Pakete**. Installiere die notwendigen Pakete mit:

```sh
dotnet restore
```

### 5️⃣ **Datenbank einrichten**

Führe dazu folgenden Befehl aus:

```sh
dotnet ef database update
```

### 6️⃣ **Projekt ausführen**

Starte die Anwendung mit:

```sh
dotnet run
```

Nach dem Start solltest du das Projekt unter **[http://localhost:5130/](http://localhost:5130/)** oder einer ähnlichen lokalen Adresse erreichen können.
