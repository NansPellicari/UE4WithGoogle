using UnrealBuildTool;
using System.Collections.Generic;
using System.IO;

public class GoogleTestAppTarget : TargetRules
{
    public GoogleTestAppTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Program;
        LinkType = TargetLinkType.Modular;
        LaunchModuleName = "GoogleTestApp";

        bIsBuildingConsoleApplication = true;
    }
}