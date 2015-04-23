using System;
using Newspaper;
namespace Newspaper
{
    public class Data
    {
        

        //the stories
        public static string[] templates = new string[]
        {
            "<PROFESSION-0-CAP> <VERB-0-PRESENT-CAP> <NOUN-0-CAP> = In the court of Judge <LASTNAME>, the <PROFESSION-0> <FIRSTNAME> <LASTNAME> could face a sentence of <INT> years on the charge of <VERB-0-ING> <NOUN-0-INDEF>. The defence has entered no plea yet. The trial is expected to last <INT> weeks, as the prosecution is having difficulty finding experts on <VERB-0-ING> <NOUN-0-PLURAL>. Laws in the <REGION> are unclear on the issue, but <CITIZEN-X-PLURAL> are clamoring for the death penalty.",
            "<NOUN-0-CAP> <VERB-0-CAP-PAST> by <PROFESSION-0-CAP-PLURAL> = In <ADJECTIVE-X-INDEF> incident, <NOUN-0-INDEF> was <VERB-0-PAST> by a group of <ADJECTIVE> <PROFESSION-0-PLURAL>. Local <CITYNAME> authorities are concerned that many <NOUN-0-PLURAL> could be <VERB-0-PAST> in the future, so <CITIZEN-X-PLURAL> are being told to lock up their <NOUN-0-PLURAL>. The owner of the <NOUN-0>, <FIRSTNAME> <LASTNAME>, <SAID> \"I hope that the authorities nab these <PROFESSION-0-PLURAL>. They are <LARGE-X-INDEF> danger. Personally, I blame <PROFESSION-X-PLURAL> for this\".",
            "Escape From <LASTNAME-0> Research Facility = Late last night, an alarm was raised at the <LASTNAME-0> research facility as a <LARGE> <ANIMAL-0> escaped. Local <CITYNAME> police scrambled in order to detain the <ADJECTIVE> <ANIMAL-0>. When the <ANIMAL-0> stopped <MOVE-X-ING> <ADVERB>, and <VERB-X-PAST>, police were able to <MOVE> <ADVERB> and capture the <ADJECTIVE> <ANIMAL-0>. Authorities suspect that a group of animal-right activists <ADVERB> broken into the facility.",
             "Masses of <ANIMAL-0-PLURAL-CAP> = <LASTNAME> <ROAD-0-CAP> saw an infestation of <ANIMAL-0-PLURAL> recently. <CITIZEN-X-PLURAL-CAP> <MOVE-X-PAST> <ADVERB> as the mass of <ANIMAL-0-PLURAL> descended on the <ROAD-0>. Local resident <FIRSTNAME> had this to say, \"<EXCLAM> I've never seen anything like this! The last time something this <ADJECTIVE> happened is when those <ANIMAL-X-PLURAL> <VERB-X-PAST> my <NOUN-X-PLURAL>!\".",
            "Unknown <ADJECTIVE-X-CAP> Chemical Leaks = In <DISTRICT>, <BAD-X-INDEF> accident has led to the leak of <INT> litres of Oxysobelnuclia, <NOUN-X-INDEF> cleaner. Local <CITIZEN-X-PLURAL> have chirped that the ground appears to be turning purple, and is emitting a <BAD> smell. Authorities are as yet unaware what effect the chemical will have on local <CITIZEN-X-PLURAL>, but note that it may cause cases of <DISEASE>.",
            "Discovery of Ancient Village in <CITYNAME> = A local archelogist, Dr. <LASTNAME> has announced that a ruin from ancient <CITYNAME> has been discovered in <DISTRICT>. Within the ruins were some artifacts, which have been theorized to be for <VERB-X-ING> <NOUN-X-PLURAL> by the ancient <CITIZEN-X-PLURAL> of this <REGION>. The recovery of bone fragments also suggests that inhabitants suffered from <ADJECTIVE> <DISEASE>, which may have caused the destruction of the village.",
            "Local <PROFESSION-0-CAP> is World's Best = Making headlines around the world, <FIRSTNAME-0> <LASTNAME-0> has broken the world record for <VERB-0-ING> <NOUN-0-INDEF>. <FIRSTNAME-0> <ADVERB> <VERB-0-PAST> <INT> times, while also <ADVERB> <VERB-X-ING>. An official <SAID> \"I haven't seen <VERB-0-ING> of this quality since <FIRSTNAME> <LASTNAME> <VERB-0-PAST> all those <NOUN-X-PLURAL> the last time this record was attempted. <EXCLAM> That was <ADJECTIVE-X-INDEF> day!\"",
            "New Trend on Social Media = As you've no doubt heard, there's a new <ADJECTIVE> trend on Chirper. All around the <REGION>, Chirpers are chirping <ADVERB> about <VERB-0-ING> their <NOUN-0-PLURAL>. One teenager <SAID>, \"Of course we <VERB-0> our <NOUN-0-PLURAL>. It's much more <ADJECTIVE> than <VERB-1-ING> them. Obviously.\". The older generation has responded as one to the news: in fear and disgust. Old Mr. <LASTNAME> <SAID>, \"Back in my day, we <VERB-1-PAST> our <NOUN-0-PLURAL>! Now get away from my <NOUN-X-PLURAL>!\"",
            "Officials Make Statement = In response to <CITIZEN-X-PLURAL> fear's about <ADJECTIVE> <PROFESSION-0-PLURAL> <VERB-0-ING> <NOUN-0-PLURAL>, officials took to social media to answer a few <ADJECTIVE> questions. However, the activist and hacktivist group Undefined soon joined the conversation, posting misinformation. \"They were posting <ADJECTIVE> stuff, mostly for the ROFLs,\" <SAID> one official. \"They were blaming <PROFESSION-X-PLURAL> for all the incidents of <VERB-0-ING>. How can that be true?\" Only <INT> <NOUN-0-PLURAL> have been <VERB-0-PAST> this month.",
            "New <CITIZEN-X-PLURAL-CAP> in <CITYNAME> = You might have noticed a few more <ADJECTIVE> neighbours on your <ROAD>. Since last week, there's been <LARGE-X-INDEF> <ADJECTIVE> wave of people who have moved into <CITYNAME>, and are looking for <ADJECTIVE-X-INDEF> place to call home. One <CITIZEN>, <FIRSTNAME> <LASTNAME>, <SAID>, \"I love <CITYNAME>. It's so <ADJECTIVE>, not to mention <LARGE>. My old town of East Acres was very tiny, and had no room for new <ROAD-X-PLURAL>. How could anyone live like that?\".",
			"Traffic Engineer Gives <ADJECTIVE-0-CAP> Presentation = In a hall packed with <ADJECTIVE> <CITIZEN-X-PLURAL> and mayors from other cities, David Rushkey gave <ADJECTIVE-0-INDEF> presentation, which captivated his audience with the details of traffic planning. Talking <ADVERB>, Mr. Rushkey explained how traffic in his home town of Victoria is organized into a three-level hierarchy. Mayor <LASTNAME> of <CITY> <SAID>, \"This changes everything. I can't wait to get back to <CITY> and evict some <CITIZEN-X-PLURAL> to build more highways!\" One <CITIZEN> dissented, \"I've heard that roundabouts are the best. Why don't we <ADVERB> build more of those?\"", 
			"Does Mayor <MAYORNAME> Have Too Much Power? = Questions have been raised recently about the <ADJECTIVE> power that Mayor <MAYORNAME> has over <CITYNAME>. Local councilman <FIRSTNAME> <LASTNAME> <SAID>, \"It fills me with <EMOTION> that Mayor <MAYORNAME> is the one who controls where people live and <VERB>. For example, it was the mayor who <ADVERB> planned all of <CITYNAME>'s neighbourhoods, without the consultation of <CITIZEN-X-PLURAL> or <PROFESSION-X-PLURAL>. It's <ADJECTIVE>!\" A new bill has been <ADVERB> introduced into city council, in order to restrict these powers and force a vote before <ADJECTIVE> construction crews begin any construction.",
			"Weather Continues to be <WEATHER-X-CAP> = Most <CITIZEN-X-PLURAL> love the <ADJECTIVE> warmth most days, but some have been complaining <ADVERB>. <FIRSTNAME> <LASTNAME> <SAID>, \"<EXCLAM> The heat is melting my ice cream! This makes me feel <EMOTION>, and I want the Mayor to fix it <ADVERB>!\" <REGION-X-CAP> scientists are still at a loss to explain the <ADJECTIVE> phenomenon, but have noted that it at least makes solar power plants highly efficient.",
			"Feelings of <EMOTION-0-CAP> for Green Energy = New construction projects have been <ADVERB> proposed in city council, focusing on the <ADJECTIVE> promise of green energy. One councilwoman <SAID>, \"I had <ADJECTIVE-X-INDEF> idea while <VERB-X-ING> my <NOUN>. Let's harness the power of the wind and the water to power our <ADJECTIVE> city.\" While this may be good for the environment, others <ADVERB> disagree. \"I have feelings of fear and <EMOTION> about these proposals. I mean, how do dams actually work? Is it going to flood <CITYNAME>?\"",
		};
    
