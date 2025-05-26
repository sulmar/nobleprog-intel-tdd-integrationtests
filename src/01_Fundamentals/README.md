# 01_Fundamentals – TDD & Testy jednostkowe w C#

Zestaw modułów wprowadzających do testów jednostkowych, testowania sterowanego testami (TDD) oraz dobrych praktyk testowania w języku C#.

## 📦 Moduły

### 01. TestNaming
Jak nadawać nazwę testowi, aby jasno komunikował jego cel: `Metoda_WhenWarunek_ShouldOczekiwanyRezultat`.

### 02. Arrange-Act-Assert
Struktura testów: jak podzielić kod testowy na trzy sekcje dla czytelności i przejrzystości.

### 03. Red-Green-Refactor
Wprowadzenie do cyklu TDD: najpierw czerwony test, potem działający kod (zielony), a następnie refaktoryzacja.

### 04. Path-Based Testing
Pokrycie różnych ścieżek wykonania kodu – instrukcje warunkowe, pętle, przypadki brzegowe.

### 05. Theory & InlineData
Parametryzacja testów przy użyciu `[Theory]`, `[InlineData]` i testowanie wielu przypadków.

### 06. Testing Strings
Testowanie wartości tekstowych – zawartość, wielkość liter, formatowanie, wzorce.

### 07. Testing Void Methods
Jak testować metody, które nic nie zwracają – poprzez efekty uboczne, stany i wywołania.

### 08. Testing Exceptions
Testowanie scenariuszy wyjątków, `Assert.Throws`, `Record.Exception`, `FluentAssertions.Throw`.

### 09. Data-Driven Testing
Zewnętrzne źródła danych: `[MemberData]`, `[ClassData]`, testy oparte na kolekcjach przypadków.

### 10. Testing Collections
Porównywanie kolekcji, kolejność elementów, `Assert.Collection`, `Assert.Equal`, FluentAssertions.

### 11. Boundary Testing
Wartości skrajne: min, max, null, puste, graniczne indeksy – typowe źródła błędów.

### 12. Testing Events
Subskrybowanie i testowanie eventów (zdarzeń) – czy zostały wywołane, ile razy i z jakimi argumentami.

### 13. Default & Null Testing
Testowanie wartości domyślnych, `null`, braku ustawień – odporność kodu na brak danych.

### 14. Async Testing
Testowanie metod asynchronicznych (`async/await`, `Task`, `ValueTask`), użycie `Assert.ThrowsAsync`, `await`.

### 15. Complex Objects & Equality
Porównywanie złożonych obiektów, `Equals`, `IEquatable<T>`, `DeepEqual`, FluentAssertions.

### 16. Pure Functions vs Side Effects
Testowanie funkcji czystych kontra funkcji ze skutkami ubocznymi – co i jak warto testować.

---

## 🛠️ Uruchamianie testów

```bash
dotnet test
```

---

## 📚 Wymagania

- .NET 8.0 lub wyższy
- xUnit
- Visual Studio / Rider / VS Code

## 📎 Licencja
MIT