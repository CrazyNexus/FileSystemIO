﻿//
// ViewController.cs
//
// Created by Thomas Dubiel on 22.12.2016
// Copyright 2016 Thomas Dubiel. All rights reserved.
//
using System;
using UIKit;
using System.IO;
using System.Threading.Tasks;
using System.Threading;


namespace FileIO
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void FileButton_TouchUpInside(UIButton sender)
		{
			var entries = Directory.EnumerateFiles("./");
			foreach (var item in entries)
			{
				Console.WriteLine(item);
			}
		}

		partial void ReadButton_TouchUpInside(UIButton sender)
		{
			var text = File.ReadAllLines("story.txt");
			foreach (var line in text)
			{
				Console.WriteLine(line);
			}

		}

		partial void WriteButton_TouchUpInside(UIButton sender)
		{
			var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			Console.WriteLine(documents);
			var filename = Path.Combine(documents, "newstory.txt");
			Console.WriteLine(filename);
			File.WriteAllText(filename, "This course is still awsome!");

			var dirname = Path.Combine(documents, "Stories");
			Directory.CreateDirectory(dirname);

			var dirExists = Directory.Exists(dirname);

		}

		partial void LogButton_TouchUpInside(UIButton sender)
		{
			Task.Factory.StartNew(() =>
			{
				var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "log.txt");

				if (!File.Exists(filePath))
					File.Create(filePath);

				for (var i = 0; i < 5; i++)
				{
					var time = DateTime.Now.ToShortTimeString();
					File.AppendAllText(filePath, time + " ** ");
					Thread.Sleep(1000);
				}

				Console.WriteLine(File.ReadAllText(filePath));
			});
		}
	}
}
