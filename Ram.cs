using System;

namespace customcolorsandsounds {
    public class Ram : Vehicle {
    public override void Drive() {
        Console.WriteLine("the green car goes");
    }
    public override void Turn(string direction) {
        Console.WriteLine($"{direction}");
    }
    public override void Stop() {
        Console.WriteLine("truck");
    }
    }
}