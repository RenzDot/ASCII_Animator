using System;
using System.Collections.Generic;
using System.Text;

namespace ASCII_Animator
{
    class Program {
        static void Main(string[] args) {
            List<string> frames;

            for (int i = 0; true; i++) {
                frames = (new Twerk()).GetFrames();
                i = i % frames.Count;
                string frame = frames[i];
                frame = frame.Replace(@"\n", Environment.NewLine);

                Console.Clear();
                Console.Write(frame + $"\n\n Frame: {i + 1}");
                var key = Console.ReadKey();
            }
        }
    }

    public class Twerk : Anime {
        public Twerk() {
            SetFrames(new List<string> {
                @"\n    :-.\n  .+###+.\n.=_ :+: _=.\n   .+++.\n  :#   #;\n =+     +=\n",
                @"\n    :-.\n  .+###+.\n.=_ :+: _=.\n   .++.\n  :#  #;\n =+    +=\n",
                @"\n    :-.\n  .+###+.\n.=_ :+. _=.\n    ++.\n  :#  #;\n =+    +=\n",
                @"\n    :-.\n  .+###+.\n.=_ +++ _=.\n   .++.\n  :#  #;\n =+    +=\n",
                @"\n    :-.\n  .+###+.\n.=_ :+: _=.\n   .+++.\n  :#   #;\n =+     +=\n",
                @"\n    :-.\n  .+###+.\n.=_ :+: _=.\n    .++.\n  :#  #;\n =+    +=\n",
                @"\n    :-.\n  .+###+.\n.=_ +:: _=.\n    .++.\n  :#   #;\n =+    +=\n",
                @"\n    :-.\n  .+###+.\n.=_ +:: _=.\n    .++.\n  :#  #;\n =+    +=\n" 
            });
        }
    }

    public class Nyan : Anime {
        public Nyan() {
            SetFrames(new List<string> {
                @"\n  \n      .  .\n     ( 'w')\n \n",
                @"\n  \n     .   .\n     ( 'w')\n \n",
            });
        }
    }

    public class AmongUs: Anime {
        public AmongUs() {
            SetFrames(new List<string> {
            @"    __\n .`:__:\n|X:::::\n'x;::::\n   V  >",
            @"\n    __\n .`:__:\n|X:::::\n'x;::::\n   `||",
            @"    __\n .`:__:\n|X:::::\n'x;::::\n  /  `>",
            @"\n    __\n .`:__:\n|X:::::\n'x;::::\n   '||"
        });
        }
    }

    public class Duratech : Anime {
        public Duratech() {
            SetFrames(new List<string> {
            @"\n':        '\n':        '\n':        '\n\n",
            @"\n' ::      '\n' ::      '\n' ::      '\n  |:\n   '",
            @"\n'  ::     '\n'  :!     '\n'  :!     '\n   :!\n   '!",
            @"\n'   :::   '\n'   ! !   '\n'   ! !   '\n    ! !\n    ! !",
            @"\n'     ::  '\n'     !:  '\n'     !:  '\n      !:\n      !'",
            @"\n'      :: '\n'      :: '\n'      :: '\n       :|\n       '",
            @"\n'       ::'\n'       ::'\n'       ::'\n        |\n",
            @"\n'      :::'\n'      :::'\n'      :::'\n       :|\n       '",
            @"\n'     ::::'\n'     !:::'\n'     !:::'\n      !:|\n      !'",
            @"\n'    :::::'\n'     !:::'\n'     !:::'\n      !:|\n      !'",
            @"\n'   ::::::'\n'   ! !:::'\n'   ! !:::'\n    ! !:|\n    ! !'",
            @"\n'  :::::::'\n'  :! !:::'\n'  :! !:::'\n   :! !:|\n   '! !'",
            @"\n' ::::::::'\n' ::! !:::'\n' ::! !:::'\n  |:! !:|\n   '! !'",
            @"\n':::::::::'\n':::! !:::'\n':::! !:::'\n  |:! !:|\n   '! !'",
            @"\n':::::::: '\n':::! !:: '\n':::! !:: '\n  |:! !:|\n   '! !'",
            @"\n':::::::  '\n':::! !:  '\n':::! !:  '\n  |:! !:\n   '! !'",
            @"\n':::::    '\n':::!     '\n':::!     '\n  |:!\n   '!",
            @"\n':::      '\n':::      '\n':::      '\n  |:\n   '",
            @"\n'::       '\n'::       '\n'::       '\n  |\n"
        });
        }
    }

