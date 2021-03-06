﻿using Newtonsoft.Json;
using PittGo.Classes;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PittGo
{
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        private const string UserJson = "";
        private static readonly string UserJsonDefault = "";
        public static User UserData
        {
            get
            {
                string data = AppSettings.GetValueOrDefault(UserJson, UserJsonDefault);
                if (String.IsNullOrEmpty(data))
                {
                    return null;
                }
                else
                {
                    return JsonConvert.DeserializeObject<User>(data);
                }
            }
            set
            {

                string data = JsonConvert.SerializeObject(value);
                AppSettings.AddOrUpdateValue(UserJson, data);
            }

        }
    }
}
