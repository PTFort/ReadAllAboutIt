﻿using System;
using Newspaper;
namespace Newspaper
{
    public class Data
    {
        

        //the stories
        public static string[] templates = new string[]
        {
            "<PROFESSION-0-CAP> <VERB-0-PRESENT-CAP> <NOUN-0-CAP> = In the court of Judge <LASTNAME>, the <PROFESSION-0> <FIRSTNAME> <LASTNAME> could face a sentence of <INT> years on the charge of <VERB-0-ING> <NOUN-0-INDEF>. The defence has entered no plea yet. The trial is expected to last <INT> weeks, as the prosecution is having difficulty finding experts on <VERB-0-ING> <NOUN-0-PLURAL>.",
            "<NOUN-0-CAP> <VERB-0-CAP-PAST> by <PROFESSION-0-CAP-PLURAL> = In <ADJECTIVE-X-INDEF> incident, <NOUN-0-INDEF> was <VERB-0-PAST> by a group of <ADJECTIVE> <PROFESSION-0-PLURAL>. Local <CITYNAME> authorities are concerned that many <NOUN-0-PLURAL> could be <VERB-0-PAST> in the future, so <CITIZEN-X-PLURAL> are being told to lock up their <NOUN-0-PLURAL>. The owner of the <NOUN-0>, <FIRSTNAME> <LASTNAME>, <SAID> \"I hope that the authorities nab these <PROFESSION-0-PLURAL>. They are a <LARGE> danger. Personally, I blame <PROFESSION-X-PLURAL> for this\".",
            "Escape From <LASTNAME-0> Research Facility = Late last night, an alarm was raised at the <LASTNAME-0> research facility as a <LARGE> <ANIMAL-0> escaped. Local <CITYNAME> police scrambled in order to detain the <ADJECTIVE> <ANIMAL-0>. When the <ANIMAL-0> stopped <MOVE-X-ING> <ADVERB>, and <VERB-X-PAST>, police were able to <MOVE> <ADVERB> and capture the <ADJECTIVE> <ANIMAL-0>.",
             "Masses of <ANIMAL-0-PLURAL-CAP> = <LASTNAME> <ROAD-0-CAP> saw an infestation of <ANIMAL-0-PLURAL> recently. <CITIZEN-X-PLURAL-CAP> <MOVE-X-PAST> <ADVERB> as the mass of <ANIMAL-0-PLURAL> descended on the <ROAD-0>. Local resident <FIRSTNAME> had this to say, \"<EXCLAM>. I've never seen anything like this! The last time something this <ADJECTIVE> happened is when those <ANIMAL> <VERB-X-PAST> my <NOUN-X-PLURAL>!\".",
            "Unknown <ADJECTIVE-X-CAP> Chemical Leaks = In the <DISTRICT>, <BAD-X-INDEF> accident has led to the leak of <INT> litres of OXYSOBELNUCLIA, <NOUN-X-INDEF> cleaner. Local <CITIZEN-X-PLURAL> have chirped that the ground appears to be turning purple, and is emitting a <BAD> smell. Authorities are as yet unaware what effect the chemical will have on local <CITIZEN-X-PLURAL>, but note that it may cause cases of <DISEASE>.",
            "Discovery of Ancient Village = A local archelogist, Dr. <LASTNAME> has announced that a ruin from ancient <CITYNAME> has been discovered in <DISTRICT>. Within the ruins were some artifacts, which have been theorized to be for <VERB-X-ING> <NOUN-X-PLURAL> by the ancient <CITIZEN-X-PLURAL> of this <REGION>. The recovery of bone fragments also suggests that inhabitants suffered from <ADJECTIVE> <DISEASE>, which may have caused the destruction of the village.",
            "Local <PROFESSION-0-CAP> is World's Best = Making headlines around the world, <FIRSTNAME-0> <LASTNAME-0> has broken the world record for <VERB-0-ING> <NOUN-0-INDEF>. <FIRSTNAME-0> <ADVERB> <VERB-0-PAST> <INT> times, while also <ADVERB> <VERB-X-ING>. An official <SAID> \"I haven't seen <VERB-0-ING> of this quality since <FIRSTNAME> <LASTNAME> <VERB-0-PAST> all those <NOUN-X-PLURAL> the last time this record was attempted. <EXCLAM> That was <ADJECTIVE-X-INDEF> day!\"",
            "New Trend on Social Media = As you've no doubt heard, there's a new <ADJECTIVE> trend on Chirper. All around the <REGION>, Chirpers are chirping <ADVERB> about <VERB-0-ING> their <NOUN-0-PLURAL>. One teenager <SAID>, \"Of course we <VERB-0> our <NOUN-0-PLURAL>. It's much more <ADJECTIVE> than <VERB-1-ING> them. Obviously.\". The older generation has responded as one to the news: in fear and disgust. Old Mr. <LASTNAME> <SAID>, \"Back in my day, we <VERB-1-PAST> our <NOUN-0-PLURAL>! Now get away from my <NOUN-X-PLURAL>!\"",
            "Officials Make Statement = In response to <CITIZEN-X-PLURAL> fear's about <ADJECTIVE> <PROFESSION-0-PLURAL> <VERB-0-ING> <NOUN-0-PLURAL>, officials took to social media to answer a few <ADJECTIVE> questions. However, the activist and hacktivist group UNDEFINED soon joined the conversation, posting misinformation. \"They were posting <ADJECTIVE> stuff, mostly for the ROFLs,\" <SAID> one official. \"They were blaming <PROFESSION-X-PLURAL> for all the incidents of <VERB-0-ING>. How can that be true?\" Only <INT> <NOUN-0-PLURAL> have been <VERB-0-PAST> this month.",
            "New <CITIZEN-X-PLURAL-CAP> in <CITYNAME> = You might have noticed a few more neighbours on your <ROAD>. Since last week, there's been <LARGE-X-INDEF> <ADJECTIVE> wave of people who have moved into <CITYNAME>, and are looking for <ADJECTIVE-X-INDEF> place to call home. One <CITIZEN>, <FIRSTNAME> <LASTNAME>, <SAID>, \"I love <CITYNAME>. It's so <ADJECTIVE>, not to mention <LARGE>. My old town of East Acres was very tiny, and had no room for expansion. How could anyone live like that?\".",
			"Traffic Engineer Gives <ADJECTIVE-0-CAP> Presentation = In a hall packed with <ADJECTIVE> <CITIZEN-X-PLURAL> and mayors from other cities, David Rushkey gave <ADJECTIVE-0-INDEF> presentation, which captivated his audience with the details of traffic planning. Talking <ADVERB>, Mr. Rushkey explained how traffic in his home town of Victoria is organized into a three-level hierarchy. Mayor <LASTNAME> of <CITY> <SAID>, \"This changes everything. I can't wait to get back to <CITY> and evict some <CITIZEN-X-PLURAL> to build more highways!\" One <CITIZEN> dissented, \"I've heard that roundabouts are the best. Why don't we <ADVERB> build more of those?\"", 
		
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

            "One official <SAID> \"This doesn't happen every day, but I have feelings of <EMOTION> about it.\"",
            "Protest groups organized <ADJECTIVE> protests on Chirper at the news. Already, the tag #PROTESTALLTHETHINGS had <INT> rechirps.",
            "A press conference was called, but the spokesperson got caught in <ADJECTIVE> traffic. Reporters waited for <INT> hours, before heading to a local bar.",
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

            "Other reporters printed a different, and much worse version of the above events.",

            "On the other side of a street, a <PROFESSION> <ADVERB> <VERB-X-PAST>.",


            "Our local expert Dr. <LASTNAME> couldn't be reached for comment on the issue. Their secretary <SAID> <ADVERB>, \"Uh, I guess... This is a bad thing? IDK\".",

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
            "Sales of hot dogs and ice cream doubled after the news broke.",
            "Quite a few <CITIZEN-X-PLURAL> surveyed didn't understand the events at all.",
            "A local <PROFESSION> <VERB-X-PAST> his <NOUN> when he heard the news.",

            "A <PROFESSION> tripped and fell down at the scene, bruising his <BODYPART>."
        };
			