    public class Rain : Anime {
        public Rain() {
            SetFrames(new List<string> {
            @"\n|      |\n    |\n    |   | |\n|  |\n----*--*---",
            @"\n|         |\n|      |\n    |\n    |   | |\n*--*-------",
            @"\n   |   ||\n|         |\n|      |\n    |\n----*---*-*",
            @"\n      |   |\n   |   ||\n|         |\n|      |\n----*------",
            @"\n     |\n      |   |\n   |   ||\n|         |\n*------*---",
            @"\n          |\n     |\n      |   |\n   |   ||\n*---------*",
            @"\n     |\n          |\n     |\n      |   |\n---*---**--",
            @"\n  |\n     |\n          |\n     |\n------*---*",
            @"\n    |     |\n  |\n     |\n          |\n-----*-----",
            @"\n      |  |\n    |     |\n  |\n     |\n----------*",
            @"\n|        |\n      |  |\n    |     |\n  |\n-----*-----",
            @"\n   |   ||\n|        |\n      |  |\n    |     |\n--*--------",
            @"\n  | |\n   |   ||\n|        |\n      |  |\n----*-----*",
            @"\n    |  |\n  | |\n   |   ||\n|        |\n-----*---*-",
            @"\n\n    |  |\n  | |\n   |   ||\n*--------*-",
            @"\n    |   | |\n|  |\n    |  |\n  | |\n---*---**--",
            @"\n    |\n    |   | |\n|  |\n    |  |\n--*-*------"
        });
        }
    }

    public class Pick : Anime {
        public Pick() {
            SetFrames(new List<string> {
            @"\n\n  o\n <|\ :;:;\n / \ :;:;\n",
            @"\n\n   o\\n  ./':;:;\n  /| :;:;\n",
            @"\n\n   o  +S\n  ./=);:;\n  /| :;:;\n",
            @"\n      +S\n  o\n <|\ :;:;\n / \ :;:;\n"
        });
        }
    }

    public class LiftOff : Anime {
        SetFrames(new List<string> {
            @"\n |T|T|T|\n \  :  /\n    '\n   !|!\n   |!|",
            @"\n |T|T|T|\n \  .  /\n   .:.\n   |!|\n   !|!"
        };

        public LiftOff() { }
    }

    public class Fire : Anime {
        SetFrames(new List<string> {
            @"\n      .\n     *\n    ,&+\n   x&@%x\n  ==---==",
            @"\n     . '\n    ':'\n    *%a\n   x%.@x\n  ==---==",
            @"\n   . *\n    .&*\n     @\n   x.*,x\n  ==---==",
            @"\n   '.*,\n     s\n     .\n   x+&*x\n  ==---==",
            @"\n    ',\n     .\n     *\n   xd%Bx\n  ==---=="
        };

        public Fire() { }
    }

    public class Yoda : Anime {
        SetFrames(new List<string> {
            @"\n    __\n\`_    _-'/\n ` . .  /\n _\ -  /_\n/\ ,,, / \",
            @"\n    __\n |`_  _-'/\n ` . .  /\n _\ -  /_\n/\ ,,, / \",
            @"\n    __\n |`_   _-'/\n ` . .  /\n _\ -  /_\n/\ ,,, / \",
            @"\n    __\n\`_    _-'/\n ` . .  /\n _\ -  /_\n/\ ,,, / \",
            @"\n    __\n\`_    _-'/\n ` . .  /\n _\ -  /_\n/\ ,,, / \",
            @"\n    __\n\`.    .-'/\n ` . .  /\n _\ -  /_\n/\ ,,, / \",
            @"\n    __\n\`_    _-'/\n ` . .  /\n _\ -  /_\n/\ ,,, / \",
            @"\n    __\n\`_    _-'/\n ` . .  /\n _\ -  /_\n/\ ,,, / \",
            @"\n    __\n |`_   -'/\n ` . .  /\n _\ -  /_\n/\ ,,, / \",
            @"\n    __\n |`_   _-'/\n ` . .  /\n _\ -  /_\n/\ ,,, / \",
            @"\n    __\n\`_    _-'/\n ` . .  /\n _\ -  /_\n/\ ,,, / \"
        };

        public Yoda() { }
    }

