using System;
using System.Globalization;
using Newspaper;

namespace Newspaper
{
	public class Parser
	{

		static Random random = new Random();

		//text that should be detected automatically
		//or stored in a config file

		public static string[] districts = {"Poplar Hills", "Hemlock Hills"};

		public static string cityName = "Sunshine Town";
		static string mayorpossess;
		static string mayorname;

		public static readonly string configPath = "NewspaperConfig.xml";
		public Configuration config;


		//bound strings to refer to them multiple times in the same story
		string[] boundNouns = new string[3];
		string[] boundVerbs = new string[3];
		string[] boundAdjs = new string[3];
		string[] boundEmotions = new string[3];
		string[] boundProfessions = new string[3];
		string[] boundAdverbs = new string[3];
		string[] boundExclamations = new string[3];
		string[] boundTitles = new string[3];
		string[] boundFirstNames = new string[3];
		string[] boundLastNames = new string[3];
		string[] boundCities = new string[3];
		string[] boundPlaces = new string[3];
		string[] boundSaidTypes = new string[3];
		string[] boundBodyParts = new string[13];
		string[] boundDiseases = new string[10];
		string[] boundAnimals = new string[10];
		string[] boundRoad = new string[3];


		//parse this string
		public string parse(string s)
		{
			string returnString = "";
			for (int i = 0; i < s.Length; i++)
			{

				char c = s [i];

				//start parsing tokens at a < character
				if (c == '<')
				{
					returnString += parseToken(s, i);
					while (c != '>')
					{
						c = s[i];
						i++;
					}
					i--;

				}
				else
				{
					returnString += c;
				}

			}
			return returnString;
		}

