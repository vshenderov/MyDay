set taskrun="%CD%\MyDay.Grabber\bin\Debug\MyDay.Grabber.exe"
schtasks /create /TN "MyDay Grabber" /TR \"%taskrun%\" /SC MINUTE /mo 1 /RL HIGHEST /F
pause