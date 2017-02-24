FROM acraven/dotnet:build-api-1.0.1

WORKDIR /app

COPY . /app

EXPOSE 5000

RUN dotnet-build.sh
#RUN dotnet run -p ./project.json

#VOLUME /build/binaries