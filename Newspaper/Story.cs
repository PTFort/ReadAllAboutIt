using System;
using Newspaper;
using System.Collections;

namespace Newspaper
{
	public class Story
	{
        public static Random random = new Random();

        public string headline;
        public string reporter;
        public string text;

		public string poll;
		public string qotd;

		public string weather;
		public string otherArticle1;
		public string otherArticle2;

		public string moneyString;
        Parser p;

        public Story()
        {
            p = new Parser();

            string t = "";

			//get a template from the story bank
            int index = random.Next(Data.templates.Length);
            t += Data.templates[index];

			//get the number of the fragments
            int numFragments = random.Next(3);

			//add fragments, but don't repeat them
            ArrayList fragsSelected = new ArrayList();

            for (int i = 0; i < numFragments; i++)
            {
                int frag = random.Next(Data.fragments.Length);
                if (!fragsSelected.Contains(frag))
                {
                    fragsSelected.Add(frag);
                    t += "\n\n" + Data.fragments[frag];
                }
            }

			//parse the whole story
			string parsedString;

			try
			{
				parsedString = p.parse (t);
			}
			catch(Exception) {
				parsedString = t + "\nError parsing.";
			}

			//the headline is everything before the equals sign
            char[] delim = new char[] { '=' };
            string[] sArr = parsedString.Split(delim);

			//assign the pieces
            headline = sArr[0];
            text = sArr[1];
            reporter = "Written by: " + Data.reporters[random.Next(Data.reporters.Length)];

			poll = p.parse(Data.polls[random.Next(Data.polls.Length)]);
			qotd = p.parse(Data.qotds[random.Next(Data.qotds.Length)]);

			weather = Data.weather [random.Next (Data.weather.Length)];
			otherArticle1 = getOtherArticle ();
			otherArticle2 = getOtherArticle ();

			moneyString = random.Next(5) + 2 + " " + Data.money[random.Next(Data.money.Length)];
        }


		public string getOtherArticle()
		{
			string oa = "";

			try{
				oa = Data.otherArticles [random.Next (Data.otherArticles.Length)];
				return p.parse(oa);
			}
			catch(Exception e) {
				return e.Message + oa;
			}
		}

		//print all the templates and all the fragments to test the parsing
        public string testAll()
        {
            string t = "";
            for (int i = 0; i < Data.templates.Length; i++)
            {
                string s = p.parse(Data.templates[i]);
                print(s + "\n\n");
            }

            for (int i = 0; i < Data.fragments.Length; i++)
            {
                string s = p.parse(Data.fragments[i]);
                print(s + "\n\n");
            }
            return t;
        }

		public static void Main (string[] args)
		{
            
			Story s = new Story ();
			s.testAll ();
		}

        static void print(string s)
        {
            Console.WriteLine (s);
        }
	}
}
