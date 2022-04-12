@echo off
nuget.exe pack Digi21.OpenGis.nuspec
nuget.exe sign Digi21.OpenGis.17.2.0.nupkg -CertificatePath dwo.pfx -TimeStamper http://tsa.starfieldtech.com
