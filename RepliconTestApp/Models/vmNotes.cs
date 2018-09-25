using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepliconTestApp.Models
{
    public class vmNotes
    {
        public int note500 { get; set; }
        public int note100 { get; set; }
        public int note50 { get; set; }
        public int note10 { get; set; }
        public int note5 { get; set; }
        public int amount { get; set; }
        public string errorMsg { get; set; }


        public vmNotes SplitAmount(int amount)
        {
            vmNotes objNotes = new vmNotes();
            if (amount >= 500)
            {
                objNotes.note500 = amount / 500;
                amount -= objNotes.note500 * 500;
            }
            if (amount >= 100)
            {
                objNotes.note100 = amount / 100;
                amount -= objNotes.note100 * 100;
            }
            if (amount >= 50)
            {
                objNotes.note50 = amount / 50;
                amount -= objNotes.note50 * 50;
            }
            if (amount >= 10)
            {
                objNotes.note10 = amount / 10;
                amount -= objNotes.note10 * 10;
            }
            if (amount >= 5)
            {
                objNotes.note5 = amount / 5;
                amount -= objNotes.note5 * 5;
            }

            if (amount > 0)
            {
                objNotes = new vmNotes();
                objNotes.errorMsg = "Invalid Amount";

            }
            return objNotes;
        }
    }
}