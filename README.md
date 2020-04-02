# UE4WithGoogle
## /!\ Is not working for now

Inspired by this great serie of articles wrote by @[ericlemes](https://github.com/ericlemes):

* https://ericlemes.com/2018/12/12/unit-tests-in-unreal-pt-1/
* https://ericlemes.com/2018/12/13/unit-tests-in-unreal-pt-2/
* https://ericlemes.com/2018/12/17/unit-tests-in-unreal-pt-3/


## Errors on GenerateProjectFile

### Build with 4.24

![Build with 4.21](./Docs/build-UE4.24.png)

```
Running C:/Program Files/Epic Games/UE_4.24/Engine/Binaries/DotNET/UnrealBuildTool.exe  -projectfiles -project="C:/Users/nansp/Documents/Unreal Projects/UE4WithGoogle/GoogleTestApp.uproject" -game -rocket -progress -log="C:\Users\nansp\Documents\Unreal Projects\UE4WithGoogle/Saved/Logs/UnrealVersionSelector-2020.04.03-09.44.27.log"
Discovering modules, targets and source code for project...
ERROR: Targets with a unique build environment cannot be built an installed engine.
```

### Build with 4.21

![Build with 4.21](./Docs/build-UE4.21.png)

```
Running C:/Program Files/Epic Games/UE_4.21/Engine/Binaries/DotNET/UnrealBuildTool.exe  -projectfiles -project="C:/Users/nansp/Documents/Unreal Projects/UE4WithGoogle/GoogleTestApp.uproject" -game -rocket -progress -log="C:\Users\nansp\Documents\Unreal Projects\UE4WithGoogle/Saved/Logs/UnrealVersionSelector-2020.04.03-09.41.37.log"
Discovering modules, targets and source code for project...
While compiling C:\Users\nansp\Documents\Unreal Projects\UE4WithGoogle\Intermediate\Build\BuildRules\GoogleTestAppModuleRules.dll:
c:\Users\nansp\Documents\Unreal Projects\UE4WithGoogle\Source\UE4WithGoogle.Target.cs(11,9) : error CS0103: Le nom 'DefaultBuildSettings' n'existe pas dans le contexte actuel
c:\Users\nansp\Documents\Unreal Projects\UE4WithGoogle\Source\UE4WithGoogle.Target.cs(11,32) : error CS0103: Le nom 'BuildSettingsVersion' n'existe pas dans le contexte actuel
c:\Users\nansp\Documents\Unreal Projects\UE4WithGoogle\Source\UE4WithGoogleEditor.Target.cs(11,9) : error CS0103: Le nom 'DefaultBuildSettings' n'existe pas dans le contexte actuel
c:\Users\nansp\Documents\Unreal Projects\UE4WithGoogle\Source\UE4WithGoogleEditor.Target.cs(11,32) : error CS0103: Le nom 'BuildSettingsVersion' n'existe pas dans le contexte actuel
ERROR: UnrealBuildTool Exception: Unable to compile source files.
```