		//the fragments to be placed at the end of a story
        public static string[] fragments = new string[]
        {
            "Many <PROFESSION-X-PLURAL> across the <REGION> <VERB-X-PAST> <ADVERB> at the news.",
            "When asked <MAYORPOSSESS> opinion, the mayor <SAID> \"I can't say no to that!\" Later, Mayor <MAYORNAME> approached this reporter and <SAID>, \"Uh, don't quote me on that.\"",
            "When asked <MAYORPOSSESS> opinion, the mayor <SAID> \"<EXCLAM> Absolutely not!\" Later, Mayor <MAYORNAME> approached this reporter and <SAID>, \"Uh, don't quote me on that.\"",
            "Chirper went afire at the news, with many <ADJECTIVE> chirps posted.",
            "<ADJECTIVE-X-CAP> researchers in <CITYNAME> are working <ADVERB> on this issue. Initial results are expected in <INT> years.",
            "This reporter believes the issue will <ADVERB> change the <ADJECTIVE> character of <CITYNAME>.",
            "Mayor <MAYORNAME> later apparently chirped, \"I <ADVERB> stand with <CITIZEN-X-PLURAL> on this issue\". This was later found to be a fake account.",
            "\"This kind of thing hasn't happened in <CITYNAME> for a while, \" <SAID> one <PROFESSION>. \"But I think we'll see it almost daily from now on.\"",
            "When asked, a <PROFESSION> <SAID> \"Yeah sure, but what are the chances of that happening?\"",

			"A group of <PROFESSION-X-PLURAL> later protested in <DISTRICT>.",

            "One official <SAID> \"This doesn't happen every day, but I have feelings of <EMOTION> about it.\"",
            "Protest groups organized <ADJECTIVE> protests on Chirper at the news. Already, the tag #PROTESTALLTHETHINGS had <INT> rechirps.",
			"A press conference was called, but the spokesperson got caught in <ADJECTIVE> traffic. Reporters waited for <INT> hours, before heading to <ADJECTIVE-X-INDEF> bar.",
            "With <LARGE> feelings of <EMOTION>, <CITYNAME> representatives went on Chirper to deny all responsibility.",

            "The <ADJECTIVE> <CITIZEN-X-PLURAL> of <CITYNAME> are demanding official comments on this <ADJECTIVE> issue.",

            "Chirps from the <PROFESSION-X-PLURAL> of <COUNTRY> show that they feel <EMOTION> about this whole situation.",

            "One <PROFESSION> <SAID>, \"It just proves, the more things change, the more they stay the same.\"",
            "One <PROFESSION> <SAID>, \"This is the best thing since <VERB-X-PAST> <NOUN>.\"",
            "One <PROFESSION> <SAID>, \"I've never seen anything more <ADJECTIVE>.\"",
            "One <PROFESSION> <SAID>, \"<EXCLAM>\"",
            "One <PROFESSION> <SAID>, \"This is so <ADJECTIVE>, <ADJECTIVE>, and uh, <ADJECTIVE>?\"",
            "One <PROFESSION> <SAID>, \"Well, beats getting stuck in traffic.\"",

            "One <PROFESSION> <SAID>, \"This fills me with <EMOTION-0>. Just <ADJECTIVE> <EMOTION-0>.\"",
            "One <PROFESSION> <SAID>, \"What about the <ADJECTIVE> <PROFESSION-X-PLURAL> that will be affected by this?\"",

            "One <CITIZEN> <SAID>, \"I've <SAID> a million times, this would be solved with more roundabouts!\"",

            "One <CITIZEN> <SAID>, \"I can't believe this happened in <CITYNAME>!\"",
            "One <CITIZEN> <SAID>, \"Is the mayor going to do anything about this <ADJECTIVE> situation?\"",

            "One <CITIZEN> <SAID>, \"If we focused <ADVERB> on this issue, we could solve it once and for all.\"",

            "One <CITIZEN> <SAID>, \"I can't believe this is happening! This is the most <ADJECTIVE> thing since I moved here <INT> years ago.\"",

            "Bystanders couldn't collaborate the above story, but it probably happened.",

			"Shouts of <EMOTION> reverbated through <DISTRICT> at the news.",

            "Other newspapers printed a different, and much worse version of the above events.",

            "On the other side of the street, <PROFESSION-X-INDEF> <ADVERB> <VERB-X-PAST>.",


            "Our local expert Dr. <LASTNAME> couldn't be reached for comment on the issue. His secretary <SAID> <ADVERB>, \"Uh, I don't know...\".",

            "Most <CITYNAME> <CITIZEN-X-PLURAL> would be filled with <EMOTION> after hearing the news, but Mrs. <LASTNAME>, at age one-hundred and <INT>, has seen it all. \"Veni, vidi, vici\", she <SAID>.",

            "Chances are high that this will affect all <CITIZEN-X-PLURAL> of <CITYNAME>, especially if this <ADJECTIVE> situation gets out of hand.",

            "It's unknown why some <PROFESSION-X-PLURAL> respond so <ADVERB> to this.",

            "The parents in <DISTRICT> started a paper petition about the issue. No-one noticed as the <CITIZEN-X-PLURAL> of <CITYNAME> are too busy <ADVERB> Chirping all the time.",

            "The Council of <PROFESSION-X-CAP-PLURAL> denounced the news, and promised to hold a <ADJECTIVE> vote at their next meeting.",

            "The <CITYNAME> convention centre was rented out for a benefit for the affected. The meal was <ADJECTIVE>, but there wasn't enough <ANIMAL> meat to go around.",


            "A protest of <PROFESSION-X-PLURAL> marched <ADVERB> towards the mayor's office. Multiple roundabouts in their path made their <MOVE-X-ING> quite <ADJECTIVE>.",

            "One <CITIZEN> tried to shake Mayor <MAYORNAME>'s hand <ADVERB>, but was tackled <ADVERB> in the <BODYPART> by the Mayor's security detail.",

            "Local researchers cannot explain these <ADJECTIVE> events, but insist that they could publish many <ADJECTIVE> papers about it if they had more funding.",


            "Internet comments on the issue were <ADJECTIVE> and <ADJECTIVE>, as expected.",

            "Local health experts claimed that <CITIZEN-X-PLURAL> should never attempt the above, adding that it is bad for the <BODYPART>.",
            "Local health experts claimed that <CITIZEN-X-PLURAL> should attempt the above daily, adding that it is good for the <BODYPART>.",

            "A popular local <PROFESSION> took multiple selfies during these events.",

            "After the incident, the Mayor of <CITY> <SAID> <ADVERB> that this would NEVER happen in their city.",

            "The Mayor's staff dressed extra <ADVERB> the day after, because of the media attention.",


            "An old man at the scene complained about how the kids of <CITYNAME> and their <ADJECTIVE> antics caused the incident.",

            "City council declared that this day should be <ADVERB> remembered in <CITYNAME> history forever.",

            "Aid agencies are asking <CITIZEN-X-PLURAL> to donate <ADJECTIVE> <NOUN-X-PLURAL> to help those affected.",

            "It is expected that this will change how often babies are named after Mayor <MAYORNAME>, especially <ADJECTIVE> babies.",

            "Multiple <CITIZEN-X-PLURAL> drove home <ADVERB> after hearing the news.",
            "Sales of hot-dogs and ice cream doubled after the news broke.",
            "Quite a few <CITIZEN-X-PLURAL> surveyed didn't understand the events at all.",
            "A local <PROFESSION> <VERB-X-PAST> his <NOUN> when he heard the news.",

            "<PROFESSION-X-INDEF-CAP> tripped and fell down at the scene, bruising his <BODYPART>.",

			"Mayor <MAYORNAME> was probably too busy building roundabouts to care."
        };

