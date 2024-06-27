@echo off
setlocal

rem Path to ILRepack.exe (adjust according to your ILRepack installation path)
set ILREPACK="packages\ILRepack.2.0.34\tools\ILRepack.exe"

rem Output path for the merged EXE
set OUTPUT="bin\Distribusi\ePrinterBASE_Merged.exe"

rem Path to your main EXE
set MAINEXE="bin\Release\ePrinterBASE.exe"

rem Paths to all the .NET DLLs you want to merge
set DLL1="bin\Release\Newtonsoft.Json.dll"
set DLL2="bin\Release\PdfiumViewer.dll"

rem Check if the files exist
if not exist %MAINEXE% (
    echo Main executable not found: %MAINEXE%
    exit /b 1
)

if not exist %DLL1% (
    echo DLL not found: %DLL1%
    exit /b 1
)

if not exist %DLL2% (
    echo DLL not found: %DLL2%
    exit /b 1
)

rem Run ILRepack
%ILREPACK% /out:%OUTPUT% %MAINEXE% %DLL1% %DLL2%

endlocal
