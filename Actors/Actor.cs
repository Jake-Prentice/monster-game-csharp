using System;
using System.IO;

namespace MonsterGame
{
    class Actor
    {
        public int Row {get; set;}
        public int Col {get; set;}
        public char Symbol {get; set;}
        public ConsoleColor Color {get; set;}

        public void Draw() {
            Console.CursorVisible = false;
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(Col, Row);
            Console.Write(Symbol);         
            Console.ResetColor();
        }

        public void Move(int newRow, int newCol) {
            Console.SetCursorPosition(Col, Row); 
            Console.Write(" "); //get rid of current position
            Row = newRow;
            Col = newCol;
        }

        public static bool DoesCollide(Actor actor1, Actor actor2) {
            return actor1.Row == actor2.Row && actor1.Col == actor2.Col;
        }
    }
}