    public class Pacman : Anime {
        SetFrames(new List<string> {
            @"\n\n\n  ( . . . .\n\n",
            @"\n\n\n  <. . . *\n\n",
            @"\n\n\n  - . . * .\n\n",
            @"\n\n\n  <. . * .\n\n",
            @"\n\n\n  ( . * . .\n\n",
            @"\n\n\n  <. * . .\n\n",
            @"\n\n\n  - * . . .\n\n",
            @"\n\n\n  <* . . .\n\n",
            @"\n\n   .\n  ( . . . .\n\n",
            @"\n\n    '\n  <. . . .\n\n",
            @"\n\n   +100\n  - . . . .\n\n",
            @"\n    +100\n\n  <. . . .\n\n",
            @"\n       +100\n\n  ( . . .\n\n",
            @"\n         +1\n\n  <. . .\n\n",
            @"\n\n\n  - . .   .\n\n",
            @"\n\n\n  <. .   .\n\n",
            @"\n\n\n  ( .   . .\n\n",
            @"\n\n\n  <.   . .\n\n",
            @"\n\n\n  -   . . .\n\n",
            @"\n\n\n  <  . . .\n\n"
        };

        public Pacman() { }
    }

    public class Magic : Anime {
        SetFrames(new List<string> {
            @"\n   \n   *\n O_|\n/| |\n/ \|",
            @"\n   \n   *\n O_|\n(| |\n/ \|",
            @"\n   \n   *\n O_|\n |\|\n/ \|",
            @"\n  * \n   \\n O/_\\n |   \\n/ \ ",
            @"\n\n-----\n\O)\n |\n/ \",
            @"\n   `*  -\n    | `\n O/_|\n |  |\n/ \",
            @"\n    | \\n  < * - .__\n O_/  `\n(|/ \n/ \",
            @"\n   . .\n  - * -___\n O_/'     \\n(|/       |\n/ \",
            @"\n\n    *\n O_/\n(|/ \n/ \     _\_",
            @"\n\n    *\n O_/\n(|/    - ..\n/ \    '___",
            @"\n\n    *\n O_/ _   .\n(|/    `   `\n/ \     ___",
            @"\n\n   *     . '\n O_| `\n/| |\n/ \|     _",
            @"\n         .\n   *\n O_|\n/| |\n/ \|"
        };

        public Magic() { }
    }

    public class Skate : Anime {
        SetFrames(new List<string> {
            @"\n    _ O\n   / /\/\n __ /\__ __\n   /  \\n  LOL LOL",
            @"\n     _O\n   / /|_\n_ __ |_ __\n    /|\n   LLOL",
            @"\n      O\n     /_\n __ _|\__ _\n    / |\n   LOLLOL",
            @"\n    _ O\n   / /\/\n_ _ /\_ _\n   /  \\n  LOL LOL"
        };

        public Skate() { }
    }

    public class Monke : Anime {
        SetFrames(new List<string> {
            @"\n  _ _\nC(o.o)3\n /{-}\\n\     /   .\n C   O __/",
            @"\n  _ _\nC(._.)3\n /{-}\\n\     /  .\n C   O __/",
            @"\n  _ _\nC(._.)3\n /{-}\\n \   /  .\n  C ) -__}",
            @"\n  _ _\nC(._.)3\n /{-}\\n \   /   .\n  ( > -__/",
            @"\n  _ _\nC(._.)3\n /{-}\\n \   /    .\n  C ) -__/",
            @"\n  _ _\nC(o_o)3\n /{-}\\n \   /    .\n  ( > -__/",
            @"\n  _ _\nC(o_o)3\n /{-}\\n \   /   .\n  C ) -__/",
            @"\n  _ _\nC(o_O)3\n /{O}\\n \   /  .\n  C ) -__}",
            @"\n  _ _\nC(o_O)3\n /{.}\\n \   /   .\n  C ) -__/",
            @"\n  _ _\nC(o_O)3\n /{O}\\n \   /    .\n  C ) -__/",
            @"\n  _ _\nC(o_O)3\n /{.}\\n \   /   .\n  C ) -__/",
            @"\n  _ _\nC(o_O)3\n /{.}\\n\     / .\n C   O __}",
            @"\n  _ _\nC(o.o)3\n /{-}\\n\     /  .\n C   O __/",
            @"\n  _ _\nC(o.o)3\n /{-}\\n\     /   .\n C   O __/",
            @"\n  _ _\nC(o.o)3\n /{-}\\n\     /  .\n C   O __/",
            @"\n  _ _\nC(o.o)3\n /{-}\\n\     / .\n C   O __}",
            @"\n  _ _\nC(o.o)3\n /{-}\\n\     /  .\n C   O __/"
        };
        public Monke() { }
    }
    interface IAnime { }
    public class Anime : IAnime {
        protected List<string[]> lines;
        protected List<string> frames;

