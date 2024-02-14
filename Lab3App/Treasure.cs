﻿
using System;
using System.Collections.Generic;


namespace Lab3App
    

{
    public class Treasure: Collectable
    {
        public int Score { get; set; }


        protected void UpdateTotalScore()
        {
            this.Board.TotalScore += Score;
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
        }


        //override the AddMe method
        public override void AddMe(List<Collectable> list)
        {
          
            base.AddMe(list);
            UpdateTotalScore(); // modified for treasure

        }

    }
}
