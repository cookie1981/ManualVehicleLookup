FROM microsoft/dotnet:runtime
#acraven/dotnet:build-api-1.0.1

WORKDIR /app

COPY . /app

EXPOSE 9000


#RUN dotnet-build-and-test.sh
#RUN dotnet restore
#RUN dotnet publish  --configuration Release --output binaries
#RUN dotnet run -p project.json

ENTRYPOINT ["dotnet", "ManualVehicleLookup.dll"]

#VOLUME /build/binaries