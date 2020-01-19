using System;

namespace Robots
{
    internal class Robot : Actor
    {
        public Robot(Table t) : base(t)
        {
        }

        public string Report()
        {
            string response = "Robot not yet placed";
            if (coords != null) response = String.Format("Output: {0},{1},{2}", coords.GetCol(), coords.GetRow(), facing);
            Console.WriteLine(response);
            return response;
        }

        public void ExecuteCommand(string command)
        {
            string function = command.Split(' ')[0].ToUpper();
            //Console.WriteLine(function);
            try
            {
                switch (function)
                {
                    case "PLACE":
                        string[] placementData = command.Split(' ')[1].ToUpper().Split(',');
                        int row = Int32.Parse(placementData[0]);
                        int col = Int32.Parse(placementData[1]);
                        Direction.Facing facing = Direction.GetFacing(command.Split(' ')[1].ToUpper().Split(',')[2]);
                        Place(row, col, facing);
                        break;
                    case "RIGHT":
                        Right();
                        break;
                    case "LEFT":
                        Left();
                        break;
                    case "MOVE":
                        Move();
                        break;
                    case "REPORT":
                        Report();
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                Console.WriteLine("INVALID COMMAND");
            }

        }
    }
}