using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;

namespace GorillaTagModTemplateProject.Patches
{
	[HarmonyPatch(typeof(GorillaLocomotion.Player))]
	[HarmonyPatch("Awake", MethodType.Normal)]
	internal class ExamplePatch
	{
		private static void Postfix(GorillaLocomotion.Player __instance)
		{
			Console.WriteLine(__instance.maxJumpSpeed);
		}
	}
}
