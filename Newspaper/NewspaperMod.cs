using ICities;
using UnityEngine;
using ColossalFramework.UI;
using ColossalFramework.Plugins;
using System.Reflection;

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

			Newspaper.Initialize();

		}
		private void ButtonClick(UIComponent component, UIMouseEventParameter eventParam)
		{
			Newspaper.Toggle();
		} 

	}
		


} 