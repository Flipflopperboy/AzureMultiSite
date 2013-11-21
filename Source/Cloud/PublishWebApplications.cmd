@echo off

set configuration=%~1
set publishDirectory=%~2

if "%configuration%"=="" (
	set configuration="Cloud"
)
if "%publishDirectory%"=="" (
	set publishDirectory="%~dp0Published"
)

echo Publishing web applications in configuration %configuration% to %publishDirectory%

%WINDIR%\Microsoft.NET\Framework\v4.0.30319\MSBuild "%~dp0\..\Web.Admin\Web.Admin.csproj" /p:Configuration=%configuration% /v:quiet /p:DeployOnBuild=true /p:PublishProfile=Publish.Web.Admin.pubxml /p:VisualStudioVersion=11.0 /p:publishUrl="%publishDirectory%\Web.Admin"
%WINDIR%\Microsoft.NET\Framework\v4.0.30319\MSBuild "%~dp0\..\Web.Public\Web.Public.csproj" /p:Configuration=%configuration% /v:quiet /p:DeployOnBuild=true /p:PublishProfile=Publish.Web.Public.pubxml /p:VisualStudioVersion=11.0 /p:publishUrl="%publishDirectory%\Web.Public"

echo Done!