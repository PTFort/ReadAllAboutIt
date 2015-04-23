using System.IO;
using System;
using System.Xml.Serialization;
using UnityEngine;

namespace Newspaper
{

	public class Configuration
	{

		public string mayorpossess = "his";
		public string mayorname = "McMayor";

		public void OnPreSerialize()
		{
		}

		public void OnPostDeserialize()
		{
			Debug.Log ("mayorpossess " + mayorpossess);
			Debug.Log ("mayorname " + mayorname);
		}

		public static void Serialize(string filename, Configuration config)
		{
			
			var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Configuration));

			using (var writer = new StreamWriter(filename))
			{
				config.OnPreSerialize();
				serializer.Serialize(writer, config);
			}
		}

		public static Configuration Deserialize(string filename)
		{
			
			var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Configuration));

			try
			{
				using (var reader = new StreamReader(filename))
				{
					var config = (Configuration)serializer.Deserialize(reader);
					config.OnPostDeserialize();
					return config;
				}
			}
			catch (System.Exception ex)
			{
				Debug.Log (ex.ToString ());
			}

			return null;
		}
	}

}