        public Anime() {}

        public List<string> GetFrames() {
            if (lines == null || lines.Count == 0) { return frames;  }
            frames = new List<string>() { };
            var segment = new StringBuilder();
            foreach (var frame in lines) {
                segment.Clear();
                foreach (var line in frame) {
                    segment.Append(line);
                }
                frames.Add(segment.ToString());
            }

            return frames;
        }

        public void SetFrames(List<string> frames) {
            this.frames = frames;
        }
    }

    public class Text : Anime {
        public Text() {
            var cut = new List<string>();

            for (int i = 0; i < frames.Count; i++) {
                frames[i].Substring(0, frames[i].Length-2);
            }
        }

        public List<string> cygnet_reverse = new List<string>() {
            @". . .-. .-.  .-. --.   . :-. . . -.- .-. . . --. .  . . . .-.   . \-. \ ! .-.  .  .-. .^. .^.^. .  .  .  \--",
            @"|-|  >|   | {  |  -|  -| ''| |-|  |  | '  >|   | |/\| |\| | | .-| |`| .`| `-.  |  | | | | | ! |  )(   !   \ ",
            @"'-' '-' '-'  `-' --' --' '-' ' ' -'- '   ' '   ' '  ' ' ' '-' '-' '-' '-' `-' -'- ' '     '   ' '  ' / \ --\"
        };

        public List<string> Fuzzy_reverse = new List<string>() {
            @".-..-.   .---.   .--.   .---.    .--.   .---.    .--.   .-..-.  .-.     .-.  .-..-.  .-.     .-..-.  .-..-.   .--.   .---.    .--.   .---.    .--.   .-----.  .-..-.  .-..-.  .-.   .-.  .-..-.  .-..-.  .----.",
            @": :: :  : '; :   --'  : .  :  : .--'  : .--'  : .--'  : :; :  : :     : :  : :' ;  : :     : `' :  : `: :  : ,. :  : .; :  : ,. :  : .; :  : .--'  `-. .-'  : :: :  : :: :  : :.-.: :  : `' :  : :: :  `--. :",
            @":    :  .'   :  :  : :  : :: :  : `;    : `;    : : _   :    :  : :   _ : :  :   '   : :     : .. :  : .` :  : :: :  :  _.'  : :: :  :   .'  `. `.     : :    : :: :  : :: :  : :: :: :   `  '   `.  .'    ,','",
            @": '; :  : '; :  :  : :  : :; :  : :__   : :     : :; :  : :: :  : :  : :; :  : :.`.  : :__   : :; :  : :. :  : :; :  : :     : :;_:  : :.`.   _`, :    : :    : :; :  : `' ;  : `' `' ;  .'  `.   .' ;   .'.'_ ",
            @" '--'    '---'  `.__.'  :___.'  `.__.'  :_;     `.__.'  :_;:_;  :_;  `.__.'  :_;:_;  :___.'  :_;:_;  :_;:_;  `.__.'  :_;     `._:_;  :_;:_;  `.__.'    :_;    `.__.'   `.,'    `.,`.,'   :_;:_;  :_,'    :____;"
        };

