﻿using System;

namespace JiraVersionUpdater
{
	internal class JiraOptions : IJiraOptions
	{
		public string JiraUri { get; set; }

		public string Password { get; set; }

		public string UserName { get; set; }

		public string FixVersionStr { get; set; }

		public Version FixVersion => Version.Parse(FixVersionStr);

		public string AvailableFromVersionStr { get; set; }

        public Version AvailableFromVersion => Version.Parse(AvailableFromVersionStr);

        public string ProjectKey { get; set; }

		public string CustomFieldName { get; set; }
	}
}