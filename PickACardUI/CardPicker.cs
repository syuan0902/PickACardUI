using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    class CardPicker
    {   
        /// <summary>
        /// 宣告random為Random的新實例
        /// </summary>
        static Random random = new Random();


        /// <summary>
        /// 抽出一些撲克牌並回傳它們
        /// </summary>
        /// <param name="numberOfCards">要抽出幾張牌</param>
        /// <returns>存有撲克牌名稱的字串陣列</returns>
        public string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for(int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomSuit() + RandomValue();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {   
            //取得一個1~4的隨機數
            int value = random.Next(1, 5);
            //如果他是1，回傳黑桃
            if (value == 1) return "黑桃";
            if (value == 2) return "紅心";
            if (value == 3) return "方塊";
            //如果還沒有回傳，回傳梅花
            return "梅花";
        }

        private static string RandomValue()
        {
            //取得一個1~13的隨機數
            int value = random.Next(1, 14);
            //如果他是1，回傳Ace
            if (value == 1) return "A";
            if (value == 11) return "J";
            if (value == 12) return "Q";
            if (value == 13) return "K";
            //將整數2~10轉換成字串回傳
            return value.ToString();
        }
    }
}
