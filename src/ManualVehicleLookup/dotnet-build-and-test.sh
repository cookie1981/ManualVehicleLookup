#!/bin/bash
set -e

dotnet restore
dotnet publish  --configuration Release --output binaries
dotnet run -p project.json
