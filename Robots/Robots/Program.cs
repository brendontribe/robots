using System;
using System.IO;

namespace Robots
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table(5, 5);
            Robot robot = new Robot(table);
            ExecuteAllCommands(robot);
            Console.ReadKey();
        }


        private static void ExecuteAllCommands(Robot robot)
        {
            string path = @"commands.txt";
            string[] commands = File.ReadAllLines(path);
            foreach (string command in commands)
            {
                robot.ExecuteCommand(command);
            }
        }
    }
}
