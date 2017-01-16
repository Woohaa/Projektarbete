using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete
{
	public class Manager
	{
		public bool Coca()
		{
			bool isCoca = false;

			for (int i = 1; i < 101; i++)
			{
				if (i % 3 == 0)
				{
					Console.WriteLine(i + " " + "Coca");
					isCoca = true;			
				}
				else
				{
					Console.WriteLine(i);					
				}				
			}

			return isCoca;
		}

		public bool Cola()
		{
			bool isCola = false;

			for (int i = 1; i < 101; i++)
			{
				if (i % 5 == 0)
				{
					Console.WriteLine(i + " " + "Cola");
					isCola = true;
				}
				else
				{
					Console.WriteLine(i);
				}
			}

			return isCola;
		}

		public bool CocaCola()
		{
			bool isCocaCola = false;

			for (int i = 1; i < 101; i++)
			{
				if(i % 3 == 0 && i % 5 == 0)
				{
					Console.WriteLine(i + " " + "CocaCola");
					isCocaCola = true;
				}
				else
				{
					Console.WriteLine(i);
				}
			}

			return isCocaCola;
		}

		public int ShowAllDividableNumbers()
		{
			int result = 0;

			for (int i = 1; i < 101; i++)
			{
				if (i % 3 == 0)
				{
					Console.WriteLine(i + " " + "Coca");
					result++;
				}
				if (i % 5 == 0)
				{
					Console.WriteLine(i + " " + "Cola");
					result++;
				}
				if (i % 3 == 0 && i % 5 == 0)
				{
					Console.WriteLine(i + " " + "CocaCola");
					result++;
				}
				else
				{
					Console.WriteLine(i);
				}
			}

			return result;
		}

	}
}
