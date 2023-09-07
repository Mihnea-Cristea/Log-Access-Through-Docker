# Using a multi stage docker image, for building the app, then storing it in the cache for faster compile time except the first time build.
# builder
FROM mcr.microsoft.com/dotnet/framework/sdk:4.8-windowsservercore-ltsc2019 AS builder

WORKDIR /src/Logger.Console
COPY src /src
#Msbuild = packaging the application after copying the source code into the image
RUN msbuild Logger.Console/Logger.Console.csproj /p:Configuration=Release /p:OutputPath=c:/out
#No nuGet restore because there are no library references
# app
FROM mcr.microsoft.com/dotnet/framework/runtime:4.8-windowsservercore-ltsc2019
#Using runtime so there are no extra resources downloaded and used for the application deployment, if i would have used SDK it would have occupied a lot more space of the shared layers.
WORKDIR /app
COPY --from=builder /out/ .
CMD /app/Logger.Console.exe