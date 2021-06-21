#!/bin/bash

echo "Suma kontrolna lokalnego skryptu sql: ";
sha1sum ./script.sql;

docker cp ./script.sql topicly_db:/script.sql

echo "Suma kontrolna skryptu na dockerze: ";
docker exec -it topicly_db /bin/bash -c 'sha1sum /script.sql';

echo "Uruchomienie skryptu SQL:";
docker exec -it topicly_db /bin/bash -c '/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P "My_password123" -i ./script.sql';