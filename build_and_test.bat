@echo off

:: build_and_test.bat
:: This file is used for local development.

:: Each tool's path
set MSBUILD_EXE="C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\msbuild.exe"
set ALTCOVER_EXE="packages\altcover.8.6.68\tools\net472\altcover.exe"
set VSTEST_CONSOLE_EXE="C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe"
set REPORT_GENERATOR_EXE="packages\ReportGenerator.5.1.26\tools\net47\ReportGenerator.exe"

:: Debug build
%MSBUILD_EXE% PFD_Editor.sln /p:Configuration=Debug /p:Platform="Any CPU"

:: AltCover
%ALTCOVER_EXE% /i="UnitTestProject/bin/Debug" /o="__Instrumented/UnitTestProject/bin/Debug" -l

:: vstest.console.exe
%VSTEST_CONSOLE_EXE% __Instrumented\UnitTestProject\bin\Debug\UnitTestProject.dll

:: ReportGenerator
%REPORT_GENERATOR_EXE% -reports:coverage.xml -targetdir:.\CoverageReport -reporttypes:"Html;MarkdownSummaryGithub;JsonSummary;Badges"
