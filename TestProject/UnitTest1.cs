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

            Assert.Equal('�', result);                                           //assert

        }

        [Fact]
        public void ToChar_GreenColor_Returns_Z()
        {
            var obj = new ColoredObject { Color = ColoredObject.ColorEnum.Green };

            var result = obj.ToChar();                                           

            Assert.Equal('�', result);
        }

        [Fact]
        public void ToChar_BlueColor_Returns_S()
        {
            var obj = new ColoredObject { Color = ColoredObject.ColorEnum.Blue };

            var result = obj.ToChar();

            Assert.Equal('�', result);
        }

        [Fact]
        public void ToString_RedColor_Returns_K()
        {
            var obj = new ColoredObject { Color = ColoredObject.ColorEnum.Red };

            var result = obj.ToString();

            Assert.Equal("�", result);
        }
        [Fact]
        public void ToString_GreenColor_Returns_Z()
        {
            var obj = new ColoredObject { Color = ColoredObject.ColorEnum.Green};

            var result = obj.ToString();

            Assert.Equal("�", result);
        }
        [Fact]
        public void ToString_BlueColor_Returns_S()
        {
            var obj = new ColoredObject { Color = ColoredObject.ColorEnum.Blue };

            var result = obj.ToString();

            Assert.Equal("�", result);
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
            string rule = "� < � < �";

            var result = _sorter.SortByRule(list, rule);

            Assert.Equal('�', result[0].ToChar());
            Assert.Equal('�', result[1].ToChar());
            Assert.Equal('�', result[2].ToChar());
            Assert.Equal('�', result[3].ToChar());
            Assert.Equal('�', result[4].ToChar());
            Assert.Equal('�', result[5].ToChar());
            Assert.Equal('�', result[6].ToChar());
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
            string rule = "� < � < �";

            var result = _sorter.SortByRule(list, rule);

            Assert.Equal('�', result[0].ToChar());
            Assert.Equal('�', result[1].ToChar());
            Assert.Equal('�', result[2].ToChar());
            Assert.Equal('�', result[3].ToChar());
            Assert.Equal('�', result[4].ToChar());
            Assert.Equal('�', result[5].ToChar());
            Assert.Equal('�', result[6].ToChar());
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
            string rule = "� < � < �";

            var result = _sorter.SortByRule(list, rule);

            Assert.Equal('�', result[0].ToChar());
            Assert.Equal('�', result[1].ToChar());
            Assert.Equal('�', result[2].ToChar());
            Assert.Equal('�', result[3].ToChar());
            Assert.Equal('�', result[4].ToChar());
            Assert.Equal('�', result[5].ToChar());
            Assert.Equal('�', result[6].ToChar());
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
            string rule = "� < � < �";

            var result = _sorter.SortByRule(list, rule);

            Assert.Equal('�', result[0].ToChar());
            Assert.Equal('�', result[1].ToChar());
            Assert.Equal('�', result[2].ToChar());
            Assert.Equal('�', result[3].ToChar());
            Assert.Equal('�', result[4].ToChar());
            Assert.Equal('�', result[5].ToChar());
            Assert.Equal('�', result[6].ToChar());
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
            string rule = "� < � < �";

            var result = _sorter.SortByRule(list, rule);

            Assert.Equal('�', result[0].ToChar());
            Assert.Equal('�', result[1].ToChar());
            Assert.Equal('�', result[2].ToChar());
            Assert.Equal('�', result[3].ToChar());
            Assert.Equal('�', result[4].ToChar());
            Assert.Equal('�', result[5].ToChar());
            Assert.Equal('�', result[6].ToChar());
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
            string rule = "� < � < �";

            var result = _sorter.SortByRule(list, rule);

            Assert.Equal('�', result[0].ToChar());
            Assert.Equal('�', result[1].ToChar());
            Assert.Equal('�', result[2].ToChar());
            Assert.Equal('�', result[3].ToChar());
            Assert.Equal('�', result[4].ToChar());
            Assert.Equal('�', result[5].ToChar());
            Assert.Equal('�', result[6].ToChar());
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
            string rule = "� < � < �";

            var result = _sorter.SortByRule(list, rule);

            Assert.Equal('�', result[0].ToChar());
            Assert.Equal('�', result[1].ToChar());
            Assert.Equal('�', result[2].ToChar());
            Assert.Equal('�', result[3].ToChar());
            Assert.Equal('�', result[4].ToChar());
            Assert.Equal('�', result[5].ToChar());
            Assert.Equal('�', result[6].ToChar());
            Assert.Equal('�', result[7].ToChar());
        }

        [Fact]
        public void SortByRule_EmptyList_ReturnsEmptyList()
        {
            var list = new List<ColoredObject>();
            string rule = "� < � < �";

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
            string rule = "� < � < �";

            var result = _sorter.SortByRule(list, rule);

            Assert.Single(result);
            Assert.Equal('�', result[0].ToChar());
        }
    }

    public class ProgramIntegrationTests
    {
        [Theory]
        [InlineData("� < � < �", new[] { '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�' })]
        [InlineData("� < � < �", new[] { '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�' })]
        [InlineData("� < � < �", new[] { '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�' })]
        [InlineData("� < � < �", new[] { '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�' })]
        [InlineData("� < � < �", new[] { '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�' })]
        [InlineData("� < � < �", new[] { '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�' })]
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
