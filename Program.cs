/*
 * Created by SharpDevelop.
 * User: adam.moseman
 * Date: 11/30/2018
 * Time: 1:05 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace cylinderareabottomless
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			GunList art = new GunList();
			
			art.AddGun("Great",20,26);
			art.AddGun("Mortar",15,17);
			art.AddGun("Helstorm",23,19);
			art.AddGun("Helblaster",20,18);
			art.AddGun("Luminark",18,14);
			art.AddGun("Tank", 30,40);
			
			art.AddGun("Boltthrower",18,21);
			art.AddGun("Cannon",18,21);
			art.AddGun("OrganGun",16,19);
			art.AddGun("FlameCannon",16,21);
			art.AddGun("GrudgeThrow",28,21);
			
			art.AddGun("Carronade",20,26);
			art.AddGun("Mortar",17,15);
			art.AddGun("Bess",54,36);
			
			art.AddGun("Plagueclaw",55,30);
			art.AddGun("WLC", 45,35);
			
			art.AddGun("Hellcannon",54,36);
			
			art.AddGun("ElfBolt", 18,15);
			
			art.AddGun("Trebuchet",38,30);
			
			art.AddGun("ScrmngCtplt",20,26);
			art.AddGun("CasketSouls",17,22);
			
			art.AddGun("Doomdivers",21,21);
			art.AddGun("RockLobbaz",28,21);
			
			art.PrintGuns();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	public class GunList
	{
		List<Tuple<string,int,int>> Guns;
		public GunList()
		{
			Guns = new List<Tuple<string, int, int>>();
		}
		
		private int GunArea(int height, int radius)
		{
			double H = (double)height;
			double R = (double)radius;
			
			double Area = Math.PI * R * H * 2.0 + R*R*Math.PI;
			Area = Math.Round(Area);
			return (int)Area;
		}
		
		public void PrintGuns()
		{
			for(int i=0;i<Guns.Count;i++)
			{
				Console.WriteLine(string.Format("{0} : {1}/{2} : {3} : {4}",
				                                Guns[i].Item1, 
				                                Guns[i].Item2, 
				                                Guns[i].Item3, 
				                                GunArea(Guns[i].Item2, Guns[i].Item3),
				                                Guns[i].Item2*Guns[i].Item3*2));
			}
		}
		
		public void AddGun(string gunName, int gunHeight, int gunRadius)
		{
			Guns.Add(new Tuple<string,int,int>(gunName, gunHeight, gunRadius));
		}
	}
}