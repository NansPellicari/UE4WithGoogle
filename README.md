# UE4WithGoogle

>:warning: Important note :warning:  
> If you prefer a ready made solutions you can take a look at this repository:  
> https://github.com/NansPellicari/UE4-TPL-CppWithTestEnv :gift:  
> You can launch UE4 tests and google test easily + have code coverage reports (OpenCppCoverage).  
> :wink: Enjoy!

Inspired by this great serie of articles wrote by [@ericlemes](https://github.com/ericlemes):

* https://ericlemes.com/2018/12/12/unit-tests-in-unreal-pt-1/
* https://ericlemes.com/2018/12/13/unit-tests-in-unreal-pt-2/
* https://ericlemes.com/2018/12/17/unit-tests-in-unreal-pt-3/

## How it's work

:confused:  First, I still don't know for what reason but the **Unreal Build Tool** is not capable to `Generate Visual Studio project files` of the `GoogleTestApp.uproject` when the `Source/UE4WithGoogle[Editor].Target.cs` files exists (but no problem to generate `UE4WithGoogle.uproject`).

:bulb: So the best shot I've found is to used command lines instead.  
This will generate the tests executable in `Binaries/Win64[or 32]/GoogleTestApp.exe`:

```bat
// depends on your system, switch Win64 to Win32 of course
<your UE4 installed directory>Engine\Build\BatchFiles\Build.bat GoogleTestApp Win64 Development <your project directory>GoogleTestApp.uproject -waitmutex
# OR you can use this script if you have lazy fingers like me:
.\BuildGoogleTestApp.bat <your UE4 installed directory>
```

Then to run tests you just have to execute the generated exe file:

```bat
.\Binaries\Win64\GoogleTestApp.exe
# OR
RunTest.bat
```

And Voilà :clap:

![Command Results](./Docs/command-results.png)

## Step by step

### clone & install submodule

```
git clone git@github.com:NansPellicari/UE4WithGoogle.git
cd UE4WithGoogle
git submodule init
git submodule update
```


### 1. Create *.uproject file

'Cause I used a clone of the Unreal Engine repository (https://github.com/EpicGames/UnrealEngine) (and recommend to do the same), these files contained a weird `"EngineAssociation"` value.  
To be honest I didn't dig too much but these values doesn't seems to be related to the repository commit, so my guess was _"it's probably a random value"_.  

Then instead to commit them I create `*.uproject.sample` files.  
Just copy them and remove the `.sample` suffix or use
 ```
 .\CopyUprojectFiles.bat
 ```


### 2. Generate Visual Studio project files

![Generate Visual Studio project files](./Docs/generate-vs-files.png)

### 3. Build `GoogleTestApp.uproject`

As I said above, it can't be created as the `UE4WithGoogle.uproject`.  

```bat
.\BuildGoogleTestApp.bat <your UE4 installed directory>
```
![Build Results](./Docs/build-results.png)

### 4. Run tests

```bat
 .\RunTest.bat
```
It's soooo fast :heart_eyes:!

![Command Results](./Docs/command-results.png)