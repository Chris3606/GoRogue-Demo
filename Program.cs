using GoRogue;
using RLNET;

namespace GoRogue_Demo
{
    class Program
    {
        // Initialize "root console" -- the main window of the game.
        public static RLRootConsole RootConsole = new RLRootConsole("terminal8x8.png", 50, 50, 8, 8, 1f, "GoRogue Demo");

        static void Main(string[] args)
        {
            // The root console's Update event is triggered once per frame,
            // followed by the root console's Render event.  Here, we add the
            // functions we would like to run upon each of those events happening.
            RootConsole.Update += rootConsole_Update;
            RootConsole.Render += rootConsole_Render;

            // Start the main window.
            RootConsole.Run();
        }

        static void rootConsole_Update(object sender, UpdateEventArgs e)
        {
            //Update Logic Here
        }

        static void rootConsole_Render(object sender, UpdateEventArgs e)
        {
            RootConsole.Clear();
            // Test GoRogue
            Coord c = Coord.Get(1, 1);
            RootConsole.Print(c.X, c.Y, "Hello World!", RLColor.White);
            RootConsole.Draw();
        }

    }
}