		public static string[] polls = new string[] { "<INT> percent of <CITIZEN-X-PLURAL> hate <PROFESSION-X-PLURAL>", "<INT> percent of <CITIZEN-X-PLURAL> are <ADJECTIVE>", "<INT> percent of <CITIZEN-X-PLURAL> love <NOUN-X-PLURAL>", "<INT> percent of <CITIZEN-X-PLURAL> have a pet <ANIMAL>.", "<INT> percent of <CITIZEN-X-PLURAL> have <DISEASE>.",  "<INT> percent of <CITIZEN-X-PLURAL> prefer <COUNTRY> over <COUNTRY>.","<INT> percent of <CITIZEN-X-PLURAL> think <CITYNAME> is <ADJECTIVE>.","<INT> percent of <CITIZEN-X-PLURAL> <VERB> <ADVERB>" };
		public static string[] qotds = new string[] { "\"A city is not an accident but the result of coherent visions and aims.\"", "\"Traffic congestion is caused by vehicles, not by people in themselves.\"", "\"A city is more than a place in space, it is a drama in time.\"", "\"Growth for the sake of growth is the ideology of the cancer cell.\"", 
			"\"Before beginning, plan carefully.\"", "\"Roundabouts are what you build until sanity prevails again.\"", "\"In Houston, a person walking is someone on his way to his car.\"" , "\"A thousand policemen directing traffic cannot tell you why you come or where you go.\"",
			"\"Let the river roll which way it will, cities will rise on its banks.\"" ,"\"Perfection is achieved, not when there is nothing more to add, but when there is nothing left to take away.\"" ,"\"The living arrangements Americans now think are normal are bankrupting us economically, socially, ecologically and spiritually.\"","\"Traveler, there is no path. Paths are made by walking.\"","\"Any town that doesn't have sidewalks doesn't love its children.\"",
			"\"Cities have always been the fireplaces of civilization, whence light and heat radiated out into the dark. \"","\"The home is where part of the family waits until the others are through with the car.\"","\"The trouble with land is that they're not making it anymore.\"" ,"\"Form ever follows function.\"","\"The city is built to music, therefore never built at all, and therefore built for ever.\"","\"I have never learned to tune a lute or play upon a harp, but I can take a small and obscure city and raise it to greatness.\""};

