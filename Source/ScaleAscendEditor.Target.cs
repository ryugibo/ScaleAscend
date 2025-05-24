// Copyright ryugibo. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ScaleAscendEditorTarget : TargetRules
{
	public ScaleAscendEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;
		ExtraModuleNames.Add("ScaleAscend");
	}
}
