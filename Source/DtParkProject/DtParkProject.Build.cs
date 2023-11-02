// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class DtParkProject : ModuleRules
{
	public DtParkProject(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