		//the word bank
        public static string[] nouns = new string[] { "vegetable", "fruit", "apple", "tin-whistle", "stroller", "piglet", "goat", "roundabout", "marble", "hamster", "aardvark", "abacus", "bear", "weasel", "cannon", "camera", "brick", "brush", "fork", "spoon", "fruit cup", "newspaper", "smartphone", "bowtie", "underwear", "banana", "whale-oil lantern", "monocle", "take-out food" };
        public static string[] verbs = new string[] { "kill", "heal", "jump", "paint", "clean", "march", "cook", "spot", "annoy", "assemble", "attack", "bite", "bend", "bounce", "breed", "bump", "drink", "eat", "bury", "buy", "chase", "choke", "crush", "carve", "dress", "drown", "sell", "throw", "fling", "freeze", "grease", "heat", "kick", "lick", "flick", "marry", "kiss", "murder", "organize", "prick", "research", "rinse", "stimulate", "streamline", "transform", "undress", "upgrade", "wrestle" };
        public static string[] adjectives = new string[] { "crabby", "naughty", "tough", "disheveled", "happy", "proud", "threatening", "melodious", "crazy", "magnanimous", "cute", "thirsty", "circling", "passionate", "cranky", "colourful", "sulky", "bright", "greasy", "carefree", "warm", "cold-blooded", "sweet", "adorable", "beautiful", "clean", "elegant", "glamorous", "magnificent", "old-fashioned", "unsightly", "mushy", "tender", "vast", "helpful", "obnoxious", "repulsive", "thoughtless", "uptight", "jolly", "chubby", "rolly-polly", "hollow", "steep", "wide", "deafening", "ancient", "rapid", "early", "bitter", "salty", "tart", "uneven", "crooked", "dusty", "filthy", "fluffy", "broken", "abundant", "sparse", "substantial" };
        public static string[] emotions = new string[] { "pride", "hunger", "pride", "dread", "apathy", "trust", "sympathy", "angst", "anguish", "lust", "outrage", "panic", "relief", "suffering", "shock", "zeal", "indifference", "disgust", "ecstasy", "courage", "envy", "loathing", "guilt", "remorse", "schadenfreude", "self-confidence" };
        public static string[] professions = new string[] { "gambler", "cop", "teacher", "clown", "homeowner", "communist", "citizen", "local", "jogger", "writer", "surfer dude", "roller blader", "evangelist", "child", "cyclist", "inhabitant", "jock", "evil guy", "programmer", "sanitation worker", "pastor", "teacher", "chiropractor", "pharmacist", "surgeon", "veterinarian", "accountant", "architect", "librarian", "urban planner", "traffic engineer", "soldier", "firefighter", "pilot", "sea captain", "biologist", "oceanographer", "physicist", "virologist", "botanist", "web designer", "3D modeller" };
        public static string[] adverbs = new string[] { "quickly", "slowly", "actively", "momentarily", "recklessly", "shamelessly", "uncontrollably", "wildly", "allegedly", "absentmindedly", "anxiously", "awkwardly", "bashfully", "blindly", "bravely", "briskly", "cautiously", "continually", "cruelly", "daintily", "defiantly", "dreamily", "excitedly", "faithfully", "ferociously", "foolishly", "frightfully", "furiously", "irritably", "joyfully", "knowledgeably", "mechanically", "mysteriously", "noisily", "obnoxiously", "overconfidently", "painfully", "powerfully", "punctually", "quirkily", "rigidly", "rudely", "sternly", "suspiciously", "swiftly", "tenderly", "tightly", "urgently", "uselessly", "weakly", "zealously" };
        public static string[] exclamations = new string[] { "Jeepers!", "Crikey!", "Blimey!", "Holy cow!", "OMG!", "Ain't that a kick in the pants!", "Boy howdy!" };
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
    
        public static string[] moveTerms = new string[] { "move", "scramble", "run", "jog", "progress", "advance", "relocate", "flee", "circulate" };
    
        public static string[] reporters = new string[] {"Peter T. Forte", "Todd A. LeMou", "Ned Light", "Tim Bow", "M.A. Bacco", "Flynn S. Mann", "S. Codder"};
    }
}

