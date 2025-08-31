using System;
using Xunit;
using System.Collections.Generic;
using ConsoleApp5;

namespace TestProject
{
    public class ColoredObjectTests
    {
        [Fact]
        public void ToChar_RedColor_Returns_K()
        {
            var obj = new ColoredObject { Color = ColoredObject.ColorEnum.Red }; //arrange

            var result = obj.ToChar();                                           //act

            Assert.Equal('Ê', result);                                           //assert

        }

        [Fact]
        public void ToChar_GreenColor_Returns_Z()
        {
            var obj = new ColoredObject { Color = ColoredObject.ColorEnum.Green };

            var result = obj.ToChar();                                           

            Assert.Equal('Ç', result);
        }

        [Fact]
        public void ToChar_BlueColor_Returns_S()
        {
            var obj = new ColoredObject { Color = ColoredObject.ColorEnum.Blue };

            var result = obj.ToChar();

            Assert.Equal('Ñ', result);
        }

        [Fact]
        public void ToString_RedColor_Returns_K()
        {
            var obj = new ColoredObject { Color = ColoredObject.ColorEnum.Red };

            var result = obj.ToString();

            Assert.Equal("Ê", result);
        }
        [Fact]
        public void ToString_GreenColor_Returns_Z()
        {
            var obj = new ColoredObject { Color = ColoredObject.ColorEnum.Green};

            var result = obj.ToString();

            Assert.Equal("Ç", result);
        }
        [Fact]
        public void ToString_BlueColor_Returns_S()
        {
            var obj = new ColoredObject { Color = ColoredObject.ColorEnum.Blue };

            var result = obj.ToString();

            Assert.Equal("Ñ", result);
        }

    }

    public class ColorSorterTests 
    {
        private readonly ColorSorter _sorter;

        public ColorSorterTests() 
        {
            _sorter = new ColorSorter();
        }

        [Fact]
        public void SortByRule_Rule1_ZSK_ReturnsZSK()
        {
            var list = new List<ColoredObject>
            {
                new() { Color = ColoredObject.ColorEnum.Green },
                new() { Color = ColoredObject.ColorEnum.Red },
                new() { Color = ColoredObject.ColorEnum.Blue },
                new() { Color = ColoredObject.ColorEnum.Blue},
                new() { Color = ColoredObject.ColorEnum.Red },
                new() { Color = ColoredObject.ColorEnum.Green },
                new() { Color = ColoredObject.ColorEnum.Green }
            };
            string rule = "Ç < Ñ < Ê";

            var result = _sorter.SortByRule(list, rule);

            Assert.Equal('Ç', result[0].ToChar());
            Assert.Equal('Ç', result[1].ToChar());
            Assert.Equal('Ç', result[2].ToChar());
            Assert.Equal('Ñ', result[3].ToChar());
            Assert.Equal('Ñ', result[4].ToChar());
            Assert.Equal('Ê', result[5].ToChar());
            Assert.Equal('Ê', result[6].ToChar());
        }

        [Fact]
        public void SortByRule_Rule2_ZKS_ReturnsZKS()
        {
            var list = new List<ColoredObject>
            {
                new() { Color = ColoredObject.ColorEnum.Green },
                new() { Color = ColoredObject.ColorEnum.Red },
                new() { Color = ColoredObject.ColorEnum.Blue },
                new() { Color = ColoredObject.ColorEnum.Blue},
                new() { Color = ColoredObject.ColorEnum.Red },
                new() { Color = ColoredObject.ColorEnum.Green },
                new() { Color = ColoredObject.ColorEnum.Green }
            };
            string rule = "Ç < Ê < Ñ";

            var result = _sorter.SortByRule(list, rule);

            Assert.Equal('Ç', result[0].ToChar());
            Assert.Equal('Ç', result[1].ToChar());
            Assert.Equal('Ç', result[2].ToChar());
            Assert.Equal('Ê', result[3].ToChar());
            Assert.Equal('Ê', result[4].ToChar());
            Assert.Equal('Ñ', result[5].ToChar());
            Assert.Equal('Ñ', result[6].ToChar());
        }

