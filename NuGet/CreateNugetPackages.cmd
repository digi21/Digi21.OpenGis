@echo off
nuget.exe pack Digi21.OpenGis.nuspec
nuget.exe sign Digi21.OpenGis.22.0.0.nupkg -CertificateSubjectName "DREAMING WITH OBJECTS" -TimeStamper http://timestamp.comodoca.com?td=sha256.

