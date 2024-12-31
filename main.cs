using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace TypeTest;
class Program
{
    public static void Main(String[] args)
    {
        string input = " ";
        int length = 0;
        do {
            Console.Write("Length:\nvshort             10 words\nshort              25 words\nmedium             50 words\nlong               100 words\nvlong              150 words\nmarathon           200 words\n\nInput - ");
            input = Console.ReadLine();
            switch (input) {
                case "vshort":
                    length = 10;
                    break;
                case "short":
                    length = 25;
                    break;
                case "medium":
                    length = 50;
                    break;
                case "long":
                    length = 100;
                    break;
                case "vlong":
                    length = 150;
                    break;
                case "marathon":
                    length = 200;
                    break;
                default:
                    continue;

            }
            Program.BeginTest(Program.GenerateText(length), length);
        } while (input != "");
    }
    public static string GenerateText(int len)
    {
        Random rand = new Random();
				// the following is sourced from: https://en.wiktionary.org/wiki/Appendix:1000_basic_English_words
				//with some alterations to remove innaproprate terms, replacing them with other words
        List<string> words = new List<string>() { "a", "about", "above", "across", "act", "active", "activity", "add", "afraid", "after", "again", "age", "ago", "agree", "air", "all", "alone", "along", "already", "always", "am", "amount", "an", "and", "angry", "another", "answer", "any", "anyone", "anything", "anytime", "appear", "apple", "are", "area", "arm", "army", "around", "arrive", "art", "as", "ask", "at", "attack", "aunt", "autumn", "away", "baby", "back", "bad", "bag", "ball", "bank", "base", "basket", "bath", "be", "bean", "bear", "beautiful", "bed", "bedroom", "beer", "behave", "before", "begin", "behind", "bell", "below", "besides", "best", "better", "between", "big", "bird", "birth", "birthday", "bit", "bite", "black", "bleed", "block", "blood", "blow", "blue", "board", "boat", "body", "boil", "bone", "book", "border", "born", "borrow", "both", "bottle", "bottom", "bowl", "box", "boy", "branch", "brave", "bread", "break", "breakfast", "breathe", "bridge", "bright", "bring", "brother", "brown", "brush", "build", "burn", "business", "bus", "busy", "but", "buy", "by", "cake", "call", "can", "candle", "cap", "car", "card", "care", "careful", "careless", "carry", "case", "cat", "catch", "central", "century", "certain", "chair", "chance", "change", "chase", "cheap", "cheese", "chicken", "child", "children", "chocolate", "choice", "choose", "circle", "city", "class", "clever", "clean", "clear", "climb", "clock", "cloth", "clothes", "cloud", "cloudy", "close", "coffee", "coat", "coin", "cold", "collect", "colour", "comb", "comfortable", "common", "compare", "come", "complete", "computer", "condition", "continue", "control", "cook", "cool", "copper", "corn", "corner", "correct", "cost", "contain", "count", "country", "course", "cover", "crash", "cross", "cry", "cup", "cupboard", "cut", "dance", "dangerous", "dark", "daughter", "day", "dead", "decide", "decrease", "deep", "deer", "depend", "desk", "destroy", "develop", "die", "different", "difficult", "dinner", "direction", "dirty", "discover", "dish", "do", "dog", "door", "double", "down", "draw", "dream", "dress", "drink", "drive", "drop", "dry", "duck", "dust", "duty", "each", "ear", "early", "earn", "earth", "east", "easy", "eat", "education", "effect", "egg", "eight", "either", "electric", "elephant", "else", "empty", "end", "enemy", "enjoy", "enough", "enter", "equal", "entrance", "escape", "even", "evening", "event", "ever", "every", "everyone", "exact", "everybody", "examination", "example", "except", "excited", "exercise", "expect", "expensive", "explain", "extremely", "eye", "face", "fact", "fail", "fall", "false", "family", "famous", "far", "farm", "father", "fast", "fat", "fault", "fear", "feed", "feel", "female", "fever", "few", "fight", "fill", "film", "find", "fine", "finger", "finish", "fire", "first", "fish", "fit", "five", "fix", "flag", "flat", "float", "floor", "flour", "flower", "fly", "fold", "food", "fool", "foot", "football", "for", "force", "foreign", "forest", "forget", "forgive", "fork", "form", "fox", "four", "free", "freedom", "freeze", "fresh", "friend", "friendly", "from", "front", "fruit", "full", "fun", "funny", "furniture", "further", "future", "game", "garden", "gate", "general", "gentleman", "get", "gift", "give", "glad", "glass", "go", "goat", "god", "gold", "good", "goodbye", "grandfather", "grandmother", "grass", "grave", "great", "green", "gray", "ground", "group", "grow", "gas", "hair", "half", "hall", "hammer", "hand", "happen", "happy", "hard", "hat", "hate", "have", "he", "head", "healthy", "hear", "heavy", "heart", "heaven", "height", "hello", "help", "hen", "her", "here", "hers", "hide", "high", "hill", "him", "his", "hit", "hobby", "hold", "hole", "holiday", "home", "hope", "horse", "hospital", "hot", "hotel", "house", "how", "hundred", "hungry", "hour", "hurry", "husband", "hurt", "I", "ice", "idea", "if", "important", "in", "increase", "inside", "into", "introduce", "invent", "iron", "invite", "is", "island", "it", "its", "jelly", "job", "join", "juice", "jump", "just", "keep", "key", "kill", "kind", "king", "kitchen", "knee", "knife", "knock", "know", "ladder", "lady", "lamp", "land", "large", "last", "late", "lately", "laugh", "lazy", "lead", "leaf", "learn", "leave", "leg", "left", "lend", "length", "less", "lesson", "let", "letter", "library", "lie", "life", "light", "like", "lion", "lip", "list", "listen", "little", "live", "lock", "lonely", "long", "look", "lose", "lot", "love", "low", "lower", "luck", "machine", "main", "make", "male", "man", "many", "map", "mark", "market", "marry", "matter", "may", "me", "meal", "mean", "measure", "meat", "medicine", "meet", "member", "mention", "method", "middle", "milk", "million", "mind", "minute", "miss", "mistake", "mix", "model", "modern", "moment", "money", "monkey", "month", "moon", "more", "morning", "most", "mother", "mountain", "mouth", "move", "much", "music", "must", "my", "name", "narrow", "nation", "nature", "near", "nearly", "neck", "need", "needle", "neighbour", "neither", "net", "never", "new", "news", "newspaper", "next", "nice", "night", "nine", "no", "noble", "noise", "none", "nor", "north", "nose", "not", "nothing", "notice", "now", "number", "obey", "object", "ocean", "of", "off", "offer", "office", "often", "oil", "old", "on", "one", "only", "open", "opposite", "or", "orange", "order", "other", "our", "out", "outside", "over", "own", "page", "pain", "paint", "pair", "pan", "paper", "parent", "park", "part", "partner", "party", "pass", "past", "path", "pay", "peace", "pen", "pencil", "people", "pepper", "per", "perfect", "period", "person", "petrol", "photograph", "piano", "pick", "picture", "piece", "pig", "pin", "pink", "place", "plane", "plant", "plastic", "plate", "play", "please", "pleased", "plenty", "pneumonoultramicroscopicsilicovolcanoconiosis", "pocket", "point", "poison", "police", "polite", "pool", "poor", "popular", "position", "possible", "potato", "pour", "power", "present", "press", "pretty", "prevent", "price", "prince", "prison", "private", "prize", "probably", "problem", "produce", "promise", "proper", "protect", "provide", "public", "pull", "punish", "pupil", "push", "put", "queen", "question", "quick", "quiet", "quite", "radio", "rain", "rainy", "raise", "reach", "read", "ready", "real", "really", "receive", "record", "red", "remember", "remind", "remove", "rent", "repair", "repeat", "reply", "report", "rest", "restaurant", "result", "return", "rice", "rich", "ride", "right", "ring", "rise", "road", "rob", "rock", "room", "round", "rubber", "rude", "rule", "ruler", "run", "rush", "sad", "safe", "sail", "salt", "same", "sand", "save", "say", "school", "science", "scissors", "search", "seat", "second", "see", "seem", "sell", "send", "sentence", "serve", "seven", "several", "slack", "shade", "shadow", "shake", "shape", "share", "sharp", "she", "sheep", "sheet", "shelf", "shine", "ship", "shirt", "shoe", "shoot", "shop", "short", "should", "shoulder", "shout", "show", "sick", "side", "signal", "silence", "silly", "silver", "similar", "simple", "single", "since", "sing", "sink", "sister", "sit", "six", "size", "skill", "skin", "skirt", "sky", "sleep", "slip", "slow", "small", "smell", "smile", "smoke", "snow", "so", "soap", "sock", "soft", "some", "someone", "something", "sometimes", "son", "soon", "sorry", "sound", "soup", "south", "space", "speak", "special", "speed", "spell", "spend", "spoon", "sport", "spread", "spring", "square", "stamp", "stand", "star", "start", "station", "stay", "steal", "steam", "step", "still", "stomach", "stone", "stop", "store", "storm", "story", "strange", "street", "strong", "structure", "student", "study", "stupid", "subject", "substance", "successful", "such", "sudden", "sugar", "suitable", "summer", "sun", "sunny", "support", "sure", "surprise", "sweet", "swim", "sword", "table", "take", "talk", "tall", "taste", "taxi", "tea", "teach", "team", "tear", "telephone", "television", "tell", "ten", "tennis", "terrible", "test", "than", "that", "the", "their", "then", "there", "therefore", "these", "thick", "thin", "thing", "think", "third", "this", "though", "threat", "three", "tidy", "tie", "title", "to", "today", "toe", "together", "tomorrow", "tonight", "too", "tool", "tooth", "top", "total", "touch", "town", "train", "tram", "travel", "tree", "trouble", "true", "trust", "twice", "try", "turn", "type", "ugly", "uncle", "under", "understand", "unit", "until", "up", "use", "useful", "usual", "usually", "vegetable", "very", "village", "voice", "visit", "wait", "wake", "walk", "want", "warm", "was", "wash", "waste", "watch", "water", "way", "we", "weak", "wear", "weather", "wedding", "week", "weight", "welcome", "were", "well", "west", "wet", "what", "wheel", "when", "where", "which", "while", "white", "who", "why", "wide", "wife", "wild", "will", "win", "wind", "window", "wine", "winter", "wire", "wise", "wish", "with", "without", "woman", "wonder", "word", "work", "world", "worry", "yard", "yell", "yesterday", "yet", "you", "young", "your", "zero", "zoo" };
        string text = "";
        for (int i = 0; i < len; i++)
        {
            text += words[rand.Next(0, words.Count)] + " ";
        }
        return text;

    }
    public static void BeginTest(string TEXT, int len)
    {
        Console.Write("Press any key to begin:  ");
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        Stopwatch stopwatch = new Stopwatch();
        int wrong = 0;
        int keystrokes = 0;
        stopwatch.Start();
        Test test = new Test(TEXT);
        bool correctChar;
        for (int i = 0; i < test.text.Length; i++)
        {
            Console.Clear();
            test.DisplayText();
            keyInfo = Console.ReadKey(true);
            correctChar = test.AttemptInput(keyInfo.KeyChar);
            keystrokes++;
            if (correctChar)
            {
                Console.Write("✔");
            }
            else
            {
                Console.Write("✘");
                i--;
                wrong++;
            }
        }
        

        Console.Clear();
        stopwatch.Stop();
        TimeSpan ts = stopwatch.Elapsed;
        float accuracy = wrong / keystrokes;
        Console.Write("WPM: ");
        Console.WriteLine(len / (((float)ts.Hours * 60f + (float)ts.Minutes + (float)ts.Seconds / 60f)));
        Console.WriteLine($"Accuracy: {100 - (((float)wrong / keystrokes) * 100)}%");
        Console.Write($"Time: {ts.Hours}:{ts.Minutes}:{ts.Seconds}");
        Console.Write("\n\nPress");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(" [ENTER] ");
        Console.ResetColor();
        Console.WriteLine("to continue.");
        Console.WriteLine("\n\n\n ######     ######     ######    ######\n#      #   #      #   #      #   #     #\n#          #      #   #      #   #      #\n#          #      #   #      #   #      #\n#   ###    #      #   #      #   #      #\n#      #   #      #   #      #   #      #\n#      #   #      #   #      #   #      #\n ######     ######     ######    ######\n\n\n       #    ######    #######    ########\n       #   #      #   #      #   ########\n       #   #      #   #      #   ########\n       #   #      #   #######     ######\n#      #   #      #   #      #    \n#      #   #      #   #      #     ####\n#      #   #      #   #      #     ####\n  #####     ######    #######      ####\n\n\n");
        Console.ReadLine();
        Console.Clear();


    }
    public string getLineInput(string writeThis)
    {
        Console.Write(writeThis);
        return Console.ReadLine();
    }

}




class Test
{
    public string text { get; private set; }
    public int index { get; private set; }
    public char nextCharacter { get; private set; }
		//public List<int> wrongest = List; 
    public Test(string Texta)
    {

        index = 0;
        text = Texta;
    }

    public void DisplayText()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("\n" + text.Substring(0, index));
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(text.Substring(index, text.Length - index));
        Console.ResetColor();

    }

    public bool AttemptInput(char input)
    {
        if (index != text.Length) { nextCharacter = text[index]; }
        if (input == nextCharacter)
        {
            index++;
            if (index != text.Length) { nextCharacter = text[index]; }

            return true;
        }
        else
        {
            return false;
        }
    }

}