        [Fact]
        public void SortByRule_Rule3_SKZ_ReturnsSKZ()
        {
            var list = new List<ColoredObject>
            {
                new() { Color = ColoredObject.ColorEnum.Green },
                new() { Color = ColoredObject.ColorEnum.Red },
                new() { Color = ColoredObject.ColorEnum.Blue },
                new() { Color = ColoredObject.ColorEnum.Blue},
                new() { Color = ColoredObject.ColorEnum.Red },
                new() { Color = ColoredObject.ColorEnum.Green },
                new() { Color = ColoredObject.ColorEnum.Green }
            };
            string rule = "Ñ < Ê < Ç";

            var result = _sorter.SortByRule(list, rule);

            Assert.Equal('Ñ', result[0].ToChar());
            Assert.Equal('Ñ', result[1].ToChar());
            Assert.Equal('Ê', result[2].ToChar());
            Assert.Equal('Ê', result[3].ToChar());
            Assert.Equal('Ç', result[4].ToChar());
            Assert.Equal('Ç', result[5].ToChar());
            Assert.Equal('Ç', result[6].ToChar());
        }

        [Fact]
        public void SortByRule_Rule4_SZK_ReturnsSZK()
        {
            var list = new List<ColoredObject>
            {
                new() { Color = ColoredObject.ColorEnum.Green },
                new() { Color = ColoredObject.ColorEnum.Red },
                new() { Color = ColoredObject.ColorEnum.Blue },
                new() { Color = ColoredObject.ColorEnum.Blue},
                new() { Color = ColoredObject.ColorEnum.Red },
                new() { Color = ColoredObject.ColorEnum.Green },
                new() { Color = ColoredObject.ColorEnum.Green }
            };
            string rule = "Ñ < Ç < Ê";

            var result = _sorter.SortByRule(list, rule);

            Assert.Equal('Ñ', result[0].ToChar());
            Assert.Equal('Ñ', result[1].ToChar());
            Assert.Equal('Ç', result[2].ToChar());
            Assert.Equal('Ç', result[3].ToChar());
            Assert.Equal('Ç', result[4].ToChar());
            Assert.Equal('Ê', result[5].ToChar());
            Assert.Equal('Ê', result[6].ToChar());
        }

        [Fact]
        public void SortByRule_Rule5_KSZ_ReturnsKSZ()
        {
            var list = new List<ColoredObject>
            {
                new() { Color = ColoredObject.ColorEnum.Green },
                new() { Color = ColoredObject.ColorEnum.Red },
                new() { Color = ColoredObject.ColorEnum.Blue },
                new() { Color = ColoredObject.ColorEnum.Blue},
                new() { Color = ColoredObject.ColorEnum.Red },
                new() { Color = ColoredObject.ColorEnum.Green },
                new() { Color = ColoredObject.ColorEnum.Green }
            };
            string rule = "Ê < Ñ < Ç";

            var result = _sorter.SortByRule(list, rule);

            Assert.Equal('Ê', result[0].ToChar());
            Assert.Equal('Ê', result[1].ToChar());
            Assert.Equal('Ñ', result[2].ToChar());
            Assert.Equal('Ñ', result[3].ToChar());
            Assert.Equal('Ç', result[4].ToChar());
            Assert.Equal('Ç', result[5].ToChar());
            Assert.Equal('Ç', result[6].ToChar());
        }

        [Fact]
        public void SortByRule_Rule6_KZS_ReturnsKZS()
        {
            var list = new List<ColoredObject>
            {
                new() { Color = ColoredObject.ColorEnum.Green },
                new() { Color = ColoredObject.ColorEnum.Red },
                new() { Color = ColoredObject.ColorEnum.Blue },
                new() { Color = ColoredObject.ColorEnum.Blue},
                new() { Color = ColoredObject.ColorEnum.Red },
                new() { Color = ColoredObject.ColorEnum.Green },
                new() { Color = ColoredObject.ColorEnum.Green }
            };
            string rule = "Ê < Ç < Ñ";

            var result = _sorter.SortByRule(list, rule);

            Assert.Equal('Ê', result[0].ToChar());
            Assert.Equal('Ê', result[1].ToChar());
            Assert.Equal('Ç', result[2].ToChar());
            Assert.Equal('Ç', result[3].ToChar());
            Assert.Equal('Ç', result[4].ToChar());
            Assert.Equal('Ñ', result[5].ToChar());
            Assert.Equal('Ñ', result[6].ToChar());
        }

        [Fact]
        public void SortByRule_AlreadySorted_ReturnsSameOrder()
        {
            var list = new List<ColoredObject>
            {
                new() { Color = ColoredObject.ColorEnum.Green },
                new() { Color = ColoredObject.ColorEnum.Green },
                new() { Color = ColoredObject.ColorEnum.Blue },
                new() { Color = ColoredObject.ColorEnum.Blue },
                new() { Color = ColoredObject.ColorEnum.Blue },
                new() { Color = ColoredObject.ColorEnum.Red },
                new() { Color = ColoredObject.ColorEnum.Red },
                new() { Color = ColoredObject.ColorEnum.Red }
            };
            string rule = "Ç < Ñ < Ê";

            var result = _sorter.SortByRule(list, rule);

            Assert.Equal('Ç', result[0].ToChar());
            Assert.Equal('Ç', result[1].ToChar());
            Assert.Equal('Ñ', result[2].ToChar());
            Assert.Equal('Ñ', result[3].ToChar());
            Assert.Equal('Ñ', result[4].ToChar());
            Assert.Equal('Ê', result[5].ToChar());
            Assert.Equal('Ê', result[6].ToChar());
            Assert.Equal('Ê', result[7].ToChar());
        }