		public static string[] weather = new string[] { "Blinding sun", "Unceasing heat", "Pleasant", "Brilliant", "Luminous", "Radiant", "Clarion", "Cloudless", "Fine", "Light", "Shining", "Shiny", "Summery", "Rainless", "Unclouded", "Sunlit", "Sunshiny", "Undarkened" };
		public static string[] otherArticles = new string[] { "Spotlight on traffic: pg. <INT>", "Driving advice: pg. <INT>", "How's Your Driving?: pg. <INT>", "<CITYNAME>'s Best Restaurants: pg. <INT>", "Spotlight on <DISTRICT>", "<CITYNAME> Budget Issues: pg. <INT>", "Meet a <CITIZEN-X-CAP>: pg. <INT>", "Unrest on <COUNTRY>: pg. <INT>", "Profile Inside: New Art Trend",
			"Killer <ANIMAL-X-PLURAL-CAP> in <CITYNAME>?: pg. <INT>", "<DISEASE-X-CAP> spreading in <CITYNAME>?: pg. <INT>", "<CITYNAME> Honours <PROFESSION-X-PLURAL-CAP>: pg. <INT>"};
			
		public static string[] money = new string[] {"ducats", "rubles", "euros", "pounds", "dollars", "pesoes", "yuan"
		, "gold coins", "bars of gold", "shillings", "pence", "farthings", "florins", "thalers", "markkas"};
	
