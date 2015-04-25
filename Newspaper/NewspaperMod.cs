using ICities;
using UnityEngine;
using ColossalFramework.UI;
using ColossalFramework.Plugins;
using System.Reflection;
using System;
using System.Collections;
using Newspaper;

//many parts taken from:
//https://github.com/AlexanderDzhoganov/Skylines-DynamicResolution/

namespace Newspaper
{
	public class NewspaperMod : IUserMod
	{
		public string Name { get { return "Read All About It"; } }
		public string Description { get { return "This is a newspaper mod in order to re-live the glory days of simulated newspapers in our simulated cities."; } }
	}

	public class LoadingExtension : LoadingExtensionBase
	{

		public override void OnLevelLoaded(LoadMode mode)
		{
			if (mode != LoadMode.NewGame && mode != LoadMode.LoadGame)
			{
				return;
			}

			// this seems to get the default UIView
			UIView uiView = UIView.GetAView ();

			//this adds an UIComponent to the view
			//UIComponent uic = uiView.AddUIComponent (typeof(NewspaperPanel));

			// Add a new button to the view.
			var button = (UIButton)uiView.AddUIComponent(typeof(UIButton));

			// Set the text to show on the button.
			button.text = "Show Newspaper";

			// Set the button dimensions.
			button.width = 200;
			button.height = 30;

			// Style the button to look like a menu button.
			button.normalBgSprite = "ButtonMenu";
			button.disabledBgSprite = "ButtonMenuDisabled";
			button.hoveredBgSprite = "ButtonMenuHovered";
			button.focusedBgSprite = "ButtonMenuFocused";
			button.pressedBgSprite = "ButtonMenuPressed";
			button.textColor = new Color32(255, 255, 255, 255);
			button.disabledTextColor = new Color32(7, 7, 7, 255);
			button.hoveredTextColor = new Color32(7, 132, 255, 255);
			button.focusedTextColor = new Color32(255, 255, 255, 255);
			button.pressedTextColor = new Color32(30, 30, 44, 255);

			// Enable button sounds.
			button.playAudioEvents = true;

//			UIComponent escbutton = uiView.FindUIComponent("Esc");
//			button.relativePosition = new Vector2
//				(
//					escbutton.relativePosition.x - escbutton.width / 2.0f - button.width / 2.0f - escbutton.width - 20.0f,
//					escbutton.relativePosition.y + escbutton.height / 2.0f - button.height / 2.0f
//				);

			//set button position
			button.transformPosition = new Vector3(0.8f, 0.95f);
			button.BringToFront();
			button.eventClick += NewspaperPage.Toggle; 


			try
			{
				
				//uiView = UIView.GetAView ();
				//hook = uiView.gameObject.AddComponent<Hook>();

				//var controller = GameObject.FindObjectOfType<CameraController>();

//				if (uiView == null)
//					Debug.Log ("uiView is null");
//
//				if (uiView.gameObject == null)
//					Debug.Log ("uiView.gameObject is null");
//
//				NewspaperObj nObj = uiView.gameObject.AddComponent<NewspaperObj>();
//
//				if (nObj == null)
//					Debug.Log ("nObj is null");



				//uiView = UIView.GetAView ();

				NewspaperPage.instance = uiView.gameObject.AddComponent<NewspaperPage>();

				//TODO: Figure out why nulls sometimes appear
				if (NewspaperPage.instance == null)
					Debug.Log ("instance is null!!!");


			}catch (Exception e) {
				Debug.Log (e.Message);
				Debug.Log (e.StackTrace);
			}


			try
			{
				//get the names of any districts in the city
				DistrictManager dm = DistrictManager.instance;

				int dCount = 0;
				uint maxDCount = dm.m_districts.m_size;

				//Debug.Log ("District maxDCount: " + maxDCount);

				for (int i = 0; i < maxDCount; i++) {
					String d = dm.GetDistrictName(i);
					if (d != null && ! d.Equals ("")) {
						dCount += 1;
					}
				}

				//Debug.Log ("District Size: " + dCount);
					
				if (dCount > 0) {
					
					string[] dNameArr = new string[dCount];
					int index = 0;

					//TODO: Make this not run through the list twice
					for (int i = 0; i < maxDCount; i++) {
						String d = dm.GetDistrictName (i);

						//Debug.Log ("District: " + d);
						if (d != null && ! d.Equals ("")) {
							dNameArr [index] = d;
							index += 1;
						}
					}
					Parser.districts = dNameArr;
				}

			}catch (Exception e) {
				Debug.Log ("Error in detecting district names");
				Debug.Log (e.Message);
				Debug.Log (e.StackTrace);
			}

			//TODO: Make Newspaper camera work
			//try to start up the newspaper camera
			//NewspaperCamera.Initialize ();

		}


	

	}
		


} 