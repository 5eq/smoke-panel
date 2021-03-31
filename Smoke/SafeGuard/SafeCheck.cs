using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SafeGuard
{
	// Token: 0x02000008 RID: 8
	internal class SafeCheck
	{
		// Token: 0x06000012 RID: 18 RVA: 0x000022E8 File Offset: 0x000004E8
		internal static void Md5Check()
		{
			bool flag = SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "SafeGuard.dll", "MD5") != SafeCheck.CurrentDllMD5;
			if (flag)
			{
				MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			bool flag2 = SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "SafeGuard.dll", "SHA1") != SafeCheck.CurrentDllSHA1;
			if (flag2)
			{
				MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			bool flag3 = SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "SafeGuard.dll", "SHA256") != SafeCheck.CurrentDllSHA256;
			if (flag3)
			{
				MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			bool flag4 = SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "SafeGuard.dll", "SIZE") != SafeCheck.CurrentDllSize;
			if (flag4)
			{
				MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			bool flag5 = SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "Newtonsoft.Json.dll", "MD5") != SafeCheck.CurrentNewtonSoftMD5;
			if (flag5)
			{
				MessageBox.Show("Invalid Newtonsoft.Json.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			bool flag6 = SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "Newtonsoft.Json.dll", "SHA1") != SafeCheck.CurrentNewtonSoftSHA1;
			if (flag6)
			{
				MessageBox.Show("Invalid Newtonsoft.Json.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			bool flag7 = SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "Newtonsoft.Json.dll", "SHA256") != SafeCheck.CurrentNewtonSoftSHA256;
			if (flag7)
			{
				MessageBox.Show("Invalid Newtonsoft.Json.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			bool flag8 = SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "Newtonsoft.Json.dll", "SIZE") != SafeCheck.CurrentNewtonSoftSize;
			if (flag8)
			{
				MessageBox.Show("Invalid Newtonsoft.Json.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002548 File Offset: 0x00000748
		internal static string ComputeHash(string s, string hashtype)
		{
			if (!(hashtype == "MD5"))
			{
				if (!(hashtype == "SHA1"))
				{
					if (hashtype == "SHA256")
					{
						goto IL_15F;
					}
					if (!(hashtype == "SIZE"))
					{
						goto IL_224;
					}
					goto IL_1E9;
				}
			}
			else
			{
				using (MD5 md = MD5.Create())
				{
					try
					{
						using (FileStream fileStream = File.OpenRead(s))
						{
							byte[] array = md.ComputeHash(fileStream);
							StringBuilder stringBuilder = new StringBuilder();
							for (int i = 0; i < array.Length; i++)
							{
								stringBuilder.Append(array[i].ToString("X2"));
							}
							return stringBuilder.ToString();
						}
					}
					catch
					{
						return "MD5 Error";
					}
				}
			}
			using (SHA1 sha = SHA1.Create())
			{
				try
				{
					using (FileStream fileStream2 = File.OpenRead(s))
					{
						byte[] array2 = sha.ComputeHash(fileStream2);
						StringBuilder stringBuilder2 = new StringBuilder();
						for (int j = 0; j < array2.Length; j++)
						{
							stringBuilder2.Append(array2[j].ToString("X2"));
						}
						return stringBuilder2.ToString();
					}
				}
				catch
				{
					return "SHA1 Error";
				}
			}
			IL_15F:
			using (SHA256 sha2 = SHA256.Create())
			{
				try
				{
					using (FileStream fileStream3 = File.OpenRead(s))
					{
						byte[] array3 = sha2.ComputeHash(fileStream3);
						StringBuilder stringBuilder3 = new StringBuilder();
						for (int k = 0; k < array3.Length; k++)
						{
							stringBuilder3.Append(array3[k].ToString("X2"));
						}
						return stringBuilder3.ToString();
					}
				}
				catch
				{
					return "SHA256 Error";
				}
			}
			IL_1E9:
			try
			{
				using (File.OpenRead(s))
				{
					return new FileInfo(s).Length.ToString();
				}
			}
			catch
			{
				return "File Size Error";
			}
			IL_224:
			return "Invalid Type";
		}

		// Token: 0x04000011 RID: 17
		internal static string CurrentDllMD5 = "3307FC407D88BA40ABEAC87266F4558D";

		// Token: 0x04000012 RID: 18
		internal static string CurrentDllSHA1 = "3B85FC7EC65D4E26720516866E72B240598CEDCE";

		// Token: 0x04000013 RID: 19
		internal static string CurrentDllSHA256 = "B215110D42BDEC6069D1328E429C959F68C1BEE08333C4852BD3F5299B95173F";

		// Token: 0x04000014 RID: 20
		internal static string CurrentDllSize = "1741312";

		// Token: 0x04000015 RID: 21
		internal static string CurrentNewtonSoftMD5 = "F33CBE589B769956284868104686CC2D";

		// Token: 0x04000016 RID: 22
		internal static string CurrentNewtonSoftSHA1 = "2FB0BE100DE03680FC4309C9FA5A29E69397A980";

		// Token: 0x04000017 RID: 23
		internal static string CurrentNewtonSoftSHA256 = "973FD70CE48E5AC433A101B42871680C51E2FEBA2AEEC3D400DEA4115AF3A278";

		// Token: 0x04000018 RID: 24
		internal static string CurrentNewtonSoftSize = "653824";
	}
}