		//the word bank
		public static string[] nouns = new string[] { "doo-hickey", "potato", "vegetable", "fruit", "apple", "tin-whistle", "stroller", "piglet", "goat", "roundabout", "marble", "hamster", "aardvark", "rock", "bear", "weasel", "cannon", "camera", "brick", "brush", "fork", "spoon", "fruit cup", "newspaper", "smartphone", "bowtie", "underwear", "cactus", "banana", "whale-oil lantern", "monocle", "take-out food", "hot-dog", "ice cream cone" };
        public static string[] verbs = new string[] { "kill", "heal", "jump", "paint", "clean", "march", "cook", "spot", "annoy", "assemble", "attack", "bite", "bend", "bounce", "breed", "bump", "drink", "eat", "bury", "buy", "chase", "choke", "crush", "carve", "dress", "drown", "sell", "throw", "fling", "freeze", "grease", "heat", "kick", "lick", "flick", "marry", "kiss", "murder", "organize", "prick", "research", "rinse", "stimulate", "streamline", "transform", "undress", "upgrade", "wrestle" };
        public static string[] adjectives = new string[] { "crabby", "naughty", "tough", "blinding", "dazzling", "disheveled", "happy", "proud", "threatening", "melodious", "crazy", "magnanimous", "cute", "thirsty", "circling", "passionate", "cranky", "colourful", "sulky", "bright", "greasy", "carefree", "warm", "cold-blooded", "sweet", "adorable", "beautiful", "clean", "elegant", "glamorous", "magnificent", "old-fashioned", "unsightly", "mushy", "tender", "vast", "helpful", "obnoxious", "repulsive", "thoughtless", "uptight", "jolly", "chubby", "rolly-polly", "hollow", "steep", "wide", "deafening", "ancient", "rapid", "early", "bitter", "salty", "tart", "uneven", "crooked", "dusty", "filthy", "fluffy", "broken", "abundant", "sparse", "substantial", "unbelievable" };
        public static string[] emotions = new string[] { "pride", "hunger", "pride", "dread", "apathy", "trust", "sympathy", "angst", "anguish", "lust", "outrage", "panic", "relief", "suffering", "shock", "zeal", "indifference", "disgust", "ecstasy", "courage", "envy", "loathing", "guilt", "remorse", "schadenfreude", "self-confidence" };
        public static string[] professions = new string[] { "gambler", "cop", "teacher", "clown", "homeowner", "communist", "citizen", "local", "jogger", "writer", "surfer dude", "roller blader", "evangelist", "child", "cyclist", "inhabitant", "jock", "evil guy", "programmer", "sanitation worker", "pastor", "teacher", "chiropractor", "pharmacist", "surgeon", "veterinarian", "accountant", "architect", "librarian", "urban planner", "traffic engineer", "soldier", "firefighter", "pilot", "sea captain", "biologist", "oceanographer", "physicist", "virologist", "botanist", "web designer", "3D modeller" };
        public static string[] adverbs = new string[] { "quickly", "slowly", "actively", "momentarily", "recklessly", "shamelessly", "uncontrollably", "wildly", "allegedly", "absentmindedly", "anxiously", "awkwardly", "bashfully", "blindly", "bravely", "briskly", "cautiously", "continually", "cruelly", "daintily", "defiantly", "dreamily", "excitedly", "faithfully", "ferociously", "foolishly", "frightfully", "furiously", "irritably", "joyfully", "knowledgeably", "mechanically", "mysteriously", "noisily", "obnoxiously", "overconfidently", "painfully", "powerfully", "punctually", "quirkily", "rigidly", "rudely", "sternly", "suspiciously", "swiftly", "tenderly", "tightly", "urgently", "uselessly", "weakly", "zealously" };
        public static string[] exclamations = new string[] { "Jeepers!", "Crikey!", "Blimey!", "Holy cow!", "OMG!", "Ain't that a kick in the pants!", "Boy howdy!", "Oh my!", "By Jove!" };
        public static string[] titles = new string[] { "King", "Emperor", "Dr.", "Professor", "Mister", "Master", "Alderman", "Delegate", "Premier", "ambassador", "Envoy", "Provost", "Archduke", "Marquis", "Count", "Duke", "Petty King", "Baron", "Lord", "Tsar", "Leader" };
        public static string[] firstNames = new string[] { "Mario", "Julie", "Vanessa", "Debra", "Sam", "Toby", "Michael", "Patricia", "James", "Daniel", "David", "Joesph", "Francis", "Bruno", "Marcus", "Bernhard" };
        public static string[] lastNames = new string[] { "Carrow", "Gumbolt", "Wright", "Newell", "Simons", "Nigel", "Weiss", "Edward", "Larson", "O'Hare", "Sadat", "Cousteau", "Oscar", "Zimmerman", "Vinci", "Forte", "Tremblay", "Augustus" };
        public static string[] cities = new string[] { "Paris", "Tokyo", "San Francisco", "Los Angeles", "Stockholm", "Darwin" };
        public static string[] places = new string[] { "Iraq", "Afganistan", "Paraguay", "Egypt", "South Africa", "Brazil", "the U.S.S.R.", "Australia" };
        public static string[] saidTypes = new string[] { "grunted", "replied", "said", "disclosed", "exclaimed", "mused", "stated", "observed", "shrieked", "stammered", "complained", "explained", "shouted", "whispered", "suggested" };

