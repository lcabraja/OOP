using System.Numerics;

namespace Zadatak01
{
    public class ComplexNumber
    {
        public int RealComponent { get; set; }
        public int ImaginaryComponent { get; set; }

        public ComplexNumber(int realComponent, int imaginaryComponent)
        {
            RealComponent = realComponent;
            ImaginaryComponent = imaginaryComponent;
        }

        public override string ToString() => $"{RealComponent} + {ImaginaryComponent}i";

        public override bool Equals(object obj)
            => (obj is ComplexNumber other) &&
               (other.RealComponent == RealComponent && other.ImaginaryComponent == ImaginaryComponent);

        public override int GetHashCode() => ImaginaryComponent.GetHashCode() * 31 + RealComponent.GetHashCode();
    }
}
// Objeckti su na heapu, new keyword kreira podatke na heapu
// Za objekte, na stacku se samo drzi referenca