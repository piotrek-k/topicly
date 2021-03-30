# Notatki

## Uruchomienie projektu

Przy użyciu docker-compose:
```bash
docker-compose up --build
```

Bez docker compose, konieczny .NET SDK:
```bash
dotnet run
```

API można przeglądać pod adresem [/swagger/index.html](https://localhost:5001/swagger/index.html)

## Uruchomienie bazy danych

### Jako kontener
w bashu:

```bash
./run_database.sh
```

Baza nasłuchuje na porcie `1433`. Connection string znajduje się w `appsettings.json`.