        public List<string> Fuzzy = new List<string>() {
            @" .--.   .---.    .--.   .---.    .--.   .---.    .--.   .-..-.  .-.     .-.  .-..-.  .-.     .-..-.  .-..-.   .--.   .---.    .--.   .---.    .--.   .-----.  .-..-.  .-..-.  .-.   .-.  .-..-.  .-..-.  .----.",
            @": .; :  : .; :  : .--'  : .  :  : .--'  : .--'  : .--'  : :; :  : :     : :  : :' ;  : :     : `' :  : `: :  : ,. :  : .; :  : ,. :  : .; :  : .--'  `-. .-'  : :: :  : :: :  : :.-.: :  : `' :  : :: :  `--. :",
            @":    :  :   .'  : :     : :: :  : `;    : `;    : : _   :    :  : :   _ : :  :   '   : :     : .. :  : .` :  : :: :  :  _.'  : :: :  :   .'  `. `.     : :    : :: :  : :: :  : :: :: :   `  '   `.  .'    ,','",
            @": :: :  : .; :  : :__   : :; :  : :__   : :     : :; :  : :: :  : :  : :; :  : :.`.  : :__   : :; :  : :. :  : :; :  : :     : :;_:  : :.`.   _`, :    : :    : :; :  : `' ;  : `' `' ;  .'  `.   .' ;   .'.'_ ",
            @":_;:_;  :___.'  `.__.'  :___.'  `.__.'  :_;     `.__.'  :_;:_;  :_;  `.__.'  :_;:_;  :___.'  :_;:_;  :_;:_;  `.__.'  :_;     `._:_;  :_;:_;  `.__.'    :_;    `.__.'   `.,'    `.,`.,'   :_;:_;  :_,'    :____;"
        };

        public List<string> shimrod = new List<string>() {
            @" ,.    ,-.     ,-.   ,-.    ,--.   ,--.    ,-.   .  .   ,    ,   ,  ,   ,      .   ,   .  .    ,-.    ;-.     ,-.     ,-.     ,-.    ,---.   .  .   .   ,   ,   .   .   ,   .   ,   ,---, ",
            @"/  \   |  )   /      |  \   |      |      /      |  |   |    |   | /    |      |\ /|   |\ |   /   \   |  )   /   \    |  )   (   `     |     |  |   |  /    | . |    \ /     \ /       /  ",
            @"|--|   |-<    |      |  |   |-     |-     | -.   |--|   |    |   |<     |      | V |   | \|   |   |   |-'    |   |    |-<     `-.      |     |  |   | /     | ) )     X       Y       /   ",
            @"|  |   |  )   \      |  /   |      |      \  |   |  |   |    |   | \    |      |   |   |  |   \   /   |      \   X    |  \   .   )     |     |  |   |/      |/|/     / \      |      /    ",
            @"'  '   `-'     `-'   `-'    `--'   '       `-'   '  '   '   -'   '  `   `--'   '   '   '  '    `-'    '       `-' `   '  '    `-'      '     `--`   '       ' '     '   `     '     '---' "
        };

        public List<string> cygnet = new List<string>() {
            @"  .    .-.   .-  .-.  .--  .--  .-.  . .  -.-  .-.  . .  .    .  .  . .  .-.  .-.  .-.  .-.  .-.  ---  . .  . .  .  .  . .  . .  --.",
            @" /-\   |<   (    | :  |-   |-   |-.  |-|   |     ;  |<   |    |\/|  |\|  | |  |-'  |.|  |-'  `-.   |   | |  | |  |/\|   x    Y    / ",
            @"'   '  '-'   `-  '-'  '--  '    '-'  ' '  -'-  `'   ' `  '-'  '  '  ' '  `-'  '    `-`  '`-  `-'   '   `-'   `   '  '  ' '   '   '--"
        };

        public List<string> tinker = new List<string>() {
            @"  O   o--o    o-o o-o   o--o o--o  o-o  o  o o-O-o     o o  o o     o   o o   o  o-o  o--o   o-o  o--o   o-o  o-O-o o   o o   o o       o o   o o   o o---o",
            @" / \  |   |  /    |  \  |    |    o     |  |   |       | | /  |     |\ /| |\  | o   o |   | o   o |   | |       |   |   | |   | |       |  \ /   \ /     / ",
            @"o---o O--o  O     |   O O-o  O-o  |  -o O--O   |       | OO   |     | O | | \ | |   | O--o  |   | O-Oo   o-o    |   |   | o   o o   o   o   O     O    -O- ",
            @"|   | |   |  \    |  /  |    |    o   | |  |   |   \   o | \  |     |   | |  \| o   o |     o   O |  \      |   |   |   |  \ /   \ / \ /   / \    |    /   ",
            @"o   o o--o    o-o o-o   o--o o     o-o  o  o o-O-o  o-o  o  o O---o o   o o   o  o-o  o      o-O\ o   o o--o    o    o-o    o     o   o   o   o   o   o---o"
        };


    }
}
