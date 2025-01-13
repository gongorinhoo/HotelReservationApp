# Dokumentacja aplikacji "Menedżer Hotelowy"

## Spis treści
1. [Wymagania](#wymagania)
2. [Instalacja](#instalacja)
3. [Konfiguracja](#konfiguracja)
4. [Opis działania aplikacji](#opis-działania-aplikacji)

---

## Wymagania

Aby uruchomić aplikację "Menedżer Hotelowy", wymagane są:

- **System operacyjny**: Windows, Linux lub macOS
- **.NET SDK**: wersja 9.0 lub nowsza
- **Baza danych**: plik SQLite
- **Przeglądarka internetowa**: dowolna nowoczesna (np. Chrome, Firefox, Edge)

## Instalacja

1. **Klonowanie repozytorium:**
   ```bash
   git clone https://github.com/gongorinhoo/HotelReservationApp
   cd HotelReservationApp
   ```

2. **Przygotowanie bazy danych:**
   - Plik bazy danych zostanie utworzony automatycznie, jest w repozytorium.

3. **Migracje bazy danych:**
   Uruchom następujące polecenie, aby zastosować migracje:
   ```bash
   dotnet ef database update
   ```

4. **Uruchomienie aplikacji:**
    Najlepiej uruchomić aplikacje przez Visual Studio.
   Aplikacja będzie dostępna pod adresem: `http://localhost:5000`

## Konfiguracja

1. **Łańcuch połączenia z bazą danych:**
   - Plik konfiguracyjny znajduje się w `appsettings.json`.
     ```json
        "ConnectionStrings": {
            "Database" : "Data Source=database.db"
        }
     ```

## Opis działania aplikacji

Aplikacja "Menedżer Hotelowy" umożliwia zarządzanie rezerwacjami, pracownikami, klientami i pokojami.
Poniżej opis funkcjonalności z punktu widzenia użytkownika:

1. **Rezerwacje:**
   - Tworzenie nowej rezerwacji poprzez podanie danych klienta, pokoju i daty pobytu.
   - Przeglądanie listy wszystkich rezerwacji z możliwością filtrowania po dacie.
   - Edytowanie szczegółów rezerwacji.
   - Usuwanie rezerwacji.

2. **Klienci:**
   - Dodawanie nowych klientów poprzez wypełnienie formularza z danymi osobowymi.
   - Przeglądanie listy klientów.

3. **Pokoje:**
   - Przeglądanie listy pokoi wraz z ich stanem (wolne/zajęte).
   - Edytowanie danych pokoju (np. liczba łóżek, cena).

4. **Pracownicy:**
   - Przeglądanie listy pracowników wraz z ich rolą i kontaktem.

Aplikacja oferuje intuicyjny interfejs graficzny, dzięki któremu użytkownik może szybko poruszać się między sekcjami i wykonywać niezbędne operacje.

---

W razie pytań lub problemów skontaktuj się z administratorem systemu.

