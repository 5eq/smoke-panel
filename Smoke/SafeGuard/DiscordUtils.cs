using System;

namespace SafeGuard
{
	// Token: 0x02000002 RID: 2
	internal static class DiscordUtils
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static void DiscordLog(string action, string username, string ip)
		{
			action = action.ToLower();
			string message = "";
			string title = "";
			string picture = "https://i.imgur.com/IQ6BmXx.png";
			string text = action;
			string a = text;
			if (!(a == "login"))
			{
				if (!(a == "register"))
				{
					if (!(a == "attack"))
					{
						if (!(a == "geo"))
						{
							if (a == "logout")
							{
								message = string.Concat(new string[]
								{
									"Project_Hell | Version: [",
									Update.version,
									"]\n ",
									username,
									"\n [",
									Tools.GetClientIP(),
									"]\n User Loggout Out."
								});
								title = "Log | Logout";
							}
						}
						else
						{
							message = "Project_Hell | Version: [" + Update.version + "]\n" + ip;
							title = "Log | Geo";
						}
					}
					else
					{
						message = string.Concat(new string[]
						{
							"Project_Hell | Version: [",
							Update.version,
							"]\n ",
							username,
							":\n",
							ip,
							"\n"
						});
						title = "Log | Attack";
					}
				}
				else
				{
					message = "Project_Hell | Version: [" + Update.version + "]\n" + ip;
					title = "Log | Register";
				}
			}
			else
			{
				message = "Project_Hell | Version: [" + Update.version + "]\n" + ip;
				title = "Log | Login";
			}
			DiscordUtils.LogToDiscord("r4pBzgKUgkGC1WPV8pHnok+942q+QjA11bY4rcbkfcICCzH1NGMNzqmYiKMo45eBU7Yn2ajBCG7fgoWvewrG0A==", new DiscordHookObject
			{
				Message = message,
				Title = title,
				Picture = picture,
				ProgramId = "879b6894-e303-40c6-8e80-c361ccee02a9"
			});
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000021EC File Offset: 0x000003EC
		private static bool LogToDiscord(string apikey, DiscordHookObject DiscordObject)
		{
			bool flag = DiscordObject == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				try
				{
					Tools.postRequest("https://safeguardauth.us/LogToDiscordv2?apikey=" + apikey, DiscordObject);
				}
				catch
				{
					return false;
				}
				result = true;
			}
			return result;
		}
	}
}
