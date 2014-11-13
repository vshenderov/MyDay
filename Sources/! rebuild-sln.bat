.\.nuget\nuget.exe restore
rd %CD%\website\bin /s /q
rd %CD%\website\obj /s /q
md %CD%\website\bin
%windir%\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe MyDay.sln /t:Build /p:Configuration=Debug