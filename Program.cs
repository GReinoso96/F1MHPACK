using DATAbin;
using System;
using System.Reflection;

namespace MHPACK
{
	class Program
	{
		static void Main(string[] args)
		{
			ShowHelp();

			if (args == null || args.Length == 0)
			{
				return;
			}

			Console.ForegroundColor = ConsoleColor.White;

			if (args[0] == "-e")
			{
				try
				{
					DATA data = new DATA();

					if (args.Length == 3) data.ExtractDATA(args[1], args[2]);

					Console.WriteLine("\n\nOperation complete.");
				}
				catch (Exception e)
				{
					Console.WriteLine("\n\nError: " + e.Message);
				}
			}
			return;
		}

		static void ShowHelp()
		{

			Console.WriteLine("MHPACK -e <input_file> <output_dir> :  Extract DATA archive\n");
		}
	}
}