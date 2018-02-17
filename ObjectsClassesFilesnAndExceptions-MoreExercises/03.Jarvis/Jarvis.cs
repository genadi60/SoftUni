using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class Jarvis
{
	class Head
	{
		public int EnergyConsumption { get; set; }
		public int IQ { get; set; }
		public string SkinMaterial { get; set; }
	}
	class Torso
	{
		public int EnergyConsumption { get; set; }
		public double ProcessorSize { get; set; }
		public string HousingMaterial { get; set; }
	}
	class Leg
	{
		public int EnergyConsumption { get; set; }
		public int Strength { get; set; }
		public int Speed { get; set; }
	}
	class Arm
	{
		public int EnergyConsumption { get; set; }
		public int ReachDistance { get; set; }
		public int Fingers { get; set; }
	}
	public static void Main()
	{
		var headList = new List<Head>();
		var torsoList = new List<Torso>();
		var legList = new List<Leg>();
		var armList = new List<Arm>();
		
		var energyCapacity = BigInteger.Parse(Console.ReadLine());
		while (true)
		{
			var line = Console.ReadLine();
			if (line.Equals("Assemble!"))
			{
				break;
			}
			var robotComponents = line
				.Split()
				.ToArray();
			var typeOfComponent = robotComponents[0];
			var energyConsumption = int.Parse(robotComponents[1]);
			var property1 = robotComponents[2];
			var property2 = robotComponents[3];
			if (typeOfComponent.Equals("Head"))
			{
				var head = new Head();
				var energy = energyConsumption;
				var headIQ = int.Parse(property1);
				var material = property2;
				head.EnergyConsumption = energy;
				head.IQ = headIQ;
				head.SkinMaterial = material;
				if (headList.Count == 0 )
				{
					energyCapacity -= head.EnergyConsumption;
					headList.Add(head);
				}
				else
				{
					foreach (var h in headList)
					{
						if (h.EnergyConsumption >= head.EnergyConsumption)
						{
							energyCapacity += (h.EnergyConsumption - head.EnergyConsumption);
							headList.Insert(0, head);
							headList.RemoveAt(headList.Count - 1);
							break;
						}
					}
				}
			}
			else if (typeOfComponent.Equals("Torso"))
			{
				var torso = new Torso();
				var energy = energyConsumption;
				var size = double.Parse(property1);
				var material = property2;
				torso.EnergyConsumption = energy;
				torso.ProcessorSize = size;
				torso.HousingMaterial = material;
				if (torsoList.Count == 0)
				{
					energyCapacity -= torso.EnergyConsumption;
					torsoList.Add(torso);
				}
				else
				{
					foreach (var t in torsoList)
					{
						if (t.EnergyConsumption >= torso.EnergyConsumption)
						{
							energyCapacity += (t.EnergyConsumption - torso.EnergyConsumption);
							torsoList.Insert(0, torso);
							torsoList.RemoveAt(torsoList.Count - 1);
							break;
						}
					}
				}
			}
			else if (typeOfComponent.Equals("Leg"))
			{
				var leg = new Leg();
				var energy = energyConsumption;
				var strength = int.Parse(property1);
				var speed = int.Parse(property2);
				leg.EnergyConsumption = energy;
				leg.Strength = strength;
				leg.Speed = speed;
				if (legList.Count < 2)
				{
					energyCapacity -= leg.EnergyConsumption;
					if (legList.Count > 0)
					{
						legList.Insert(0, leg);
					}
					else
					{
						legList.Add(leg);
					}
					legList = legList
						.OrderBy(x => x.EnergyConsumption)
						.ToList();
				}
				else
				{
					foreach (var l in legList)
					{
						if (l.EnergyConsumption >= leg.EnergyConsumption)
						{
							energyCapacity += legList[1].EnergyConsumption - leg.EnergyConsumption;
							legList.Insert(legList.IndexOf(l), leg);
							legList.RemoveAt(legList.Count -1);
							break;
						}
					}
				}
			}
			else
			{
				var arm = new Arm();
				var energy = energyConsumption;
				var distance = int.Parse(property1);
				var fingers = int.Parse(property2);
				arm.EnergyConsumption = energy;
				arm.ReachDistance = distance;
				arm.Fingers = fingers;
				if (armList.Count < 2)
				{
					energyCapacity -= arm.EnergyConsumption;
					if (armList.Count > 0)
					{
						armList.Insert(0, arm);
					}
					else
					{
						armList.Add(arm);
					}
					
					armList = armList
						.OrderBy(x => x.EnergyConsumption)
						.ToList();
				}
				else
				{
					foreach (var a in armList)
					{
						if (a.EnergyConsumption >= arm.EnergyConsumption)
						{
							energyCapacity += (armList[1].EnergyConsumption - arm.EnergyConsumption);
							armList.Insert(armList.IndexOf(a), arm);
							armList.RemoveAt(armList.Count - 1);
							break;
						}
					}
				}
			}
		}
		if (headList.Count < 1 || torsoList.Count < 1 || legList.Count < 2 || armList.Count < 2)
		{
			Console.WriteLine("We need more parts!");
			return;
		}
		else if (energyCapacity < 0)
		{
			Console.WriteLine("We need more power!");
			return;
		}
		else
		{
			Console.WriteLine("Jarvis:");
			foreach (var h in headList)
			{
				Console.WriteLine("#Head:");
				Console.WriteLine($"###Energy consumption: {h.EnergyConsumption}");
				Console.WriteLine($"###IQ: {h.IQ}");
				Console.WriteLine($"###Skin material: {h.SkinMaterial}");
			}
			foreach (var t in torsoList)
			{
				Console.WriteLine("#Torso:");
				Console.WriteLine($"###Energy consumption: {t.EnergyConsumption}");
				Console.WriteLine($"###Processor size: {t.ProcessorSize:F1}");
				Console.WriteLine($"###Corpus material: {t.HousingMaterial}");
			}
			foreach (var a in armList)
			{
				Console.WriteLine("#Arm:");
				Console.WriteLine($"###Energy consumption: {a.EnergyConsumption}");
				Console.WriteLine($"###Reach: {a.ReachDistance}");
				Console.WriteLine($"###Fingers: {a.Fingers}");
			}
			foreach (var l in legList)
			{
				Console.WriteLine("#Leg:");
				Console.WriteLine($"###Energy consumption: {l.EnergyConsumption}");
				Console.WriteLine($"###Strength: {l.Strength}");
				Console.WriteLine($"###Speed: {l.Speed}");
			}
		}
	}
}