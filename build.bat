@echo off
setlocal enabledelayedexpansion

if not exist dist (
	mkdir dist
)

if exist C:\Windows\Microsoft.NET\Framework\v4.* (
	for /d %%a in ("C:\Windows\Microsoft.NET\Framework\v4.*") do (
		set "file=%%~fa\msbuild.exe"
	)
	if exist !file! (
		echo on
		!file! ShadowverseTracker.sln
		echo finished compiling
		copy ShadowverseTracker\obj\debug\ShadowverseTracker.exe dist
		copy IconChanger\obj\debug\IconChanger.exe dist
		echo copied files to dist
		echo done
		echo off
	) else (
		echo on
		echo could not find msbuild.exe
		echo off
	)
) else (
	echo on
	echo could not find .net framework 4
	echo off
)

pause>nul