using UnityEngine;
using ColossalFramework.UI;
using System;
using Newspaper;

namespace Newspaper
{
	public class NewspaperSkin
	{
		private Texture2D bgTexture;
		public GUISkin skin;

		public NewspaperSkin ()
		{
			bgTexture = new Texture2D(1, 1);
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
			texture.SetPixel(0, 0, new Color(0.98f, 0.98f, 0.98f, 0.98f));
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

