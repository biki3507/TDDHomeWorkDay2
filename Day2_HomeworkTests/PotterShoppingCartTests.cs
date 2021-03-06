﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2_Homework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Day2_Homework.Tests
{
    [TestClass()]
    public class PotterShoppingCartTests
    {
        List<Book> list = new List<Book>();
        //        User Story
        //哈利波特一到五冊熱潮正席捲全球，世界各地的孩子都為之瘋狂。
        //出版社為了慶祝TDD課程招生順利，決定訂出極大的優惠，來回饋給為了小孩四處奔波買書的父母親們。
        //定價的方式如下：
        //1. 一到五集的哈利波特，每一本都是賣100元
        //2. 如果你從這個系列買了兩本不同的書，則會有5%的折扣
        //3. 如果你買了三本不同的書，則會有10%的折扣
        //4. 如果是四本不同的書，則會有20%的折扣
        //5. 如果你一次買了整套一到五集，恭喜你將享有25%的折扣
        //6. 需要留意的是，如果你買了四本書，其中三本不同，第四本則是重複的，
        //   那麼那三本將享有10%的折扣，但重複的那一本，則仍須100元。
        // 你的任務是，設計一個哈利波特的購物車，能提供最便宜的價格給這些爸爸媽媽。


        //Feature: PotterShoppingCart
        //    In order to 提供最便宜的價格給來買書的爸爸媽媽
        //    As a 佛心的出版社老闆
        //    I want to 設計一個哈利波特的購物車


        //        homework 要求：
        //先寫測試案例，得到紅燈之後，才開始寫 production code, 目標是用最簡單、直覺、好懂的程式碼通過測試
        //一次同時只存在 0~1 個紅燈，如果有出現紅燈，第一優先任務應該是讓它變綠燈
        //baby step, 紅燈變綠燈的過程，請用最簡單直覺好懂的程式碼通過紅燈變成綠燈。變成綠燈之後，請判斷是否需要進行重構。
        //只收 git, 請在每一次紅燈，綠燈，重構的時間點，進行 commit, review 會看 commit history 來給

        //Scenario: 第一集買了一本，其他都沒買，價格應為100*1=100元
        //    Given 第一集買了 1 本
        //    And 第二集買了 0 本
        //    And 第三集買了 0 本
        //    And 第四集買了 0 本
        //    And 第五集買了 0 本
        //    When 結帳
        //    Then 價格應為 100 元
        [TestMethod()]
        public void GetPriceTest_Fst_1_price_must_be_100()
        {
            //arrange
            var target = new PotterShoppingCart();
            //act
            var expected = 100;
            list.Add(new Book() { Version = 1, Num = 1, UnitPrice = 100 });
            var actual = target.GetPrice(list);
            //assert
            Assert.AreEqual(expected, actual);
        }

        //Scenario: 第一集買了一本，第二集也買了一本，價格應為100*2*0.95=190
        //    Given 第一集買了 1 本
        //    And 第二集買了 1 本
        //    And 第三集買了 0 本
        //    And 第四集買了 0 本
        //    And 第五集買了 0 本
        //    When 結帳
        //    Then 價格應為 190 元
        [TestMethod()]
        public void GetPriceTest_Fst_1__Sec_1_price_must_be_190()
        {
            //arrange
            var target = new PotterShoppingCart();
            //act
            var expected = 190;
            list.Add(new Book() { Version = 1, Num = 1, UnitPrice = 100 });
            list.Add(new Book() { Version = 2, Num = 1, UnitPrice = 100 });
            var actual = target.GetPrice(list);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetPriceTest_Fst_1__Fst_1_price_must_be_200()
        {
            //arrange
            var target = new PotterShoppingCart();
            //act
            var expected = 200;
            list.Add(new Book() { Version = 1, Num = 1, UnitPrice = 100 });
            list.Add(new Book() { Version = 1, Num = 1, UnitPrice = 100 });
            var actual = target.GetPrice(list);
            //assert
            Assert.AreEqual(expected, actual);
        }
        //Scenario: 一二三集各買了一本，價格應為100*3*0.9=270
        //    Given 第一集買了 1 本
        //    And 第二集買了 1 本
        //    And 第三集買了 1 本
        //    And 第四集買了 0 本
        //    And 第五集買了 0 本
        //    When 結帳
        //    Then 價格應為 270 元
        [TestMethod()]
        public void GetPriceTest_Fst_1_Sec_1_Thi_1_price_must_be_270()
        {
            //arrange
            var target = new PotterShoppingCart();

            //act
            var expected = 270;
            list.Add(new Book() { Version = 1, Num = 1, UnitPrice = 100 });
            list.Add(new Book() { Version = 2, Num = 1, UnitPrice = 100 });
            list.Add(new Book() { Version = 3, Num = 1, UnitPrice = 100 });
            var actual = target.GetPrice(list);
            //assert
            Assert.AreEqual(expected, actual);
        }

        //Scenario: 一二三四集各買了一本，價格應為100*4*0.8=320
        //    Given 第一集買了 1 本
        //    And 第二集買了 1 本
        //    And 第三集買了 1 本
        //    And 第四集買了 1 本
        //    And 第五集買了 0 本
        //    When 結帳
        //    Then 價格應為 320 元
        [TestMethod()]
        public void GetPriceTest_Fst_1_Sec_1_Thi_1_Fou_1_price_must_be_320()
        {
            //arrange
            var target = new PotterShoppingCart();
            //act
            var expected = 320;
            list.Add(new Book() { Version = 1, Num = 1, UnitPrice = 100 });
            list.Add(new Book() { Version = 2, Num = 1, UnitPrice = 100 });
            list.Add(new Book() { Version = 3, Num = 1, UnitPrice = 100 });
            list.Add(new Book() { Version = 4, Num = 1, UnitPrice = 100 });
            var actual = target.GetPrice(list);
            //assert
            Assert.AreEqual(expected, actual);
        }

        //Scenario: 一次買了整套，一二三四五集各買了一本，價格應為100*5*0.75=375
        //    Given 第一集買了 1 本
        //    And 第二集買了 1 本
        //    And 第三集買了 1 本
        //    And 第四集買了 1 本
        //    And 第五集買了 1 本
        //    When 結帳
        //    Then 價格應為 375 元
        [TestMethod()]
        public void GetPriceTest_Fst_1_Sec_1_Thi_1_Fou_1_Fiv_1_price_must_be_375()
        {
            //arrange
            var target = new PotterShoppingCart();
            //act
            var expected = 375;
            list.Add(new Book() { Version = 1, Num = 1, UnitPrice = 100 });
            list.Add(new Book() { Version = 2, Num = 1, UnitPrice = 100 });
            list.Add(new Book() { Version = 3, Num = 1, UnitPrice = 100 });
            list.Add(new Book() { Version = 4, Num = 1, UnitPrice = 100 });
            list.Add(new Book() { Version = 5, Num = 1, UnitPrice = 100 });
            var actual = target.GetPrice(list);
            //assert
            Assert.AreEqual(expected, actual);
        }

        //Scenario: 一二集各買了一本，第三集買了兩本，價格應為100*3*0.9 + 100 = 370
        //    Given 第一集買了 1 本
        //    And 第二集買了 1 本
        //    And 第三集買了 2 本
        //    And 第四集買了 0 本
        //    And 第五集買了 0 本
        //    When 結帳
        //    Then 價格應為 370 元
        [TestMethod()]
        public void GetPriceTest_Fst_1_Sec_1_Thi_2_price_must_be_370()
        {
            //arrange
            var target = new PotterShoppingCart();
            //act
            var expected = 370;
            list.Add(new Book() { Version = 1, Num = 1, UnitPrice = 100 });
            list.Add(new Book() { Version = 2, Num = 1, UnitPrice = 100 });
            list.Add(new Book() { Version = 3, Num = 1, UnitPrice = 100 });
            list.Add(new Book() { Version = 3, Num = 1, UnitPrice = 100 });
            var actual = target.GetPrice(list);
            //assert
            Assert.AreEqual(expected, actual);
        }

        //Scenario: 第一集買了一本，第二三集各買了兩本，價格應為100*3*0.9 + 100*2*0.95 = 460
        //    Given 第一集買了 1 本
        //    And 第二集買了 2 本
        //    And 第三集買了 2 本
        //    And 第四集買了 0 本
        //    And 第五集買了 0 本
        //    When 結帳
        //    Then 價格應為 460 元
        [TestMethod()]
        public void GetPriceTest_Fst_1_Sec_2_Thi_2_price_must_be_460()
        {
            //arrange
            var target = new PotterShoppingCart();
            //act
            var expected = 460;
            list.Add(new Book() { Version = 1, Num = 1, UnitPrice = 100 });
            list.Add(new Book() { Version = 2, Num = 1, UnitPrice = 100 });
            list.Add(new Book() { Version = 2, Num = 1, UnitPrice = 100 });
            list.Add(new Book() { Version = 3, Num = 1, UnitPrice = 100 });
            list.Add(new Book() { Version = 3, Num = 1, UnitPrice = 100 });
            var actual = target.GetPrice(list);
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
