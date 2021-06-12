#!/bin/bash

docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=My_password123' -p 1433:1433 --name "mssql_as_db" -d mcr.microsoft.com/mssql/server:2017-latest