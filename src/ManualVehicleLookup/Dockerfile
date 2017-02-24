FROM acraven/dotnet:build-api-1.0.1

WORKDIR /app

COPY . /app

EXPOSE 5000

RUN dotnet-build-and-test.sh
#RUN dotnet run -p ./project.json

#VOLUME /build/binaries