Zawsze pokazuj szczegóły

Kopiuj
# Re-create the README.txt file
readme_content = """Aplikacja Bankowa

Prosta aplikacja desktopowa WinForms w C# (.NET 6.0 Windows) do rejestracji i logowania użytkownika, obsługi SQLite oraz eksportu PDF (stub).

Spis treści:
1. Wymagania
2. Instalacja & Uruchomienie
3. Struktura projektu
4. Konfiguracja bazy
5. Użycie
6. Rozszerzenia
7. Licencja

1. Wymagania
- .NET 6.0 SDK (Windows)
- Visual Studio 2022+ z Windows Forms
- (Opcjonalnie) DB Browser for SQLite

2. Instalacja & Uruchomienie
1) Sklonuj lub pobierz repozytorium:
   git clone https://github.com/mlodyluzakk/aplikacja-bankowa.git
   cd aplikacja-bankowa
2) Otwórz w Visual Studio plik AplikacjaBankowa.csproj.
3) Przywróć pakiety NuGet:
   - System.Data.SQLite.Core (1.0.118)
   - PdfSharp (6.2.0)
4) Build → Clean Solution, następnie Build → Build Solution.
5) Uruchom aplikację (F5 lub Ctrl+F5).

3. Struktura projektu
/AplikacjaBankowa
  AplikacjaBankowa.csproj       – projekt .NET SDK
  Program.cs                    – punkt wejścia
  DBHelper.cs                   – klasa do połączenia SQLite
  UserService.cs                – rejestracja, hashowanie, generowanie kont
  User.cs                       – model User
  RegisterForm.cs               – formularz rejestracji
  RegisterForm.Designer.cs      – Designer
  RegisterForm.resx             – zasoby
  LoginForm.cs                  – formularz logowania (stub)
  LoginForm.Designer.cs         – Designer
  LoginForm.resx                – zasoby
  bank_app_fixed (1).sqlite     – baza SQLite (kopiowana do bin/)

4. Konfiguracja bazy
Plik bank_app_fixed (1).sqlite powinien zawierać tabele:
CREATE TABLE users (
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  username TEXT UNIQUE NOT NULL,
  password_hash TEXT NOT NULL,
  role_id INTEGER NOT NULL
);
CREATE TABLE clients (
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  user_id INTEGER NOT NULL REFERENCES users(id),
  first_name TEXT NOT NULL,
  last_name TEXT NOT NULL
);
CREATE TABLE bank_accounts (
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  client_id INTEGER NOT NULL REFERENCES clients(id),
  account_number TEXT NOT NULL,
  balance REAL NOT NULL DEFAULT 0
);
Użyj DB Browser for SQLite, by edytować lub stworzyć własną bazę.

5. Użycie
a) Rejestracja:
   - Wypełnij pola: nazwa użytkownika, hasło (min. 1 cyfra + 1 znak specjalny), imię, nazwisko.
   - Po powodzeniu otworzy się ekran logowania.
b) Logowanie:
   - Stub w LoginForm wyświetla komunikat – dodaj logikę UserService.Login(...).
c) Panel główny:
   - Dodaj MainForm z funkcjami: transfer, historia, eksport PDF.

6. Rozszerzenia
- Login: implementacja metody Login w UserService.
- Walidacja: rozszerzenie IsValidPassword o dodatkowe reguły.
- PDF: wykorzystaj PdfSharp do pełnego raportu.
- UI: dodaj nowe formularze (Transfer, Historia, Logs).

7. Licencja
Projekt na licencji MIT. Szczegóły w pliku LICENSE.
