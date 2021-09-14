using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {

XmlReader reader = XmlReader.Create("https://www.nationalbanken.dk/_vti_bin/DN/DataService.svc/CurrencyRatesXML?lang=da");

	Console.WriteLine("Choose a value and a currency and see how much it is in DKK");

	Console.WriteLine("Input value:");
	
	string inputVal = Console.ReadLine();
	
	Console.WriteLine("\nCalculating: " + inputVal + "_");

XmlReader codeReader = XmlReader.Create("https://www.nationalbanken.dk/_vti_bin/DN/DataService.svc/CurrencyRatesXML?lang=da");

	while (codeReader.Read())
	{
		if ((codeReader.NodeType == XmlNodeType.Element) && (codeReader.Name == "currency"))
		{
			if (codeReader.HasAttributes)
			{
				Console.Write(codeReader.GetAttribute("code") + "  ");
			}
		}
	}

	Console.WriteLine("\nInput a currency code: ");
	
	string inputCode = Console.ReadLine();
	
	inputCode = inputCode.ToUpper();

	while (reader.Read())
	{
		if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "currency"))
		{
			if ((reader.HasAttributes) && reader.GetAttribute("code").Equals(inputCode))
			{
				Console.WriteLine("\nCode: " + reader.GetAttribute("code") + "\nCurrency: " + reader.GetAttribute("desc"));
				var valuta = Convert.ToDouble(reader.GetAttribute("rate")) / 100;
				var inputDKK = Convert.ToDouble(inputVal);
				Console.Write(inputVal + " " + reader.GetAttribute("code")+ " = " + valuta * inputDKK + " DKK");
			}
		}
	}

}
}
}