        [Fact]
        public void SortByRule_EmptyList_ReturnsEmptyList()
        {
            var list = new List<ColoredObject>();
            string rule = "Ç < Ñ < Ê";

            var result = _sorter.SortByRule(list, rule);

            Assert.Empty(result);
        }

        [Fact]
        public void SortByRule_SingleElement_ReturnsSameList()
        {
            var list = new List<ColoredObject>
            {
                new() { Color = ColoredObject.ColorEnum.Red }
            };
            string rule = "Ç < Ñ < Ê";

            var result = _sorter.SortByRule(list, rule);

            Assert.Single(result);
            Assert.Equal('Ê', result[0].ToChar());
        }
    }

    public class ProgramIntegrationTests
    {
        [Theory]
        [InlineData("Ç < Ñ < Ê", new[] { 'Ç', 'Ç', 'Ç', 'Ç', 'Ç', 'Ç', 'Ñ', 'Ñ', 'Ñ', 'Ñ', 'Ñ', 'Ñ', 'Ê', 'Ê', 'Ê', 'Ê' })]
        [InlineData("Ç < Ê < Ñ", new[] { 'Ç', 'Ç', 'Ç', 'Ç', 'Ç', 'Ç', 'Ê', 'Ê', 'Ê', 'Ê', 'Ñ', 'Ñ', 'Ñ', 'Ñ', 'Ñ', 'Ñ' })]
        [InlineData("Ñ < Ê < Ç", new[] { 'Ñ', 'Ñ', 'Ñ', 'Ñ', 'Ñ', 'Ñ', 'Ê', 'Ê', 'Ê', 'Ê', 'Ç', 'Ç', 'Ç', 'Ç', 'Ç', 'Ç' })]
        [InlineData("Ñ < Ç < Ê", new[] { 'Ñ', 'Ñ', 'Ñ', 'Ñ', 'Ñ', 'Ñ', 'Ç', 'Ç', 'Ç', 'Ç', 'Ç', 'Ç', 'Ê', 'Ê', 'Ê', 'Ê' })]
        [InlineData("Ê < Ñ < Ç", new[] { 'Ê', 'Ê', 'Ê', 'Ê', 'Ñ', 'Ñ', 'Ñ', 'Ñ', 'Ñ', 'Ñ', 'Ç', 'Ç', 'Ç', 'Ç', 'Ç', 'Ç' })]
        [InlineData("Ê < Ç < Ñ", new[] { 'Ê', 'Ê', 'Ê', 'Ê', 'Ç', 'Ç', 'Ç', 'Ç', 'Ç', 'Ç', 'Ñ', 'Ñ', 'Ñ', 'Ñ', 'Ñ', 'Ñ' })]
        public void ColorSorter_WithAllRules_ShouldSortCorrectly(string rule, char[] expected)
        {
            var list = new List<ColoredObject>
            {
                new() { Color = ColoredObject.ColorEnum.Blue },
                new() { Color = ColoredObject.ColorEnum.Blue },
                new() { Color = ColoredObject.ColorEnum.Green }, 
                new() { Color = ColoredObject.ColorEnum.Blue }, 
                new() { Color = ColoredObject.ColorEnum.Red }, 
                new() { Color = ColoredObject.ColorEnum.Green }, 
                new() { Color = ColoredObject.ColorEnum.Green }, 
                new() { Color = ColoredObject.ColorEnum.Green }, 
                new() { Color = ColoredObject.ColorEnum.Red }, 
                new() { Color = ColoredObject.ColorEnum.Red }, 
                new() { Color = ColoredObject.ColorEnum.Blue }, 
                new() { Color = ColoredObject.ColorEnum.Green }, 
                new() { Color = ColoredObject.ColorEnum.Blue }, 
                new() { Color = ColoredObject.ColorEnum.Blue }, 
                new() { Color = ColoredObject.ColorEnum.Red }, 
                new() { Color = ColoredObject.ColorEnum.Green } 
            };
            var sorter = new ColorSorter();

            var result = sorter.SortByRule(list, rule);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], result[i].ToChar());
            }
        }
    }
}
