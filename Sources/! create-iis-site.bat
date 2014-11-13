REM Define variables
set hostspath=%windir%\System32\drivers\etc\hosts
set appcmdpath=%windir%\System32\inetsrv
set sitedir="%CD%\Website"
set project=myday

REM Delete site and pool
%appcmdpath%\appcmd.exe delete site /site.name:"colours-%project%"
%appcmdpath%\appcmd.exe delete apppool /apppool.name:"colours-%project%"

REM Create AppPool
%appcmdpath%\appcmd.exe add apppool /name:"colours-%project%"
%appcmdpath%\appcmd.exe set apppool /apppool.name:"colours-%project%" /processModel.identityType:NetworkService
%appcmdpath%\appcmd.exe set apppool /apppool.name:"colours-%project%" /enable32BitAppOnWin64:false
%appcmdpath%\appcmd.exe set apppool /apppool.name:"colours-%project%" /managedPipelineMode:Integrated
%appcmdpath%\appcmd.exe set apppool /apppool.name:"colours-%project%" /managedRuntimeVersion:v4.0
%appcmdpath%\appcmd.exe set apppool /apppool.name:"colours-%project%" /autoStart:True
%appcmdpath%\appcmd.exe start apppool /apppool.name:"colours-%project%"

REM Create site
%appcmdpath%\appcmd.exe add site /name:"colours-%project%" /physicalPath:"%sitedir%"
%appcmdpath%\appcmd.exe set app /app.name:"colours-%project%/" /applicationPool:"colours-%project%"

REM Define bindings (leave first as)
%appcmdpath%\appcmd set site /site.name:"colours-%project%" /+bindings.[protocol='http',bindingInformation='*:80:%project%.local']
REM start site
%appcmdpath%\appcmd.exe start site /site.name:"colours-%project%"

@echo off
REM Add hosts to host file
echo. >> %hostspath%
echo 127.0.0.1		%project%.local >> %hostspath%

echo. >> %hostspath%
