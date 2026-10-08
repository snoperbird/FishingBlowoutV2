// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FishingBlowout : ModuleRules
{
	public FishingBlowout(ReadOnlyTargetRules Target) : base(Target)
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
			"FishingBlowout",
			"FishingBlowout/Variant_Platforming",
			"FishingBlowout/Variant_Platforming/Animation",
			"FishingBlowout/Variant_Combat",
			"FishingBlowout/Variant_Combat/AI",
			"FishingBlowout/Variant_Combat/Animation",
			"FishingBlowout/Variant_Combat/Gameplay",
			"FishingBlowout/Variant_Combat/Interfaces",
			"FishingBlowout/Variant_Combat/UI",
			"FishingBlowout/Variant_SideScrolling",
			"FishingBlowout/Variant_SideScrolling/AI",
			"FishingBlowout/Variant_SideScrolling/Gameplay",
			"FishingBlowout/Variant_SideScrolling/Interfaces",
			"FishingBlowout/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
