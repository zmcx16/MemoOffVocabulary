@echo off

set PlatformName=%1
::------------------------
:: robocopy return code (0:No errors occurred, and no copying was done.) (1:One or more files were copied successfully (that is, new files have arrived).) (16:Serious error. Robocopy did not copy any files.)
robocopy .\ ..\..\..\Common\Output\%PlatformName%\ /e /xf *.config *.pdb *.manifest *.vshost.exe
if %errorlevel% == 16 ( 
	echo "copy build fail, error code = %errorlevel%"
) else (
	echo "copy build success, error code = %errorlevel%"
	cmd /c exit /b 0
)

robocopy .\ ..\..\..\Common\pdb\%PlatformName%\ *.pdb
if %errorlevel% == 16 ( 
	echo "copy build fail, error code = %errorlevel%"
) else (
	echo "copy build success, error code = %errorlevel%"
	cmd /c exit /b 0
)
::------------------------
cd ..\..\..\
set OutputFileListPath=%CD%\OutputFileList.txt
echo %OutputFileListPath%
cd Common\Output\%PlatformName%\
echo Current Dir = %CD%
set TargetDir=I:\work\WORK\C#\MemoOffVocabulary_release\MemoOffVocabularyVerSIGN\%PlatformName%\MemoOffVocabulary
for /F "tokens=*" %%A in (%OutputFileListPath%) do echo f | xcopy /f /y %CD%\%%A %TargetDir%\%%A
cd I:\work\WORK\C#\MemoOffVocabulary_release\MemoOffVocabularyVerSIGN\%PlatformName%
sign.bat


