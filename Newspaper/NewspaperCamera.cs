using UnityEngine;
using System;
using System.Linq;
using System.Collections;

namespace Newspaper
{
	public class NewspaperCamera : MonoBehaviour
	{
//		static System.Random random = new System.Random();
//
//		private GameObject _cameraGameObject;
//		private Camera _camera;
//
//		public static NewspaperCamera instance;
//		public static Camera mainCamera;

		public static void Initialize()
		{
//			CameraController controller = FindObjectOfType<CameraController>();
//			instance = controller.gameObject.AddComponent<NewspaperCamera>();
		}

		void Awake()
		{
//			_cameraGameObject = new GameObject("NewspaperCamera");
//			_camera = _cameraGameObject.AddComponent<Camera>();
//
//			var controller = FindObjectOfType<CameraController>();
//			mainCamera = controller.GetComponent<Camera>();
//
//
//			_camera.CopyFrom (mainCamera);
//
//			//Find main cam and copy config from it.
////			var cameras = GameObject.FindObjectsOfType<Camera>();
////			foreach (var cam in cameras)
////			{
////				if (cam.name == "Main Camera")
////					_camera.CopyFrom(cam);
////			}
//
//			_camera.depth = -100;


		}

		public Texture2D getTexture(int width, int height)
		{
//		void Update()
//		{

//			//get the names of any districts in the city
//			DistrictManager dm = DistrictManager.instance;
//
//			//int dCount = 0;
//			//uint maxDCount = dm.m_districts.m_size;
//
//			//Debug.Log ("District maxDCount: " + maxDCount);
//
//
//			ArrayList ds = new ArrayList();
//
//			uint maxDCount = dm.m_districts.m_size;
//
//			//Debug.Log ("District maxDCount: " + maxDCount);
//
//			for (int i = 0; i < maxDCount; i++) {
//				String d = dm.GetDistrictName(i);
//				if (d != null && ! d.Equals ("")) {
//					ds.Add (dm.m_districts.m_buffer[i]);
//				}
//			}
//
//			int randDistrictIndex = random.Next (ds.Count);
//			District dis = (District) ds[randDistrictIndex];
//
//			float mapMiddle = TerrainManager.RAW_RESOLUTION / 2;
//			Vector3 middle = new Vector3 (mapMiddle, 60, mapMiddle);
//
//			width = 400;
//			height = 200;
//
//			//Render the camera to a Render texture
//			RenderTexture rt = new RenderTexture (width, height, 24);
//			rt.Create ();
//			mainCamera.targetTexture = rt;
//
//			Vector3 position = Vector3.zero;
//			Quaternion orientation = Quaternion.identity;
//
//			Vector3 mainCameraPosition = mainCamera.transform.position;
//
//			//float randX = random.Next (0, 500);
//			//float randY = random.Next (0, 500);
//			Vector3 fromPos = new Vector3 (mainCameraPosition.x, mainCameraPosition.y, mainCameraPosition.z);
//			Vector3 toPos = new Vector3 (mainCameraPosition.x, mainCameraPosition.y, TerrainManager.instance.SampleDetailHeight(mainCameraPosition));
//
//			//Quaternion mainCameraOrientation = mainCamera.transform.rotation;
//
//			//_camera.transform.position = fromPos;
//			//_camera.transform.rotation = mainCameraOrientation;
//			//_camera.transform.LookAt(toPos + new Vector3(0f, 1.5f, 0f), Vector3.up);
//
//			mainCamera.transform.LookAt(middle);
//
//			mainCamera.Render();
//
//			RenderTexture.active = rt;
//			Texture2D screenShot = new Texture2D(width, height, TextureFormat.RGB24, false);
//			screenShot.ReadPixels(new Rect(0, 0, width, height), 0, 0);
//			screenShot.Apply ();
//
//			mainCamera.targetTexture = null;
//			RenderTexture.active = null; 
//			Destroy(rt);
//
//			return screenShot;
			return null;
		}
	}
}

