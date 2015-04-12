﻿
﻿using System;
using ColossalFramework;
using Newspaper;
using UnityEngine;
using ColossalFramework.Plugins;
using ColossalFramework.UI;

namespace Newspaper
{
	public class Newspaper : MonoBehaviour
	{
		public static System.Random random = new System.Random();

		public static Newspaper instance;
		public static bool b = true;
		public bool show = false;
		private Rect windowRect;

		Story s;

		GUIStyle labelStyle;
		GUIStyle boldLabelStyle;
		GUIStyle headlineStyle;
		GUIStyle bannerStyle;

		GUIStyle barStyle;

		GUISkin skin = null;

		Texture2D bgTexture;

		Texture2D bannerBoxes;
		GUIStyle bannerBoxStyle;



		void Awake()
		{
			

			//TODO: Move this to NewspaperSkin

			float w = 0.9f; // proportional width (0..1)
			float h = 0.5f; // proportional height (0..1)

			float xDiff = (Screen.width * w)/2;
			float yDiff = (Screen.height * h)/2;

			if (xDiff > 300)
				xDiff = 300;

			
			windowRect = new Rect ();

			windowRect.xMin = (Screen.width/2) - xDiff;
			windowRect.xMax = (Screen.width/2) + xDiff;
			windowRect.yMin = (Screen.height/3) - yDiff;
			windowRect.yMax = (Screen.height/3) + yDiff;




			//nSkin = new NewspaperSkin ();


			bgTexture = new Texture2D(1, 1);
			//				for (int i = 0; i < 3; i++) {
			//					for (int j = 0; j < 3; j++) {
			//						bgTexture.SetPixel(i, j, Color.black);
			//					}
			//				}
			bgTexture.SetPixel(0, 0, Color.black);
			bgTexture.Apply();

			bannerBoxes = new Texture2D(1, 1, TextureFormat.RGBA32, false);
			bannerBoxes.SetPixel (0, 0, new Color(0.90f, 0.90f, 0.98f, 1f));
			bannerBoxes.Apply ();



		}
			


		void OnGUI()
		{
			

			if (show)
			{	

				if (skin == null)
					createSkin ();

				try
				{
					//get the name of the city
					Parser.cityName = CityInfoPanel.instance.GetCityName();
				}catch (Exception e) {
					Debug.Log ("Error in detecting city name");
					Debug.Log (e.Message);
					Debug.Log (e.StackTrace);
				}

				Texture2D texture = new Texture2D(1, 1, TextureFormat.RGBA32, false);
				texture.SetPixel(0, 0, new Color(0.98f, 0.98f, 0.98f, 1f));
				texture.Apply();


				labelStyle = new GUIStyle { fontSize = 12, wordWrap = true, normal = new GUIStyleState { textColor = Color.black, background = texture } };
				boldLabelStyle = new GUIStyle { alignment = TextAnchor.MiddleCenter, fontSize = 12, fontStyle = FontStyle.Bold, wordWrap = true, normal = new GUIStyleState { textColor = Color.black, background = texture } };


				headlineStyle = new GUIStyle { alignment = TextAnchor.MiddleCenter, fontStyle = FontStyle.Bold, fontSize = 16, wordWrap = true, normal = new GUIStyleState { textColor = Color.black, background = texture } };
				bannerStyle = new GUIStyle { alignment = TextAnchor.MiddleCenter, fontStyle = FontStyle.Italic, fontSize = 38, wordWrap = true, normal = new GUIStyleState { textColor = Color.black, background = texture } };
				barStyle = new GUIStyle { alignment = TextAnchor.MiddleCenter, fontStyle = FontStyle.Italic, fontSize = 6, wordWrap = true, normal = new GUIStyleState { textColor = Color.black, background = bgTexture } };

				Color bannerBoxTextColor = new Color (0.0f, 0.15f, 0.7f, 1f);
				bannerBoxStyle = new GUIStyle { alignment = TextAnchor.MiddleCenter, fontSize = 12, wordWrap = true, normal = new GUIStyleState { textColor = bannerBoxTextColor, background = bannerBoxes } };


				//leave the newspaper on escape key-press
				if (Input.GetKeyDown (KeyCode.Escape)) {
					show = false;
				}


				GUISkin oldSkin = GUI.skin;


				GUI.skin = skin;
				windowRect = GUILayout.Window(31521, windowRect, DoConfigWindow, "");
				GUI.skin = oldSkin;
			}
		}


		public static void Toggle(UIComponent component, UIMouseEventParameter eventParam)
		{
			instance.show = !instance.show;

			//generate a new Story only when the newspaper is opened
			if (instance.show == true) {
				instance.s = new Story ();
			} else {
				instance.s = null;
			}
		}
			
