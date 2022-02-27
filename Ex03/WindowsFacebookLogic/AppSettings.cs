﻿using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFacebookLogic
{
    public sealed class AppSettings
    {
        private const string k_AppSettignsFileName = "AppSettings.xml";
        private static AppSettings m_AppSettings;
        private Point m_LastWindowLocation;
        private Size m_LastWindowSize;
        private bool m_RememberUser;
        private string m_LastAccessToken;

        private AppSettings()
        {
            this.m_LastWindowLocation = new Point(200, 200);
            this.m_LastWindowSize = new Size(1450, 700);
            this.m_RememberUser = false;
            this.m_LastAccessToken = null;
        }

        public static AppSettings LoadFromFile()
        {
            m_AppSettings = new AppSettings();
            if (File.Exists(k_AppSettignsFileName))
            {
                using (Stream stream = new FileStream(k_AppSettignsFileName, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    m_AppSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return m_AppSettings;
        }

        public Point LastWindowLocation
        {
            get
            {
                return m_LastWindowLocation;
            }

            set
            {
                m_LastWindowLocation = value;
            }
        }

        public Size LastWindowSize
        {
            get
            {
                return m_LastWindowSize;
            }

            set
            {
                m_LastWindowSize = value;
            }
        }

        public bool RememberUser
        {
            get
            {
                return m_RememberUser;
            }

            set
            {
                m_RememberUser = value;
            }
        }

        public string LastAccessToken
        {
            get
            {
                return m_LastAccessToken;
            }

            set
            {
                m_LastAccessToken = value;
            }
        }

        public static AppSettings AppSettingsInstance()
        {
            return m_AppSettings;
        }

        public void SaveToFile()
        {
            Stream stream;

            if (File.Exists(k_AppSettignsFileName))
            {
                stream = new FileStream(k_AppSettignsFileName, FileMode.Truncate);
            }
            else
            {
                stream = new FileStream(k_AppSettignsFileName, FileMode.Create);
            }

            using (stream)
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}