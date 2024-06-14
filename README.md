# Geometry Calculator Web App

## Opis projektu

Geometry Calculator Web App to aplikacja webowa stworzona przy użyciu technologii ASP.NET Core, umożliwiająca użytkownikowi obliczanie różnych właściwości prostokąta na podstawie wprowadzonych wartości szerokości i wysokości.

## Funkcjonalności

### Główne funkcjonalności

1. **Obliczanie powierzchni**:
   - Aplikacja oblicza powierzchnię prostokąta na podstawie szerokości (`Width`) i wysokości (`Height`).

2. **Obliczanie obwodu**:
   - Aplikacja oblicza obwód prostokąta na podstawie szerokości (`Width`) i wysokości (`Height`).

3. **Obliczanie przekątnej**:
   - Aplikacja oblicza długość przekątnej prostokąta na podstawie szerokości (`Width`) i wysokości (`Height`).

4. **Obliczanie sumy długości wszystkich boków**:
   - Aplikacja oblicza sumę długości wszystkich boków prostokąta na podstawie szerokości (`Width`) i wysokości (`Height`).

### Interfejs użytkownika

- **Formularz HTML** do wprowadzania szerokości i wysokości.
- **Przycisk "Calculate"** do wywoływania obliczeń.
- **Div "result"** do wyświetlania wyników obliczeń.
- **Walidacja formularza** z użyciem Bootstrap.

## Uruchomienie aplikacji

### Wymagania

- Visual Studio 2019 lub nowszy
- .NET Core 3.1 lub nowszy

### Kroki do uruchomienia

1. **Klonowanie repozytorium**:
   - Skopiuj URL repozytorium i uruchom poniższe polecenie w terminalu:
     ```bash
     git clone [URL_REPOZYTORIUM]
     ```

2. **Otwórz projekt w Visual Studio**:
   - Uruchom Visual Studio.
   - Wybierz **Open a project or solution**.
   - Znajdź i otwórz plik `.sln` z repozytorium.

3. **Zbuduj projekt**:
   - Kliknij **Build > Build Solution** (lub naciśnij `Ctrl+Shift+B`).

4. **Uruchom aplikację**:
   - Kliknij **Debug > Start Debugging** (lub naciśnij `F5`).

5. **Przetestuj aplikację**:
   - Przejdź do przeglądarki i wpisz adres URL aplikacji, np. `https://localhost:5001/`.
   - Wprowadź wartości w polach **Width** i **Height**.
   - Kliknij przycisk **Calculate**.
   - Wyniki obliczeń powinny zostać wyświetlone poniżej formularza.

## Struktura projektu

- `Models`:
  - **ShapeModel.cs**: Klasa zawierająca logikę obliczeń geometrycznych.
  
- `Controllers`:
  - **GeometryController.cs**: Kontroler obsługujący żądania HTTP związane z obliczeniami.

- `Views/Geometry`:
  - **Index.cshtml**: Widok HTML do wprowadzania danych i wyświetlania wyników.

- `Program.cs`:
  - Plik konfiguracji aplikacji.

