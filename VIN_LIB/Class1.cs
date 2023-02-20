using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace VIN_LIB
{
    public class Class1
    {

        private static readonly List<char> VinSymbols = new List<char>
            {
              '0', '1', '2', '3', '4', '5', '6', '7', '8',
              '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
              'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T',
              'U', 'V', 'W', 'X', 'Y', 'Z'
            };
        public static Regex RegulalForVIN = new Regex(@"^[A-HJ-NPR-Za-hj-npr-z\d]{8}[\dX][A-HJ-NPR-Za-hj-npr-z\d]{2}\d{6}$");



        public static bool CheckVIN(string vin)
        {
            if (RegulalForVIN.IsMatch(vin.ToUpper()))
            {
                if (vin.ToUpper().Length != 17)
                {
                    return false;
                }

                for (int i = 0; i < 17; i++)
                {
                    int count = 0;

                    foreach (char item in VinSymbols)
                    {
                        count++;

                        if (vin.ToUpper()[i] == item)
                        {
                            break;
                        }
                    }

                    if (count == VinSymbols.Count && vin.ToUpper()[i] != VinSymbols[VinSymbols.Count - 1])
                    {
                        return false;
                    }
                }
                return true;
            }


            return false;
        }

        public static string GetVINCountry(string vin)
        {
            try
            {
                if (vin.ToUpper()[0] == 'A' || vin.ToUpper()[0] == 'B' || vin.ToUpper()[0] == 'C' || vin.ToUpper()[0] == 'D' || vin.ToUpper()[0] == 'E' || vin.ToUpper()[0] == 'F' || vin.ToUpper()[0] == 'G' || vin.ToUpper()[0] == 'H')
                {
                    return "Африка";
                }
                if (vin.ToUpper()[0] == 'J' || vin.ToUpper()[0] == 'K' || vin.ToUpper()[0] == 'L' || vin.ToUpper()[0] == 'M' || vin.ToUpper()[0] == 'N' || vin.ToUpper()[0] == 'P' || vin.ToUpper()[0] == 'R')
                {
                    return "Азия";
                }
                return vin.ToUpper()[0] == 'S' || vin.ToUpper()[0] == 'T' || vin.ToUpper()[0] == 'U' || vin.ToUpper()[0] == 'V' || vin.ToUpper()[0] == 'W' || vin.ToUpper()[0] == 'X' || vin.ToUpper()[0] == 'Y' || vin.ToUpper()[0] == 'Z'
                    ? "Европа"
                    : vin.ToUpper()[0] == '1' || vin.ToUpper()[0] == '2' || vin.ToUpper()[0] == '3' || vin.ToUpper()[0] == '4' || vin.ToUpper()[0] == '5'
                    ? "Северная Америка"
                    : vin.ToUpper()[0] == '6' || vin.ToUpper()[0] == '7'
                    ? "Океания"
                    : vin.ToUpper()[0] == '8' || vin.ToUpper()[0] == '9' ? "Южная Америка" : "Не определена информация";
            }
            catch
            {
                return "Не определена информация";
            }
        }
    }
}