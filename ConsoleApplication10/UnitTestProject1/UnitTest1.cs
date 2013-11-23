using System;
using ConsoleApplication10;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using ATM;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class SavingAccountTest
    {
        [TestMethod]
        public void SavingAccountCreate()
        {
            SavingAccount acc = new SavingAccount(0.2, DateTime.Now.AddMinutes(2), 214, 1234);
            Assert.AreNotEqual(null, acc);
        }
        [TestMethod]
        public void SavingAccountBalance()
        {
            SavingAccount acc = new SavingAccount(0.2, DateTime.Now.AddMinutes(2), 214, 1234);
            Assert.AreEqual(0, acc.checkBalance());
        }
        [TestMethod]
        public void SavingAccountGetMoneyEmpty()
        {
            SavingAccount acc = new SavingAccount(0.2, DateTime.Now.AddMinutes(2), 214, 1234);
            Assert.AreEqual(0, acc.getMoney(13));
        }
        [TestMethod]
        public void SavingAccountGetMoneyFull()
        {
            SavingAccount acc = new SavingAccount(0.2, DateTime.Now.AddMinutes(2), 214, 1234);
            acc.addMoney(1000);
            Assert.AreEqual(13, acc.getMoney(13));
        }
        [TestMethod]
        public void SavingAccountGetMoneyBalance()
        {
            SavingAccount acc = new SavingAccount(0.2, DateTime.Now.AddMinutes(2), 214, 1234);
            acc.addMoney(1000);
            acc.getMoney(100);
            Assert.AreEqual(900,acc.checkBalance() );
        }

    }
    [TestClass]
    public class CheckingAccountTest
    {
        [TestMethod]
        public void CheckingAccountCreate()
        {
            CheckingAccount acc = new CheckingAccount(2, 2, 4, 3, 100, 100);
            Assert.AreNotEqual(null, acc);
        }
        [TestMethod]
        public void CheckingAccountBalance()
        {
            CheckingAccount acc = new CheckingAccount(2, 2, 4, 3, 100, 100);
            Assert.AreEqual(0, acc.checkBalance());
        }
        [TestMethod]
        public void CheckingAccountGetMoneyEmpty()
        {
            CheckingAccount acc = new CheckingAccount(2, 2, 4, 3, 100, 100);
            Assert.AreEqual(0, acc.getMoney(13));
        }
        [TestMethod]
        public void CheckingAccountGetMoneyFull()
        {
            CheckingAccount acc = new CheckingAccount(2, 2, 4, 3, 100, 100);
            acc.addMoney(1000);
            Assert.AreEqual(13, acc.getMoney(13));
        }
        [TestMethod]
        public void CheckingAccountGetMoneyBalance()
        {
            CheckingAccount acc = new CheckingAccount(0, 2, 4, 3, 100, 100);
            acc.addMoney(1000);
            acc.getMoney(100);
            Assert.AreEqual(900, acc.checkBalance());
        }

    }
    [TestClass]
    public class OverdraftAccountTest
    {
        [TestMethod]
        public void OverdraftAccountCreate()
        {
            OverdraftAccount acc = new OverdraftAccount(new TimeSpan(99,99,99),0.2,100,100);
            Assert.AreNotEqual(null, acc);
        }
        [TestMethod]
        public void OverdraftAccountBalance()
        {
            OverdraftAccount acc = new OverdraftAccount(new TimeSpan(99, 99, 99), 0.2, 100, 100);
            Assert.AreEqual(0, acc.checkBalance());
        }
        [TestMethod]
        public void OverdraftAccountGetMoneyEmpty()
        {
            OverdraftAccount acc = new OverdraftAccount(new TimeSpan(99, 99, 99), 0.2, 100, 100);
            Assert.AreEqual(13, acc.getMoney(13));
        }
        [TestMethod]
        public void OverdraftAccountGetMoneyFull()
        {
            OverdraftAccount acc = new OverdraftAccount(new TimeSpan(99, 99, 99), 0.2, 100, 100);
            acc.addMoney(1000);
            Assert.AreEqual(13, acc.getMoney(13));
        }
        [TestMethod]
        public void OverdraftAccountGetMoneyBalance()
        {
            OverdraftAccount acc = new OverdraftAccount(new TimeSpan(99, 99, 99), 0.2, 100, 100);
            acc.addMoney(1000);
            acc.getMoney(100);
            Assert.AreEqual(900, acc.checkBalance());
        }

    }
    [TestClass]
    public class TimedMaturuityAccountTest
    {
        [TestMethod]
        public void TimedMaturuityAccountCreate()
        {
            TimedMaturuityAccount acc = new TimedMaturuityAccount(DateTime.Now.AddMilliseconds(100), 2, 100, 100);
            Assert.AreNotEqual(null, acc);
        }
        [TestMethod]
        public void TimedMaturuityAccountBalance()
        {
            TimedMaturuityAccount acc = new TimedMaturuityAccount(DateTime.Now.AddMilliseconds(100), 2, 100, 100);
            Assert.AreEqual(0, acc.checkBalance());
        }
        [TestMethod]
        public void TimedMaturuityAccountGetMoneyEmpty()
        {
            TimedMaturuityAccount acc = new TimedMaturuityAccount(DateTime.Now.AddMilliseconds(100), 2, 100, 100);
            Assert.AreEqual(0, acc.getMoney(13));
        }
        [TestMethod]
        public void TimedMaturuityAccountGetMoneyFull()
        {
            TimedMaturuityAccount acc = new TimedMaturuityAccount(DateTime.Now.AddMilliseconds(100), 2, 100, 100);
            acc.addMoney(1000);
            Thread.Sleep(1000);
            Assert.AreEqual(300, acc.getMoney(100));
        }
        [TestMethod]
        public void TimedMaturuityAccountGetMoneyBalance()
        {
            TimedMaturuityAccount acc = new TimedMaturuityAccount(DateTime.Now.AddMilliseconds(100), 2, 100, 100);
            acc.addMoney(1000);
            Thread.Sleep(1000);
            acc.getMoney(100);
            Assert.AreEqual(700, acc.checkBalance());
        }

    }
    [TestClass]
    public class InterfaceTest
    {
        [TestMethod]
        public void InterfaceDb()
        {
            List<Tuple<BasicClass, int>> list = new List<Tuple<BasicClass, int>>();
            Assert.AreNotEqual(null, list);
        }
        [TestMethod]
        public void InterfaceCreation()
        {
            Program pro = new Program();
            Assert.AreNotEqual(null, pro);
        }
    }
}
