@echo off

call clean

md bin

csc -t:library -out:bin/ConceptArchitectIN.dll Source/ConceptArchitectIn/Data/*.cs Source/ConceptArchitectIn/Furniture/*.cs

csc -t:library -out:bin/EchoLabs.dll Source/EchoLabs/*.cs 

csc Source/App.cs -out:bin/App.exe -r:bin/ConceptArchitectIN.dll,bin/EchoLabs.dll

tree bin /f
