#region License
// 
// Copyright (c) 2007-2009, Sean Chambers <schambers80@gmail.com>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using System;
using System.IO;

namespace FluentMigrator.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				string [] myArgs = new string[6];
				myArgs[0] = "/connection";
				myArgs[1] =@"Data Source=C:\Projects\chrispfarrell-com\src\chrispfarrell.Web.MVC3\App_Data\fluentTest.sqlite;Version=3";

				myArgs[2] = "/db";
				myArgs[3] = "sqlite";

				myArgs[4] = "/target";
				myArgs[5] = @"C:\Projects\chrispfarrell-com\src\chrispfarrell.Database\bin\Debug\chrispfarrell.Database.dll";

				new MigratorConsole(myArgs);
				//new MigratorConsole(args);
			}
			catch (ArgumentException ex)
			{
				System.Console.WriteLine(ex.Message);
			}
		}
	}
}