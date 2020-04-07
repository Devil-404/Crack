using System;
using System.Text;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Crack
{
    public class Common
    {
        /// <summary>
        /// 定义ide下拉框的值
        /// </summary>
        public static Dictionary<int, string> IdeName { get; } = new Dictionary<int, string>
        {
            {0, "IntelliJIdea" },
            {1, "PhpStorm" },
            {2, "WebStorm" },
            {3, "PyCharm" },
            {4, "Clion" }
        };

        /// <summary>
        /// ide下载地址，必须与ideName保持一致
        /// </summary>
        public static Dictionary<int, string> IdeUrl { get; } = new Dictionary<int, string>
        {
            {0, "https://download.jetbrains.8686c.com/idea/ideaIU-2019.3.4.exe" },
            {1, "https://download.jetbrains.8686c.com/webide/PhpStorm-2019.3.4.exe" },
            {2, "https://download.jetbrains.8686c.com/webstorm/WebStorm-2019.3.4.exe" },
            {3, "https://download.jetbrains.8686c.com/python/pycharm-professional-2019.3.4.exe" },
            {4, "https://download.jetbrains.8686c.com/cpp/CLion-2019.3.5.exe" }
        };

        /// <summary>
        /// 下载是否停止的状态
        /// </summary>
        public static bool StopDownLoad { get; set; } = true;
        public static int DownloadNum { get; set; } = 0;

        #region  判断是否联网
        [DllImport("winInet.dll")]
        private static extern bool InternetGetConnectedState(
        ref int dwFlag,
        int dwReserved
        );


        /// <summary>
        /// 判断是否联网
        /// </summary>
        /// <returns>true 是联网，false 是断网</returns>
        public static bool Networking()
        {
            try
            {
                Ping ping = new Ping();
                PingOptions poptions = new PingOptions();
                poptions.DontFragment = true;
                string data = string.Empty;
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                System.Int32 dwFlag = new int();
                if (!InternetGetConnectedState(ref dwFlag, 0))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("判断是否联网！" + ex.Message);
            }
        }

        public static void DialogNetworking(string Prompt)
        {
            MessageBox.Show(Prompt, "系统消息");
        }
        #endregion
    }
}
