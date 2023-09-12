using System.Diagnostics;
using TestHelper;

namespace TestHelperTest;

[TestFixture]
public class HelperTests
{
    [TestCase("IMG-20200401-WA0009.jpg", "2020.04.01")]
    [TestCase("IMG-20210509-WA0007.jpg", "2021.05.09")]
    [TestCase("received_220321092417492.jpg", "2021.03.22")]
    [TestCase("2020-03-21-142032253.mp4", "2020.03.21")]
    [TestCase("PANO_202001018-135332.jpg", "2020.01.01")]
    [TestCase("000000IMG_00000_BURST20200315122243772_COVER.jpg", "2020.03.15")]
    [TestCase("11_05_2020_19_06_46_8650000.mp4", "2020.05.11")]
    [TestCase("20140102_0055556.mp4", "2014.01.02")]
    public void GetDateFromFileName(string fileName, string expected) =>
        Assert.AreEqual(expected, Helper.GetDateFromFileName(fileName).ToString("yyyy.MM.dd"));
}