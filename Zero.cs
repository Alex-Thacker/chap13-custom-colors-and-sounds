using System;

namespace customcolorsandsounds {
    public class Zero : Vehicle {
    public override void Drive() {
        Console.WriteLine($"the {MainColor} car goes");
    }
    public override void Turn(string direction) {
        Console.WriteLine($"you need to turn this way: {direction}");
    }
    public override void Stop() {
        Console.WriteLine("this is a new stop message for the zero class");
    }
    }
}
