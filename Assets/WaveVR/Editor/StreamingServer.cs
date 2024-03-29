using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Diagnostics;
using System;

public class StreamingServer
{
	public static Process myProcess = new Process();

	[UnityEditor.MenuItem("WaveVR/DirectPreview/Start Streaming Server")]
	static void StartStreamingServerMenu()
	{
		StartStreamingServer();
	}

	[UnityEditor.MenuItem("WaveVR/DirectPreview/Stop Streaming Server")]
	static void StopStreamingServerMenu()
	{
		StopStreamingServer();
	}

	// Launch rrServer
	public static void StartStreamingServer()
	{
		try
		{
			UnityEngine.Debug.Log("StartStreamingServer");
			//Get the path of the Game data folder
			myProcess.StartInfo.FileName = "C:\\Windows\\system32\\cmd.exe";
			myProcess.StartInfo.Arguments = "/c cd Assets\\WaveVR\\Platform\\Windows && dpServer";
			myProcess.Start();
		}
		catch (Exception e)
		{
			UnityEngine.Debug.LogError(e);
		}
	}
	// Stop rrServer
	public static void StopStreamingServer()
	{
		try
		{
			UnityEngine.Debug.Log("Stop Streaming Server.");
			myProcess.StartInfo.FileName = "C:\\Windows\\system32\\cmd.exe";
			myProcess.StartInfo.Arguments = "/c taskkill /F /IM dpServer.exe";
			myProcess.Start();	
		}
		catch (Exception e)
		{
			UnityEngine.Debug.LogError(e);
		}
	}
}
