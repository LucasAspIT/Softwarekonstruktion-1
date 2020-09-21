using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimering_af_kode_09 {
    class Program {
        static void Main(string[] args) {


            UnsignedData();
            Console.ReadKey();
        }
    public static void UnsignedData() {

        byte byteMax = byte.MaxValue;
        byte byteMin = byte.MinValue;

        ushort ushortMax = ushort.MaxValue;
        ushort ushortMin = ushort.MinValue;

        uint uintMax = uint.MaxValue;
        uint uintMin = uint.MinValue;

        ulong ulongMax = ulong.MaxValue;
        ulong ulongMin = ulong.MinValue;

        // Write out the values
        Console.WriteLine(
            "byte:\n" + byteMax + "\n" + byteMin + "\n\n" +
            "ushort:\n" + ushortMax + "\n" + ushortMin + "\n\n" +
            "uint:\n" + uintMax + "\n" + uintMin + "\n\n" +
            "ulong:\n" + ulongMax + "\n" + ulongMin + "\n");
        }
    }
}
