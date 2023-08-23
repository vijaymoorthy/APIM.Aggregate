$Application = Read-Host -Prompt 'Input your application name'
$PortHttp = Read-Host -Prompt 'Input desired HTTP port'
$PortHttps = Read-Host -Prompt 'Input desired HTTPS port'

docker build -f $Application/Dockerfile --pull -t $Application.ToLower() .

docker stop $Application
docker rm $Application

docker run -d -it -p ${PortHttp}:80 -p ${PortHttps}:443 --name $Application -e ASPNETCORE_URLS="https://+;http://+" -e ASPNETCORE_HTTPS_PORT=$PortHttps -e ASPNETCORE_ENVIRONMENT=Development -v $env:APPDATA\microsoft\UserSecrets\:/root/.microsoft/usersecrets -v $env:USERPROFILE\.aspnet\https:/root/.aspnet/https/ $Application.ToLower()