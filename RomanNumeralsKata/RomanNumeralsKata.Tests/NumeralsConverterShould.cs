using NUnit.Framework;
using Should;
using RomanNumeralsKata;

namespace RomanNumeralsKata.Tests
{
    [TestFixture]
    public class NumeralsConverterShould
    {
        [Test]
        public void Convert_1_to_I()
        {
            var romanNumeralsConverter = new NumeralsConverter();

            string romanNumeral = romanNumeralsConverter.ConvertToRoman(1);

            romanNumeral.ShouldEqual("I");
        }

        [Test]
        public void Convert_2_to_II()
        {
            var romanNumeralsConverter = new NumeralsConverter();

            string romanNumeral = romanNumeralsConverter.ConvertToRoman(2);

            romanNumeral.ShouldEqual("II");
        }

        [Test]
        public void Convert_3_to_III()
        {
            var romanNumeralsConverter = new NumeralsConverter();

            string romanNumeral = romanNumeralsConverter.ConvertToRoman(3);

            romanNumeral.ShouldEqual("III");
        }

        [Test]
        public void Convert_4_to_IV()
        {
            var romanNumeralsConverter = new NumeralsConverter();

            string romanNumeral = romanNumeralsConverter.ConvertToRoman(4);

            romanNumeral.ShouldEqual("IV");
        }

        [Test]
        public void Convert_5_to_V()
        {
            var romanNumeralsConverter = new NumeralsConverter();

            string romanNumeral = romanNumeralsConverter.ConvertToRoman(5);

            romanNumeral.ShouldEqual("V");
        }

        [Test]
        public void Convert_6_to_VI()
        {
            var romanNumeralsConverter = new NumeralsConverter();

            string romanNumeral = romanNumeralsConverter.ConvertToRoman(6);

            romanNumeral.ShouldEqual("VI");
        }

        [Test]
        public void Convert_9_to_IX()
        {
            var romanNumeralsConverter = new NumeralsConverter();

            string romanNumeral = romanNumeralsConverter.ConvertToRoman(9);

            romanNumeral.ShouldEqual("IX");
        }

        [Test]
        public void Convert_10_to_X()
        {
            var romanNumeralsConverter = new NumeralsConverter();

            string romanNumeral = romanNumeralsConverter.ConvertToRoman(10);

            romanNumeral.ShouldEqual("X");
        }

        [Test]
        public void Convert_50_to_L()
        {
            var romanNumeralsConverter = new NumeralsConverter();

            string romanNumeral = romanNumeralsConverter.ConvertToRoman(50);

            romanNumeral.ShouldEqual("L");
        }

        [Test]
        public void Convert_100_to_C()
        {
            var romanNumeralsConverter = new NumeralsConverter();

            string romanNumeral = romanNumeralsConverter.ConvertToRoman(100);

            romanNumeral.ShouldEqual("C");
        }

        [Test]
        public void Convert_500_to_D()
        {
            var romanNumeralsConverter = new NumeralsConverter();

            string romanNumeral = romanNumeralsConverter.ConvertToRoman(500);

            romanNumeral.ShouldEqual("D");
        }

        [Test]
        public void Convert_1000_to_M()
        {
            var romanNumeralsConverter = new NumeralsConverter();

            string romanNumeral = romanNumeralsConverter.ConvertToRoman(1000);

            romanNumeral.ShouldEqual("M");
        }
    }
}
