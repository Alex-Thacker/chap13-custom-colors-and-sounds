using System;

namespace customcolorsandsounds {
    public class Tesla : Vehicle {
    public override void Drive() {
        Console.WriteLine("the yellow car goes");
    }
    public override void Turn(string direction) {
        Console.WriteLine($"{direction} is what you need to do");
    }
    public override void Stop() {
        Console.WriteLine("stop yo");
    }
    }
}