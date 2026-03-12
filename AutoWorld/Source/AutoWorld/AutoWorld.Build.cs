// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class AutoWorld : ModuleRules
{
	public AutoWorld(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"AutoWorld",
			"AutoWorld/Variant_Platforming",
			"AutoWorld/Variant_Platforming/Animation",
			"AutoWorld/Variant_Combat",
			"AutoWorld/Variant_Combat/AI",
			"AutoWorld/Variant_Combat/Animation",
			"AutoWorld/Variant_Combat/Gameplay",
			"AutoWorld/Variant_Combat/Interfaces",
			"AutoWorld/Variant_Combat/UI",
			"AutoWorld/Variant_SideScrolling",
			"AutoWorld/Variant_SideScrolling/AI",
			"AutoWorld/Variant_SideScrolling/Gameplay",
			"AutoWorld/Variant_SideScrolling/Interfaces",
			"AutoWorld/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
