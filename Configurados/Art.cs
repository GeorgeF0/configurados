﻿using System;

namespace Configurados
{
    public class Art
    {
        private const string Logo = @"
                /||\
                ||||
                ||||
                |||| /|\
           /|\  |||| |||    ____  ___  _   _ _____ ___ ____ _   _ ____     _    ____   ___  ____  
           |||  |||| |||   / ___|/ _ \| \ | |  ___|_ _/ ___| | | |  _ \   / \  |  _ \ / _ \/ ___| 
           |||  |||| |||  | |   | | | |  \| | |_   | | |  _| | | | |_) | / _ \ | | | | | | \___ \ 
           |||  |||| d||  | |___| |_| | |\  |  _|  | | |_| | |_| |  _ < / ___ \| |_| | |_| |___) |
           |||  |||||||/   \____|\___/|_| \_|_|   |___\____|\___/|_| \_|_/   \_\____/ \___/|____/ 
           ||b._||||~~'
           \||||||||
            `~~~||||
                ||||
                ||||
~~~~~~~~~~~~~~~~||||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
  \/..__..--  . |||| \/  .  ..      \/..__..--  .  \/  .  ..      \/ ..      \/     \/..__..--  . 
\/         \/ \/    \/            \/         \/ \/\/            \/         \/     \/         \/ \/
        .  \/              \/    .        .  \/          \/    .    \/    .      .        .  \/   
. \/             .   \/     .     . \/             \/     .     . \/ .     . \/   . \/            
   __...--..__..__       .     \/    __...--..__..     .     \/    _    \/    _\/    __...--..__..
\/  .   .    \/     \/    __..--..\/  .   .    \/ \/    __..--..\/  _..--..\/  -..\/  .   .    \/  
";
        private const string ColorCodedLogo = @"
          $g      /||\
          $g      ||||
          $g      ||||
          $g      |||| /|\
          $g /|\  |||| |||  $y  ____  ___  _   _ _____ ___ ____ _   _ ____     _    ____   ___  ____  
          $g |||  |||| |||  $y / ___|/ _ \| \ | |  ___|_ _/ ___| | | |  _ \   / \  |  _ \ / _ \/ ___| 
          $g |||  |||| |||  $y| |   | | | |  \| | |_   | | |  _| | | | |_) | / _ \ | | | | | | \___ \ 
          $g |||  |||| d||  $y| |___| |_| | |\  |  _|  | | |_| | |_| |  _ < / ___ \| |_| | |_| |___) |
          $g |||  |||||||/  $y \____|\___/|_| \_|_|   |___\____|\___/|_| \_|_/   \_\____/ \___/|____/ 
          $g ||b._||||~~'
          $g \||||||||
          $g  `~~~||||
          $g      ||||
          $g      ||||
$y~~~~~~~~~~~~~~~~$g||||$y~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
$Y  \/..__..--  . $g||||$Y \/  .  ..      \/..__..--  .  \/  .  ..      \/ ..      \/     \/..__..--  . 
$Y\/         \/ \/    \/            \/         \/ \/\/            \/         \/     \/         \/ \/
$Y        .  \/              \/    .        .  \/          \/    .    \/    .      .        .  \/   
$Y. \/             .   \/     .     . \/             \/     .     . \/ .     . \/   . \/            
$Y   __...--..__..__       .     \/    __...--..__..     .     \/    _    \/    _\/    __...--..__..
$Y\/  .   .    \/     \/    __..--..\/  .   .    \/ \/    __..--..\/  _..--..\/  -..\/  .   .    \/  
";

        public static void PrintLogo()
        {
            for (var i = 0; i < ColorCodedLogo.Length; i++)
            {
                if (ColorCodedLogo[i] == '$')
                {
                    SwitchColor(ColorCodedLogo[++i]);
                    continue;
                }

                if (ColorCodedLogo[i] == '\n') Console.ResetColor();

                Console.Write(ColorCodedLogo[i]);
            }
        }

        private static void SwitchColor(char c)
        {
            switch (c)
            {
                case 'g':
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 'y':
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 'Y':
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
            }
        }
    }
}