@echo off

set configuration=%1

if "%configuration%"=="" (
	set configuration="Cloud"
)

echo Configuration %configuration%

%WINDIR%\Microsoft.NET\Framework\v4.0.30319\MSBuild "%~dp0\Web.Admin\Web.Admin.csproj" /p:Configuration=%configuration% /v:quiet /p:DeployOnBuild=true /p:PublishProfile=Publish.Web.Admin.pubxml /p:VisualStudioVersion=11.0
%WINDIR%\Microsoft.NET\Framework\v4.0.30319\MSBuild "%~dp0\Web.Public\Web.Public.csproj" /p:Configuration=%configuration% /v:quiet /p:DeployOnBuild=true /p:PublishProfile=Publish.Web.Public.pubxml /p:VisualStudioVersion=11.0
rem %WINDIR%\Microsoft.NET\Framework\v4.0.30319\MSBuild "%~dp0\Publish.proj" /target:PreBuildEvent /p:Configuration=Cloud
rem %WINDIR%\Microsoft.NET\Framework\v4.0.30319\MSBuild "%~dp0\Cloud\Cloud.ccproj" /target:Build /p:Configuration=Cloud /p:VisualStudioVersion=11.0

echo Done!