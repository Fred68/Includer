
/////////////////////////////////////////////////
///
///		Includer
///
/////////////////////////////////////////////////


//	 
//	Finds and replaces comments, containg identified and a filename, with the file name content
//	
//	Example:
//	
//	File: prova.cs
//		public /* #FILE pippo.txt */ /* extra text */
//	
//	File: pippo.txt
//		enum X
//			{
//			xx=1,
//			yy=2
//			};
//	Command:	
//		includer prova.cs .2 #FILE
//
//	Output file: prova.2.cs
//		public enum X
//			{
//			xx=1,
//			yy=2
//			};/* extra text */

/*
includer
includer	[help]
includer	[origin]	
includer	[origin]	[ext]
includer	[origin]	[ext]	[ID]

[help]		help		Show help
			?			Show help

[origin]	path\filename		filename with path
			filename			filename in the includer.exe folder
			*.yyy				all files with extension yyy
			path\*.yyy			all files with extension yyy in the path
			no arg				[default] all .cs file in the includer.exe folder

[ext]		XYZ					text added before file.extension. i.e.	filename.cs -> filenameXYZ.cs
			no arg				[default]	.1

[ID]		id					string searched in C# comments 
			no arg				[default]	#INCLUDE

*/



namespace Includer
	{
	internal class Program
		{
		static void Main(string[] args)
			{
			Console.WriteLine($"Hello, World [{args.Length}]!");
			for(int i=0; i<args.Length; i++)
				{
				Console.WriteLine(args[i]);
				}
			}
		}
	}