		public void DoConfigWindow(int wnd)
		{
			try{
				
				GUILayout.Height (10);

				GUILayout.ExpandHeight (true);
				GUILayout.BeginVertical();

				GUILayout.Label("The " + Parser.cityName + " Times", bannerStyle);
				GUILayout.Space (8);


				GUILayout.BeginHorizontal();

				GUILayout.Label("Weather: " + s.weather, bannerBoxStyle);
				GUILayout.Space (10);
				GUILayout.Label(s.otherArticle1, bannerBoxStyle);
				GUILayout.Space (10);
				GUILayout.Label(s.otherArticle2, bannerBoxStyle);

				GUILayout.EndHorizontal();

				GUILayout.Space (8);
				GUILayout.Label ("-----------------------------", barStyle); 
				GUILayout.Space (8);

				//begin main section
				GUILayout.BeginHorizontal();

				GUILayout.BeginVertical();
				GUILayout.Label("", labelStyle);
				GUILayout.EndVertical();

				GUILayout.Space (10);

				GUILayout.BeginVertical();
				GUILayout.Label(s.headline, headlineStyle);
				GUILayout.Space (15);
				GUILayout.Label("-" + s.reporter + "\n", labelStyle);
				GUILayout.Label(s.text, labelStyle);
				GUILayout.EndVertical();

				GUILayout.Space (10);

				GUILayout.BeginVertical();
				GUILayout.Label("", labelStyle);
				GUILayout.EndVertical();


				//end main section
				GUILayout.EndHorizontal();

				GUILayout.Space (30);

				GUILayout.BeginHorizontal();
				GUILayout.Label("Founded 2015", boldLabelStyle);
				GUILayout.Space (10);


				GUILayout.BeginVertical();
				GUILayout.Label("Daily Poll:", boldLabelStyle);
				GUILayout.Label (s.poll, labelStyle);
				GUILayout.EndVertical();


				GUILayout.Space (10);

				GUILayout.BeginVertical();
				GUILayout.Label("Quote of the Day:", boldLabelStyle);
				GUILayout.Label(s.qotd, labelStyle);
				GUILayout.EndVertical();



				GUILayout.EndHorizontal();

				GUILayout.EndVertical();
			}
			catch(Exception e) {
				Debug.Log (e.Message);
				Debug.Log (e.StackTrace);
			}

		}

		public void createSkin()
		{
			Texture2D bgTexture = new Texture2D(1, 1);
			bgTexture.SetPixel(0, 0, Color.grey);
			bgTexture.Apply();


			skin = ScriptableObject.CreateInstance<GUISkin>();
			skin.box = new GUIStyle(GUI.skin.box);
			skin.button = new GUIStyle(GUI.skin.button);
			skin.horizontalScrollbar = new GUIStyle(GUI.skin.horizontalScrollbar);
			skin.horizontalScrollbarLeftButton = new GUIStyle(GUI.skin.horizontalScrollbarLeftButton);
			skin.horizontalScrollbarRightButton = new GUIStyle(GUI.skin.horizontalScrollbarRightButton);
			skin.horizontalScrollbarThumb = new GUIStyle(GUI.skin.horizontalScrollbarThumb);
			skin.horizontalSlider = new GUIStyle(GUI.skin.horizontalSlider);
			skin.horizontalSliderThumb = new GUIStyle(GUI.skin.horizontalSliderThumb);
			skin.label = new GUIStyle(GUI.skin.label);

			Texture2D texture = new Texture2D(1, 1, TextureFormat.RGBA32, false);
			texture.SetPixel(0, 0, new Color(0.98f, 0.98f, 0.98f, 1f));
			texture.Apply();

			//labelStyle = new GUIStyle { fontSize = 12, wordWrap = true, normal = new GUIStyleState { textColor = Color.black, background = texture } };
			//headlineStyle = new GUIStyle { alignment = TextAnchor.MiddleCenter, fontSize = 18, wordWrap = true, normal = new GUIStyleState { textColor = Color.black, background = texture } };

			skin.scrollView = new GUIStyle(GUI.skin.scrollView);
			skin.textArea = new GUIStyle(GUI.skin.textArea);
			skin.textField = new GUIStyle(GUI.skin.textField);
			skin.toggle = new GUIStyle(GUI.skin.toggle);
			skin.verticalScrollbar = new GUIStyle(GUI.skin.verticalScrollbar);
			skin.verticalScrollbarDownButton = new GUIStyle(GUI.skin.verticalScrollbarDownButton);
			skin.verticalScrollbarThumb = new GUIStyle(GUI.skin.verticalScrollbarThumb);
			skin.verticalScrollbarUpButton = new GUIStyle(GUI.skin.verticalScrollbarUpButton);
			skin.verticalSlider = new GUIStyle(GUI.skin.verticalSlider);
			skin.verticalSliderThumb = new GUIStyle(GUI.skin.verticalSliderThumb);
			skin.window = new GUIStyle(GUI.skin.window);
			skin.window.normal.background = texture;
			skin.window.onNormal.background = texture;
		}
	}
} 