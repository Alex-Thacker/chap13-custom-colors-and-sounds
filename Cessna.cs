using System;

namespace customcolorsandsounds {
    public class Cessna : Vehicle {
    public override void Drive() {
        Console.WriteLine("the blue car goes");
    }
    public override void Turn(string direction) {
        Console.WriteLine($"{direction} = {direction} i hope");
    }
    public override void Stop() {
        Console.WriteLine("what is a cessna?");
    }
    }
}