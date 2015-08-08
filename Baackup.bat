@echo off
rem This is the launch script for the backup program!
rem The server will call this script upon backup.

rem Change to current directory and drive. NOTE: This may make it impossible to be run if the server is on a network path, please map the drive.
%~d0
cd %~dp0

rem Start program.

echo [Backup] Starting backup software.. please wait..
"%~dp0\Baackup\Baackup.exe"
if ERRORLEVEL==0 ( echo [Backup] Backup software reported finish. )
exit