
﻿using System;
using ColossalFramework;
using Newspaper;
using UnityEngine;
using ColossalFramework.Plugins;

namespace Newspaper
{
	public class Newspaper : MonoBehaviour
	{

		public static Newspaper instance;

		public bool show = false;
		private Rect windowRect = new Rect(64, 64, 350, 370);

		Story s;

		public static void Initialize()
		{
			var controller = GameObject.FindObjectOfType<CameraController>();
			instance = controller.gameObject.AddComponent<Newspaper>();
		}

		void OnGUI()
		{
			if (show)
			{	
				windowRect = GUI.Window(31521, windowRect, DoConfigWindow, "Newspaper");
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
			GUILayout.Label(s.headline);
			GUILayout.Label("-" + s.reporter);
			GUILayout.Label(s.text);
		}
	}
} 