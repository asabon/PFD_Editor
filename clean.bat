@echo off

%MSBUILD_EXE% PFD_Editor.sln /t:clean
del coverage.xml
rmdir /s /q CoverageReport
rmdir /s /q TestResults
