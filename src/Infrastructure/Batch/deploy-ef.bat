set EfMigrationsNamespace=%1
set EfMigrationsDllName=%1.dll
set EfMigrationsDllDepsJson=%1.deps.json
set EfContext="CatalogContext"
set EfMigrationsDllRuntimeConfigJson=%1.runtimeconfig.json
set DllDir=%cd%
set PathToNuGetPackages=%USERPROFILE%\.nuget\packages
set PathToNuGetPackages_Fallback1="C:\Program Files (x86)\Microsoft SDKs\NuGetPackagesFallback"
set PathToNuGetPackages_Fallback2="C:\Program Files\dotnet\sdk\NuGetFallbackFolder"

set PathToEfDll="not-found"

set PathToEfDll_Option1=%PathToNuGetPackages_Fallback1%\microsoft.entityframeworkcore.tools.dotnet\2.0.3\tools\netcoreapp2.1\ef.dll
set PathToEfDll_Option2=%PathToNuGetPackages_Fallback2%\microsoft.entityframeworkcore.tools.dotnet\2.0.3\tools\netcoreapp2.1\ef.dll
set PathToEfDll_Option5=%PathToNuGetPackages_Fallback2%\microsoft.entityframeworkcore.tools\2.1.1\tools\netcoreapp2.0\any\ef.dll

set PathToEfDll_Option3=%PathToNuGetPackages%\microsoft.entityframeworkcore.tools\2.0.3\tools\netcoreapp2.1\ef.dll
set PathToEfDll_Option4=ef.dll

if %PathToEfDll% EQU "not-found" (
  if exist %PathToEfDll_Option4% (
      ECHO found ef.dll at %PathToEfDll_Option4%
      set PathToEfDll=%PathToEfDll_Option4%
  ) else (
    ECHO ef.dll not found at %PathToEfDll_Option4%      
  )
)

if %PathToEfDll% EQU "not-found" (
  if exist %PathToEfDll_Option1% (
      ECHO found ef.dll at %PathToEfDll_Option1%
      set PathToEfDll=%PathToEfDll_Option1%
  ) else (
    ECHO ef.dll not found at %PathToEfDll_Option1%      
  )
)

if %PathToEfDll% EQU "not-found" (
  if exist %PathToEfDll_Option2% (
      ECHO found ef.dll at %PathToEfDll_Option2%
      set PathToEfDll=%PathToEfDll_Option2%
  ) else (
    ECHO ef.dll not found at %PathToEfDll_Option2%      
  ) 
)

if %PathToEfDll% EQU "not-found" (
  if exist %PathToEfDll_Option3% (
      ECHO found ef.dll at %PathToEfDll_Option3%
      set PathToEfDll=%PathToEfDll_Option3%
  ) else (
    ECHO ef.dll not found at %PathToEfDll_Option3%      
  )
)

if %PathToEfDll% EQU "not-found" (
  if exist %PathToEfDll_Option5% (
      ECHO found ef.dll at %PathToEfDll_Option5%
      set PathToEfDll=%PathToEfDll_Option5%
  ) else (
    ECHO ef.dll not found at %PathToEfDll_Option5%      
  )
)

dotnet exec --depsfile .\%EfMigrationsDllDepsJson% --additionalprobingpath %PathToNuGetPackages% --additionalprobingpath %PathToNuGetPackages_Fallback1% --additionalprobingpath %PathToNuGetPackages_Fallback2% --runtimeconfig %EfMigrationsDllRuntimeConfigJson% %PathToEfDll% database update --assembly .\%EfMigrationsDllName% --startup-assembly .\%EfMigrationsDllName% --project-dir . --verbose --root-namespace %EfMigrationsNamespace% --context %EfContext%