#### Install dotnet SDK
1. Register Microsoft key and feed for ```ubuntu 19.10```
```
wget -q https://packages.microsoft.com/config/ubuntu/19.10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
```
2. Install .net SDK
```
sudo apt-get update
sudo apt-get install apt-transport-https
sudo apt-get update
sudo apt-get install dotnet-sdk-3.1
```
#### Create a solution
```
dotnet new sln -o unit-testing-using-dotnet-test
```
#### Create a console application
```
cd unit-testing-using-dotnet-test
dotnet new classlib -o PrimeService
ren .\PrimeService\Class1.cs PrimeService.cs
```
#### add console application to solution
```
dotnet sln add ./PrimeService/PrimeService.csproj
```
#### Test Setup **Xunit**
```
dotnet new xunit -o PrimeService.Tests
dotnet add ./PrimeService.Tests/PrimeService.Tests.csproj reference ./PrimeService/PrimeService.csproj
```
#### Add to project solution
It is applicable when you have created a solution for a application. For example, you have console application solution and later you added test solution to the projects.
#### Create MVC application
```
dotnet new mvc -o {ApplicationName}
```
#### Serve
```
dotnet run watch
```
#### Test
```
dotnet test
```