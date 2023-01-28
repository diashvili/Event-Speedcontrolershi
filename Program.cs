using BMW;

M5 m5 = new();

while (true)
{
	var key = Console.ReadKey(true).Key;
	switch (key)
	{
		case ConsoleKey.UpArrow:
			m5.Accelerate(20);
			break;
		case ConsoleKey.DownArrow:
			m5.Accelerate(-20);
			break;
		case ConsoleKey.Escape:
			return;
	}
}

//1. დაადეთ დაცვა რომ არ გადავიდეს სიჩქარე მინუსებში. 
//2. დაამატეთ საშუალება, რომ სიჩქარის გადაჭარბების დროს ასევე ეკრანზე დაწეროს რამდენით გადააჭარბე სიჩქარეს,
//   ეს უნდა უზრუნველყოს თვითონ დელეგატმა და მნიშვნელობა გადაეცეს ჩვენი კლასიდან გარეთ.