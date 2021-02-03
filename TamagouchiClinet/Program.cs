using System;

namespace TamagouchiClinet
{
    class Program
    {
        static void Main(string[] args)
        {
            UIMain ui = new UIMain(new OpenScreen());
            ui.ApplicationStart();

        }
    }
}
