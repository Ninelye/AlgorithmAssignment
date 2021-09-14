using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using GameFunction;
using scorekeeper;
using restartgame;
//The application has a known error of sometimes breaking without warning and I was not able to find a fix that works.
//It usually happens when inputting too quickly and gets stuck mid exectution.
namespace startgame
{
    public class chan
    {
		//Public Lists so they are usable in Stretch & Game Class
		public static List<string> name = new List<string>();
		public static List<int> date = new List<int>();
		public static List<int> startdate = new List<int>();
		public static List<int> enddate = new List<int>();
		public static bool o = true;
		
        public static void Main()
        {
			DateTime today = DateTime.Today;
			int tempo;
			int temp;
			
			//Reads the CSV file, fixes anomalies in the file, converts the numbers into intgers
			//Finally adds all the value to the respective lists in the format intended for use later
			var Lines = File.ReadLines("prelist.csv");
			foreach (string s in Lines)
			{
				string[] parts = s.Split(',');
				if (parts[3] == "Incumbent")
				{
					parts[3] = today.ToString("dd/MM/yyyy");
				}
				parts[3] = parts[3].Substring(parts[3].Length - 4);
				parts[4] = parts[4].Substring(parts[4].Length - 4);
				Int32.TryParse(parts[4], out temp);
				bool success = Int32.TryParse(parts[3], out tempo);
				if (success)
				{
					name.Add(parts[1]);
					date.Add(tempo);
					startdate.Add(tempo);
					enddate.Add(temp);
				}
				else
				{
					continue;
				}	
			}
			restarting.menubar();
		}
            
    }
}