		//parse the token, starting at the start position
		string parseToken(string s, int start)
		{
			string token = "";


			//append to the token, until a > is reached
			for (int i=start + 1; i < s.Length; i++)
			{
				char c = s[i];

				if (c == '>')
				{
					break;

				}
				else
				{
					token += c;
				}
			}

			//split the token based on -
			char[] splitchar = { '-' };
			string[] tokens = token.Split(splitchar);

			//the type of the token is first
			string type = tokens[0];
			if (type == "CITYNAME")
			{
				return cityName;
			}


			//the num is for binding of the word
			string num = "";

			if (tokens.Length > 1) {
				num = tokens [1];
			}

			//the boundArr is the array to put the word in
			//the sourceArr is where the word comes from

			//TODO: Clean this up
			string[] boundArr = null;
			string[] sourceArr = null;


			if (type == "NOUN")
			{
				boundArr = boundNouns;
				sourceArr = Data.nouns;
			}
			else if (type == "VERB")
			{
				boundArr = boundVerbs;
				sourceArr = Data.verbs;
			}
			else if (type == "ADJECTIVE")
			{
				boundArr = boundAdjs;
				sourceArr = Data.adjectives;
			}
			else if (type == "EMOTION")
			{
				boundArr = boundEmotions;
				sourceArr = Data.emotions;
			}
			else if (type == "PROFESSION")
			{
				boundArr = boundProfessions;
				sourceArr = Data.professions;
			}
			else if (type == "ADVERB")
			{
				boundArr = boundAdverbs;
				sourceArr = Data.adverbs;
			}
			else if (type == "EXCLAM")
			{
				boundArr = boundExclamations;
				sourceArr = Data.exclamations;
			}
			else if (type == "TITLE")
			{
				boundArr = boundTitles;
				sourceArr = Data.titles;
			}
			else if (type == "FIRSTNAME")
			{
				boundArr = boundFirstNames;
				sourceArr = Data.firstNames;
			}
			else if (type == "LASTNAME")
			{
				boundArr = boundLastNames;
				sourceArr = Data.lastNames;
			}
			else if (type == "CITY")
			{
				boundArr = boundCities;
				sourceArr = Data.cities;
			}
			else if (type == "COUNTRY")
			{
				boundArr = boundPlaces;
				sourceArr = Data.places;
			}
			else if (type == "SAID")
			{
				boundArr = boundSaidTypes;
				sourceArr = Data.saidTypes;
			}
			else if (type == "BODYPART")
			{
				boundArr = boundBodyParts;
				sourceArr = Data.bodyParts;
			}
			else if (type == "DISEASE")
			{
				boundArr = boundDiseases;
				sourceArr = Data.diseases;
			}
			else if (type == "DISTRICT")
			{
				sourceArr = districts;
			}
			else if (type == "BAD")
			{
				sourceArr = Data.badTerms;
			}
			else if (type == "LARGE")
			{
				sourceArr = Data.largeTerms;
			}
			else if (type == "CITIZEN")
			{
				sourceArr = Data.citizenTerms;
			}
			else if (type == "REGION")
			{
				sourceArr = Data.regionTerms;
			}
			else if (type == "ROAD")
			{
				boundArr = boundRoad;
				sourceArr = Data.roadTerms;
			}
			else if (type == "ANIMAL")
			{
				boundArr = boundAnimals;
				sourceArr = Data.animals;
			}
			else if (type == "INT")
			{
				return "" + random.Next(1, 20);
			}
			else if (type == "MAYORPOSSESS")
			{
				return mayorpossess;
			}
			else if (type == "MAYORNAME")
			{
				return mayorname;
			}
			else if (type == "MOVE")
			{
				sourceArr = Data.moveTerms;
			}
			else if (type == "WEATHER")
			{
				sourceArr = Data.weather;
			}

			else
			{
				print("Type unknown: " + type);
				print(tokens.ToString());
				print(s);
				boundArr = null;
				sourceArr = null;
			}

			//If there is no number, or it is X,
			//don't bother binding
			if (num == "" || num == "X")
			{
				int randomNumber = random.Next(0, sourceArr.Length);
				token = sourceArr[randomNumber];
			}
			else
			{
				//bind this variable to this
				//position in the array
				int intNum = Int32.Parse(num);

				if (boundArr[intNum] == null)
				{
					int randomNumber = random.Next(0, sourceArr.Length);
					boundArr[intNum] = sourceArr[randomNumber];
				}           
				token = boundArr[intNum];

			}

			//the last tokens are for special operations
			for (int i = 2; i < tokens.Length; i++) {
				string op = tokens [i];

				//capitalizes all words in the word
				if (op == "CAP") {
					CultureInfo cultureInfo = CultureInfo.InvariantCulture;

					TextInfo textInfo = cultureInfo.TextInfo;

					token = textInfo.ToTitleCase (token);
				}

				//add an indefinite article
				//a or an
				else if (op == "INDEF")
							{
					bool foundVowel = false;
					char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
					for (int j = 0; j < vowels.Length; j++)
					{
						if (token[0] == vowels[j])
						{
							token = "an " + token;
							foundVowel = true;
						}
					}

					if (!foundVowel)
						token = "a " + token;
				}

				//make the word plural
				//this could be smarter
				else if (op == "PLURAL")
				{
					if (token == "child")
						token += "ren";
					else if (token == "potato")
						token = "potatoes";
					else if (token == "cactus")
						token = "catcuses";
					else if (token.EndsWith ("s"))
						token = token.Remove (token.Length - 1) + "es";
					else
						token += "s";
				}

				//change the verb to be in the past
				//walked, bought, changed, etc.
				else if (op == "PAST")
				{
					if (token.ToLower () == "spot")
						token += "t";
					else if (token.ToLower () == "buy")
						return "bought";
					else if (token.ToLower () == "throw")
						return "threw";
					else if (token.ToLower() == "run")
						return "ran";
					else if (token.ToLower() == "eat")
						return "ate";
					else if (token.ToLower() == "bite")
						return "bit";
					else if (token.ToLower() == "sell")
						return "sold";
					else if (token.EndsWith ("e"))
						token = token.Remove (token.Length - 1);
					else if (token.EndsWith ("y")) {
						token = token.Remove (token.Length - 1);
						token += "i";
					}
					token += "ed";
				}

				//change the verb to be progressive
				//running, cooking, throwing, etc.
				else if (op == "ING")
				{
					if (token.ToLower() == "spot")
						token += "t";
					else if (token.ToLower() == "run")
						return "running";
					else if (token.EndsWith("e"))
						token = token.Remove(token.Length-1);
					token += "ing";
				}

				//change the verb to be in the present
				//runs, cooks, throws, etc.
				else if (op == "PRESENT")
				{
					if (token.EndsWith("s"))
						token += "e";
					else if (token.EndsWith("y"))
					{
						token = token.Remove(token.Length-1);
						return token + "ies";
					}
					
					token += "s";
				}
				else
				{
					//TODO: Make this an exception
					print("Unknown op: " + op);
				}
			}


			return token;
		}

		void print(string s)
		{
			Console.WriteLine (s);
		}


		public Parser()
		{
			config = Configuration.Deserialize(configPath);
			if (config == null) {
				mayorpossess = "his";
				mayorname = "McMayor";
				config = new Configuration ();
			} else {
				mayorpossess = config.mayorpossess;
				mayorname = config.mayorname;
			}

			Configuration.Serialize(configPath, config);
		}
	}
}

