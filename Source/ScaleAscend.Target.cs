// Copyright ryugibo. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ScaleAscendTarget : TargetRules
{
	public ScaleAscendTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;
		ExtraModuleNames.Add("ScaleAscend");
	}
}
