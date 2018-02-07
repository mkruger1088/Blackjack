using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Windows.Media.Imaging;

namespace cardClass
{
    [DataContract]
    public class Card
    {
        public BitmapImage Pic;
        public enum rankType { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };
        [DataMember]
        public rankType rank;
        public enum suitType { Heart, Diamond, Spade, Club };
        [DataMember]
        public suitType suit;

        public Card()
        {
            rank = 0;
            suit = 0;
        }

        public rankType getRank()
        {
             return rank;
        }

        public void setRank(rankType r)
        {
            rank = r;
        }

        public suitType getSuit()
        {
            return suit;
        }
        public void setSuit (suitType s)
        {
            suit = s;
        }

        public void writeXML(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            DataContractSerializer ser = new DataContractSerializer(typeof(Card));

            ser.WriteObject(fs, this);
            fs.Close();
        }


        public void writeJSON(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Card));
       
            ser.WriteObject(fs, this);
            fs.Close();
        }

        public void write(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);

            fs.Close();
        }

        public void read(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            fs.Close();
        }

        override public String ToString()
        {
            string s = "";
            s += rank;
            s += ", ";
            s += suit;

            return s;
        }
      }
    }
