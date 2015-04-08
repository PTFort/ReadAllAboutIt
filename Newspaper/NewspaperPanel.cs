using System;
using ICities;
using UnityEngine;
using ColossalFramework.UI;

namespace Newspaper
{
	public class NewspaperPanel : UIPanel
	{
		public static NewspaperPanel instance;

		public bool show = false;
		private Rect windowRect = new Rect(64, 64, 350, 370);

		Story s;

		public static void Initialize()
		{
			//var controller = GameObject.FindObjectOfType<CameraController>();
			//instance = controller.gameObject.AddComponent<NewspaperPanel>();
		}

		public NewspaperPanel ()
		{
		}

		public override void Start ()
		{
			//this makes the panel "visible", I don't know what sprites are available, but found this value to work
			this.backgroundSprite = "GenericPanel";
			this.color = new Color32 (255, 0, 0, 100);
			this.width = 100;
			this.height = 200;

		}

		public override void Update()
		{
			if (show) {	

				windowRect = GUILayout.Window (31521, windowRect, DoConfigWindow, "The " + Parser.cityName + " Times");
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

