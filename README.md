## ⚙️ Installation & Setup  

Um dieses Projekt lokal auszuführen, folge den folgenden Schritten: 
WICHTIG: Es ist nur auf Windows Systemen möglich !

### 1️⃣ **Repository klonen**  
Öffne eine Konsole und navigiere zu dem Verzeichnis, in dem du das Projekt speichern möchtest. Führe dann diesen Befehl aus, um das Repository zu klonen:  

```sh
git clone https://github.com/TimoNegel/CRM.git
cd .\CRM\CRM\
```

### 2️⃣ **Abhängigkeiten installieren**  
Das Projekt verwendet **NuGet-Pakete**. Installiere die notwendigen Pakete mit:  

```sh
dotnet restore
```

### 3️⃣ **Datenbank einrichten**  
 Führe dazu folgenden Befehl aus:  

```sh
dotnet ef database update
```

### 4️⃣ **Projekt ausführen**  
Starte die Anwendung mit:  

```sh
dotnet run
```


Nach dem Start solltest du das Projekt unter **http://localhost:5130/** oder einer ähnlichen lokalen Adresse erreichen können.  

