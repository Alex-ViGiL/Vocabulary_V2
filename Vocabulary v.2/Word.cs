using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabulary_v._2
{
    class Word
    {
        public int id { get; set; }

        private string word, translat;

        public string Words 
        {
            get { return word; }
            set { word = value; }
        }

        public string Translat
        {
            get { return translat; }
            set { translat = value; }
        }

        public Word() {}
        public Word(string add_word , string add_translat) 
        {
            this.word = add_word;
            this.translat = add_translat;
        }
    }
}
