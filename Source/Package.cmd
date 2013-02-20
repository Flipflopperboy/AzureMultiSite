%WINDIR%\Microsoft.NET\Framework\v4.0.30319\MSBuild Publish.proj /verbosity:normal /property:Configuration=Cloud;Debug=false
%WINDIR%\Microsoft.NET\Framework\v4.0.30319\MSBuild Package.proj /verbosity:normal /property:Configuration=debug;Debug=true
pause