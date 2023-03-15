using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SF2022User07Lib;
using System.Linq;

namespace SF2022User07Tests
{
    [TestClass]
    public class Tests
    {
        Calculations calculations = new Calculations();

        [TestMethod]
        public void MainTest()
        {
            var startTime = new TimeSpan[]
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0),
            };
            var durations = new int[]
            {
                60,
                30,
                10,
                10,
                40
            };
            var beginWorkingTime = TimeSpan.FromHours(8);
            var endWorkingTime = TimeSpan.FromHours(18);
            var consultationTime = 30;

            var expected = new string[]
            {
                "08:00 - 08:30",
                "08:30 - 09:00",
                "09:00 - 09:30",
                "09:30 - 10:00",
                "11:30 - 12:00",
                "12:00 - 12:30",
                "12:30 - 13:00",
                "13:00 - 13:30",
                "13:30 - 14:00",
                "14:00 - 14:30",
                "14:30 - 15:00",
                "15:40 - 16:10",
                "16:10 - 16:40",
                "17:30 - 18:00"
            };
            var actual = calculations.AvailablePeriods(startTime, durations, beginWorkingTime, endWorkingTime, consultationTime);
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        public void TestOne()
        {
            var startTime = new TimeSpan[]
            {
                new TimeSpan(12, 40, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0),
            };
            var durations = new int[]
            {
                120,
                10,
                10,
                40
            };
            var beginWorkingTime = TimeSpan.FromHours(8);
            var endWorkingTime = TimeSpan.FromHours(18);
            var consultationTime = 30;

            var expected = new string[]
            {
                "08:00 - 08:30",
                "08:30 - 09:00",
                "09:00 - 09:30",
                "09:30 - 10:00",
                "10:00 - 10:30",
                "10:30 - 11:00",
                "11:00 - 11:30",
                "11:30 - 12:00",
                "12:00 - 12:30",
                "15:40 - 16:10",
                "16:10 - 16:40",
                "17:30 - 18:00"
            };
            var actual = calculations.AvailablePeriods(startTime, durations, beginWorkingTime, endWorkingTime, consultationTime);
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        public void TestTwo()
        {
            var startTime = new TimeSpan[]
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0),
            };
            var durations = new int[]
            {
                60,
                30,
                10,
                10,
                40
            };
            var beginWorkingTime = TimeSpan.FromHours(8);
            var endWorkingTime = TimeSpan.FromHours(18);
            var consultationTime = 45;

