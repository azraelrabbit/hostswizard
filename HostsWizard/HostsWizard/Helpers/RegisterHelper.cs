using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration.Internal;
using Microsoft.Win32;

namespace HostsWizard.Helpers
{
    public class RegisterHelper
    {
        const string RegMainPath = "Software/Microsoft/Windows/CurrentVersion/Internet Settings/";

        const string DnsCacheEnabled = "DnsCacheEnabled";
        const string DnsCacheTimeout = "DnsCacheTimeout";
        const string ServerInfoTimeOut = "ServerInfoTimeOut";

        /// <summary>
        /// 禁用系统dns缓存,不关闭浏览器立即生效
        /// </summary>
        public static void DisableDnsCache()
        {
            SetRegKeyValue(DnsCacheEnabled, "00000000", RegistryValueKind.DWord);
            SetRegKeyValue(DnsCacheTimeout, "00000000", RegistryValueKind.DWord);
            SetRegKeyValue(ServerInfoTimeOut, "00000000", RegistryValueKind.DWord);
        }

        /// <summary>
        /// 启用系统Dns缓存
        /// </summary>
        public static void EnableDnsCache()
        {
            SetRegKeyValue(DnsCacheEnabled, "-", RegistryValueKind.Unknown);
            SetRegKeyValue(DnsCacheTimeout, "-", RegistryValueKind.Unknown);
            SetRegKeyValue(ServerInfoTimeOut, "-", RegistryValueKind.Unknown);
        }


        private static void SetRegKeyValue(string Key, object value, RegistryValueKind vkind)
        {
            var reg = Registry.CurrentUser.OpenSubKey(RegMainPath);
            if (reg == null)
            {
                reg = Registry.CurrentUser.CreateSubKey(RegMainPath);
            }

            reg.SetValue(Key, value, vkind);
            reg.Close();
        }


        //检查某一项是否存在某一项
        public bool CheckExistSubkey(string keyStr)
        {
            try
            {
                RegistryKey root = Registry.LocalMachine.OpenSubKey(RegMainPath, false);

                string[] keyName = null;
                //这是获取该路径下的 值对应的名称 
                keyName = root.GetValueNames();
                //获取所有的子项名称的 subKeyName 
                // keyName = root.GetSubKeyNames();
                for (int i = 0; i < keyName.Length; i++)
                {
                    if (keyName[i] == keyStr)
                    {
                        root.Close();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }



    }
}