        public static string[] bodyParts = new string[] { "forehead", "face", "breast", "flank", "hip", "knee", "foot", "crown", "neck", "loin", "buttock", "heel", "chest", "shoulder", "armpit", "big toe", "elbow", "kneecap" };
        public static string[] diseases = new string[] { "wonky ankle", "bad breath", "astigmatism", "typhus", "syphilis", "pertussis", "leprosy", "fat fingers", "smallpox", "monkeypox", "plague", "polio", "tuberculosis" };

        public static string[] badTerms = new string[] { "bad", "terrible", "heinious", "awful", "grostesque", "pretty bad", "very bad", "not-great", "despicable", "faulty", "flawed", "mediocre", "reprehensible", "second-rate", "ghastly" };
        public static string[] largeTerms = new string[] { "ample", "huge", "large", "sizeable", "jumbo", "massive", "collossal" };

        public static string[] citizenTerms = new string[] { "serf", "taxpayer", "prole", "dweller", "pleb", "peasant", "citizen", "local", "resident", "denizen", "burgher", "commoner", "inhabitant", "subject" };
        public static string[] regionTerms = new string[] { "city", "town", "municipality", "metropolis", "urban area", "metropolitan area", "urban municipality", "township", "burg" };
        public static string[] roadTerms = new string[] { "road", "avenue", "boulevard", "circle", "street", "lane", "drive", "crescent" };
        public static string[] animals = new string[] { "bear", "aarvark", "snake", "dropbear", "camel", "unicorn", "elk", "parrot", "budgie", "rabbit", "pig", "wild boar", "horse", "cat", "dog", "lizard" };
    
        public static string[] moveTerms = new string[] { "move", "scramble", "run", "jog", "progress", "advance", "relocate", "flee", "circulate", "amble", "shamble" };
    
        public static string[] reporters = new string[] {"Peter T. Forte", "Todd A. LeMou", "Ned Light", "Tim Bow", "M.A. Bacco", "Flynn S. Mann", "S. Codder"};
    }
}

