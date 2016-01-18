﻿using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LaptopOrchestra.Kinect
{
	public class Constants
	{
		public const int SessionRecvConfigInterval = 5000;
		public const string OscDistanceAddr = "/kinect/distance/{0}/{1}";
		public const string OscVectorAddr = "/kinect/vector/{0}/{1}";
		public const string OscJointAddr = "/kinect/joint/{0}";
		public const string OscHandStateAddr = "/kinect/handstate";
		public const char CharTrue = '1';
		public const char CharFalse = '0';
	    public static int MaxSessionRetries = 2;
		public static readonly Color HandClosedBrush = Color.FromArgb(128, 255, 0, 0);
		public static readonly Color HandOpenBrush = Color.FromArgb(128, 0, 255, 0);
		public static readonly Color HandLassoBrush = Color.FromArgb(128, 0, 0, 255);
		public static readonly Color TrackedJointColor = Colors.ForestGreen;
		public static readonly Color UntrackedJointColor = Colors.LightSalmon;
        public static readonly Color InferredJointColor = Color.FromArgb(255, 255, 255, 0);
		public static readonly Color TrackedBoneColor = Color.FromArgb(255, 255, 0, 0);
		public static readonly Color InferredBoneColor = Color.FromArgb(255, 60, 60, 60);
		public static readonly Color UntrackedBodyColor = Colors.LightGray;
    }
}
