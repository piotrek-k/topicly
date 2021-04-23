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