            var expected = new string[]
            {
                "08:00 - 08:45",
                "08:45 - 09:30",
                "11:30 - 12:15",
                "12:15 - 13:00",
                "13:00 - 13:45",
                "13:45 - 14:30",
                "15:40 - 16:25"
            };
            var actual = calculations.AvailablePeriods(startTime, durations, beginWorkingTime, endWorkingTime, consultationTime);
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        public void TestThree()
        {
            var startTime = new TimeSpan[]
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0),
            };
            var durations = new int[]
            {
                60,
                30,
                10,
                10,
                40
            };
            var beginWorkingTime = TimeSpan.FromHours(8);
            var endWorkingTime = TimeSpan.FromHours(20);
            var consultationTime = 30;

            var expected = new string[]
            {
                "08:00 - 08:30",
                "08:30 - 09:00",
                "09:00 - 09:30",
                "09:30 - 10:00",
                "11:30 - 12:00",
                "12:00 - 12:30",
                "12:30 - 13:00",
                "13:00 - 13:30",
                "13:30 - 14:00",
                "14:00 - 14:30",
                "14:30 - 15:00",
                "15:40 - 16:10",
                "16:10 - 16:40",
                "17:30 - 18:00",
                "18:00 - 18:30",
                "18:30 - 19:00",
                "19:00 - 19:30",
                "19:30 - 20:00"
            };
            var actual = calculations.AvailablePeriods(startTime, durations, beginWorkingTime, endWorkingTime, consultationTime);
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        public void TestFour()
        {
            var startTime = new TimeSpan[]
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0),
            };
            var durations = new int[]
            {
                60,
                30,
                10,
                10,
                40
            };
            var beginWorkingTime = TimeSpan.FromHours(10);
            var endWorkingTime = TimeSpan.FromHours(18);
            var consultationTime = 30;

            var expected = new string[]
            {
                "11:30 - 12:00",
                "12:00 - 12:30",
                "12:30 - 13:00",
                "13:00 - 13:30",
                "13:30 - 14:00",
                "14:00 - 14:30",
                "14:30 - 15:00",
                "15:40 - 16:10",
                "16:10 - 16:40",
                "17:30 - 18:00"
            };
            var actual = calculations.AvailablePeriods(startTime, durations, beginWorkingTime, endWorkingTime, consultationTime);
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        public void TestFive()
        {
            var startTime = new TimeSpan[]
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0),
            };
            var durations = new int[]
            {
                60,
                30,
                10,
                10,
                40
            };
            var beginWorkingTime = TimeSpan.FromHours(10);
            var endWorkingTime = TimeSpan.FromHours(22);
            var consultationTime = 30;

            var expected = new string[]
            {
                "11:30 - 12:00",
                "12:00 - 12:30",
                "12:30 - 13:00",
                "13:00 - 13:30",
                "13:30 - 14:00",
                "14:00 - 14:30",
                "14:30 - 15:00",
                "15:40 - 16:10",
                "16:10 - 16:40",
                "17:30 - 18:00",
                "18:00 - 18:30",
                "18:30 - 19:00",
                "19:00 - 19:30",
                "19:30 - 20:00",
                "20:00 - 20:30",
                "20:30 - 21:00",
                "21:00 - 21:30",
                "21:30 - 22:00",
            };
            var actual = calculations.AvailablePeriods(startTime, durations, beginWorkingTime, endWorkingTime, consultationTime);
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        public void TestSix()
        {
            var startTime = new TimeSpan[]
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0),
            };
            var durations = new int[]
            {
                60,
                30,
                10,
                10,
                40
            };
            var beginWorkingTime = TimeSpan.FromHours(10);
            var endWorkingTime = TimeSpan.FromHours(18);
            var consultationTime = 45;

            var expected = new string[]
            {
                "11:30 - 12:15",
                "12:15 - 13:00",
                "13:00 - 13:45",
                "13:45 - 14:30",
                "15:40 - 16:25"
            };
            var actual = calculations.AvailablePeriods(startTime, durations, beginWorkingTime, endWorkingTime, consultationTime);
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        public void TestSeven()
        {
            var startTime = new TimeSpan[]
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0),
            };
            var durations = new int[]
            {
                60,
                30,
                10,
                10,
                40
            };
            var beginWorkingTime = TimeSpan.FromHours(8);
            var endWorkingTime = TimeSpan.FromHours(20);
            var consultationTime = 45;

            var expected = new string[]
            {
                "08:00 - 08:45",
                "08:45 - 09:30",
                "11:30 - 12:15",
                "12:15 - 13:00",
                "13:00 - 13:45",
                "13:45 - 14:30",
                "15:40 - 16:25",
                "17:30 - 18:15",
                "18:15 - 19:00",
                "19:00 - 19:45"
            };
            var actual = calculations.AvailablePeriods(startTime, durations, beginWorkingTime, endWorkingTime, consultationTime);
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        public void TestEight()
        {
            var startTime = new TimeSpan[]
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0),
            };
            var durations = new int[]
            {
                60,
                30,
                10,
                10,
                40
            };
            var beginWorkingTime = TimeSpan.FromHours(10);
            var endWorkingTime = TimeSpan.FromHours(22);
            var consultationTime = 45;

            var expected = new string[]
            {
                "11:30 - 12:15",
                "12:15 - 13:00",
                "13:00 - 13:45",
                "13:45 - 14:30",
                "15:40 - 16:25",
                "17:30 - 18:15",
                "18:15 - 19:00",
                "19:00 - 19:45",
                "19:45 - 20:30",
                "20:30 - 21:15",
                "21:15 - 22:00"
            };
            var actual = calculations.AvailablePeriods(startTime, durations, beginWorkingTime, endWorkingTime, consultationTime);
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        public void TestNine()
        {
            var startTime = new TimeSpan[]
            {
                new TimeSpan(8, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(18, 0, 0),
            };
            var durations = new int[]
            {
                60,
                30,
                10,
                10,
                60
            };
            var beginWorkingTime = TimeSpan.FromHours(8);
            var endWorkingTime = TimeSpan.FromHours(18);
            var consultationTime = 30;

            var expected = new string[]
            {
                "09:00 - 09:30",
                "09:30 - 10:00",
                "10:00 - 10:30",
                "10:30 - 11:00",
                "11:30 - 12:00",
                "12:00 - 12:30",
                "12:30 - 13:00",
                "13:00 - 13:30",
                "13:30 - 14:00",
                "14:00 - 14:30",
                "14:30 - 15:00",
                "15:40 - 16:10",
                "16:10 - 16:40",
                "16:40 - 17:10",
                "17:10 - 17:40",
            };
            var actual = calculations.AvailablePeriods(startTime, durations, beginWorkingTime, endWorkingTime, consultationTime);
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        public void TestTen()
        {
            var startTime = new TimeSpan[]
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(22, 0, 0),
            };
            var durations = new int[]
            {
                60,
                30,
                10,
                10,
                60
            };
            var beginWorkingTime = TimeSpan.FromHours(10);
            var endWorkingTime = TimeSpan.FromHours(22);
            var consultationTime = 45;

            var expected = new string[]
            {
                "11:30 - 12:15",
                "12:15 - 13:00",
                "13:00 - 13:45",
                "13:45 - 14:30",
                "15:40 - 16:25",
                "16:25 - 17:10",
                "17:10 - 17:55",
                "17:55 - 18:40",
                "18:40 - 19:25",
                "19:25 - 20:10",
                "20:10 - 20:55",
                "20:55 - 21:40"
            };
            var actual = calculations.AvailablePeriods(startTime, durations, beginWorkingTime, endWorkingTime, consultationTime);
            Assert.IsTrue(actual.SequenceEqual(expected));
        }
    }
}
