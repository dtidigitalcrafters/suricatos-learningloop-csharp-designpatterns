using System;

namespace BridgePattern
{
	public interface IDevice
    {
		string On();
		string Off();
    }

	class TV : IDevice
    {
		public string On()
        {
			return "TV: ON";
        }

		public string Off()
		{
			return "TV: OFF";
		}
	}

	class Light : IDevice
	{
		public string On()
		{
			return "Light: ON";
		}

		public string Off()
		{
			return "Light: OFF";
		}
	}


	public class Switch
	{
		protected IDevice _device;

		public Switch(IDevice _device)
		{
			this._device = _device;
		}


		public string On()
        {
			return _device.On();
        }

		public string Off()
		{
			return _device.Off();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			IDevice _device1 = new TV();
			IDevice _device2 = new Light();
			
			Switch _switch1 = new Switch(_device1);
			Console.WriteLine(_switch1.On());
			Console.WriteLine(_switch1.Off());
			Console.WriteLine();
			Switch _switch2 = new Switch(_device2);
			Console.WriteLine(_switch2.On());
			Console.WriteLine(_switch2.Off());
		}
	}


}
