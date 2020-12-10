namespace newQuestions {
    public class Encoder {
        //0- a method Encoder for take string them turn into a secret code .
        public static string EnCoder (string input) {
            var s = 0;
            var chars = new char[input.Length];
            for (int i = 0; i < input.Length; i++) {
                s = input[i] - 2 - (i * 4);
                chars[i] = (char) s;
            }
            return new string (chars);
        }

        //0- a method Decoder to take a secrrt code and recover the string .
        public static string DeCoder (string input) {
            var s = 0;
            var chars = new char[input.Length];
            for (int i = 0; i < input.Length; i++) {
                s = input[i] + 2 + (i * 4);
                chars[i] = (char) s;
            }
            return new string (chars);
        }

        public static void Coder () {
            System.Console.WriteLine (@"what do you want ? encode a string or decode one
for encoder Enter e :
for decoder Enter d :");

            var input = System.Console.ReadLine ().ToLower ();
            switch (input) {
                case "e":
                    System.Console.WriteLine ("Enter the Word : ");
                    var encode = System.Console.ReadLine ();
                    System.Console.WriteLine ($"The Secret code is : {EnCoder(encode)}");
                    break;

                case "d":
                    System.Console.WriteLine ("Enter the Secret code : ");
                    var decode = System.Console.ReadLine ();
                    System.Console.WriteLine ($"The word is : {DeCoder(decode)}");
                    break;

                default:
                    System.Console.WriteLine ("Invalid");
                    break;
            }

        }
    }
}