using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using Newtonsoft.Json;

namespace GTA_5_Mission_Creator_Tool.Models
{
	public class Updates
	{
		public int LatestVersion { get; set; }
		public string LatestDownload { get; set; }
		public string StartUpMessage { get; set; }

		private const string VersionCheckHost = "aaronrosser.xyz";
		private const string VersionCheckPath = "/projects/GTA5/PS3/GTA_5_Mission_Creator_Tool.json";
		public const int Version = 101;
		public const string VersionStr = "1.01";

		public static Updates CheckUpdates()
		{
			// Check if server is online
			if (new Ping().Send(VersionCheckHost).Status != IPStatus.Success)
			{
				return null;
			}

			Updates latestUpdate = null;

			try
			{
				HttpWebRequest Request = (HttpWebRequest)WebRequest.Create($"https://{VersionCheckHost}{VersionCheckPath}");
				Request.UserAgent = $"GTA_5_OG_Mission_Creator_Tool_{Version}";

				var res = Request.GetResponse().GetResponseStream();
				using (StreamReader sr = new StreamReader(res))
				{
					latestUpdate = JsonConvert.DeserializeObject<Updates>(sr.ReadToEnd());
				}
			}
			catch
			{
				return null;
			}

			return latestUpdate;
		}
	}
}
