using System;

namespace Zadatak01
{
    public class URC : IRemoteControllable
    {
        public void SwitchOn() => Console.WriteLine("Pushing my buttons.");
        public void SwitchOff() => Console.WriteLine("Pulling my plug.");
        public void VolumeUp() => Console.WriteLine("Going up.");
        public void VolumeDown() => Console.WriteLine("Falling Down.");
    }
}