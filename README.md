dotnetmicroservice


Prerequisites for development

Install dotnet SDK:

```
sudo wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
```

```
dotnet tool update --global dotnet-ef
```


```
dotnet ef database update -- --environment Development
```