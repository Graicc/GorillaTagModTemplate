using System;
using BepInEx;
using UnityEngine;
using Utilla;

namespace GorillaTagModTemplateProject
{
	[ModdedGamemode]
	[BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
	[BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
	public class Plugin : BaseUnityPlugin
	{
		bool inRoom;

		void Awake()
		{
			HarmonyPatches.ApplyHarmonyPatches();
			Utilla.Events.GameInitialized += OnGameInitialized;
		}

		void OnGameInitialized(object sender, EventArgs e)
		{
			/* Code here runs after the game initializes (i.e. GorillaLocomotion.Player.Instance != null) */
		}

		void Update()
		{

		}

		[ModdedGamemodeJoin]
		public void OnJoin(string gamemode)
		{
			/* Enable your mod here */
			inRoom = true;
		}

		[ModdedGamemodeLeave]
		public void OnLeave(string gamemode)
		{
			/* Disable your mod here */
			inRoom = false;
		}
	}
}
