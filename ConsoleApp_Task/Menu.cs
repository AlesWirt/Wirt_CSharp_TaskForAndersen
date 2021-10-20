using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Task
{
    public class Menu
    {
        private int _selectedIndex;
        private string[] _options;

        public Menu(string[] options)
        {
            _options = options;
        }

        private void DisplayOptions()
        {
            string prefix;
            string currentOption;
            for(int i = 0; i < _options.Length; i++)
            {
                currentOption = _options[i];
                if(i == _selectedIndex)
                {
                    prefix = "*";
                    BackgroundColor = ConsoleColor.White;
                    ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    prefix = " ";
                    BackgroundColor = ConsoleColor.Black;
                    ForegroundColor = ConsoleColor.White;
                }
                WriteLine($"{prefix} <<{currentOption}>>");
            }
            ResetColor();
        }

        public int RunMenu()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    _selectedIndex--;
                    if (_selectedIndex == -1)
                    {
                        _selectedIndex = _options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    _selectedIndex++;
                    if (_selectedIndex == _options.Length)
                    {
                        _selectedIndex = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);
            return _selectedIndex;
        }
    }
}
