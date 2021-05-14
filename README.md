# Notatki

Aplikacja działa na porcie **5001**

API można przeglądać i testować pod adresem [/swagger/index.html](https://localhost:5001/swagger/index.html)

## Uruchomienie projektu

### Sposób 1: przy użyciu docker-compose:
Po pobraniu zmian z git'a trzeba na nowo zbudować projekt (argument `--build`)
```bash
docker-compose up --build
```

Kolejne uruchomienia można bez tego argumentu:
```bash
docker-compose up
```

### Sposób 2: Bez docker compose, konieczny .NET SDK:
```bash
dotnet run
```

## Uruchomienie bazy danych

### Wariant docker-compose

Powinna uruchomić się sama

### Ręczne uruchamiania jako kontener
w bashu:

```bash
./run_database.sh
```

Baza nasłuchuje na porcie `1433`. Connection string znajduje się w `appsettings.json`.

## Jeśli baza danych nie działa

Usunąć ją:

```bash
# Wyświetlić utworzone kontenery
docker ps -a

# Znaleźć taki o nazwie obrazu podobnym do "mcr.microsoft.com/mssql/server:2017-latest"
# Skopiować jego id (powinno wyglądać tak: "b1461a50f71e")

# Zatrzymać i usunąć bazę
docker stop b1461a50f71e
docker rm b1461a50f71e
```

Przy następnym uruchomieniu baza utworzy się na nowo.
