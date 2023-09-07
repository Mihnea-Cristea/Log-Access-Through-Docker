# Log-Access-Through-Docker
This is a simple .NET application which writes logs in the standard output and error streams. We deploy the app using Docker then access the logs from within the container

Inside a Powershell script with the folder location opened, follow these steps :

1. Check to see if the right files are in the directory

ls ./console-logger/

You might get an error if you are already inside the console-logger directory, simply write ls .

2. Build the image

docker build -t console-logger ./console-logger

3. Check if the image was built 

docker images

4. Start a container for the image to run on

docker run --name logger console-logger

5. Check if the container is running

docker ps ( processes-show )

The container is probably not running anymore, because the container is set to be 
removed after the process finishes
The logs are still persistent, so we can access them anyway

docker logs logger  ( add -t before the name if you want timestamps as well )

Sets a format for the inspect on the logger then lists the logs contained within


cat $(docker inspect --format '{{ .LogPath }}' logger) 
