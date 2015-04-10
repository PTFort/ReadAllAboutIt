
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

		public static Newspaper instance;

		public bool show = false;
		private Rect windowRect;

		Story s;
		GUISkin skin;


		GUIStyle labelStyle;
		GUIStyle headlineStyle;

		public static void Initialize()
		{
			var controller = GameObject.FindObjectOfType<CameraController>();
			instance = controller.gameObject.AddComponent<Newspaper>();

			//TODO: Move this to NewspaperSkin

			float w = 0.8f; // proportional width (0..1)
			float h = 0.6f; // proportional height (0..1)

			float xDiff = (Screen.width * w)/2;
			float yDiff = (Screen.height * h)/2;

			
			instance.windowRect = new Rect ();

			instance.windowRect.xMin = (Screen.width/2) - xDiff;
			instance.windowRect.xMax = (Screen.width/2) + xDiff;
			instance.windowRect.yMin = (Screen.height/2) - yDiff;
			instance.windowRect.yMax = (Screen.height/2) + yDiff;

		}

		void OnGUI()
		{
			if (show)
			{	

				Texture2D bgTexture;
				bgTexture = new Texture2D(1, 1);
//				for (int i = 0; i < 3; i++) {
//					for (int j = 0; j < 3; j++) {
//						bgTexture.SetPixel(i, j, Color.black);
//					}
//				}
				bgTexture.SetPixel(0, 0, Color.black);
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
				texture.SetPixel(0, 0, new Color(0.98f, 0.98f, 0.98f, 0.98f));
				texture.Apply();

				labelStyle = new GUIStyle { fontSize = 12, wordWrap = true, normal = new GUIStyleState { textColor = Color.black, background = texture } };
				headlineStyle = new GUIStyle { alignment = TextAnchor.MiddleCenter, fontSize = 18, wordWrap = true, normal = new GUIStyleState { textColor = Color.black, background = texture } };

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

				//skin.label.font.material.color = new Color32(255, 0, 0, 0);


				GUISkin oldSkin = GUI.skin;

				GUI.skin = skin;
				windowRect = GUILayout.Window(31521, windowRect, DoConfigWindow, "The " + Parser.cityName + " Times");
				GUI.skin = oldSkin;
			}
		}

		public static void Toggle()
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
//			Texture2D headlineTexture;
//			headlineTexture = new Texture2D(1, 1);
//			headlineTexture.SetPixel(0, 0, Color.white);
//			headlineTexture.Apply();


			//GUILayout.ExpandHeight (true);
			//GUILayout.ExpandWidth (true);


			GUILayout.Label(s.headline, headlineStyle);
			GUILayout.Label("\n-" + s.reporter + "\n\n", labelStyle);
			GUILayout.Label(s.text, labelStyle);

		}
	}
} 