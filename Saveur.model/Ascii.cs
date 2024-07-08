using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saveur.model
{
    public static class Ascii
    {
        public static void king()
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine(@"                
                   / \
                  _\ /_
        .     .  (,'v`.)  .     .
        \)   ( )  ,' `.  ( )   (/
         \`. / `-'     `-' \ ,'/
          : '    _______    ' :
          |  _,-'  ,-.  `-._  |
          |,' ( )__`-'__( ) `.|
          (|,-,'-._   _.-`.-.|)
          /  /<( o)> <( o)>\  \
          :  :     | |     :  :
          |  |     ; :     |  |
          |  |    (.-.)    |  |
          |  |  ,' ___ `.  |  |
          ;  |)/ ,'---'. \(|  :
      _,-/   |/\(       )/\|   \-._
_..--'.-(    |   `-'''-'   |    )-.`--.._
         `.  ;`._________,':  ,'
        ,' `/               \'`.
             `------.------'   ");
        }

        public static void Camp()
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine(@"     
           (                 ,&&&.
            )                .,.&&
           (  (              \=__/
               )             ,'-'.
         (    (  ,,      _.__|/ /|
          ) /\ -((------((_|___/ |
        (  // | (`'      ((  `'--|
      _ -.;_/ \\--._      \\ \-._/.
     (_;-// | \ \-'.\    <_,\_\`--'|
     ( `.__ _  ___,')      <_,-'__,'
      `'(_ )_)(_)_)'                    ");
        }


        public static void Garden() 
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine(@" 
                                        E   _
                                         \  o
                .|.:.|.:.|.:.|.:.|.:.|.   \/()
             \cjr//\/'.'.'.'.'.'.\//\\//\/ \7] \__,
          \/\\//\\/'.'.'.'.'.'.'.'\//\\//\/<,] /==()
        .:.|.:.|.:.|.:.|.:.|.:.|.:.|.:.|.:.|.");
        }


        public static void dodo()
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine(@" 
                              z
                             z
                              Z
                    .--.  Z Z
                   / _(c\   .-.     __
                  | / /  '-;   \'-'`  `\______
                  \_\/'/ __/ )  /  )   |      \--,
                  | \`""`__-/ .'--/   /--------\  \
                   \\`  ///-\/   /   /---;-.    '-'
                                (________\  \
                                          '-' ");
        }
    }
}
