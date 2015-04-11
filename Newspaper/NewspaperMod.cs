using ICities;
using UnityEngine;
using ColossalFramework.UI;
using ColossalFramework.Plugins;
using System.Reflection;
using System;
using System.Collections;
using Newspaper;

//taken from https://github.com/AlexanderDzhoganov/Skylines-DynamicResolution/

namespace Newspaper
{
	public class NewspaperMod : IUserMod
	{
		public string Name { get { return "Read All About It"; } }
		public string Description { get { return "Newspaper mod"; } }
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
			button.text = "Toggle Newspaper";

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


			button.transformPosition = new Vector3(0.9f, -0.70f);
			button.BringToFront();

			// Respond to button click.
			button.eventClick += ButtonClick; 


			NewspaperObj.Initialize();


			//get the name of the city
			Parser.cityName = CityInfoPanel.instance.GetCityName();


			//get the names of any districts in the city
			DistrictManager dm = DistrictManager.instance;

			int dCount = 0;
			uint maxDCount = dm.m_districts.m_size;

			Debug.Log ("District maxDCount: " + maxDCount);

//			Debug.Log ("District count: " + dCount);


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


		}
		private void ButtonClick(UIComponent component, UIMouseEventParameter eventParam)
		{
			NewspaperObj.Toggle();
		} 

	

	}
		


} 