// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FPSGame : ModuleRules
{
	public FPSGame(ReadOnlyTargetRules Target) : base(Target)
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
			"Slate",
			"GeometryCollectionEngine"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"FPSGame",
			"FPSGame/Variant_Horror",
			"FPSGame/Variant_Horror/UI",
			"FPSGame/Variant_Shooter",
			"FPSGame/Variant_Shooter/AI",
			"FPSGame/Variant_Shooter/UI",
			"FPSGame/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
