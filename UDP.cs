﻿using System;
using System.Net;
using Rug.Osc;

public static class UDP
{
	private static int _connectPort;
	private static IPAddress _userIP;
	private static OscSender _sender;

	public static void StartDataOut()
	{
		try
		{
			_sender = new OscSender(_userIP, _connectPort);
			_sender.Connect();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.ToString());
		}
	}

	public static void StopDataOut()
	{
		_sender.Close();
	}

	public static void ConfigureIpAndPort(string ip, int port)
	{
		if(_sender != null)
		{
			StopDataOut();
		}
		_connectPort = port;
		_userIP = IPAddress.Parse(ip);
		StartDataOut();
	}

	public static void SendMessage(OscMessage message)
	{
		_sender.Send(message);
	}
}
